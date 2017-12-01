using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;
using SdsHotel.Utility;

namespace SdsHotel
{
    public partial class frmMain : FrmRibbonBase
    {
        public frmMain()
        {
            InitializeComponent();
            RegisterEvent();//注册事件
            InitSkinGallery();//初始化皮肤
            InitIndex();//初始化登录后的首页
        }

        private void InitIndex()
        {
            
        }

        #region 注册事件
        private void RegisterEvent()
        {
            //主窗体加载初始化数据
            Load += FrmMain_Load;
            //左侧菜单链接事件
            nbcMenus.LinkClicked += NbcMenus_LinkClicked;
            //双击关闭Tab页事件
            xtMMTabs.MouseDown += XtMMTabs_MouseDown;
            //Menu菜单单击事件
            rcManager.ItemClick += RcManager_ItemClick;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tsslUserInfo.Text = $"当前登录用户:[]";
        }

        #region 单击菜单打开对应的窗体
        private void RcManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Tag != null)
            {
                var item = e.Item.Tag.ToString();
                if (!FormIsExists(item))
                {
                    OpenChildForm(item, e.Item.Caption);
                }
            }
        }
        #endregion


        #region 左侧菜单item click
        private void NbcMenus_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            OpenChildFormByNavBar(e.Link.Item);
        }
        #endregion

        #region 双击关闭当前tab页

        private DateTime m_LastClick = DateTime.Now;
        private XtraMdiTabPage m_LastPage = null;

        /// <summary>
        /// 双击关当前激活的Tab页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XtMMTabs_MouseDown(object sender, MouseEventArgs e)
        {
            //当前tab页
            var curPage = (sender as XtraTabbedMdiManager).SelectedPage;
            if (e.Button == MouseButtons.Left)
            {
                var dt = DateTime.Now;
                //获取两次时间间隔的时间差
                var span = dt.Subtract(m_LastClick);
                //两次单击时间间隔比较小，则认为是双击
                if (span.TotalMilliseconds < 300)
                {
                    //Tab大于1页才能关闭，默认首页不能关闭。
                    if (MdiChildren.Length > 1)
                    {
                        if (curPage.Equals(m_LastPage))
                        {
                            ActiveMdiChild.Close();
                        }
                    }

                    m_LastClick = dt.AddMinutes(-1);
                }
                else
                {
                    m_LastClick = dt;
                    m_LastPage = curPage;
                }
            }
        }
        #endregion

        #endregion

        #region 操作Form窗体的方法

        /// <summary>
        /// 通过左侧菜单打开Form
        /// </summary>
        /// <param name="navItem"></param>
        private void OpenChildFormByNavBar(NavBarItem navItem)
        {
            if (navItem.Tag != null)
            {
                var item = navItem.Tag.ToString();
                OpenChildForm(item, navItem.Caption);
            }
        }


        #region 通过反射机制打开菜单对应的窗体
        private void OpenChildForm(string name,string caption)
        {
            if (!FormIsExists(name))
            {
                //存放窗体文件的dll文件的路径
                string path = Application.StartupPath + "\\";
                //获取启动程序的程序集
                Assembly ab = Assembly.LoadFrom(path + StaticFiled._program);
                Type[] types = ab.GetTypes();
                foreach (Type t in types)
                {

                    if (t.BaseType.Name.Equals("FrmRibbonBase") && t.Name == name)
                    {

                        FrmRibbonBase frm = ab.CreateInstance(t.FullName) as FrmRibbonBase;
                        frm.MdiParent = this;
                        frm.Text = caption;
                        frm.Show();
                        break;
                    }
                }
            }
        }




        #endregion

        #region 判断此窗体是否已经打开
        /// <summary>
        /// 判断此窗体是否已经打开
        /// </summary>
        /// <param name="mu">要判断的菜单</param>
        /// <returns>存在返</returns>
        private bool FormIsExists(string name)
        {
            foreach (XtraMdiTabPage page in xtMMTabs.Pages)
            {
                if (page.MdiChild.GetType().FullName.Equals(StaticFiled._namespace + "." + name))
                {
                    xtMMTabs.SelectedPage = page;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #endregion

        #region 设多样化皮肤的选择类别
        public void InitSkinGallery()
        {
            // DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            ////设置本地化的类
            BarLocalizer.Active = new CastorBarLocalizer();

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbSkin);
            //DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbgSkinTwo);

        }
        //该类确定本地化的实际工作方式
        public class CastorBarLocalizer : BarLocalizer
        {
            public override string GetLocalizedString(BarString id)
            {
                if (id == BarString.SkinCaptions)
                {
                    string str = base.GetLocalizedString(id);
                    //实现本地化，实际上就是替换字符串
                    return str.Replace("|DevExpress Style|", "|Castor的皮肤|");
                }
                return base.GetLocalizedString(id);
            }
        }
        #endregion
    }
}
