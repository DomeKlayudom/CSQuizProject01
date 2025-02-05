using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmRentRoom : Form
    {
        public FrmRentRoom()
        {
            InitializeComponent();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if(mtbIdCardNumber.MaskCompleted == false)
            {
                ShareData.ShowWarningMSG("กรุณากรอกหมายเลขบัตรประชาชนให้ครบถ้วน");
                return;
            }
            if(tbName.Text.Trim().Length == 0)
            {
                ShareData.ShowWarningMSG("กรุณากรอกชื่อ");
                return;
            }
            if (tbSurname.Text.Trim().Length == 0)
            {
                ShareData.ShowWarningMSG("กรุณากรอกนามสกุล");
                return;
            }
            if(dtpDate.Value > DateTime.Now)
            {
                ShareData.ShowWarningMSG("กรุณาเลือกวันที่เข้าพักให้ถูกต้อง");
                return;
            }
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            lbDate.Text = dtpDate.Value.ToString("dd/MM/yyyy",cultureInfo);
            lbIdCardNumber.Text = mtbIdCardNumber.Text;
            String titleName = rbMister.Checked ? "นาย" : rbMistress.Checked ? "นาง" : "นางสาว";
            lbFullName.Text = titleName + " " + tbName.Text + " " + tbSurname.Text;
            String roomType = cbbRoomType.SelectedIndex == 0 ? "ห้องแอร์ (VIP)" : cbbRoomType.SelectedIndex == 1 ? "ห้องแอร์ (ธรรมดา)" : cbbRoomType.SelectedIndex == 2 ? "ห้องพัดลม (VIP)" : "ห้องพัดลมธรรมดา";      
            lbRoomType.Text = roomType;

            lbPhoneNum.Text = tbPhoneNum.Text;
            lbInternetNum.Text = tbInternetNum.Text;
            lbWaterNum.Text = tbWaterNum.Text;
            lbElectricityNum.Text = tbElectricityNum.Text;

            // Function to safely parse numbers and set a default value of 0 if invalid
            double SafeParse(string text)
            {
                return string.IsNullOrEmpty(text) ? 0 : double.TryParse(text, out double result) ? result : 0;
            }

            // Calculate and update the results
            lbPhoneResult.Text = (SafeParse(lbPhoneNum.Text) * 1.50).ToString("0.00");
            lbInternetResult.Text = (SafeParse(lbInternetNum.Text) * 0.50).ToString("0.00");
            lbWaterResult.Text = (SafeParse(lbWaterNum.Text) * 12.50).ToString("0.00");
            lbElectricityResult.Text = (SafeParse(lbElectricityNum.Text) * 15.75).ToString("0.00");


            double roomPrice = cbbRoomType.SelectedIndex == 0 ? 4500.00 : cbbRoomType.SelectedIndex == 1 ? 4000.00 : cbbRoomType.SelectedIndex == 2 ? 3500.00 : 3000.00;

            lbTotalResult.Text = (roomPrice+double.Parse(lbPhoneResult.Text) + double.Parse(lbInternetResult.Text) + double.Parse(lbWaterResult.Text) + double.Parse(lbElectricityResult.Text)).ToString("0.00");
        }
            
        private void btCancel_Click(object sender, EventArgs e)
        {
            mtbIdCardNumber.Text = "";
            rbMister.Checked = true;
            tbName.Text = "";
            tbSurname.Text = "";
            cbbRoomType.SelectedIndex = 0;
            cbPhone.Checked = false;
            cbInternet.Checked = false;
            cbWater.Checked = false;
            cbElectricity.Checked = false;
            dtpDate.Value = DateTime.Now;


            tbPhoneNum.Text = "";
            tbInternetNum.Text = "";
            tbWaterNum.Text = "";
            tbElectricityNum.Text = "";

            lbPhoneNum.Text = "0";
            lbInternetNum.Text = "0";
            lbWaterNum.Text = "0";
            lbElectricityNum.Text = "0";

            lbDate.Text = "-";
            lbIdCardNumber.Text = "-";
            lbFullName.Text = "-";
            lbRoomType.Text = "-";

            lbPhoneResult.Text = "0.00";
            lbInternetResult.Text = "0.00";
            lbWaterResult.Text = "0.00";
            lbElectricityResult.Text = "0.00";
        }

        private void FrmRentRoom_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
            tbPhoneNum.Enabled = false;
            tbInternetNum.Enabled = false;
            tbWaterNum.Enabled = false;
            tbElectricityNum.Enabled = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNotInteger(sender, e);
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNotInteger(sender, e);
        }

        private void tbPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNumber(sender, e);
        }

        private void tbInternetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNumber(sender, e);
        }

        private void tbWaterNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNumber(sender, e);
        }

        private void tbElectricityNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNumber(sender, e);
        }

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            tbPhoneNum.Enabled = cbPhone.Checked;
            tbPhoneNum.Text = cbPhone.Checked ? "0" : "";
        }

        private void cbInternet_CheckedChanged(object sender, EventArgs e)
        {
            tbInternetNum.Enabled = cbInternet.Checked;
            tbInternetNum.Text = cbInternet.Checked ? "0" : "";
        }

        private void cbWater_CheckedChanged(object sender, EventArgs e)
        {
            tbWaterNum.Enabled = cbWater.Checked;
            tbWaterNum.Text = cbWater.Checked ? "0" : "";
        }

        private void cbElectricity_CheckedChanged(object sender, EventArgs e)
        {
            tbElectricityNum.Enabled = cbElectricity.Checked;
            tbElectricityNum.Text = cbElectricity.Checked ? "0" : "";
        }
    }
}
