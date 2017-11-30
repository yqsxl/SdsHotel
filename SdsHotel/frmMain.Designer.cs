﻿namespace SdsHotel
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rcManager = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.rpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystemn = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiUserInfo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModifyPwd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.rpgHotel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiHotel = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSync = new DevExpress.XtraBars.BarButtonItem();
            this.rpgSelectSkin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rgbSkin = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.rpgOther = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiExitSystem = new DevExpress.XtraBars.BarButtonItem();
            this.rpHotelMgr = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpOrderMgr = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpReportMgr = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgHotelMgr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiRoomMgr = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPriceMgr = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNewRoom = new DevExpress.XtraBars.BarButtonItem();
            this.rpgOrderMgr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiAllOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiArrangeRoomOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoomCheckOut = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCompletedOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOrderReminder = new DevExpress.XtraBars.BarButtonItem();
            this.rpgReportOpMgr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiReportOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFinanceReport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rcManager)).BeginInit();
            this.SuspendLayout();
            // 
            // rcManager
            // 
            this.rcManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.rcManager.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.rcManager.ExpandCollapseItem.Id = 0;
            this.rcManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.rcManager.Images = this.imgMenu;
            this.rcManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcManager.ExpandCollapseItem,
            this.bbiUserInfo,
            this.bbiModifyPwd,
            this.barButtonItem2,
            this.bbiHotel,
            this.bbiSync,
            this.rgbSkin,
            this.bbiExitSystem,
            this.bbiRoomMgr,
            this.bbiPriceMgr,
            this.bbiNewRoom,
            this.bbiAllOrder,
            this.bbiArrangeRoomOrder,
            this.bbiRoomCheckOut,
            this.bbiCompletedOrder,
            this.bbiOrderReminder,
            this.bbiReportOrder,
            this.bbiFinanceReport});
            this.rcManager.ItemsVertAlign = DevExpress.Utils.VertAlignment.Bottom;
            this.rcManager.LargeImages = this.imgMenu;
            this.rcManager.Location = new System.Drawing.Point(0, 0);
            this.rcManager.MaxItemId = 18;
            this.rcManager.Name = "rcManager";
            this.rcManager.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpSystem,
            this.rpHotelMgr,
            this.rpOrderMgr,
            this.rpReportMgr});
            this.rcManager.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.rcManager.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcManager.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.rcManager.ShowToolbarCustomizeItem = false;
            this.rcManager.Size = new System.Drawing.Size(854, 144);
            this.rcManager.Toolbar.ShowCustomizeItem = false;
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "userManager.png");
            this.imgMenu.Images.SetKeyName(1, "menuManage.png");
            this.imgMenu.Images.SetKeyName(2, "roleManage.png");
            this.imgMenu.Images.SetKeyName(3, "rolePerManage.png");
            this.imgMenu.Images.SetKeyName(4, "userManager.png");
            this.imgMenu.Images.SetKeyName(5, "userRoleManage.png");
            this.imgMenu.Images.SetKeyName(6, "log.png");
            this.imgMenu.Images.SetKeyName(7, "menu.png");
            this.imgMenu.Images.SetKeyName(8, "permer.png");
            this.imgMenu.Images.SetKeyName(9, "role.png");
            this.imgMenu.Images.SetKeyName(10, "rolePer.png");
            this.imgMenu.Images.SetKeyName(11, "user.png");
            this.imgMenu.Images.SetKeyName(12, "userRole.png");
            this.imgMenu.Images.SetKeyName(13, "userVip.png");
            this.imgMenu.Images.SetKeyName(14, "VipUser.png");
            this.imgMenu.Images.SetKeyName(15, "dept.png");
            this.imgMenu.Images.SetKeyName(16, "excel2.png");
            this.imgMenu.Images.SetKeyName(17, "excel3.png");
            this.imgMenu.Images.SetKeyName(18, "excel4.png");
            this.imgMenu.Images.SetKeyName(19, "print.png");
            this.imgMenu.Images.SetKeyName(20, "print2.png");
            this.imgMenu.Images.SetKeyName(21, "print3.png");
            this.imgMenu.Images.SetKeyName(22, "print4.png");
            this.imgMenu.Images.SetKeyName(23, "exit.png");
            this.imgMenu.Images.SetKeyName(24, "reportset.png");
            this.imgMenu.Images.SetKeyName(25, "excel1.png");
            this.imgMenu.Images.SetKeyName(26, "pwd.png");
            this.imgMenu.Images.SetKeyName(27, "Person.png");
            this.imgMenu.Images.SetKeyName(28, "pf.png");
            this.imgMenu.Images.SetKeyName(29, "role.png");
            this.imgMenu.Images.SetKeyName(30, "user.png");
            this.imgMenu.Images.SetKeyName(31, "t1.png");
            this.imgMenu.Images.SetKeyName(32, "t2.png");
            this.imgMenu.Images.SetKeyName(33, "t3.png");
            this.imgMenu.Images.SetKeyName(34, "t4.png");
            this.imgMenu.Images.SetKeyName(35, "t5.png");
            this.imgMenu.Images.SetKeyName(36, "t6.png");
            this.imgMenu.Images.SetKeyName(37, "t7.png");
            this.imgMenu.Images.SetKeyName(38, "t8.png");
            this.imgMenu.Images.SetKeyName(39, "t9.png");
            this.imgMenu.Images.SetKeyName(40, "hotelinfo.jpg");
            // 
            // rpSystem
            // 
            this.rpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystemn,
            this.rpgHotel,
            this.rpgOther,
            this.rpgSelectSkin});
            this.rpSystem.Name = "rpSystem";
            this.rpSystem.Text = "系统";
            // 
            // rpgSystemn
            // 
            this.rpgSystemn.ItemLinks.Add(this.bbiUserInfo);
            this.rpgSystemn.ItemLinks.Add(this.bbiModifyPwd);
            this.rpgSystemn.Name = "rpgSystemn";
            this.rpgSystemn.Text = "基本操作";
            // 
            // bbiUserInfo
            // 
            this.bbiUserInfo.Caption = "账号信息";
            this.bbiUserInfo.Id = 1;
            this.bbiUserInfo.LargeImageIndex = 14;
            this.bbiUserInfo.Name = "bbiUserInfo";
            // 
            // bbiModifyPwd
            // 
            this.bbiModifyPwd.Caption = "修改密码";
            this.bbiModifyPwd.Id = 2;
            this.bbiModifyPwd.LargeImageIndex = 26;
            this.bbiModifyPwd.Name = "bbiModifyPwd";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // rpgHotel
            // 
            this.rpgHotel.ItemLinks.Add(this.bbiHotel);
            this.rpgHotel.ItemLinks.Add(this.bbiSync);
            this.rpgHotel.Name = "rpgHotel";
            this.rpgHotel.Text = "酒店信息操作";
            // 
            // bbiHotel
            // 
            this.bbiHotel.Caption = "酒店信息";
            this.bbiHotel.Id = 4;
            this.bbiHotel.LargeImageIndex = 40;
            this.bbiHotel.Name = "bbiHotel";
            // 
            // bbiSync
            // 
            this.bbiSync.Caption = "宾馆数据同步";
            this.bbiSync.Id = 5;
            this.bbiSync.LargeImageIndex = 36;
            this.bbiSync.Name = "bbiSync";
            // 
            // rpgSelectSkin
            // 
            this.rpgSelectSkin.ItemLinks.Add(this.rgbSkin);
            this.rpgSelectSkin.Name = "rpgSelectSkin";
            this.rpgSelectSkin.Text = "更换皮肤";
            // 
            // rgbSkin
            // 
            this.rgbSkin.Caption = "更换皮肤";
            this.rgbSkin.Id = 6;
            this.rgbSkin.Name = "rgbSkin";
            // 
            // rpgOther
            // 
            this.rpgOther.ItemLinks.Add(this.bbiExitSystem);
            this.rpgOther.Name = "rpgOther";
            this.rpgOther.Text = "其他操作";
            // 
            // bbiExitSystem
            // 
            this.bbiExitSystem.Caption = "退出系统";
            this.bbiExitSystem.Id = 7;
            this.bbiExitSystem.LargeImageIndex = 23;
            this.bbiExitSystem.Name = "bbiExitSystem";
            // 
            // rpHotelMgr
            // 
            this.rpHotelMgr.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHotelMgr});
            this.rpHotelMgr.Name = "rpHotelMgr";
            this.rpHotelMgr.Text = "客房管理";
            // 
            // rpOrderMgr
            // 
            this.rpOrderMgr.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgOrderMgr});
            this.rpOrderMgr.Name = "rpOrderMgr";
            this.rpOrderMgr.Text = "订单管理";
            // 
            // rpReportMgr
            // 
            this.rpReportMgr.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgReportOpMgr});
            this.rpReportMgr.Name = "rpReportMgr";
            this.rpReportMgr.Text = "报表管理";
            // 
            // rpgHotelMgr
            // 
            this.rpgHotelMgr.ItemLinks.Add(this.bbiRoomMgr);
            this.rpgHotelMgr.ItemLinks.Add(this.bbiPriceMgr);
            this.rpgHotelMgr.ItemLinks.Add(this.bbiNewRoom);
            this.rpgHotelMgr.Name = "rpgHotelMgr";
            this.rpgHotelMgr.Text = "客房基本操作";
            // 
            // bbiRoomMgr
            // 
            this.bbiRoomMgr.Caption = "房间管理";
            this.bbiRoomMgr.Id = 8;
            this.bbiRoomMgr.LargeImageIndex = 39;
            this.bbiRoomMgr.Name = "bbiRoomMgr";
            // 
            // bbiPriceMgr
            // 
            this.bbiPriceMgr.Caption = "房价管理";
            this.bbiPriceMgr.Id = 9;
            this.bbiPriceMgr.LargeImageIndex = 24;
            this.bbiPriceMgr.Name = "bbiPriceMgr";
            // 
            // bbiNewRoom
            // 
            this.bbiNewRoom.Caption = "申请新增房型";
            this.bbiNewRoom.Id = 10;
            this.bbiNewRoom.LargeImageIndex = 22;
            this.bbiNewRoom.Name = "bbiNewRoom";
            // 
            // rpgOrderMgr
            // 
            this.rpgOrderMgr.ItemLinks.Add(this.bbiAllOrder);
            this.rpgOrderMgr.ItemLinks.Add(this.bbiArrangeRoomOrder);
            this.rpgOrderMgr.ItemLinks.Add(this.bbiRoomCheckOut);
            this.rpgOrderMgr.ItemLinks.Add(this.bbiCompletedOrder);
            this.rpgOrderMgr.ItemLinks.Add(this.bbiOrderReminder);
            this.rpgOrderMgr.Name = "rpgOrderMgr";
            this.rpgOrderMgr.Text = "订单基本操作";
            // 
            // bbiAllOrder
            // 
            this.bbiAllOrder.Caption = "全部订单";
            this.bbiAllOrder.Id = 11;
            this.bbiAllOrder.LargeImageIndex = 11;
            this.bbiAllOrder.Name = "bbiAllOrder";
            // 
            // bbiArrangeRoomOrder
            // 
            this.bbiArrangeRoomOrder.Caption = "安排房间订单";
            this.bbiArrangeRoomOrder.Id = 12;
            this.bbiArrangeRoomOrder.LargeImageIndex = 4;
            this.bbiArrangeRoomOrder.Name = "bbiArrangeRoomOrder";
            // 
            // bbiRoomCheckOut
            // 
            this.bbiRoomCheckOut.Caption = "申请退房订单";
            this.bbiRoomCheckOut.Id = 13;
            this.bbiRoomCheckOut.LargeImageIndex = 13;
            this.bbiRoomCheckOut.Name = "bbiRoomCheckOut";
            // 
            // bbiCompletedOrder
            // 
            this.bbiCompletedOrder.Caption = "已完成订单";
            this.bbiCompletedOrder.Id = 14;
            this.bbiCompletedOrder.LargeImageIndex = 1;
            this.bbiCompletedOrder.Name = "bbiCompletedOrder";
            // 
            // bbiOrderReminder
            // 
            this.bbiOrderReminder.Caption = "订单提醒";
            this.bbiOrderReminder.Id = 15;
            this.bbiOrderReminder.LargeImageIndex = 28;
            this.bbiOrderReminder.Name = "bbiOrderReminder";
            // 
            // rpgReportOpMgr
            // 
            this.rpgReportOpMgr.ItemLinks.Add(this.bbiReportOrder);
            this.rpgReportOpMgr.ItemLinks.Add(this.bbiFinanceReport);
            this.rpgReportOpMgr.Name = "rpgReportOpMgr";
            this.rpgReportOpMgr.Text = "报表基本操作";
            // 
            // bbiReportOrder
            // 
            this.bbiReportOrder.Caption = "订单统计报表";
            this.bbiReportOrder.Id = 16;
            this.bbiReportOrder.LargeImageIndex = 17;
            this.bbiReportOrder.Name = "bbiReportOrder";
            // 
            // bbiFinanceReport
            // 
            this.bbiFinanceReport.Caption = "财务对账报表";
            this.bbiFinanceReport.Id = 17;
            this.bbiFinanceReport.LargeImageIndex = 31;
            this.bbiFinanceReport.Name = "bbiFinanceReport";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 581);
            this.Controls.Add(this.rcManager);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Ribbon = this.rcManager;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rcManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystemn;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraBars.BarButtonItem bbiUserInfo;
        private DevExpress.XtraBars.BarButtonItem bbiModifyPwd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbiHotel;
        private DevExpress.XtraBars.BarButtonItem bbiSync;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHotel;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem rgbSkin;
        private DevExpress.XtraBars.BarButtonItem bbiExitSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOther;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSelectSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHotelMgr;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpOrderMgr;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReportMgr;
        private DevExpress.XtraBars.BarButtonItem bbiRoomMgr;
        private DevExpress.XtraBars.BarButtonItem bbiPriceMgr;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHotelMgr;
        private DevExpress.XtraBars.BarButtonItem bbiNewRoom;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOrderMgr;
        private DevExpress.XtraBars.BarButtonItem bbiAllOrder;
        private DevExpress.XtraBars.BarButtonItem bbiArrangeRoomOrder;
        private DevExpress.XtraBars.BarButtonItem bbiRoomCheckOut;
        private DevExpress.XtraBars.BarButtonItem bbiCompletedOrder;
        private DevExpress.XtraBars.BarButtonItem bbiOrderReminder;
        private DevExpress.XtraBars.BarButtonItem bbiReportOrder;
        private DevExpress.XtraBars.BarButtonItem bbiFinanceReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReportOpMgr;
    }
}