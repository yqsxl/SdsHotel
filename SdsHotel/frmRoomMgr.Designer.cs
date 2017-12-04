namespace SdsHotel
{
    partial class frmRoomMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomMgr));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.lblTitle = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.textBoxItem1 = new DevComponents.DotNetBar.TextBoxItem();
            this.cbiStatus = new DevComponents.DotNetBar.ComboBoxItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.btiSearch = new DevComponents.DotNetBar.ButtonItem();
            this.gcRoomList = new DevExpress.XtraGrid.GridControl();
            this.gvRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LockNum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblTitle,
            this.labelItem1,
            this.labelItem2,
            this.textBoxItem1,
            this.cbiStatus,
            this.labelItem3,
            this.btiSearch});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(856, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "共有3个房间上线,0个房间下线";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "房间名称：";
            // 
            // textBoxItem1
            // 
            this.textBoxItem1.Name = "textBoxItem1";
            this.textBoxItem1.TextBoxWidth = 120;
            this.textBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // cbiStatus
            // 
            this.cbiStatus.DropDownHeight = 106;
            this.cbiStatus.ItemHeight = 17;
            this.cbiStatus.Name = "cbiStatus";
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            // 
            // btiSearch
            // 
            this.btiSearch.Image = ((System.Drawing.Image)(resources.GetObject("btiSearch.Image")));
            this.btiSearch.Name = "btiSearch";
            this.btiSearch.Text = "buttonItem1";
            // 
            // gcRoomList
            // 
            this.gcRoomList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoomList.Location = new System.Drawing.Point(0, 28);
            this.gcRoomList.MainView = this.gvRoom;
            this.gcRoomList.Name = "gcRoomList";
            this.gcRoomList.Size = new System.Drawing.Size(856, 502);
            this.gcRoomList.TabIndex = 1;
            this.gcRoomList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoom});
            // 
            // gvRoom
            // 
            this.gvRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.RoomName,
            this.RoomType,
            this.RoomStatus,
            this.LockNum});
            this.gvRoom.GridControl = this.gcRoomList;
            this.gvRoom.Name = "gvRoom";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // RoomName
            // 
            this.RoomName.Caption = "房间名称";
            this.RoomName.FieldName = "RoomName";
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 1;
            // 
            // RoomType
            // 
            this.RoomType.Caption = "房型";
            this.RoomType.FieldName = "RoomType";
            this.RoomType.Name = "RoomType";
            this.RoomType.Visible = true;
            this.RoomType.VisibleIndex = 2;
            // 
            // RoomStatus
            // 
            this.RoomStatus.Caption = "状态";
            this.RoomStatus.FieldName = "RoomStatus";
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.Visible = true;
            this.RoomStatus.VisibleIndex = 3;
            // 
            // LockNum
            // 
            this.LockNum.Caption = "锁编号";
            this.LockNum.FieldName = "LockNum";
            this.LockNum.Name = "LockNum";
            this.LockNum.Visible = true;
            this.LockNum.VisibleIndex = 4;
            // 
            // frmRoomMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 530);
            this.Controls.Add(this.gcRoomList);
            this.Controls.Add(this.bar1);
            this.Name = "frmRoomMgr";
            this.Text = "frmRoomMgr";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem lblTitle;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem1;
        private DevComponents.DotNetBar.ComboBoxItem cbiStatus;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.ButtonItem btiSearch;
        private DevExpress.XtraGrid.GridControl gcRoomList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoom;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn RoomType;
        private DevExpress.XtraGrid.Columns.GridColumn RoomStatus;
        private DevExpress.XtraGrid.Columns.GridColumn LockNum;
    }
}