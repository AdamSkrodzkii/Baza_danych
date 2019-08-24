using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form
{
    public partial class Main : Form
    {
        public string TopName;
        static Main _object;

        public static Main Instance_main
        {
            get
            {
                if (_object == null)
                {
                    _object = new Main();
                }
                return _object;
            }
        }

        public Panel pnlContainerMain
        {
             get { return pnl_Container; }
             set { pnl_Container = value; }
        }

        public Main()
        {
            InitializeComponent();
            Timer_time.Start();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_home.Top - 5;
            pnlContainerMain.Controls["UCHome"].BringToFront();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer_time_Tick(object sender, EventArgs e)
        {
            DateTime _dt = DateTime.Now;
            txt_time.Text = _dt.ToString("HH:mm:ss");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_name.Text = TopName;
            _object = this;

            Home.UCHome _Home = new Home.UCHome();
            _Home.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_Home);
            pnlContainerMain.Controls["UCHome"].BringToFront();

            Room.UCRoom _Room = new Room.UCRoom();
            _Room.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_Room);

            Room.UCRoom_callendar _Callendar = new Room.UCRoom_callendar();
            _Callendar.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_Callendar);

            Reservation.UCReservation _reservation = new Reservation.UCReservation();
            _reservation.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_reservation);

            Attractions.UCAttractions _attraction = new Attractions.UCAttractions();
            _attraction.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_attraction);

            Contact.UCContact _contact = new Contact.UCContact();
            _contact.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_contact);

            Settings.UCSettings _settings = new Settings.UCSettings();
            _settings.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_settings);

            Information.UCInformation _information = new Information.UCInformation();
            _information.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Add(_information);

        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_room.Top - 5;
            pnlContainerMain.Controls["UCRoom"].BringToFront();
        }

        private void btn_attraction_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_attraction.Top - 5;
            pnlContainerMain.Controls["UCAttractions"].BringToFront();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_reservation.Top - 5;
            pnlContainerMain.Controls["UCReservation"].BringToFront();
        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_information.Top - 5;
            pnlContainerMain.Controls["UCInformation"].BringToFront();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_contact.Top - 5;
            pnlContainerMain.Controls["UCContact"].BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            pnl_slider.Top = btn_settings.Top - 5;
            pnlContainerMain.Controls["UCSettings"].BringToFront();
        }
        
    }
}
