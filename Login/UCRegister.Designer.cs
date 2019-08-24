namespace Register
{
    partial class UCRegister
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
            this.components = new System.ComponentModel.Container();
            this.lbl_login = new System.Windows.Forms.Label();
            this.But_rejestr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password_repeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_error = new System.Windows.Forms.Label();
            this.timer_error = new System.Windows.Forms.Timer(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(41)))), ((int)(((byte)(190)))));
            this.lbl_login.Location = new System.Drawing.Point(467, 483);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(217, 21);
            this.lbl_login.TabIndex = 26;
            this.lbl_login.Text = "Masz już konto? Zaloguj się";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // But_rejestr
            // 
            this.But_rejestr.BackColor = System.Drawing.Color.Navy;
            this.But_rejestr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_rejestr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.But_rejestr.ForeColor = System.Drawing.Color.White;
            this.But_rejestr.Location = new System.Drawing.Point(458, 425);
            this.But_rejestr.Name = "But_rejestr";
            this.But_rejestr.Size = new System.Drawing.Size(231, 35);
            this.But_rejestr.TabIndex = 25;
            this.But_rejestr.Text = "Zarejestruj";
            this.But_rejestr.UseVisualStyleBackColor = false;
            this.But_rejestr.Click += new System.EventHandler(this.But_rejestr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(338, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Powtórz hasło:";
            // 
            // txt_password_repeat
            // 
            this.txt_password_repeat.BackColor = System.Drawing.Color.White;
            this.txt_password_repeat.Location = new System.Drawing.Point(442, 226);
            this.txt_password_repeat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_password_repeat.Name = "txt_password_repeat";
            this.txt_password_repeat.Size = new System.Drawing.Size(293, 20);
            this.txt_password_repeat.TabIndex = 17;
            this.txt_password_repeat.TextChanged += new System.EventHandler(this.txt_password_repeat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(389, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hasło:";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(442, 194);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(293, 20);
            this.txt_password.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(390, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Login:";
            // 
            // txt_login
            // 
            this.txt_login.BackColor = System.Drawing.Color.White;
            this.txt_login.Location = new System.Drawing.Point(442, 162);
            this.txt_login.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(293, 20);
            this.txt_login.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(470, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 31);
            this.label12.TabIndex = 35;
            this.label12.Text = "Dane do logowania";
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_error.ForeColor = System.Drawing.Color.Red;
            this.txt_error.Location = new System.Drawing.Point(380, 382);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(388, 19);
            this.txt_error.TabIndex = 36;
            this.txt_error.Text = "Nieprawidłowo wpisane dane, lub podane konto już istnieje !!!";
            this.txt_error.Visible = false;
            // 
            // timer_error
            // 
            this.timer_error.Interval = 500;
            this.timer_error.Tick += new System.EventHandler(this.timer_error_Tick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(755, 307);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(200, 19);
            this.label26.TabIndex = 38;
            this.label26.Text = "Czy reprezentujesz jakąś firmę?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(965, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(442, 306);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(292, 20);
            this.txt_name.TabIndex = 38;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_name.Location = new System.Drawing.Point(325, 305);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 19);
            this.lbl_name.TabIndex = 39;
            this.lbl_name.Text = "Imię i nazwisko:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_password_repeat);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.But_rejestr);
            this.Name = "UCRegister";
            this.Size = new System.Drawing.Size(1099, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button But_rejestr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password_repeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_error;
        private System.Windows.Forms.Timer timer_error;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
    }
}
