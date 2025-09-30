namespace deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            boruüst = new PictureBox();
            borualt = new PictureBox();
            zemin = new PictureBox();
            fare = new PictureBox();
            scoretext = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)boruüst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borualt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fare).BeginInit();
            SuspendLayout();
            // 
            // boruüst
            // 
            boruüst.Image = (Image)resources.GetObject("boruüst.Image");
            boruüst.Location = new Point(247, 1);
            boruüst.Name = "boruüst";
            boruüst.Size = new Size(72, 100);
            boruüst.SizeMode = PictureBoxSizeMode.StretchImage;
            boruüst.TabIndex = 0;
            boruüst.TabStop = false;
            // 
            // borualt
            // 
            borualt.Image = (Image)resources.GetObject("borualt.Image");
            borualt.Location = new Point(285, 278);
            borualt.Name = "borualt";
            borualt.Size = new Size(72, 100);
            borualt.SizeMode = PictureBoxSizeMode.StretchImage;
            borualt.TabIndex = 1;
            borualt.TabStop = false;
            borualt.Click += pictureBox2_Click;
            // 
            // zemin
            // 
            zemin.Image = (Image)resources.GetObject("zemin.Image");
            zemin.Location = new Point(-5, 373);
            zemin.Name = "zemin";
            zemin.Size = new Size(622, 50);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 2;
            zemin.TabStop = false;
            zemin.Click += pictureBox3_Click;
            // 
            // fare
            // 
            fare.Image = (Image)resources.GetObject("fare.Image");
            fare.Location = new Point(-5, 91);
            fare.Name = "fare";
            fare.Size = new Size(77, 56);
            fare.SizeMode = PictureBoxSizeMode.StretchImage;
            fare.TabIndex = 3;
            fare.TabStop = false;
            fare.Click += fare_Click;
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.Location = new Point(43, 373);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(45, 15);
            scoretext.TabIndex = 4;
            scoretext.Text = "Score:0";
            scoretext.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1Event;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(613, 415);
            Controls.Add(scoretext);
            Controls.Add(fare);
            Controls.Add(zemin);
            Controls.Add(borualt);
            Controls.Add(boruüst);
            Name = "Form1";
            Text = "Flappy bird";
            Load += Form1_Load;
            KeyDown += gameisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)boruüst).EndInit();
            ((System.ComponentModel.ISupportInitialize)borualt).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)fare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox boruüst;
        private PictureBox borualt;
        private PictureBox zemin;
        private PictureBox fare;
        private Label scoretext;
        private System.Windows.Forms.Timer timer1;
    }
}
