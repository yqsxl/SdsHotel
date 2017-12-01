using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SdsHotel.ViewModel;

namespace SdsHotel
{
    public partial class frmUserInfo : FrmRibbonBase
    {
        public frmUserInfo()
        {
            InitializeComponent();
            InitFormData();//初始化
        }

        private void InitFormData()
        {
            //接口获取
            //实体映射
            //赋值
            var hotel=new HotelRegisterInfo();
            SetValue(hotel);
        }

        private void SetValue(HotelRegisterInfo hotel) {
            lblHotelName.Text = hotel.HotelName;
            lblAccount.Text = hotel.HotelLoginID;
            lblHotelAccount.Text = hotel.HotelAccountName;
            lblHotelUserPhone.Text =hotel.HotelAccountPhone;
            lblLastLoginDate.Text = hotel.LoginDate;
            lblLoginIP.Text =hotel.LoginIP;
        }
    }
}
