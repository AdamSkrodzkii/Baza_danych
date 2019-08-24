namespace Login
{
    partial class UCLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_login = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.Txt_remind = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_register = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Error = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer_error = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(456, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login:";
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.Color.Navy;
            this.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_login.ForeColor = System.Drawing.Color.White;
            this.Btn_login.Location = new System.Drawing.Point(441, 371);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(231, 35);
            this.Btn_login.TabIndex = 15;
            this.Btn_login.Text = "Zaloguj";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(507, 286);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(138, 20);
            this.textBox_Login.TabIndex = 10;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // Txt_remind
            // 
            this.Txt_remind.AutoSize = true;
            this.Txt_remind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_remind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(41)))), ((int)(((byte)(190)))));
            this.Txt_remind.Location = new System.Drawing.Point(503, 457);
            this.Txt_remind.Name = "Txt_remind";
            this.Txt_remind.Size = new System.Drawing.Size(112, 19);
            this.Txt_remind.TabIndex = 14;
            this.Txt_remind.Text = "Przypomnij hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(456, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasło:";
            // 
            // Txt_register
            // 
            this.Txt_register.AutoSize = true;
            this.Txt_register.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(41)))), ((int)(((byte)(190)))));
            this.Txt_register.Location = new System.Drawing.Point(414, 422);
            this.Txt_register.Name = "Txt_register";
            this.Txt_register.Size = new System.Drawing.Size(297, 21);
            this.Txt_register.TabIndex = 13;
            this.Txt_register.Text = "Nie masz jeszcze konta? Zarejestruj się";
            this.Txt_register.Click += new System.EventHandler(this.Txt_register_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(507, 325);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(138, 20);
            this.textBox_password.TabIndex = 12;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 177);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Error
            // 
            this.Txt_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Error.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_Error.Location = new System.Drawing.Point(342, 262);
            this.Txt_Error.Name = "Txt_Error";
            this.Txt_Error.Size = new System.Drawing.Size(474, 10);
            this.Txt_Error.TabIndex = 17;
            this.Txt_Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Error.Visible = false;
            this.Txt_Error.TextChanged += new System.EventHandler(this.Txt_Error_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(399, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 32);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "BATMAN HOTEL";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_error
            // 
            this.timer_error.Interval = 1000;
            this.timer_error.Tick += new System.EventHandler(this.timer_error_Tick);
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Txt_Error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.Txt_remind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_register);
            this.Controls.Add(this.textBox_password);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(1099, 563);
            this.Load += new System.EventHandler(this.UCLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label Txt_remind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_register;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox Txt_Error;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer_error;
    }
}
