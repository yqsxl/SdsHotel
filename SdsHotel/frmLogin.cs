using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace SdsHotel
{
    public partial class frmLogin : FrmRibbonBase
    {
        public frmLogin()
        {
            InitializeComponent();
            //注册事件
            RegisterEvent();
        }

        #region 注册事件


        private void RegisterEvent()
        {
            btnRegister.Click += BtnRegister_Click;
            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += BtnExit_Click;
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            Hide();
        }
        
        /// <summary>
        /// 申请入住
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            frmReg.LoginForm = this;
            frmReg.Show();
            Hide();
        }

        #endregion
    }
}
