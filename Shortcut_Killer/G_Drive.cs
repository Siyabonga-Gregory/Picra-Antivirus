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
    public partial class G_Drive : Form
    {
        public G_Drive()
        {
            this.writeBat = new StreamWriter(@"C:\Picra\zero.bat");
            InitializeComponent();
        }

        private StreamWriter writeBat;

        private string readLine;
        private string readLine2;
        private int signal;
        private int sum;

        private void G_Drive_Load(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Picra\G.bat",true);
            writer.WriteLine(@"del G:\*.lnk");
            writer.WriteLine("taskkill /f /im vzview.exe");
            writer.WriteLine("taskkill /f /im regsvr.exe");
            writer.WriteLine("taskkill /f /im winrsvn.exe");
            writer.WriteLine("taskkill /f /im winrsdrv32.exe");
            writer.WriteLine(@"del G:\x.mpeg");
            writer.Close();
            new StreamWriter(@"C:\Picra\G.ini").Close();
            try
            {
                this.txtError.Visible = false;
                this.txtError.Visible = false;
                StreamWriter writer3 = new StreamWriter(@"C:\Picra\cure2.bat");
                writer3.WriteLine("echo off picra shortcut antivirus version 3.0");
                writer3.WriteLine(@"                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            attrib -s -h -r -a /S /D G:\*");
                writer3.WriteLine(@"                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            attrib -s -h -a -r /d /s C:\Users\" + Environment.UserName + @"\" + "*.exe");
                writer3.Close();
                /**
                using (SoundPlayer player = new SoundPlayer(Resources.Bark))
                {
                    player.Play();
                }
                 * */
                base.FormClosing += new FormClosingEventHandler(this.formClosing);
                this.timer1.Start();
            }
            catch (Exception)
            {
                File.Delete(@"C:\Picra\G.txt");
                base.Close();
            }


        }

        public void formClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(@"C:\Picra\G.ini");
            if (File.Exists(@"G:\cure2.bat"))
            {
                File.Delete(@"G:\cure2.bat");
            }

        }

        private void killers()
        {
            FileInfo info = new FileInfo(@"C:\Picra\zero.bat");
            if (info.Length > 0L)
            {
                ProcessStartInfo info2 = new ProcessStartInfo(@"C:\Picra\zero.bat")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                using (Process process = new Process())
                {
                    process.StartInfo = info2;
                    process.Start();
                    process.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.GBar.Minimum = 0;
                this.GBar.Maximum = 0x7d0;
                this.GBar.PerformStep();
                this.GBar.Step = 1;
                Process process = new Process();



                Form1 zero = new Form1();

                int drivestatus = zero.validateDriveStatus(@"G:\");

                if (drivestatus == 0) //possible reason a drive may have been remove
                {

                    timer1.Stop();
                    timer2.Stop();

                    Application.Restart();
                }

                if (this.GBar.Value == 10)
                {
                    try
                    {
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure2.bat")
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
                        this.timer1.Stop();
                        File.Delete(@"G:\cure2.bat");
                        File.Delete(@"C:\Picra\cure2.bat");
                        base.Close();
                    }
                }
                else if (this.GBar.Value == 0x7d0)
                {
                    StreamWriter writer = new StreamWriter(@"C:\Picra\Demp");
                    if (File.Exists(@"C:\Picra\Data"))
                    {
                        using (StreamReader reader = new StreamReader(@"C:\Picra\Data"))
                        {
                            string str;
                            while ((str = reader.ReadLine()) != null)
                            {
                                string str2 = str.ToString();
                                writer.WriteLine(str2);
                            }
                        }
                    }
                    this.timer1.Stop();
                    File.Delete(@"C:\Picra\G.txt");
                    File.Delete(@"C:\Picra\cure2.bat");
                    Splash splash = new Splash
                    {
                        a = { Text = "Result" },
                        p = { Text = "G" }
                    };
                    string[] strArray = Directory.GetFiles(@"G:\", "*.exe", SearchOption.TopDirectoryOnly);
                    int length = strArray.Length;
                    for (int i = 0; i < length; i++)
                    {
                        FileInfo info2 = new FileInfo(strArray[i]);
                        if (info2.Length >= 0xdbba0L)
                        {
                            continue;
                        }
                        this.sum++;
                        DateTime creationTime = File.GetCreationTime(strArray[i]);
                        string str3 = string.Concat(new object[] { creationTime.Month, "/", creationTime.Day, "/", creationTime.Year });
                        File.GetCreationTimeUtc(strArray[i]);
                        DateTime lastAccessTime = File.GetLastAccessTime(strArray[i]);
                        string str4 = string.Concat(new object[] { lastAccessTime.Month, "/", lastAccessTime.Day, "/", lastAccessTime.Year });
                        DateTime lastWriteTime = File.GetLastWriteTime(strArray[i]);
                        string str5 = string.Concat(new object[] { lastWriteTime.Month, "/", lastWriteTime.Day, "/", lastWriteTime.Year });
                        if ((((str3.ToString() == str5.ToString()) && (str5.ToString() == str4.ToString())) || ((str3.ToString() == str5.ToString()) && (str3.ToString() == str4.ToString()))) || (str3.ToString() == str4.ToString()))
                        {
                            splash.shortcutResult.Items.Add(strArray[i].ToString());
                            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(strArray[i]);
                            writer.WriteLine(Path.GetFileName(strArray[i].ToString()));
                            try
                            {
                                File.Delete(strArray[i].ToString());
                            }
                            catch (Exception)
                            {
                            }
                            try
                            {
                                if (Directory.GetDirectories(@"G:\" + fileNameWithoutExtension).Length == 0)
                                {
                                    splash.shortcutResult.Items.Add(fileNameWithoutExtension.ToString());
                                    Directory.Delete(@"G:\" + fileNameWithoutExtension);
                                }
                                goto Label_047C;
                            }
                            catch (Exception)
                            {
                                goto Label_047C;
                            }
                        }
                        try
                        {
                            string str7 = Path.GetFileNameWithoutExtension(strArray[i]);
                            File.Delete(strArray[i]);
                            splash.shortcutResult.Items.Add(strArray[i].ToString());
                            int num5 = Directory.GetDirectories(@"G:\" + str7).Length;
                            writer.WriteLine(Path.GetFileName(strArray[i].ToString() + ".exe"));
                            if (num5 == 0)
                            {
                                splash.shortcutResult.Items.Add(str7.ToString());
                                Directory.Delete(@"G:\" + str7);
                            }
                        }
                        catch (Exception)
                        {
                        }
                    Label_047C:
                        splash.txtTotalFound.Text = this.sum.ToString();
                    }
                    writer.Close();
                    process.Close();
                    if (this.sum == 0)
                    {
                        ProcessStartInfo info3 = new ProcessStartInfo(@"C:\Picra\G.bat")
                        {
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true
                        };
                        new Process { StartInfo = info3 }.Start();
                        GBar.Value = 0;
                        this.timer2.Start();
                        this.progressBar2.Visible = true;
                    }
                    else if (this.sum > 0)
                    {
                        GBar.Value = 0;
                        this.timer2.Start();
                        this.progressBar2.Visible = true;
                        splash.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                Application.Restart();
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.GBar.Minimum = 0;
            this.GBar.Maximum = 400;
            this.GBar.PerformStep();
            this.GBar.Step = 1;

            Form1 zero = new Form1();

            int drivestatus = zero.validateDriveStatus(@"G:\");

            if (drivestatus == 0) //possible reason a drive may have been remove
            {

                timer1.Stop();
                timer2.Stop();

                Application.Restart();
            }

            if (this.GBar.Value == 10)
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\tasklist.bat")
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
                    using (StreamReader reader = process.StandardOutput)
                    {
                        this.txtResult.Text = reader.ReadToEnd();
                        StreamWriter writer = new StreamWriter(@"C:\Picra\list.txt");
                        writer.WriteLine(this.txtResult.Text.ToString());
                        writer.Close();
                        reader.Close();
                        process.Close();
                    }
                }
                StreamWriter writer2 = new StreamWriter(@"C:\Picra\Data2");
                if (File.Exists(@"C:\Picra\list.txt"))
                {
                    using (StreamReader reader2 = new StreamReader(@"C:\Picra\list.txt"))
                    {
                        while ((this.readLine = reader2.ReadLine()) != null)
                        {
                            if (this.readLine.Contains(".exe"))
                            {
                                string str = this.readLine.ToString();
                                int length = str.Length - 14;
                                writer2.WriteLine(str.Substring(14, length));
                            }
                        }
                    }
                }
                writer2.Close();
                using (StreamReader reader3 = new StreamReader(@"C:\Picra\Data2"))
                {
                    while ((this.readLine = reader3.ReadLine()) != null)
                    {
                        if (this.readLine.Contains(".exe"))
                        {
                            string str2 = this.readLine.ToString();
                            int num3 = str2.Length;
                            for (int i = 0; i < num3; i++)
                            {
                                using (StreamReader reader4 = new StreamReader(@"C:\Picra\Demp"))
                                {
                                    while ((this.readLine2 = reader4.ReadLine()) != null)
                                    {
                                        string str3 = this.readLine2.ToString();
                                        if (str3.ToString() == str2.ToString())
                                        {
                                            this.writeBat.WriteLine("taskkill /f /im " + str3.ToString());
                                            this.writeBat.WriteLine("taskkill /f /im " + str3.ToString());
                                            this.writeBat.WriteLine("del /f " + str3.ToString());
                                            i = num3;
                                        }
                                        if (str2.ToString() == "iexplore.exe".ToString())
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) && (this.signal != 2))
                                            {
                                                this.writeBat.WriteLine("taskkill /f /im iexplore.exe");
                                                this.writeBat.WriteLine("taskkill /f /im iexplore.exe");
                                                i = num3;
                                                this.signal = 2;
                                            }
                                            i = num3;
                                            this.signal = 2;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                this.writeBat.Close();
                this.killers();
            }
            if (this.GBar.Value == 160)
            {
                try
                {
                    if (Directory.Exists(@"G:\589485658"))
                    {
                        string[] files = Directory.GetFiles(@"G:\589485658");
                        int num6 = files.Length;
                        for (int j = 0; j < num6; j++)
                        {
                            File.Delete(files[j]);
                        }
                    }
                    Directory.Delete(@"G:\589485658");
                }
                catch (Exception)
                {
                }
            }
            if (this.GBar.Value == 300)
            {
                ProcessStartInfo info2 = new ProcessStartInfo(@"C:\Picra\G.bat")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                new Process { StartInfo = info2 }.Start();
                string[] strArray3 = Directory.GetFiles(@"G:\", "*.lnk", SearchOption.TopDirectoryOnly);
                int num8 = strArray3.Length;
                for (int k = 0; k < num8; k++)
                {
                    if (File.Exists(strArray3[k].ToString()))
                    {
                        File.Delete(strArray3[k].ToString());
                    }
                }
            }
            if (this.GBar.Value == 400)
            {
                this.timer2.Stop();
                Application.Restart();
            }


        }

 

    }
}
