namespace Room
{
    partial class UCRoom
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_people = new System.Windows.Forms.ComboBox();
            this.list_add = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.list_view = new System.Windows.Forms.ComboBox();
            this.lbl_people = new System.Windows.Forms.Label();
            this.lbl_view = new System.Windows.Forms.Label();
            this.lbl_add = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_amount = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clock = new System.Windows.Forms.Button();
            this.btn_broom = new System.Windows.Forms.Button();
            this.btn_hamburger = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_people
            // 
            this.list_people.Enabled = false;
            this.list_people.FormattingEnabled = true;
            this.list_people.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.list_people.Items.AddRange(new object[] {
            "(Brak)",
            "1-osobowy",
            "2-osobowy",
            "4-osobowy"});
            this.list_people.Location = new System.Drawing.Point(162, 65);
            this.list_people.Name = "list_people";
            this.list_people.Size = new System.Drawing.Size(121, 21);
            this.list_people.TabIndex = 6;
            this.list_people.Text = "(Brak)";
            this.list_people.SelectedIndexChanged += new System.EventHandler(this.list_people_SelectedIndexChanged);
            // 
            // list_add
            // 
            this.list_add.Enabled = false;
            this.list_add.FormattingEnabled = true;
            this.list_add.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.list_add.Items.AddRange(new object[] {
            "(Brak)",
            "Jedzenie do łóżka",
            "Budzenie",
            "Codzienne sprzątanie"});
            this.list_add.Location = new System.Drawing.Point(162, 171);
            this.list_add.Name = "list_add";
            this.list_add.Size = new System.Drawing.Size(121, 21);
            this.list_add.TabIndex = 8;
            this.list_add.SelectedIndexChanged += new System.EventHandler(this.list_add_SelectedIndexChanged);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_next.Enabled = false;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_next.Location = new System.Drawing.Point(124, 411);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(247, 64);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = "Dalej";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // list_view
            // 
            this.list_view.Enabled = false;
            this.list_view.FormattingEnabled = true;
            this.list_view.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.list_view.Items.AddRange(new object[] {
            "na las",
            "na jezioro"});
            this.list_view.Location = new System.Drawing.Point(162, 118);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(121, 21);
            this.list_view.TabIndex = 7;
            this.list_view.SelectedIndexChanged += new System.EventHandler(this.list_view_SelectedIndexChanged);
            // 
            // lbl_people
            // 
            this.lbl_people.AutoSize = true;
            this.lbl_people.Enabled = false;
            this.lbl_people.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_people.Location = new System.Drawing.Point(61, 65);
            this.lbl_people.Name = "lbl_people";
            this.lbl_people.Size = new System.Drawing.Size(75, 21);
            this.lbl_people.TabIndex = 10;
            this.lbl_people.Text = "Ile osób:";
            this.lbl_people.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_view
            // 
            this.lbl_view.AutoSize = true;
            this.lbl_view.Enabled = false;
            this.lbl_view.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_view.Location = new System.Drawing.Point(72, 118);
            this.lbl_view.Name = "lbl_view";
            this.lbl_view.Size = new System.Drawing.Size(64, 21);
            this.lbl_view.TabIndex = 11;
            this.lbl_view.Text = "Widok:";
            this.lbl_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Enabled = false;
            this.lbl_add.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_add.Location = new System.Drawing.Point(61, 171);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(73, 21);
            this.lbl_add.TabIndex = 12;
            this.lbl_add.Text = "Dodatki:";
            this.lbl_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(144, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ile pokoi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // list_amount
            // 
            this.list_amount.FormattingEnabled = true;
            this.list_amount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.list_amount.Items.AddRange(new object[] {
            "(Brak)",
            "1",
            "2",
            "3"});
            this.list_amount.Location = new System.Drawing.Point(252, 83);
            this.list_amount.Name = "list_amount";
            this.list_amount.Size = new System.Drawing.Size(121, 21);
            this.list_amount.TabIndex = 13;
            this.list_amount.Text = "(Brak)";
            this.list_amount.SelectedIndexChanged += new System.EventHandler(this.list_amount_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_clock);
            this.panel1.Controls.Add(this.btn_broom);
            this.panel1.Controls.Add(this.btn_hamburger);
            this.panel1.Controls.Add(this.lbl_counter);
            this.panel1.Controls.Add(this.lbl_people);
            this.panel1.Controls.Add(this.list_people);
            this.panel1.Controls.Add(this.list_view);
            this.panel1.Controls.Add(this.lbl_add);
            this.panel1.Controls.Add(this.list_add);
            this.panel1.Controls.Add(this.lbl_view);
            this.panel1.Location = new System.Drawing.Point(88, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 256);
            this.panel1.TabIndex = 15;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add.Enabled = false;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Image = global::Login.Properties.Resources.arrow_10px;
            this.btn_add.Location = new System.Drawing.Point(304, 171);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(20, 22);
            this.btn_add.TabIndex = 19;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clock
            // 
            this.btn_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clock.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clock.Image = global::Login.Properties.Resources.alarm_clock_30px;
            this.btn_clock.Location = new System.Drawing.Point(153, 207);
            this.btn_clock.Name = "btn_clock";
            this.btn_clock.Size = new System.Drawing.Size(33, 35);
            this.btn_clock.TabIndex = 18;
            this.btn_clock.UseVisualStyleBackColor = false;
            this.btn_clock.Visible = false;
            // 
            // btn_broom
            // 
            this.btn_broom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_broom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_broom.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_broom.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_broom.Image = global::Login.Properties.Resources.broom_30px;
            this.btn_broom.Location = new System.Drawing.Point(204, 207);
            this.btn_broom.Name = "btn_broom";
            this.btn_broom.Size = new System.Drawing.Size(34, 35);
            this.btn_broom.TabIndex = 17;
            this.btn_broom.UseVisualStyleBackColor = false;
            this.btn_broom.Visible = false;
            // 
            // btn_hamburger
            // 
            this.btn_hamburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_hamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hamburger.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hamburger.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hamburger.Image = global::Login.Properties.Resources.hamburger_30px;
            this.btn_hamburger.Location = new System.Drawing.Point(103, 207);
            this.btn_hamburger.Name = "btn_hamburger";
            this.btn_hamburger.Size = new System.Drawing.Size(33, 35);
            this.btn_hamburger.TabIndex = 16;
            this.btn_hamburger.UseVisualStyleBackColor = false;
            this.btn_hamburger.Visible = false;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Enabled = false;
            this.lbl_counter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_counter.Location = new System.Drawing.Point(149, 16);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(79, 24);
            this.lbl_counter.TabIndex = 13;
            this.lbl_counter.Text = "Pokój #";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Login.Properties.Resources.Bed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(471, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 404);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UCRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_amount);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCRoom";
            this.Size = new System.Drawing.Size(923, 534);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox list_people;
        private System.Windows.Forms.ComboBox list_add;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ComboBox list_view;
        private System.Windows.Forms.Label lbl_people;
        private System.Windows.Forms.Label lbl_view;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_amount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Button btn_clock;
        private System.Windows.Forms.Button btn_broom;
        private System.Windows.Forms.Button btn_hamburger;
        private System.Windows.Forms.Button btn_add;
    }
}
