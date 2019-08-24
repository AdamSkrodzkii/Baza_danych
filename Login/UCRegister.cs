using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class UCRegister : UserControl
    {
        bool if_clicked = true;
        public UCRegister()
        {
            InitializeComponent();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].BringToFront();
        }

        private void But_rejestr_Click(object sender, EventArgs e)
        {
            // Jezeli cos nie jest takie jak trzeba to ma odpalić timer_error
            if (txt_password != txt_password_repeat)
            {
                timer_error.Start();
            }

            // jeżeli wszystko jest jak należy to przechodzi do okna login i wyświetla komunikat
            else
            {
                Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].BringToFront();
                Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].Controls["Txt_Error"].Visible = true;
                Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].Controls["Txt_Error"].Text = "Pomyślnie się zarejestrowałeś! Zaloguj się";
            }
        }

        private void timer_error_Tick(object sender, EventArgs e)
        {
            int counter = 0;
            txt_login.BackColor = System.Drawing.Color.Red;
            txt_password.BackColor = System.Drawing.Color.Red;
            txt_password_repeat.BackColor = System.Drawing.Color.Red;

            if(counter == 2)
            {
                txt_login.BackColor = System.Drawing.Color.White;
                txt_password.BackColor = System.Drawing.Color.White;
                txt_password_repeat.BackColor = System.Drawing.Color.White;
            }

            if (counter < 6) counter++;
            else
            {
                txt_error.Visible = false;
                timer_error.Stop();
            }
        }

        private void txt_password_repeat_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_password_repeat.Text)
            {
                txt_password_repeat.BackColor = System.Drawing.Color.Green;
            }
            else txt_password_repeat.BackColor = System.Drawing.Color.Red;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (if_clicked == true)
            {
                if_clicked = false;
                lbl_name.Left += 19;
                lbl_name.Text = "Nazwa firmy:";
                pictureBox1.ImageLocation = @"..\..\Images\checkmark_50px.png";
            }
            else
            {
                if_clicked = true;
                lbl_name.Left -= 19;
                lbl_name.Text = "Imię i nazwisko:";
                pictureBox1.ImageLocation = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
