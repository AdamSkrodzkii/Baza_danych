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
            this.Txt_login = new System.Windows.Forms.Label();
            this.But_rejestr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password_repeat = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_town = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_error = new System.Windows.Forms.Label();
            this.timer_error = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_company_name = new System.Windows.Forms.TextBox();
            this.lbl_company_name = new System.Windows.Forms.Label();
            this.lbl_company_ = new System.Windows.Forms.Label();
            this.lbl_company_post = new System.Windows.Forms.Label();
            this.txt_company_post = new System.Windows.Forms.TextBox();
            this.lbl_company_street = new System.Windows.Forms.Label();
            this.txt_company_street = new System.Windows.Forms.TextBox();
            this.lbl_company_town = new System.Windows.Forms.Label();
            this.txt_company_town = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_login
            // 
            this.Txt_login.AutoSize = true;
            this.Txt_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(41)))), ((int)(((byte)(190)))));
            this.Txt_login.Location = new System.Drawing.Point(701, 498);
            this.Txt_login.Name = "Txt_login";
            this.Txt_login.Size = new System.Drawing.Size(217, 21);
            this.Txt_login.TabIndex = 26;
            this.Txt_login.Text = "Masz już konto? Zaloguj się";
            this.Txt_login.Click += new System.EventHandler(this.Txt_login_Click);
            // 
            // But_rejestr
            // 
            this.But_rejestr.BackColor = System.Drawing.Color.Navy;
            this.But_rejestr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_rejestr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.But_rejestr.ForeColor = System.Drawing.Color.White;
            this.But_rejestr.Location = new System.Drawing.Point(692, 440);
            this.But_rejestr.Name = "But_rejestr";
            this.But_rejestr.Size = new System.Drawing.Size(231, 35);
            this.But_rejestr.TabIndex = 25;
            this.But_rejestr.Text = "Zarejestruj";
            this.But_rejestr.UseVisualStyleBackColor = false;
            this.But_rejestr.Click += new System.EventHandler(this.But_rejestr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(102, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefon:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(164, 315);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(293, 20);
            this.txt_phone.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(85, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nazwisko:";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(164, 283);
            this.txt_surname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(293, 20);
            this.txt_surname.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(60, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Powtórz hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(116, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Imię: ";
            // 
            // txt_password_repeat
            // 
            this.txt_password_repeat.Location = new System.Drawing.Point(164, 167);
            this.txt_password_repeat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_password_repeat.Name = "txt_password_repeat";
            this.txt_password_repeat.Size = new System.Drawing.Size(293, 20);
            this.txt_password_repeat.TabIndex = 17;
            this.txt_password_repeat.TextChanged += new System.EventHandler(this.txt_password_repeat_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(164, 251);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(293, 20);
            this.txt_name.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(111, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hasło:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(164, 135);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(293, 20);
            this.txt_password.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adres email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(164, 103);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(293, 20);
            this.txt_email.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(112, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Miasto:";
            // 
            // txt_town
            // 
            this.txt_town.Location = new System.Drawing.Point(174, 417);
            this.txt_town.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_town.Name = "txt_town";
            this.txt_town.Size = new System.Drawing.Size(293, 20);
            this.txt_town.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(123, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ulica:";
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(174, 449);
            this.txt_street.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(293, 20);
            this.txt_street.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(63, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Kod pocztowy:";
            // 
            // txt_post
            // 
            this.txt_post.Location = new System.Drawing.Point(174, 481);
            this.txt_post.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(293, 20);
            this.txt_post.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(225, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Dane osobowe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(182, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 31);
            this.label11.TabIndex = 34;
            this.label11.Text = "Miejsce zamieszkania";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(192, 59);
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
            this.txt_error.Location = new System.Drawing.Point(711, 400);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(208, 19);
            this.txt_error.TabIndex = 36;
            this.txt_error.Text = "Nieprawidłowo wpisane dane !!!";
            // 
            // timer_error
            // 
            this.timer_error.Interval = 3000;
            this.timer_error.Tick += new System.EventHandler(this.timer_error_Tick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(675, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(200, 19);
            this.label26.TabIndex = 38;
            this.label26.Text = "Czy reprezentujesz jakąś firmę?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(885, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // txt_company_name
            // 
            this.txt_company_name.Enabled = false;
            this.txt_company_name.Location = new System.Drawing.Point(674, 167);
            this.txt_company_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_company_name.Name = "txt_company_name";
            this.txt_company_name.Size = new System.Drawing.Size(292, 20);
            this.txt_company_name.TabIndex = 38;
            // 
            // lbl_company_name
            // 
            this.lbl_company_name.AutoSize = true;
            this.lbl_company_name.Enabled = false;
            this.lbl_company_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_company_name.Location = new System.Drawing.Point(579, 166);
            this.lbl_company_name.Name = "lbl_company_name";
            this.lbl_company_name.Size = new System.Drawing.Size(92, 19);
            this.lbl_company_name.TabIndex = 39;
            this.lbl_company_name.Text = "Nazwa firmy";
            // 
            // lbl_company_
            // 
            this.lbl_company_.AutoSize = true;
            this.lbl_company_.Enabled = false;
            this.lbl_company_.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_company_.ForeColor = System.Drawing.Color.Black;
            this.lbl_company_.Location = new System.Drawing.Point(709, 205);
            this.lbl_company_.Name = "lbl_company_";
            this.lbl_company_.Size = new System.Drawing.Size(202, 31);
            this.lbl_company_.TabIndex = 46;
            this.lbl_company_.Text = "Siedziba główna";
            // 
            // lbl_company_post
            // 
            this.lbl_company_post.AutoSize = true;
            this.lbl_company_post.Enabled = false;
            this.lbl_company_post.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_company_post.Location = new System.Drawing.Point(568, 319);
            this.lbl_company_post.Name = "lbl_company_post";
            this.lbl_company_post.Size = new System.Drawing.Size(103, 19);
            this.lbl_company_post.TabIndex = 45;
            this.lbl_company_post.Text = "Kod pocztowy:";
            // 
            // txt_company_post
            // 
            this.txt_company_post.Enabled = false;
            this.txt_company_post.Location = new System.Drawing.Point(679, 318);
            this.txt_company_post.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_company_post.Name = "txt_company_post";
            this.txt_company_post.Size = new System.Drawing.Size(293, 20);
            this.txt_company_post.TabIndex = 44;
            // 
            // lbl_company_street
            // 
            this.lbl_company_street.AutoSize = true;
            this.lbl_company_street.Enabled = false;
            this.lbl_company_street.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_company_street.Location = new System.Drawing.Point(628, 287);
            this.lbl_company_street.Name = "lbl_company_street";
            this.lbl_company_street.Size = new System.Drawing.Size(43, 19);
            this.lbl_company_street.TabIndex = 43;
            this.lbl_company_street.Text = "Ulica:";
            // 
            // txt_company_street
            // 
            this.txt_company_street.Enabled = false;
            this.txt_company_street.Location = new System.Drawing.Point(679, 286);
            this.txt_company_street.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_company_street.Name = "txt_company_street";
            this.txt_company_street.Size = new System.Drawing.Size(293, 20);
            this.txt_company_street.TabIndex = 42;
            // 
            // lbl_company_town
            // 
            this.lbl_company_town.AutoSize = true;
            this.lbl_company_town.Enabled = false;
            this.lbl_company_town.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_company_town.Location = new System.Drawing.Point(617, 253);
            this.lbl_company_town.Name = "lbl_company_town";
            this.lbl_company_town.Size = new System.Drawing.Size(54, 19);
            this.lbl_company_town.TabIndex = 41;
            this.lbl_company_town.Text = "Miasto:";
            // 
            // txt_company_town
            // 
            this.txt_company_town.Enabled = false;
            this.txt_company_town.Location = new System.Drawing.Point(679, 254);
            this.txt_company_town.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_company_town.Name = "txt_company_town";
            this.txt_company_town.Size = new System.Drawing.Size(293, 20);
            this.txt_company_town.TabIndex = 40;
            // 
            // UCRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_company_);
            this.Controls.Add(this.lbl_company_post);
            this.Controls.Add(this.txt_company_post);
            this.Controls.Add(this.lbl_company_street);
            this.Controls.Add(this.txt_company_street);
            this.Controls.Add(this.lbl_company_town);
            this.Controls.Add(this.txt_company_town);
            this.Controls.Add(this.txt_company_name);
            this.Controls.Add(this.lbl_company_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_password_repeat);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.Txt_login);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.But_rejestr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_street);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_town);
            this.Controls.Add(this.txt_name);
            this.Name = "UCRegister";
            this.Size = new System.Drawing.Size(1099, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_login;
        private System.Windows.Forms.Button But_rejestr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password_repeat;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_town;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_post;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_error;
        private System.Windows.Forms.Timer timer_error;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_company_name;
        private System.Windows.Forms.Label lbl_company_name;
        private System.Windows.Forms.Label lbl_company_;
        private System.Windows.Forms.Label lbl_company_post;
        private System.Windows.Forms.TextBox txt_company_post;
        private System.Windows.Forms.Label lbl_company_street;
        private System.Windows.Forms.TextBox txt_company_street;
        private System.Windows.Forms.Label lbl_company_town;
        private System.Windows.Forms.TextBox txt_company_town;
    }
}
