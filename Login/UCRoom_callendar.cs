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
        int amount_of_rezervations = 0;                                 // Dobrze by było aby ta wartość pokazywała sumę wszystkich rezerwacji
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

            // tutaj dodawana jest nowa rezerwacja

            Room.UCRoom.Instance_room._container.Name = string.Format("rezerwacja {0}", amount_of_rezervations);
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].Controls.Add(Room.UCRoom.Instance_room._container);
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].Controls[string.Format("rezerwacja {0}", amount_of_rezervations)].Top = amount_of_rezervations * 180 + 15;
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].Controls[string.Format("rezerwacja {0}", amount_of_rezervations)].Left = 75;
            Main_form.Main.Instance_main.pnlContainerMain.Controls["UCReservation"].BringToFront();
        }
    }
}
