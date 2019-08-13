using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class UCLogin : UserControl
    {
        int counter = 0;

        public UCLogin()
        {
            InitializeComponent();
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        private void Txt_register_Click(object sender, EventArgs e)
        {
            Account.Form_Account.Instance_acc.PnlContainer.Controls["UCRegister"].BringToFront();
        }

        private void timer_error_Tick(object sender, EventArgs e)
        {
            if (counter < 6) counter++;
            else
            {
                counter = 0;
                Txt_Error.Visible = false;
                timer_error.Stop();
            }
        }

        private void Txt_Error_TextChanged(object sender, EventArgs e)
        {
            timer_error.Start();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Main_form.Main app = new Main_form.Main();
            Account.Form_Account.Instance_acc.Hide();
            app.ShowDialog();
            Account.Form_Account.Instance_acc.Close();
        }
    }
}
