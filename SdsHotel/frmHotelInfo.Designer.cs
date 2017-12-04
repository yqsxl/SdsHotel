namespace SdsHotel
{
    partial class frmHotelInfo
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtHotelName = new DevExpress.XtraEditors.TextEdit();
            this.txtHotelAddress = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHotelDesc = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHotelPosition = new System.Windows.Forms.TextBox();
            this.txtHotelEnvironment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(27, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "酒店名称：";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(100, 46);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtHotelName.Size = new System.Drawing.Size(387, 20);
            this.txtHotelName.TabIndex = 1;
            // 
            // txtHotelAddress
            // 
            this.txtHotelAddress.Location = new System.Drawing.Point(100, 90);
            this.txtHotelAddress.Name = "txtHotelAddress";
            this.txtHotelAddress.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtHotelAddress.Size = new System.Drawing.Size(387, 20);
            this.txtHotelAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "酒店地址：";
            // 
            // txtHotelDesc
            // 
            this.txtHotelDesc.Location = new System.Drawing.Point(100, 134);
            this.txtHotelDesc.Name = "txtHotelDesc";
            this.txtHotelDesc.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtHotelDesc.Size = new System.Drawing.Size(387, 20);
            this.txtHotelDesc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "酒店描述：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "位置交通：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(27, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "周边环境：";
            // 
            // txtHotelPosition
            // 
            this.txtHotelPosition.Location = new System.Drawing.Point(100, 181);
            this.txtHotelPosition.Multiline = true;
            this.txtHotelPosition.Name = "txtHotelPosition";
            this.txtHotelPosition.Size = new System.Drawing.Size(387, 147);
            this.txtHotelPosition.TabIndex = 9;
            // 
            // txtHotelEnvironment
            // 
            this.txtHotelEnvironment.Location = new System.Drawing.Point(100, 355);
            this.txtHotelEnvironment.Multiline = true;
            this.txtHotelEnvironment.Name = "txtHotelEnvironment";
            this.txtHotelEnvironment.Size = new System.Drawing.Size(387, 147);
            this.txtHotelEnvironment.TabIndex = 10;
            // 
            // frmHotelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 514);
            this.Controls.Add(this.txtHotelEnvironment);
            this.Controls.Add(this.txtHotelPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotelDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHotelAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.Label1);
            this.Name = "frmHotelInfo";
            this.Text = "frmHotelInfo";
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotelDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private DevExpress.XtraEditors.TextEdit txtHotelName;
        private DevExpress.XtraEditors.TextEdit txtHotelAddress;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtHotelDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHotelPosition;
        private System.Windows.Forms.TextBox txtHotelEnvironment;
    }
}