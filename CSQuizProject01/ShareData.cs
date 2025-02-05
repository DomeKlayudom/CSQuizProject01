using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    internal class ShareData
    {
        public static void CheckIsNumber(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                return;
            }


            if (e.KeyChar == '.' && ((TextBox)sender).Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
                return;
            }


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        public static void CheckIsNotInteger(object sender, KeyPressEventArgs e)
        {
            // อนุญาตให้กดปุ่มควบคุม เช่น Backspace, Delete
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // ถ้ากดเป็นตัวเลข (0-9) ให้ป้องกันการพิมพ์
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void ShowWarningMSG(String mgs)
        {
            MessageBox.Show(mgs, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
