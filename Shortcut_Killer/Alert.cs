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

namespace Shortcut_Killer
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Picra\u.bat");
            writer.WriteLine(@"taskkill /f /im wscript.exe");

            

            writer.WriteLine(@"attrib -s -h -a -r /S /D D:\*");
            writer.WriteLine(@"attrib -s -h -a -r /S /D E:\*");
            writer.WriteLine(@"attrib -s -h -a -r /S /D F:\*");
            writer.WriteLine(@"attrib -s -h -a -r /S /D G:\*");
            writer.WriteLine(@"attrib -s -h -a -r /S /D H:\*");
            writer.WriteLine(@"attrib -s -h -a -r /S /D I:\*");

            writer.WriteLine(@"del D:\winlog.vbs");
            writer.WriteLine(@"del E:\winlog.vbs");
            writer.WriteLine(@"del F:\winlog.vbs");
            writer.WriteLine(@"del G:\winlog.vbs");
            writer.WriteLine(@"del H:\winlog.vbs");
            writer.WriteLine(@"del I:\winlog.vbs");
          
            writer.Close();

            ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\u.bat")
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            using (Process process = new Process())
            {
                process.StartInfo = info;
                process.Start();
            }

              timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum =100;
            this.progressBar1.PerformStep();
            this.progressBar1.Step = 1;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();

                if (!File.Exists((@"C:\Picra\Show")))
                {
                    if (File.Exists(@"C:\Picra\u.bat"))
                    {
                        File.Delete(@"C:\Picra\u.bat");
                    }
                
                }
                else
                {
                    if (File.Exists(@"C:\Picra\u.bat"))
                    {
                        File.Delete(@"C:\Picra\u.bat");
                    }
                    Application.Exit();
                }


                this.Close();
            }
        }
    }
}
