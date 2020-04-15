namespace Uzaylı_Avı
{
    partial class bilgisayaraKarsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgisayaraKarsi));
            this.dusmanGemi = new System.Windows.Forms.PictureBox();
            this.dusmanSagaSola = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dusmanGemi)).BeginInit();
            this.SuspendLayout();
            // 
            // dusmanGemi
            // 
            this.dusmanGemi.Image = global::Uzaylı_Avı.Properties.Resources.gemiTers3;
            this.dusmanGemi.Location = new System.Drawing.Point(236, 63);
            this.dusmanGemi.Name = "dusmanGemi";
            this.dusmanGemi.Size = new System.Drawing.Size(79, 78);
            this.dusmanGemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusmanGemi.TabIndex = 0;
            this.dusmanGemi.TabStop = false;
            // 
            // dusmanSagaSola
            // 
            this.dusmanSagaSola.Interval = 60;
            this.dusmanSagaSola.Tick += new System.EventHandler(this.dusmanSagaSola_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // bilgisayaraKarsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(548, 708);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dusmanGemi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bilgisayaraKarsi";
            this.Text = "Düsmanı Oldur";
            this.Load += new System.EventHandler(this.bilgisayaraKarsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dusmanGemi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dusmanGemi;
        private System.Windows.Forms.Timer dusmanSagaSola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}