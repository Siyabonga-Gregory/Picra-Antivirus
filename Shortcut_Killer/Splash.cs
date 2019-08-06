/*     
 * Picra shortcut antivirus version 3.0
 * Developed By         : Mr Gregory
 * Developer's Website  : http://www.sgngcobo.weebly.com
 * Contact Number       : 084 4921 275
 * Contact  E-mail      : huge.fuze@gmail.com
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Media;

namespace Shortcut_Killer
{
    public partial class Splash : Form
    {
        public Splash()
        {
            this.DocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            InitializeComponent();
        }

        private string DocumentPath;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.autoHide.Text = "Yes";
            form.Visible = true;
            this.Visible = false;
            

        }
        private void hideAll()
        {
            this.p.Visible = false;
            this.i.Visible = false;
            this.c.Visible = false;
            this.r.Visible = false;
            this.a.Visible = false;
        }

        private void showAll()
        {
            this.p.Visible = true;
            this.i.Visible = true;
            this.c.Visible = true;
            this.r.Visible = true;
            this.a.Visible = true;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.progressBar1.Visible = false;
            this.hideAll();

            if (!Directory.Exists(@"C:\Picra"))
            {
                Directory.CreateDirectory(@"C:\Picra");
            }
            if (this.a.Text.ToString() == "a".ToString())
            {
                this.timer1.Start(); 
            }
           else if (this.a.Text.ToString() == "Controls".ToString())
            {
               // this.mainControls.Visible = true;
            }

            if (this.a.Text.ToString() == "Result".ToString())
            {
                this.errorProvider1.SetError(this.txtTotalFound, "Represent total number of files affected by shortcut virus,Healed and Deleted from your drive");
               // this.mainControls.Visible = false;
                this.progressBar1.Visible = true;
                this.shortcutResultBox.Visible = true;
                this.timer2.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Picra\splash.txt"))
            {
                this.progressBar1.Minimum = 0;
                this.progressBar1.Maximum = 200;
                this.progressBar1.PerformStep();
                this.progressBar1.Step = 1;
                if (this.progressBar1.Value == 200)
                {
                    this.timer1.Stop();
                    base.Visible = false;
                    new Form1().ShowDialog();

                    Process process = new Process();
                    try
                    {
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Picra\Picra Shortcut Antivirus\Site.bat")
                        {
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true
                        };
                        process.StartInfo = info;
                        process.Start();
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (this.progressBar1.Value == 10)
                {
                    this.p.Visible = true;
                }
                else if (this.progressBar1.Value == 15)
                {
                    this.i.Visible = true;
                }
                else if (this.progressBar1.Value == 20)
                {
                    this.c.Visible = true;
                }
                else if (this.progressBar1.Value == 25)
                {
                    this.r.Visible = true;
                }
                else if (this.progressBar1.Value == 30)
                {
                    this.a.Visible = true;
                }
                else if (this.progressBar1.Value == 40)
                {
                    this.hideAll();
                }
                else if (this.progressBar1.Value == 45)
                {
                    this.showAll();
                    this.hideAll();
                }
                else if (this.progressBar1.Value == 50)
                {
                    this.showAll();
                }
                else if (this.progressBar1.Value == 55)
                {
                  //  this.c.Visible = true;
                }
                else if (this.progressBar1.Value != 60)
                {
                    if (this.progressBar1.Value == 70)
                    {
                        this.hideAll();
                    }
                    else if (this.progressBar1.Value == 75)
                    {
                        this.showAll();
                    }
                    else if (this.progressBar1.Value == 100)
                    {
                        this.p.Visible = false;
                    }
                    else if (this.progressBar1.Value == 105)
                    {
                        this.a.Visible = false;
                    }
                    else if (this.progressBar1.Value == 110)
                    {
                        this.i.Visible = false;
                    }
                    else if (this.progressBar1.Value == 115)
                    {
                        this.r.Visible = false;
                    }
                    else if (this.progressBar1.Value == 120)
                    {
                        this.c.Visible = false;
                    }
                    else if (this.progressBar1.Value ==125)
                    {
                        this.a.Visible = true;
                    }
                    else if (this.progressBar1.Value == 130)
                    {
                        this.p.Visible = true;
                    }
                    else if (this.progressBar1.Value == 135)
                    {
                        this.i.Visible = true;
                    }
                    else if (this.progressBar1.Value == 140)
                    {
                        this.r.Visible = true;
                    }
                    else if (this.progressBar1.Value == 150)
                    {
                        this.c.Visible = true;
                    }
                    else if (this.progressBar1.Value == 160)
                    {
                        this.hideAll();
                    }
                    else if (this.progressBar1.Value == 165)
                    {
                        this.p.Visible = true;
                    }
                    else if (this.progressBar1.Value == 170)
                    {
                        this.i.Visible = true;
                    }
                    else if (this.progressBar1.Value == 175)
                    {
                        this.c.Visible = true;
                    }
                    else if (this.progressBar1.Value == 180)
                    {
                        this.r.Visible = true;
                    }
                    else if (this.progressBar1.Value == 185)
                    {
                        this.a.Visible = true;
                    }
                }
            }
            else if (File.Exists(@"C:\Picra\splash.txt"))
            {
                this.timer1.Stop();
                base.Visible = false;
                new Form1().ShowDialog();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 410;
            this.progressBar1.PerformStep();
            this.progressBar1.Step = 1;
            if (this.progressBar1.Value == 20)  
            {
                try
                {
                    string[] strArray = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile ), "*.exe", SearchOption.TopDirectoryOnly);
                    int length = strArray.Length;
                    if (length != 0)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            File.Delete(strArray[i]);
                        }
                    }
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
            }
            else if (this.progressBar1.Value == 410)
            {
                this.timer2.Stop();
                this.Close();
            }

        }

    }
}
