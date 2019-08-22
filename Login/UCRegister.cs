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
        bool is_client = true;
        public UCRegister()
        {
            InitializeComponent();
        }

        private void Txt_login_Click(object sender, EventArgs e)
        {
            Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].BringToFront();
        }

        private void But_rejestr_Click(object sender, EventArgs e)
        {
            if
                (
                    txt_email.Text == "" ||
            Txt_login.Text == ""||
            txt_name.Text == ""||
            txt_password.Text == "" ||
            txt_password_repeat.Text == "" ||
            txt_password_repeat.Text != txt_password.Text ||
            txt_phone.Text == "" ||
            txt_post.Text == "" ||
            txt_street.Text == "" ||
            txt_surname.Text == "" ||
            txt_town.Text == "" 
                )
            {
                txt_error.Visible = false;
            }

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
            if (counter < 5) counter++;
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
            if (is_client == true)
                {
                    is_client = false;
                txt_company_name.Enabled = true;
                txt_company_post.Enabled = true;
                txt_company_street.Enabled = true;
                txt_company_town.Enabled = true;

                lbl_company_.Enabled = true;
                lbl_company_name.Enabled = true;
                lbl_company_post.Enabled = true;
                lbl_company_street.Enabled = true;
                lbl_company_town.Enabled = true;

                pictureBox1.ImageLocation = @"..\..\Images\checkmark_50px.png";
                }
            else
            {
                txt_company_name.Enabled = false;
                txt_company_post.Enabled = false;
                txt_company_street.Enabled = false;
                txt_company_town.Enabled = false;

                lbl_company_.Enabled = false;
                lbl_company_name.Enabled = false;
                lbl_company_post.Enabled = false;
                lbl_company_street.Enabled = false;
                lbl_company_town.Enabled = false;
                is_client = true;
                pictureBox1.ImageLocation = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
