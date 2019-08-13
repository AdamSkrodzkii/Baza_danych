namespace Room
{
    partial class UCRoom_container
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_date_from = new System.Windows.Forms.Label();
            this.txt_date_to = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_room1 = new System.Windows.Forms.Label();
            this.txt_room2 = new System.Windows.Forms.Label();
            this.txt_room3 = new System.Windows.Forms.Label();
            this.btn_clock1 = new System.Windows.Forms.Button();
            this.btn_broom1 = new System.Windows.Forms.Button();
            this.btn_hamburger1 = new System.Windows.Forms.Button();
            this.btn_clock2 = new System.Windows.Forms.Button();
            this.btn_broom2 = new System.Windows.Forms.Button();
            this.btn_hamburger2 = new System.Windows.Forms.Button();
            this.btn_clock3 = new System.Windows.Forms.Button();
            this.btn_broom3 = new System.Windows.Forms.Button();
            this.btn_hamburger3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::Login.Properties.Resources.cancel_attraction_26px;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(737, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Login.Properties.Resources.sleeping_in_bed_52px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Od";
            // 
            // txt_date_from
            // 
            this.txt_date_from.AutoSize = true;
            this.txt_date_from.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_date_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_date_from.Location = new System.Drawing.Point(315, 4);
            this.txt_date_from.Name = "txt_date_from";
            this.txt_date_from.Size = new System.Drawing.Size(94, 26);
            this.txt_date_from.TabIndex = 3;
            this.txt_date_from.Text = "data_od";
            // 
            // txt_date_to
            // 
            this.txt_date_to.AutoSize = true;
            this.txt_date_to.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_date_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_date_to.Location = new System.Drawing.Point(469, 4);
            this.txt_date_to.Name = "txt_date_to";
            this.txt_date_to.Size = new System.Drawing.Size(94, 26);
            this.txt_date_to.TabIndex = 5;
            this.txt_date_to.Text = "data_od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(436, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pokoje:";
            // 
            // txt_room1
            // 
            this.txt_room1.AutoSize = true;
            this.txt_room1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_room1.Location = new System.Drawing.Point(248, 49);
            this.txt_room1.Name = "txt_room1";
            this.txt_room1.Size = new System.Drawing.Size(61, 20);
            this.txt_room1.TabIndex = 7;
            this.txt_room1.Text = "Room1";
            // 
            // txt_room2
            // 
            this.txt_room2.AutoSize = true;
            this.txt_room2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_room2.Location = new System.Drawing.Point(248, 88);
            this.txt_room2.Name = "txt_room2";
            this.txt_room2.Size = new System.Drawing.Size(61, 20);
            this.txt_room2.TabIndex = 8;
            this.txt_room2.Text = "Room2";
            this.txt_room2.Visible = false;
            // 
            // txt_room3
            // 
            this.txt_room3.AutoSize = true;
            this.txt_room3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_room3.Location = new System.Drawing.Point(248, 129);
            this.txt_room3.Name = "txt_room3";
            this.txt_room3.Size = new System.Drawing.Size(61, 20);
            this.txt_room3.TabIndex = 9;
            this.txt_room3.Text = "Room3";
            this.txt_room3.Visible = false;
            // 
            // btn_clock1
            // 
            this.btn_clock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clock1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clock1.Image = global::Login.Properties.Resources.alarm_clock_30px;
            this.btn_clock1.Location = new System.Drawing.Point(631, 32);
            this.btn_clock1.Name = "btn_clock1";
            this.btn_clock1.Size = new System.Drawing.Size(33, 35);
            this.btn_clock1.TabIndex = 21;
            this.btn_clock1.UseVisualStyleBackColor = false;
            this.btn_clock1.Visible = false;
            // 
            // btn_broom1
            // 
            this.btn_broom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_broom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_broom1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_broom1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_broom1.Image = global::Login.Properties.Resources.broom_30px;
            this.btn_broom1.Location = new System.Drawing.Point(580, 32);
            this.btn_broom1.Name = "btn_broom1";
            this.btn_broom1.Size = new System.Drawing.Size(34, 35);
            this.btn_broom1.TabIndex = 20;
            this.btn_broom1.UseVisualStyleBackColor = false;
            this.btn_broom1.Visible = false;
            // 
            // btn_hamburger1
            // 
            this.btn_hamburger1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_hamburger1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hamburger1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hamburger1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hamburger1.Image = global::Login.Properties.Resources.hamburger_30px;
            this.btn_hamburger1.Location = new System.Drawing.Point(530, 32);
            this.btn_hamburger1.Name = "btn_hamburger1";
            this.btn_hamburger1.Size = new System.Drawing.Size(33, 35);
            this.btn_hamburger1.TabIndex = 19;
            this.btn_hamburger1.UseVisualStyleBackColor = false;
            this.btn_hamburger1.Visible = false;
            // 
            // btn_clock2
            // 
            this.btn_clock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clock2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clock2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clock2.Image = global::Login.Properties.Resources.alarm_clock_30px;
            this.btn_clock2.Location = new System.Drawing.Point(631, 73);
            this.btn_clock2.Name = "btn_clock2";
            this.btn_clock2.Size = new System.Drawing.Size(33, 35);
            this.btn_clock2.TabIndex = 24;
            this.btn_clock2.UseVisualStyleBackColor = false;
            this.btn_clock2.Visible = false;
            // 
            // btn_broom2
            // 
            this.btn_broom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_broom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_broom2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_broom2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_broom2.Image = global::Login.Properties.Resources.broom_30px;
            this.btn_broom2.Location = new System.Drawing.Point(580, 73);
            this.btn_broom2.Name = "btn_broom2";
            this.btn_broom2.Size = new System.Drawing.Size(34, 35);
            this.btn_broom2.TabIndex = 23;
            this.btn_broom2.UseVisualStyleBackColor = false;
            this.btn_broom2.Visible = false;
            // 
            // btn_hamburger2
            // 
            this.btn_hamburger2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_hamburger2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hamburger2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hamburger2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hamburger2.Image = global::Login.Properties.Resources.hamburger_30px;
            this.btn_hamburger2.Location = new System.Drawing.Point(530, 73);
            this.btn_hamburger2.Name = "btn_hamburger2";
            this.btn_hamburger2.Size = new System.Drawing.Size(33, 35);
            this.btn_hamburger2.TabIndex = 22;
            this.btn_hamburger2.UseVisualStyleBackColor = false;
            this.btn_hamburger2.Visible = false;
            // 
            // btn_clock3
            // 
            this.btn_clock3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clock3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clock3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clock3.Image = global::Login.Properties.Resources.alarm_clock_30px;
            this.btn_clock3.Location = new System.Drawing.Point(631, 114);
            this.btn_clock3.Name = "btn_clock3";
            this.btn_clock3.Size = new System.Drawing.Size(33, 35);
            this.btn_clock3.TabIndex = 27;
            this.btn_clock3.UseVisualStyleBackColor = false;
            this.btn_clock3.Visible = false;
            // 
            // btn_broom3
            // 
            this.btn_broom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_broom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_broom3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_broom3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_broom3.Image = global::Login.Properties.Resources.broom_30px;
            this.btn_broom3.Location = new System.Drawing.Point(580, 114);
            this.btn_broom3.Name = "btn_broom3";
            this.btn_broom3.Size = new System.Drawing.Size(34, 35);
            this.btn_broom3.TabIndex = 26;
            this.btn_broom3.UseVisualStyleBackColor = false;
            this.btn_broom3.Visible = false;
            // 
            // btn_hamburger3
            // 
            this.btn_hamburger3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_hamburger3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hamburger3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hamburger3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hamburger3.Image = global::Login.Properties.Resources.hamburger_30px;
            this.btn_hamburger3.Location = new System.Drawing.Point(530, 114);
            this.btn_hamburger3.Name = "btn_hamburger3";
            this.btn_hamburger3.Size = new System.Drawing.Size(33, 35);
            this.btn_hamburger3.TabIndex = 25;
            this.btn_hamburger3.UseVisualStyleBackColor = false;
            this.btn_hamburger3.Visible = false;
            // 
            // UCRoom_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_clock3);
            this.Controls.Add(this.btn_broom3);
            this.Controls.Add(this.btn_hamburger3);
            this.Controls.Add(this.btn_clock2);
            this.Controls.Add(this.btn_broom2);
            this.Controls.Add(this.btn_hamburger2);
            this.Controls.Add(this.btn_clock1);
            this.Controls.Add(this.btn_broom1);
            this.Controls.Add(this.btn_hamburger1);
            this.Controls.Add(this.txt_room3);
            this.Controls.Add(this.txt_room2);
            this.Controls.Add(this.txt_room1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_date_to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_date_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCRoom_container";
            this.Size = new System.Drawing.Size(766, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_date_from;
        private System.Windows.Forms.Label txt_date_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_room1;
        private System.Windows.Forms.Label txt_room2;
        private System.Windows.Forms.Label txt_room3;
        private System.Windows.Forms.Button btn_clock1;
        private System.Windows.Forms.Button btn_broom1;
        private System.Windows.Forms.Button btn_hamburger1;
        private System.Windows.Forms.Button btn_clock2;
        private System.Windows.Forms.Button btn_broom2;
        private System.Windows.Forms.Button btn_hamburger2;
        private System.Windows.Forms.Button btn_clock3;
        private System.Windows.Forms.Button btn_broom3;
        private System.Windows.Forms.Button btn_hamburger3;
    }
}
