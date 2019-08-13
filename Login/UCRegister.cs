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
            Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].BringToFront();
            Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].Controls["Txt_Error"].Visible = true;
            Account.Form_Account.Instance_acc.PnlContainer.Controls["UCLogin"].Controls["Txt_Error"].Text = "Pomyślnie się zarejestrowałeś! Zaloguj się";
        }
    }
}
