namespace Home
{
    partial class UCHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer_pictures = new System.Windows.Forms.Timer(this.components);
            this.ptr_BOX = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(129, 345);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(680, 167);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Hotel nad jeziorem, idealny na wypoczynek.\r\nKażdy znajdzie coś dla siebie, zaczyn" +
    "ając od spaceru wokół jeziora a kończąc na jeździe konno pod okiem profesjonalis" +
    "ty.";
            // 
            // timer_pictures
            // 
            this.timer_pictures.Interval = 2000;
            this.timer_pictures.Tick += new System.EventHandler(this.timer_pictures_Tick);
            // 
            // ptr_BOX
            // 
            this.ptr_BOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptr_BOX.Image = ((System.Drawing.Image)(resources.GetObject("ptr_BOX.Image")));
            this.ptr_BOX.Location = new System.Drawing.Point(73, 23);
            this.ptr_BOX.Name = "ptr_BOX";
            this.ptr_BOX.Size = new System.Drawing.Size(778, 316);
            this.ptr_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_BOX.TabIndex = 0;
            this.ptr_BOX.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hotel.jpg");
            this.imageList1.Images.SetKeyName(1, "indeks.jpg");
            this.imageList1.Images.SetKeyName(2, "Jazda_konna.jpg");
            this.imageList1.Images.SetKeyName(3, "kajaki.jpg");
            this.imageList1.Images.SetKeyName(4, "konferencja.jpg");
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ptr_BOX);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(923, 534);
            this.Load += new System.EventHandler(this.UCHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer_pictures;
        private System.Windows.Forms.PictureBox ptr_BOX;
        private System.Windows.Forms.ImageList imageList1;
    }
}
