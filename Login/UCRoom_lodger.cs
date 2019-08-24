using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room
{
    public partial class UCRoom_lodger : UserControl
    {
        bool if_clicked = false;



        public UCRoom_lodger()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (if_clicked == true)
            {
                if_clicked = false;

                lbl_name.Enabled = false;
                lbl_surname.Enabled = false;
                lbl_town.Enabled = false;
                lbl_street.Enabled = false;
                lbl_post.Enabled = false;

                txt_name.Enabled = false;
                txt_post.Enabled = false;
                txt_street.Enabled = false;
                txt_surname.Enabled = false;
                txt_town.Enabled = false;

                label1.Enabled = false;
                label8.Enabled = false;

                pictureBox1.ImageLocation = null;
            }
            else
            {
                if_clicked = true;

                lbl_name.Enabled = true;
                lbl_surname.Enabled = true;
                lbl_town.Enabled = true;
                lbl_street.Enabled = true;
                lbl_post.Enabled = true;

                txt_name.Enabled = true;
                txt_post.Enabled = true;
                txt_street.Enabled = true;
                txt_surname.Enabled = true;
                txt_town.Enabled = true;

                label1.Enabled = true;
                label8.Enabled = true;

                pictureBox1.ImageLocation = @"..\..\Images\checkmark_50px.png";
            }
        }

    }
}
