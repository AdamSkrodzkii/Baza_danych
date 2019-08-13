using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Main_form;
using Register;
using Login;

namespace Account
{
    public partial class Form_Account : Form
    {
        static Form_Account _obj;

        public static Form_Account Instance_acc
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form_Account();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Form_Account()
        {
            InitializeComponent();
        }

        private void ButExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            _obj = this;

            UCRegister reg = new UCRegister();
            reg.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(reg);

            UCLogin log = new UCLogin();
            log.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(log);

            panelContainer.Controls["UCLogin"].BringToFront();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
