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
    public partial class frmModifyPwd : FrmRibbonBase
    {
        public frmModifyPwd()
        {
            InitializeComponent();
            RegisterEvent();
        }

        private void RegisterEvent()
        {
            btnSubmit.Click += BtnSubmit_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        #region 清空输入控件
        private void ClearControls()
        {
            try
            {
                txtOldPwd.Text = "";
                txtNewPwd.Text = "";
                txtConfirmPwd.Text = "";
            }
            catch (Exception ex)
            {
                this.ShowError(ex.Message);
            }
        }
        #endregion


    }
}
