namespace SdsHotel
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbHotelA = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotelAddress = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullNameReq = new System.Windows.Forms.Label();
            this.lblUserNameReq = new System.Windows.Forms.Label();
            this.txtTelPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtHotelName = new DevExpress.XtraEditors.TextEdit();
            this.lblRealname = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.gbHotelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHotelA
            // 
            this.gbHotelA.BackColor = System.Drawing.Color.Transparent;
            this.gbHotelA.Controls.Add(this.label5);
            this.gbHotelA.Controls.Add(this.label4);
            this.gbHotelA.Controls.Add(this.txtHotelAddress);
            this.gbHotelA.Controls.Add(this.label3);
            this.gbHotelA.Controls.Add(this.txtPhone);
            this.gbHotelA.Controls.Add(this.label2);
            this.gbHotelA.Controls.Add(this.txtUserName);
            this.gbHotelA.Controls.Add(this.label1);
            this.gbHotelA.Controls.Add(this.lblFullNameReq);
            this.gbHotelA.Controls.Add(this.lblUserNameReq);
            this.gbHotelA.Controls.Add(this.txtTelPhone);
            this.gbHotelA.Controls.Add(this.txtHotelName);
            this.gbHotelA.Controls.Add(this.lblRealname);
            this.gbHotelA.Controls.Add(this.lblUserName);
            this.gbHotelA.Location = new System.Drawing.Point(12, 39);
            this.gbHotelA.Name = "gbHotelA";
            this.gbHotelA.Size = new System.Drawing.Size(456, 194);
            this.gbHotelA.TabIndex = 0;
            this.gbHotelA.TabStop = false;
            this.gbHotelA.Text = "酒店申请入住";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(422, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(422, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "*";
            // 
            // txtHotelAddress
            // 
            this.txtHotelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelAddress.Location = new System.Drawing.Point(124, 160);
            this.txtHotelAddress.Name = "txtHotelAddress";
            this.txtHotelAddress.Properties.MaxLength = 50;
            this.txtHotelAddress.Size = new System.Drawing.Size(292, 20);
            this.txtHotelAddress.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "酒店地址(&A)：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(124, 129);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.MaxLength = 50;
            this.txtPhone.Size = new System.Drawing.Size(292, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "联系人电话(&P)：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(124, 103);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.MaxLength = 50;
            this.txtUserName.Size = new System.Drawing.Size(292, 20);
            this.txtUserName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "联系人姓名(&U)：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullNameReq
            // 
            this.lblFullNameReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullNameReq.AutoSize = true;
            this.lblFullNameReq.ForeColor = System.Drawing.Color.Red;
            this.lblFullNameReq.Location = new System.Drawing.Point(422, 108);
            this.lblFullNameReq.Name = "lblFullNameReq";
            this.lblFullNameReq.Size = new System.Drawing.Size(13, 13);
            this.lblFullNameReq.TabIndex = 25;
            this.lblFullNameReq.Text = "*";
            // 
            // lblUserNameReq
            // 
            this.lblUserNameReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserNameReq.AutoSize = true;
            this.lblUserNameReq.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameReq.Location = new System.Drawing.Point(422, 47);
            this.lblUserNameReq.Name = "lblUserNameReq";
            this.lblUserNameReq.Size = new System.Drawing.Size(13, 13);
            this.lblUserNameReq.TabIndex = 22;
            this.lblUserNameReq.Text = "*";
            // 
            // txtTelPhone
            // 
            this.txtTelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelPhone.Location = new System.Drawing.Point(124, 73);
            this.txtTelPhone.Name = "txtTelPhone";
            this.txtTelPhone.Properties.MaxLength = 50;
            this.txtTelPhone.Size = new System.Drawing.Size(292, 20);
            this.txtTelPhone.TabIndex = 23;
            // 
            // txtHotelName
            // 
            this.txtHotelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelName.Location = new System.Drawing.Point(124, 43);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.txtHotelName.Properties.MaxLength = 50;
            this.txtHotelName.Size = new System.Drawing.Size(291, 20);
            this.txtHotelName.TabIndex = 21;
            // 
            // lblRealname
            // 
            this.lblRealname.Location = new System.Drawing.Point(4, 74);
            this.lblRealname.Name = "lblRealname";
            this.lblRealname.Size = new System.Drawing.Size(122, 19);
            this.lblRealname.TabIndex = 24;
            this.lblRealname.Text = "酒店座机(&H)：";
            this.lblRealname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(4, 46);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(122, 19);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "酒店名称(&N)：";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Location = new System.Drawing.Point(260, 261);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 25);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "提交(&A)";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(353, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 25);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "返回";
            // 
            // frmRegister
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 298);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbHotelA);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.gbHotelA.ResumeLayout(false);
            this.gbHotelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHotelA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtHotelAddress;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullNameReq;
        private System.Windows.Forms.Label lblUserNameReq;
        private DevExpress.XtraEditors.TextEdit txtTelPhone;
        private DevExpress.XtraEditors.TextEdit txtHotelName;
        private System.Windows.Forms.Label lblRealname;
        private System.Windows.Forms.Label lblUserName;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}