namespace YZM2118_Odev
{
    partial class Form1
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
            this.PVideo = new System.Windows.Forms.Button();
            this.PResim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pResim2 = new System.Windows.Forms.Button();
            this.pVideo2 = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PVideo
            // 
            this.PVideo.Location = new System.Drawing.Point(184, 76);
            this.PVideo.Name = "PVideo";
            this.PVideo.Size = new System.Drawing.Size(75, 23);
            this.PVideo.TabIndex = 0;
            this.PVideo.Text = "Play Video 1";
            this.PVideo.UseVisualStyleBackColor = true;
            this.PVideo.Click += new System.EventHandler(this.PVideo_Click);
            // 
            // PResim
            // 
            this.PResim.Location = new System.Drawing.Point(184, 114);
            this.PResim.Name = "PResim";
            this.PResim.Size = new System.Drawing.Size(83, 23);
            this.PResim.TabIndex = 1;
            this.PResim.Text = "Play Resim 1";
            this.PResim.UseVisualStyleBackColor = true;
            this.PResim.Click += new System.EventHandler(this.PResim_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stop Resim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop Video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 58);
            this.textBox1.TabIndex = 4;
            // 
            // pResim2
            // 
            this.pResim2.Location = new System.Drawing.Point(184, 183);
            this.pResim2.Name = "pResim2";
            this.pResim2.Size = new System.Drawing.Size(83, 23);
            this.pResim2.TabIndex = 6;
            this.pResim2.Text = "Play Resim 2";
            this.pResim2.UseVisualStyleBackColor = true;
            this.pResim2.Click += new System.EventHandler(this.pResim2_Click);
            // 
            // pVideo2
            // 
            this.pVideo2.Location = new System.Drawing.Point(184, 145);
            this.pVideo2.Name = "pVideo2";
            this.pVideo2.Size = new System.Drawing.Size(75, 23);
            this.pVideo2.TabIndex = 5;
            this.pVideo2.Text = "Play Video 2";
            this.pVideo2.UseVisualStyleBackColor = true;
            this.pVideo2.Click += new System.EventHandler(this.pVideo2_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 35);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 7;
            this.btnBasla.Text = "Başla.";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(12, 76);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 212);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pResim2);
            this.Controls.Add(this.pVideo2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PResim);
            this.Controls.Add(this.PVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PVideo;
        private System.Windows.Forms.Button PResim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pResim2;
        private System.Windows.Forms.Button pVideo2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnKapat;
    }
}

