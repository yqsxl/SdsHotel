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
    public partial class FrmRibbonBase : RibbonForm
    {
        public FrmRibbonBase()
        {
            InitializeComponent();
        }

        #region 处理窗体上的Enter键--在非Button、Grid控件上Enter键相当于Tab键
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.ActiveControl == null) return base.ProcessCmdKey(ref msg, keyData);
            string acString = this.ActiveControl.GetType().ToString();
            if (acString != "System.Windows.Forms.Button"
                && acString != "DevExpress.XtraEditors.SimpleButton"
                && acString.IndexOf("System.Windows.Forms.DataGrid") < 0
                && acString.IndexOf(" DevExpress.XtraGrid") < 0)
            {
                if (keyData == Keys.Enter)
                {
                    SelectNextControl(this.ActiveControl, true, true, true, true);
                    return true;
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }

            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #endregion

        #region 消息处理方法集
        private const string topicTitle = "提示";
        private const string warningTitle = "警告";
        private const string errorTitle = "错误";
        private const string successTitle = "成功";
        private const string questionTitle = "请选择";

        /// <summary>
        /// 提示框
        /// </summary>
        /// <param name="message"></param>
        public void ShowTopic(string message)
        {
            MessageBox.Show(message, topicTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 警告框
        /// </summary>
        /// <param name="message"></param>
        public void ShowWarning(string message)
        {
            MessageBox.Show(message, warningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 错误框
        /// </summary>
        /// <param name="message"></param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 成功框
        /// </summary>
        /// <param name="message"></param>
        public void ShowSucess(string message)
        {
            MessageBox.Show(message, successTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 选择框
        /// </summary>
        /// <param name="message"></param>
        public DialogResult ShowQuestion(string message)
        {
            return MessageBox.Show(message, questionTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

    }
}
