using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        private int ImageNumber = 0;

        private void NextImage()
        {
            if ( ImageNumber == 4)
            {
                ImageNumber = 0;
            }
            ptr_BOX.ImageLocation = string.Format(@"..\..\Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer_pictures_Tick(object sender, EventArgs e)
        {
            NextImage();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            timer_pictures.Start();
        }
    }
}
