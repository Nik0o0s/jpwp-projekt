namespace jpwp
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
            aa = new PictureBox();
            postac = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)aa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postac).BeginInit();
            SuspendLayout();
            // 
            // aa
            // 
            aa.BackColor = Color.FromArgb(57, 32, 28);
            aa.Location = new Point(0, 811);
            aa.Name = "aa";
            aa.Size = new Size(1264, 174);
            aa.TabIndex = 2;
            aa.TabStop = false;
            aa.Click += aa_Click;
            // 
            // postac
            // 
            postac.BackgroundImage = Properties.Resources.przod;
            postac.Location = new Point(0, 0);
            postac.Name = "postac";
            postac.Size = new Size(32, 45);
            postac.TabIndex = 14;
            postac.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 190, 98);
            ClientSize = new Size(1264, 985);
            Controls.Add(postac);
            Controls.Add(aa);
            Name = "Form1";
            Text = "Grzybobranie";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)aa).EndInit();
            ((System.ComponentModel.ISupportInitialize)postac).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private PictureBox aa;

        private PictureBox postac;
        private System.Windows.Forms.Timer timer1;
    }
}