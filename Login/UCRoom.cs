using System;
using System.Windows.Forms;

namespace Room
{
    public partial class UCRoom : UserControl
    {
        int counter = 1;
        int amount =0;
        int lodgers;

        bool next_room = false;

        public Room.UCRoom_container _container = new Room.UCRoom_container();

        static UCRoom _object_room;

        public static UCRoom Instance_room
        {
            get
            {
                if (_object_room == null)
                {
                    _object_room = new UCRoom();
                }
                return _object_room;
            }
        }

        public UCRoom()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            switch (next_room)
            {

                // W tej części są tworzone okienka lokatorów, te okienka nazywają sięod lokator 1 do lokator n

                case false:
                    
                    pnl_container_lodger.Visible = true;
                    for (int i = 0; i< lodgers; i++)
                    {
                        UCRoom_lodger _lodger = new UCRoom_lodger();
                            _lodger.Name = string.Format("lokator {0}", i + 1);
                            _lodger.lbl_lodger.Text = string.Format("lokator {0}", i + 1);
                            pnl_container_lodger.Controls.Add(_lodger);
                            pnl_container_lodger.Controls[string.Format("lokator {0}", i + 1)].Top = i * 300; 
                     }
                        
                        next_room = true;
                        break;
                //

                 case true:
                    Instance_room._container.Controls[String.Format("txt_room{0}", counter)].Text = list_people.Text + " z widokiem " + list_view.Text;
                    Instance_room._container.Controls[String.Format("txt_room{0}", counter)].Visible = true;
                    if (btn_hamburger.Visible == true) Instance_room._container.Controls[String.Format("btn_hamburger{0}", counter)].Visible = true;
                    if (btn_broom.Visible == true) Instance_room._container.Controls[String.Format("btn_broom{0}", counter)].Visible = true;
                    if (btn_clock.Visible == true) Instance_room._container.Controls[String.Format("btn_clock{0}", counter)].Visible = true;

                    // tutaj kasują się kontrolki stare z lokatorami
                    // dane razem z nimi tez się tracą

                    for (int i = 0; i < lodgers; i++)
                    {
                        pnl_container_lodger.Controls.RemoveByKey(string.Format("lokator {0}", i + 1));
                    }
                    //
                    pnl_container_lodger.Visible = false;
                        counter++;
                        lbl_counter.Text = String.Format("Pokój {0}", counter);
                        next_room = false;
                        break;
                }

            if (counter == amount+1)
            {
                Main_form.Main.Instance_main.pnlContainerMain.Controls["UCRoom_callendar"].BringToFront();
            }
            

        }

        private void list_people_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tutaj kasują się kontrolki stare z lokatorami
            // dane razem z nimi tez się tracą

            next_room = false;
            pnl_container_lodger.Visible = false;
            for (int i = 0; i < lodgers; i++)
            {
                pnl_container_lodger.Controls.RemoveByKey(string.Format("lokator {0}", i + 1));
            }

            //
            if (list_people.Text == "(Brak)")
            {
                lbl_view.Enabled = false;
                list_view.Enabled = false;
                lbl_add.Enabled = false;
                list_add.Enabled = false;
                btn_next.Enabled = false;
                btn_add.Enabled = false;
            }
            else
            {
                switch (list_people.Text)
                {
                    case "1-osobowy":
                        lodgers = 1;
                        break;
                    case "2-osobowy":
                        lodgers = 2;
                        break;
                    case "4-osobowy":
                        lodgers = 4;
                        break;
                }
                lbl_view.Enabled = true;
                list_view.Enabled = true;
            }
        }

        private void list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_add.Enabled = true;
            list_add.Enabled = true;
        }

        private void list_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_next.Enabled = true;
        }

        private void list_amount_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool next_room = false;
            pnl_container_lodger.Visible = false;
            if (list_amount.Text == "(Brak)")
            {
                lbl_people.Enabled = false;
                list_people.Enabled = false;
                lbl_view.Enabled = false;
                list_view.Enabled = false;
                lbl_add.Enabled = false;
                list_add.Enabled = false;
                btn_next.Enabled = false;
                lbl_counter.Enabled = false;
                btn_add.Enabled = false;
                btn_hamburger.Visible = false;
                btn_clock.Visible = false;
                btn_broom.Visible = false;
                list_add.Text = null;
                list_people.Text = "(Brak)";
                list_view.Text = null;
                lbl_counter.Text = "Pokój #";

            }

            else
            {
                amount = Int32.Parse(list_amount.Text);
                counter = 1;
                lbl_counter.Text = String.Format("Pokój {0}", counter);
                lbl_counter.Enabled = true;
                lbl_people.Enabled = true;
                list_people.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (list_add.Text == "Jedzenie do łóżka") btn_hamburger.Visible = true;
            if (list_add.Text == "Budzenie") btn_clock.Visible = true;
            if (list_add.Text == "Codzienne sprzątanie") btn_broom.Visible = true;
            if (list_add.Text == "(Brak)")
            {
                btn_hamburger.Visible = false;
                btn_clock.Visible = false;
                btn_broom.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCRoom_Load(object sender, EventArgs e)
        {
            pnl_container_lodger.Visible = false;
        }
    }
}
