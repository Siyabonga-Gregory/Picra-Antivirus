namespace Shortcut_Killer
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalFound = new System.Windows.Forms.Label();
            this.shortcutResult = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.shortcutResultBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.shortcutResultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.ForeColor = System.Drawing.Color.Red;
            this.p.Location = new System.Drawing.Point(40, 112);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(84, 71);
            this.p.TabIndex = 3;
            this.p.Text = "p";
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.Transparent;
            this.i.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.ForeColor = System.Drawing.Color.Red;
            this.i.Location = new System.Drawing.Point(115, 50);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(84, 71);
            this.i.TabIndex = 4;
            this.i.Text = "i";
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.Red;
            this.c.Location = new System.Drawing.Point(217, 9);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(84, 71);
            this.c.TabIndex = 5;
            this.c.Text = "c";
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.ForeColor = System.Drawing.Color.Red;
            this.r.Location = new System.Drawing.Point(319, 50);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(88, 71);
            this.r.TabIndex = 6;
            this.r.Text = "r";
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.Red;
            this.a.Location = new System.Drawing.Point(401, 121);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(84, 71);
            this.a.TabIndex = 7;
            this.a.Text = "a";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Shortcut_Killer.Properties.Resources.Slide1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalFound
            // 
            this.txtTotalFound.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFound.ForeColor = System.Drawing.Color.Red;
            this.txtTotalFound.Location = new System.Drawing.Point(380, 111);
            this.txtTotalFound.Name = "txtTotalFound";
            this.txtTotalFound.Size = new System.Drawing.Size(32, 17);
            this.txtTotalFound.TabIndex = 3;
            this.txtTotalFound.Text = "000";
            // 
            // shortcutResult
            // 
            this.shortcutResult.BackColor = System.Drawing.Color.Black;
            this.shortcutResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shortcutResult.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortcutResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shortcutResult.FormattingEnabled = true;
            this.shortcutResult.ItemHeight = 27;
            this.shortcutResult.Location = new System.Drawing.Point(80, 19);
            this.shortcutResult.Name = "shortcutResult";
            this.shortcutResult.Size = new System.Drawing.Size(294, 324);
            this.shortcutResult.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(80, 343);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(294, 18);
            this.progressBar1.TabIndex = 15;
            // 
            // shortcutResultBox
            // 
            this.shortcutResultBox.BackColor = System.Drawing.Color.Transparent;
            this.shortcutResultBox.BackgroundImage = global::Shortcut_Killer.Properties.Resources.Capture2;
            this.shortcutResultBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shortcutResultBox.Controls.Add(this.progressBar1);
            this.shortcutResultBox.Controls.Add(this.shortcutResult);
            this.shortcutResultBox.Controls.Add(this.txtTotalFound);
            this.shortcutResultBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortcutResultBox.ForeColor = System.Drawing.Color.Cyan;
            this.shortcutResultBox.Location = new System.Drawing.Point(2, -5);
            this.shortcutResultBox.Name = "shortcutResultBox";
            this.shortcutResultBox.Size = new System.Drawing.Size(484, 362);
            this.shortcutResultBox.TabIndex = 14;
            this.shortcutResultBox.TabStop = false;
            this.shortcutResultBox.Visible = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(474, 347);
            this.ControlBox = false;
            this.Controls.Add(this.shortcutResultBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.r);
            this.Controls.Add(this.c);
            this.Controls.Add(this.i);
            this.Controls.Add(this.p);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                         Picra Shortcut Antivirus Version 3.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.shortcutResultBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label a;
        public System.Windows.Forms.Label r;
        public System.Windows.Forms.Label c;
        public System.Windows.Forms.Label i;
        public System.Windows.Forms.Label p;
        private System.Windows.Forms.GroupBox shortcutResultBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ListBox shortcutResult;
        public System.Windows.Forms.Label txtTotalFound;
        private System.Windows.Forms.Button button1;
    }
}