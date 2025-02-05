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
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {
            btReset.PerformClick();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNotInteger(sender, e);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            mtbIdCardNumber.Text = "";
            tbFullName.Text = "";
            rbMember.Checked = true;
            cbbService.SelectedIndex = 0;
            tbHour.Text = "";
            cbPayCheck.Checked = false;

            mcDate.SetDate(DateTime.Now);


            lbDate.Text = "-";
            lbIdCardNumber.Text = "-";
            lbFullName.Text = "-";
            lbUserService.Text = "-";
            lbService.Text = "-";
            lbHour.Text = "-";

            lbResult.Text = "0.00";
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if (mtbIdCardNumber.MaskCompleted == false)
            {
                ShareData.ShowWarningMSG("กรุณากรอกเลขบัตรประชาชนให้ครบถ้วน");
                mtbIdCardNumber.Focus();
                return;
            }
            if (tbFullName.Text.Trim() == "")
            {
                ShareData.ShowWarningMSG("กรุณากรอกชื่อ-นามสกุล");
                tbFullName.Focus();
                return;
            }
            if (cbPayCheck.Checked == false)
            {
                ShareData.ShowWarningMSG("กรุณายอมรับเงื่อนไขการใช้บริการ");
                cbPayCheck.Focus();
                return;
            }
            if (tbHour.Text.Trim() == "")
            {
                ShareData.ShowWarningMSG("กรุณากรอกจำนวนชั่วโมงที่ใช้บริการ");
                tbHour.Focus();
                return;
            }
            if (mcDate.SelectionStart < DateTime.Now)
            {
                ShareData.ShowWarningMSG("กรุณาเลือกวันที่ให้ถูกต้อง");
                mcDate.Focus();
                return;
            }

            // ดึงค่าชั่วโมงจาก tbHour
            double hours = double.Parse(tbHour.Text);
            double[] rates = { 20.50, 10.50, 15.50, 25.50 };  // อัตราค่าบริการตามลำดับ

            // ใช้ index จาก cbbService เพื่อเลือกราคา
            int selectedIndex = cbbService.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= rates.Length)
            {
                ShareData.ShowWarningMSG("กรุณาเลือกประเภทบริการที่ถูกต้อง");
                return;
            }

            double rate = rates[selectedIndex];  // เลือกราคาโดยใช้ index

            double discount = 0;

            // ตรวจสอบประเภทผู้ใช้
            if (rbMember.Checked)
            {
                discount = 0.10; // สมาชิก ลด 10%
            }
            else if (rbStudent.Checked)
            {
                discount = 0.05; // นักเรียน ลด 5%
            }
            else
            {
                discount = 0.00; // บุคคลทั่วไป ไม่ลด
            }

            // คำนวณราคาสุทธิ
            double total = hours * rate;
            double discountAmount = total * discount;
            double finalPrice = total - discountAmount;

            // แสดงผลลัพธ์
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            lbDate.Text = mcDate.SelectionStart.ToString("dd/MM/yyyy", cultureInfo);
            lbIdCardNumber.Text = mtbIdCardNumber.Text;
            lbFullName.Text = tbFullName.Text;
            lbUserService.Text = rbMember.Checked ? "สมาชิก" : rbStudent.Checked ? "นักเรียน - นักศึกษา" : "บุคคลทั่วไป";
            lbService.Text = cbbService.Text;
            lbHour.Text = tbHour.Text;

            lbResult.Text = finalPrice.ToString("0.00"); // แสดงผลรวมหลังหักส่วนลด
        }

    }
}
