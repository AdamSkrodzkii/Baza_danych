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
    public partial class UCRoom_callendar : UserControl
    {
        bool poczatek = true;
        public UCRoom_callendar()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCRoom"].BringToFront();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if ( poczatek == true) { lbl_start.Text = monthCalendar1.SelectionStart.ToShortDateString(); poczatek = false; }
            else { lbl_end.Text = monthCalendar1.SelectionStart.ToShortDateString(); poczatek = true; }
        }

        private void btn_rez_Click(object sender, EventArgs e)
        {
            Room.UCRoom.Instance_room._container.Controls["txt_date_from"].Text = lbl_start.Text;
            Room.UCRoom.Instance_room._container.Controls["txt_date_to"].Text = lbl_end.Text;
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].Controls.Add(Room.UCRoom.Instance_room._container);
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].Controls["UCRoom_container"].Location = new System.Drawing.Point(56, 25);
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].BringToFront();
        }
    }
}
