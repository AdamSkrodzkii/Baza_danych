namespace Main_form
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param >true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_slider = new System.Windows.Forms.Panel();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_information = new System.Windows.Forms.Button();
            this.btn_contact = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_attraction = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_time = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_time = new System.Windows.Forms.Timer(this.components);
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.pnl_slider);
            this.panel1.Controls.Add(this.btn_room);
            this.panel1.Controls.Add(this.btn_information);
            this.panel1.Controls.Add(this.btn_contact);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_reservation);
            this.panel1.Controls.Add(this.btn_attraction);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 632);
            this.panel1.TabIndex = 0;
            // 
            // pnl_slider
            // 
            this.pnl_slider.BackColor = System.Drawing.Color.Crimson;
            this.pnl_slider.Location = new System.Drawing.Point(3, 169);
            this.pnl_slider.Name = "pnl_slider";
            this.pnl_slider.Size = new System.Drawing.Size(10, 40);
            this.pnl_slider.TabIndex = 11;
            // 
            // btn_room
            // 
            this.btn_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_room.FlatAppearance.BorderSize = 0;
            this.btn_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_room.ForeColor = System.Drawing.Color.White;
            this.btn_room.Image = global::Login.Properties.Resources.bedroom_30px;
            this.btn_room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_room.Location = new System.Drawing.Point(12, 215);
            this.btn_room.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(165, 29);
            this.btn_room.TabIndex = 10;
            this.btn_room.Text = "Rezerwuj pokój";
            this.btn_room.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_room.UseVisualStyleBackColor = true;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_information
            // 
            this.btn_information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_information.FlatAppearance.BorderSize = 0;
            this.btn_information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_information.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_information.ForeColor = System.Drawing.Color.White;
            this.btn_information.Image = global::Login.Properties.Resources.door_hanger_30px;
            this.btn_information.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_information.Location = new System.Drawing.Point(12, 338);
            this.btn_information.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_information.Name = "btn_information";
            this.btn_information.Size = new System.Drawing.Size(165, 29);
            this.btn_information.TabIndex = 9;
            this.btn_information.Text = "O hotelu";
            this.btn_information.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_information.UseVisualStyleBackColor = true;
            this.btn_information.Click += new System.EventHandler(this.btn_information_Click);
            // 
            // btn_contact
            // 
            this.btn_contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_contact.FlatAppearance.BorderSize = 0;
            this.btn_contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_contact.ForeColor = System.Drawing.Color.White;
            this.btn_contact.Image = global::Login.Properties.Resources.contacts_30px;
            this.btn_contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contact.Location = new System.Drawing.Point(12, 379);
            this.btn_contact.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(165, 29);
            this.btn_contact.TabIndex = 8;
            this.btn_contact.Text = "Kontakt";
            this.btn_contact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_contact.UseVisualStyleBackColor = true;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::Login.Properties.Resources.settings_30px;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(12, 562);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(160, 29);
            this.btn_settings.TabIndex = 7;
            this.btn_settings.Text = "Profil użytkownika";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reservation.FlatAppearance.BorderSize = 0;
            this.btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_reservation.Image = global::Login.Properties.Resources.calendar_30px;
            this.btn_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservation.Location = new System.Drawing.Point(12, 297);
            this.btn_reservation.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(165, 29);
            this.btn_reservation.TabIndex = 6;
            this.btn_reservation.Text = "Twoje rezerwacje";
            this.btn_reservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_attraction
            // 
            this.btn_attraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_attraction.FlatAppearance.BorderSize = 0;
            this.btn_attraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attraction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_attraction.ForeColor = System.Drawing.Color.White;
            this.btn_attraction.Image = global::Login.Properties.Resources.atrakcje_30px;
            this.btn_attraction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attraction.Location = new System.Drawing.Point(12, 256);
            this.btn_attraction.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_attraction.Name = "btn_attraction";
            this.btn_attraction.Size = new System.Drawing.Size(165, 29);
            this.btn_attraction.TabIndex = 5;
            this.btn_attraction.Text = "Atrakcje";
            this.btn_attraction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_attraction.UseVisualStyleBackColor = true;
            this.btn_attraction.Click += new System.EventHandler(this.btn_attraction_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::Login.Properties.Resources.home_30px;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(12, 174);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(165, 29);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Strona główna";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 45);
            this.panel2.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::Login.Properties.Resources.shutdown_32px;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(876, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(47, 36);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.txt_time);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(176, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 53);
            this.panel3.TabIndex = 2;
            // 
            // txt_time
            // 
            this.txt_time.AutoSize = true;
            this.txt_time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_time.ForeColor = System.Drawing.Color.White;
            this.txt_time.Location = new System.Drawing.Point(825, 16);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(83, 19);
            this.txt_time.TabIndex = 2;
            this.txt_time.Text = "HH:MM:SS";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(72, 16);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(102, 19);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Imię i nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj";
            // 
            // Timer_time
            // 
            this.Timer_time.Tick += new System.EventHandler(this.Timer_time_Tick);
            // 
            // pnl_Container
            // 
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(176, 98);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(923, 534);
            this.pnl_Container.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1099, 632);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_form";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_contact;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_attraction;
        private System.Windows.Forms.Button btn_information;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Timer Timer_time;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel pnl_slider;
    }
}