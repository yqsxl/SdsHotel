using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdsHotel
{
    public partial class frmRegister : FrmRibbonBase
    {
        public frmRegister()
        {
            InitializeComponent();
            RegisterEvent();//注册事件
        }

        #region 属性
        public frmLogin LoginForm { get; set; }
        #endregion

        #region 注册事件
        /// <summary>
        /// 注册事件
        /// </summary>
        private void RegisterEvent()
        {
            btnSubmit.Click += BtnSubmit_Click;
            btnBack.Click += BtnBack_Click;
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm.Show();
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                //todo 

                //Hide();
                //LoginForm.Show();
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 验证表单
        /// </summary>
        private bool ValidInput()
        {
            if (txtHotelName.Text.Trim().Equals(string.Empty))
            {
                ShowTopic("酒店名称不能为空");
                txtHotelName.Focus();
                ActiveControl = txtHotelName;
                return false;
            }

            if (txtUserName.Text.Trim().Equals(string.Empty))
            {
                ShowTopic("联系人姓名不能为空");
                txtUserName.Focus();
                ActiveControl = txtUserName;
                return false;
            }

            if (txtTelPhone.Text.Trim().Equals(string.Empty))
            {
                ShowTopic("联系人电话不能为空");
                txtTelPhone.Focus();
                ActiveControl = txtTelPhone;
                return false;
            }
            return true;
        }

        #endregion
    }
}
