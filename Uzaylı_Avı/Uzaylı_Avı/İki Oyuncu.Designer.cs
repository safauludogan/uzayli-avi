namespace Uzaylı_Avı
{
    partial class İki_Oyuncu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İki_Oyuncu));
            this.roketAtesle = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.tersRoketAtesle = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progres = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roketTers = new System.Windows.Forms.PictureBox();
            this.gemi = new System.Windows.Forms.PictureBox();
            this.roket = new System.Windows.Forms.PictureBox();
            this.gemiTers = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timerPatlama = new System.Windows.Forms.Timer(this.components);
            this.patlamaTers = new System.Windows.Forms.PictureBox();
            this.patlama = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roketTers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemiTers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlamaTers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama)).BeginInit();
            this.SuspendLayout();
            // 
            // roketAtesle
            // 
            this.roketAtesle.Interval = 35;
            this.roketAtesle.Tick += new System.EventHandler(this.roketAtesle_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 12);
            this.progressBar1.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 490);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(524, 12);
            this.progressBar2.TabIndex = 7;
            // 
            // tersRoketAtesle
            // 
            this.tersRoketAtesle.Interval = 35;
            this.tersRoketAtesle.Tick += new System.EventHandler(this.tersRoketAtesle_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seçenekler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(42, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tekrar Oyna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(199, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Menüye Git";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(356, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(42, 380);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(465, 23);
            this.progressBar3.TabIndex = 12;
            // 
            // progres
            // 
            this.progres.Tick += new System.EventHandler(this.progres_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(386, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Oyuncu 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(386, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Oyuncu 2 :";
            // 
            // roketTers
            // 
            this.roketTers.BackColor = System.Drawing.Color.Transparent;
            this.roketTers.Image = global::Uzaylı_Avı.Properties.Resources.roketTers;
            this.roketTers.Location = new System.Drawing.Point(262, 138);
            this.roketTers.Name = "roketTers";
            this.roketTers.Size = new System.Drawing.Size(26, 33);
            this.roketTers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roketTers.TabIndex = 3;
            this.roketTers.TabStop = false;
            // 
            // gemi
            // 
            this.gemi.BackColor = System.Drawing.Color.Transparent;
            this.gemi.Image = global::Uzaylı_Avı.Properties.Resources.Gemi1;
            this.gemi.Location = new System.Drawing.Point(234, 562);
            this.gemi.Name = "gemi";
            this.gemi.Size = new System.Drawing.Size(79, 80);
            this.gemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gemi.TabIndex = 5;
            this.gemi.TabStop = false;
            // 
            // roket
            // 
            this.roket.BackColor = System.Drawing.Color.Transparent;
            this.roket.Image = global::Uzaylı_Avı.Properties.Resources.roket;
            this.roket.Location = new System.Drawing.Point(259, 534);
            this.roket.Name = "roket";
            this.roket.Size = new System.Drawing.Size(26, 33);
            this.roket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roket.TabIndex = 4;
            this.roket.TabStop = false;
            // 
            // gemiTers
            // 
            this.gemiTers.BackColor = System.Drawing.Color.Transparent;
            this.gemiTers.Image = global::Uzaylı_Avı.Properties.Resources.gemiTers3;
            this.gemiTers.Location = new System.Drawing.Point(236, 63);
            this.gemiTers.Name = "gemiTers";
            this.gemiTers.Size = new System.Drawing.Size(79, 78);
            this.gemiTers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gemiTers.TabIndex = 2;
            this.gemiTers.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(82, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kazan Kişi";
            // 
            // timerPatlama
            // 
            this.timerPatlama.Interval = 600;
            this.timerPatlama.Tick += new System.EventHandler(this.timerPatlama_Tick);
            // 
            // patlamaTers
            // 
            this.patlamaTers.Image = global::Uzaylı_Avı.Properties.Resources.patlama;
            this.patlamaTers.Location = new System.Drawing.Point(219, 54);
            this.patlamaTers.Name = "patlamaTers";
            this.patlamaTers.Size = new System.Drawing.Size(111, 97);
            this.patlamaTers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patlamaTers.TabIndex = 16;
            this.patlamaTers.TabStop = false;
            // 
            // patlama
            // 
            this.patlama.BackColor = System.Drawing.Color.Transparent;
            this.patlama.Image = global::Uzaylı_Avı.Properties.Resources.patlama1;
            this.patlama.Location = new System.Drawing.Point(217, 552);
            this.patlama.Name = "patlama";
            this.patlama.Size = new System.Drawing.Size(111, 97);
            this.patlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patlama.TabIndex = 17;
            this.patlama.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // İki_Oyuncu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(548, 708);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roketTers);
            this.Controls.Add(this.gemi);
            this.Controls.Add(this.roket);
            this.Controls.Add(this.gemiTers);
            this.Controls.Add(this.patlamaTers);
            this.Controls.Add(this.patlama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "İki_Oyuncu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İki Oyuncu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.İki_Oyuncu_FormClosed);
            this.Load += new System.EventHandler(this.İki_Oyuncu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roketTers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemiTers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlamaTers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gemiTers;
        private System.Windows.Forms.PictureBox roketTers;
        private System.Windows.Forms.PictureBox roket;
        private System.Windows.Forms.PictureBox gemi;
        private System.Windows.Forms.Timer roketAtesle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer tersRoketAtesle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Timer progres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerPatlama;
        private System.Windows.Forms.PictureBox patlamaTers;
        private System.Windows.Forms.PictureBox patlama;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}