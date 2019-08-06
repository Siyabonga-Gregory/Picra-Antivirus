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
  public partial  class Form1 : Form
  {
  

    // Methods
    public Form1()
    {
        this.InitializeComponent();
    }

    private void autoChecked()
    {
            try
            {
                if (!Directory.Exists(@"C:\Picra"))
                {
                    Directory.CreateDirectory(@"C:\Picra");
                }
                new StreamWriter(@"C:\Picra\splash.txt").Close();
               
                    if (!Directory.Exists(@"C:\Picra"))
                    {
                        Directory.CreateDirectory(@"C:\Picra");
                    }
                    StreamWriter writer2 = new StreamWriter(@"C:\Picra\I.bat");
                    writer2.WriteLine("echo off");
                    writer2.WriteLine(@"del I:\bealie.exe");
                    writer2.WriteLine(@"del I:\bealiex.exe");
                    writer2.WriteLine(@"del I:\x.mpeg");
                    writer2.WriteLine(@"del I:\fhkiw.exe");
                    writer2.WriteLine(@"del I:\fhkiwx.exe");
                    writer2.WriteLine(@"del I:\vzview.exe");
                    writer2.WriteLine(@"del I:\geefoos.exe");
                    writer2.WriteLine(@"del I:\fbjeg.exe");
                    writer2.WriteLine(@"del I:\vzviewx.exe");
                    writer2.WriteLine(@"del I:\fbjegx.exe");
                    writer2.WriteLine(@"del I:\geefoos.exe");
                    writer2.WriteLine(@"del I:\Passwords.exe");
                    writer2.WriteLine(@"del I:\Passwords.lnk");
                    writer2.WriteLine("taskkill /f /im vzview.exe");
                    writer2.WriteLine("taskkill /f /im regsvr.exe");
                    writer2.WriteLine("taskkill /f /im winrsvn.exe");
                    writer2.WriteLine("taskkill /f /im winrsdrv32.exe");
                    writer2.WriteLine(@"del I:\bbyac.exe");
                    writer2.WriteLine(@"del I:\Porn.exe");
                    writer2.WriteLine(@"del I:\Secret.exe");
                    writer2.WriteLine(@"del I:\Password.exe");
                    writer2.WriteLine(@"del I:\Sexy.exe");
                    writer2.WriteLine(@"del I:\autorun.inf");
                    writer2.WriteLine(@"del I:\fkXZvxCvQF.exe");
                    writer2.WriteLine("cls");
                    writer2.Close();
                   // this.timer1.Start();
                   // base.Visible = false;
              
                    if (!Directory.Exists(@"C:\Picra"))
                    {
                        Directory.CreateDirectory(@"C:\Picra");
                    }
                    StreamWriter writer3 = new StreamWriter(@"C:\Picra\D.bat");
                    writer3.WriteLine("echo off");
                    writer3.WriteLine(@"del D:\x.mpeg");
                    writer3.WriteLine(@"del D:\fhkiw.exe");
                    writer3.WriteLine(@"del D:\fhkiwx.exe");
                    writer3.WriteLine(@"del D:\vzview.exe");
                    writer3.WriteLine(@"del D:\vzviewx.exe");
                    writer3.WriteLine(@"del D:\geefoos.exe");
                    writer3.WriteLine(@"del D:\fbjeg.exe");
                    writer3.WriteLine(@"del D:\fbjegx.exe");
                    writer3.WriteLine(@"del D:\geefoos.exe");
                    writer3.WriteLine(@"del D:\Passwords.exe");
                    writer3.WriteLine(@"del D:\Passwords.lnk");
                    writer3.WriteLine("taskkill /f /im vzview.exe");
                    writer3.WriteLine("taskkill /f /im regsvr.exe");
                    writer3.WriteLine("taskkill /f /im winrsvn.exe");
                    writer3.WriteLine("taskkill /f /im winrsdrv32.exe");
                    writer3.WriteLine(@"del D:\bbyac.exe");
                    writer3.WriteLine(@"del D:\Porn.exe");
                    writer3.WriteLine(@"del D:\Secret.exe");
                    writer3.WriteLine(@"del D:\Password.exe");
                    writer3.WriteLine(@"del D:\Sexy.exe");
                    writer3.WriteLine(@"del D:\autorun.inf");
                    writer3.WriteLine(@"del D:\bealie.exe");
                    writer3.WriteLine(@"del D:\bealiex.exe");
                    writer3.WriteLine(@"del D:\fkXZvxCvQF.exe");
                    writer3.WriteLine(@"del D:\sLrab.exe");
                    writer3.WriteLine("cls");
                    writer3.Close();
                   // this.timer1.Start();
                  //  base.Visible = false;
                
               
                    if (!Directory.Exists(@"C:\Picra"))
                    {
                        Directory.CreateDirectory(@"C:\Picra");
                    }
                    StreamWriter writer4 = new StreamWriter(@"C:\Picra\E.bat");
                    writer4.WriteLine("echo off");
                    writer4.WriteLine(@"del E:\x.mpeg");
                    writer4.WriteLine(@"del E:\fhkiw.exe");
                    writer4.WriteLine(@"del E:\fhkiwx.exe");
                    writer4.WriteLine(@"del E:\vzview.exe");
                    writer4.WriteLine(@"del E:\geefoos.exe");
                    writer4.WriteLine(@"del E:\fbjeg.exe");
                    writer4.WriteLine(@"del E:\vzviewx.exe");
                    writer4.WriteLine(@"del E:\fbjegx.exe");
                    writer4.WriteLine(@"del E:\geefoos.exe");
                    writer4.WriteLine(@"del E:\Passwords.exe");
                    writer4.WriteLine(@"del E:\Passwords.lnk");
                    writer4.WriteLine("taskkill /f /im vzview.exe");
                    writer4.WriteLine("taskkill /f /im regsvr.exe");
                    writer4.WriteLine("taskkill /f /im winrsvn.exe");
                    writer4.WriteLine("taskkill /f /im winrsdrv32.exe");
                    writer4.WriteLine(@"del E:\bbyac.exe");
                    writer4.WriteLine(@"del E:\Porn.exe");
                    writer4.WriteLine(@"del E:\Secret.exe");
                    writer4.WriteLine(@"del E:\Password.exe");
                    writer4.WriteLine(@"del E:\Sexy.exe");
                    writer4.WriteLine(@"del E:\autorun.inf");
                    writer4.WriteLine(@"del E:\bealie.exe");
                    writer4.WriteLine(@"del E:\bealiex.exe");
                    writer4.WriteLine(@"del E:\fkXZvxCvQF.exe");
                    writer4.WriteLine(@"del E:\sLrab.exe");
                    writer4.WriteLine("cls");
                    writer4.Close();
                   // this.timer1.Start();
                   // base.Visible = false;
                
                
                    if (!Directory.Exists(@"C:\Picra"))
                    {
                        Directory.CreateDirectory(@"C:\Picra");
                    }
                    StreamWriter writer5 = new StreamWriter(@"C:\Picra\F.bat");
                    writer5.WriteLine("echo off");
                    writer5.WriteLine(@"del F:\x.mpeg");
                    writer5.WriteLine(@"del F:\fhkiw.exe");
                    writer5.WriteLine(@"del F:\fhkiwx.exe");
                    writer5.WriteLine(@"del F:\vzview.exe");
                    writer5.WriteLine(@"del F:\geefoos.exe");
                    writer5.WriteLine(@"del F:\fbjeg.exe");
                    writer5.WriteLine(@"del F:\vzviewx.exe");
                    writer5.WriteLine(@"del F:\fbjegx.exe");
                    writer5.WriteLine(@"del F:\geefoos.exe");
                    writer5.WriteLine(@"del F:\Passwords.exe");
                    writer5.WriteLine(@"del F:\Passwords.lnk");
                    writer5.WriteLine("taskkill /f /im vzview.exe");
                    writer5.WriteLine("taskkill /f /im regsvr.exe");
                    writer5.WriteLine("taskkill /f /im winrsvn.exe");
                    writer5.WriteLine("taskkill /f /im winrsdrv32.exe");
                    writer5.WriteLine(@"del F:\bbyac.exe");
                    writer5.WriteLine(@"del F:\Porn.exe");
                    writer5.WriteLine(@"del F:\Secret.exe");
                    writer5.WriteLine(@"del F:\Password.exe");
                    writer5.WriteLine(@"del F:\Sexy.exe");
                    writer5.WriteLine(@"del F:\autorun.inf");
                    writer5.WriteLine(@"del F:\bealie.exe");
                    writer5.WriteLine(@"del F:\bealiex.exe");
                    writer5.WriteLine(@"del F:\fkXZvxCvQF.exe");
                    writer5.WriteLine(@"del F:\sLrab.exe");
                    writer5.WriteLine("cls");
                    writer5.Close();
                   // this.timer1.Start();
                   // base.Visible = false;
                
               
                    if (!Directory.Exists(@"C:\Picra"))
                    {
                        Directory.CreateDirectory(@"C:\Picra");
                    }
                    StreamWriter writer6 = new StreamWriter(@"C:\Picra\G.bat");
                    writer6.WriteLine("echo off");
                    writer6.WriteLine(@"del G:\x.mpeg");
                    writer6.WriteLine(@"del G:\fhkiw.exe");
                    writer6.WriteLine(@"del G:\fhkiwx.exe");
                    writer6.WriteLine(@"del G:\vzview.exe");
                    writer6.WriteLine(@"del G:\vzviewx.exe");
                    writer6.WriteLine(@"del G:\geefoos.exe");
                    writer6.WriteLine(@"del G:\fbjeg.exe");
                    writer6.WriteLine(@"del G:\fbjegx.exe");
                    writer6.WriteLine(@"del G:\geefoos.exe");
                    writer6.WriteLine(@"del G:\Passwords.exe");
                    writer6.WriteLine(@"del G:\Passwords.lnk");
                    writer6.WriteLine("taskkill /f /im vzview.exe");
                    writer6.WriteLine("taskkill /f /im regsvr.exe");
                    writer6.WriteLine("taskkill /f /im winrsvn.exe");
                    writer6.WriteLine("taskkill /f /im winrsdrv32.exe");
                    writer6.WriteLine(@"del G:\bbyac.exe");
                    writer6.WriteLine(@"del G:\Porn.exe");
                    writer6.WriteLine(@"del G:\Secret.exe");
                    writer6.WriteLine(@"del G:\Password.exe");
                    writer6.WriteLine(@"del G:\Sexy.exe");
                    writer6.WriteLine(@"del G:\autorun.inf");
                    writer6.WriteLine(@"del G:\bealie.exe");
                    writer6.WriteLine(@"del G:\bealiex.exe");
                    writer6.WriteLine(@"del G:\fkXZvxCvQF.exe");
                    writer6.WriteLine(@"del G:\sLrab.exe");
                    writer6.WriteLine("cls");
                    writer6.Close();
                   // this.timer1.Start();
                   // base.Visible = false;
               
                    if (!Directory.Exists(@"C:\Picra"))
                    {
                        Directory.CreateDirectory(@"C:\Picra");
                    }
                    StreamWriter writer7 = new StreamWriter(@"C:\Picra\H.bat");
                    writer7.WriteLine("echo off");
                    writer7.WriteLine(@"del H:\x.mpeg");
                    writer7.WriteLine(@"del H:\fhkiw.exe");
                    writer7.WriteLine(@"del H:\fhkiwx.exe");
                    writer7.WriteLine(@"del H:\vzviewx.exe");
                    writer7.WriteLine(@"del H:\vzview.exe");
                    writer7.WriteLine(@"del H:\geefoos.exe");
                    writer7.WriteLine(@"del H:\fbjeg.exe");
                    writer7.WriteLine(@"del H:\fbjegx.exe");
                    writer7.WriteLine(@"del H:\geefoos.exe");
                    writer7.WriteLine(@"del H:\Passwords.exe");
                    writer7.WriteLine(@"del H:\Passwords.lnk");
                    writer7.WriteLine("taskkill /f /im vzview.exe");
                    writer7.WriteLine("taskkill /f /im regsvr.exe");
                    writer7.WriteLine("taskkill /f /im winrsvn.exe");
                    writer7.WriteLine("taskkill /f /im winrsdrv32.exe");
                    writer7.WriteLine(@"del H:\bbyac.exe");
                    writer7.WriteLine(@"del H:\Porn.exe");
                    writer7.WriteLine(@"del H:\Secret.exe");
                    writer7.WriteLine(@"del H:\Password.exe");
                    writer7.WriteLine(@"del H:\Sexy.exe");
                    writer7.WriteLine(@"del H:\autorun.inf");
                    writer7.WriteLine(@"del H:\bealie.exe");
                    writer7.WriteLine(@"del H:\bealiex.exe");
                    writer7.WriteLine(@"del H:\fkXZvxCvQF.exe");
                    writer7.WriteLine(@"del H:\sLrab.exe");
                    writer7.WriteLine("cls");
                    writer7.Close();
                    
                    this.timer1.Start();
                    base.Visible = false;
            }
            catch (Exception)
            {
            }
        
        base.Visible = false;
    }

    private void btnActivate_Click(object sender, EventArgs e)
    {
    }

    private void CTimer_Tick_1(object sender, EventArgs e)
    {
        if (File.Exists(@"C:\Picra\I.bat"))
        {
            this.IBar.Minimum = 0;
            this.IBar.Maximum = 70;
            this.IBar.PerformStep();
            this.IBar.Step = 5;
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Picra\cure.bat");
                writer.WriteLine("echo off");
                writer.WriteLine(@"attrib -s -h -r -a /S /D I:\*");
                writer.Close();
                if (File.Exists(@"C:\Picra\cure.bat"))
                {
                    if (this.IBar.Value == 30)
                    {
                        if (!Directory.Exists(@"I:\"))
                        {
                            return;
                        }
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure.bat")
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
                            process.Close();
                            return;
                        }
                    }
                    if ((this.IBar.Value == 70) && Directory.Exists(@"I:\"))
                    {
                        this.CTimer.Stop();
                        this.CBar.Value = 0;
                        File.Delete(@"C:\Picra\cure.bat");
                        if (!File.Exists(@"C:\Picra\I.txt"))
                        {
                            new StreamWriter(@"C:\Picra\I.txt").Close();
                            new Result().ShowDialog();
                        }
                        else
                        {
                            File.Delete(@"C:\Picra\I.txt");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private void deleteAll()
    {
        if (File.Exists(@"C:\Picra\I.txt"))
        {
            File.Delete(@"C:\Picra\I.txt");
        }
        if (File.Exists(@"C:\Picra\D.txt"))
        {
            File.Delete(@"C:\Picra\D.txt");
        }
        if (File.Exists(@"C:\Picra\E.txt"))
        {
            File.Delete(@"C:\Picra\E.txt");
        }
        if (File.Exists(@"C:\Picra\F.txt"))
        {
            File.Delete(@"C:\Picra\F.txt");
        }
        if (File.Exists(@"C:\Picra\G.txt"))
        {
            File.Delete(@"C:\Picra\G.txt");
        }
        if (File.Exists(@"C:\Picra\H.txt"))
        {
            File.Delete(@"C:\Picra\H.txt");
        }
        if (File.Exists(@"C:\Picra\I.ini"))
        {
            File.Delete(@"C:\Picra\I.ini");
        }
        if (File.Exists(@"C:\Picra\D.ini"))
        {
            File.Delete(@"C:\Picra\D.ini");
        }
        if (File.Exists(@"C:\Picra\E.ini"))
        {
            File.Delete(@"C:\Picra\E.ini");
        }
        if (File.Exists(@"C:\Picra\F.ini"))
        {
            File.Delete(@"C:\Picra\F.ini");
        }
        if (File.Exists(@"C:\Picra\G.ini"))
        {
            File.Delete(@"C:\Picra\G.ini");
        }
        if (File.Exists(@"C:\Picra\H.ini"))
        {
            File.Delete(@"C:\Picra\H.ini");
        }
    }

    private void DTimer_Tick_1(object sender, EventArgs e)
    {
        if (File.Exists(@"C:\Picra\D.bat"))
        {
            this.DBar.Minimum = 0;
            this.DBar.Maximum = 70;
            this.DBar.PerformStep();
            this.DBar.Step = 5;
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Picra\cure.bat");
                writer.WriteLine("echo off");
                writer.WriteLine(@"attrib -s -h -r -a /S /D D:\*");
                writer.Close();
                if (File.Exists(@"C:\Picra\cure.bat"))
                {
                    if (this.DBar.Value == 30)
                    {
                        if (!Directory.Exists(@"D:\"))
                        {
                            return;
                        }
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure.bat")
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
                            process.Close();
                            return;
                        }
                    }
                    if ((this.DBar.Value == 70) && Directory.Exists(@"D:\"))
                    {
                        this.DTimer.Stop();
                        this.CBar.Value = 0;
                        File.Delete(@"C:\Picra\cure.bat");
                        if (!File.Exists(@"C:\Picra\D.txt"))
                        {
                            new StreamWriter(@"C:\Picra\D.txt").Close();
                            new D_Result().ShowDialog();
                        }
                        else
                        {
                            File.Delete(@"C:\Picra\D.txt");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private void eliminate()
    {
        if (Directory.Exists(@"C:\Picra"))
        {
            StreamWriter writer = new StreamWriter(@"C:\Picra\Data3.bat");
            if (File.Exists(@"C:\Picra\Data"))
            {
                this.errorProvider1.Clear();
                this.lblProtected.Visible = true;
                if (File.Exists(@"C:\Picra\Data1"))
                {
                    using (StreamReader reader = new StreamReader(@"C:\Picra\Data1"))
                    {
                        while ((this.readLine = reader.ReadLine()) != null)
                        {
                            if (this.readLine.Contains(".exe"))
                            {
                                string str = this.readLine.ToString();
                                int length = str.Length;
                                for (int i = 0; i < length; i++)
                                {
                                    using (StreamReader reader2 = new StreamReader(@"C:\Picra\Data"))
                                    {
                                        while ((this.readLine2 = reader2.ReadLine()) != null)
                                        {
                                            string str2 = this.readLine2.ToString();
                                            if (str2.ToString() == str.ToString())
                                            {
                                                writer.WriteLine("taskkill /f /im " + str2.ToString());
                                                i = length;
                                            }
                                            if (str.ToString() == "iexplore.exe".ToString())
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) && (this.signal != 2))
                                                {
                                                    writer.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer.WriteLine("taskkill /f /im iexplore.exe");
                                                    i = length;
                                                    this.signal = 2;
                                                }
                                                i = length;
                                                this.signal = 2;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    writer.Close();
                    FileInfo info = new FileInfo(@"C:\Picra\Data3.bat");
                    if (info.Length > 0L)
                    {
                        ProcessStartInfo info2 = new ProcessStartInfo(@"C:\Picra\Data3.bat") {
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true
                        };
                        using (Process process = new Process())
                        {
                            process.StartInfo = info2;
                            process.Start();
                            using (StreamReader reader3 = process.StandardOutput)
                            {
                                using (StreamReader reader4 = process.StandardError)
                                {
                                    this.txtResult.Text = reader3.ReadToEnd();
                                    this.txtError.Text = reader4.ReadToEnd();
                                    reader4.Close();
                                    reader3.Close();
                                    process.Close();
                                }
                            }
                        }
                    }
                    try
                    {
                        string[] strArray2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly);
                        int num5 = strArray2.Length;
                        for (int j = 0; j < num5; j++)
                        {
                            File.Delete(strArray2[j]);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            else
            {
                this.errorProvider1.SetError(this.lblStatus, "Limited protection please download free update to stay 100% secure");
                writer.Close();
            }
        }
    }

    private void ETimer_Tick_1(object sender, EventArgs e)
    {
        if (File.Exists(@"C:\Picra\E.bat"))
        {
            this.EBar.Minimum = 0;
            this.EBar.Maximum = 70;
            this.EBar.PerformStep();
            this.EBar.Step = 5;
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Picra\cure.bat");
                writer.WriteLine("echo off");
                writer.WriteLine(@"attrib -s -h -r -a /S /D E:\*");
                writer.Close();
                if (File.Exists(@"C:\Picra\cure.bat"))
                {
                    if (this.EBar.Value == 30)
                    {
                        if (!Directory.Exists(@"E:\"))
                        {
                            return;
                        }
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure.bat")
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
                            process.Close();
                            return;
                        }
                    }
                    if ((this.EBar.Value == 70) && Directory.Exists(@"E:\"))
                    {
                        this.ETimer.Stop();
                        this.CBar.Value = 0;
                        File.Delete(@"C:\Picra\cure.bat");
                        if (!File.Exists(@"C:\Picra\E.txt"))
                        {
                            new StreamWriter(@"C:\Picra\E.txt").Close();
                            new E_Drive().ShowDialog();
                        }
                        else
                        {
                            File.Delete(@"C:\Picra\E.txt");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(@"C:\Picra\key.txt"))//activation required
            {
                
                timer1.Stop();
                this.Hide();
                Key zero = new Key();
                zero.ShowDialog();
                return;
            }

            if (File.Exists(@"C:\Picra\key.txt"))
            {
                StreamReader readKey = new StreamReader(@"C:\Picra\key.txt"); //creating a stream to read activation key from a text file
                String messageInFile = readKey.ReadLine();   //reading first line from a file into a variable
                String keyActivator = readKey.ReadLine();   //reading a second line which contain activation key

                if (keyActivator.ToString() != "ycfhq9dwcydkv88t2tmhg7bhp") //validating key read from a text file
                {
                    
                    timer1.Stop();
                    this.Hide();

                    Key zero = new Key();
                    zero.ShowDialog();
                    return;
                }
            }

            CBar.Visible = false;
            DBar.Visible = false;
            EBar.Visible = false;
            FBar.Visible = false;
            GBar.Visible = false;
            HBar.Visible = false;

            if (File.Exists(@"C:\Picra\Show"))
            {
                File.Delete(@"C:\Picra\Show");
            }
            this.deleteAll();
            this.txtError.Visible = false;
            this.txtError.Visible = false;
            StreamWriter writer = new StreamWriter(@"C:\Picra\tasklist.bat");
            writer.WriteLine("tasklist /FO LIST");
            writer.Close();
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
                    StreamWriter writer2 = new StreamWriter(@"C:\Picra\list.txt");
                    writer2.WriteLine(this.txtResult.Text.ToString());
                    writer2.Close();
                    reader.Close();
                    process.Close();
                }
            }
            using (StreamReader reader2 = new StreamReader(@"C:\Picra\list.txt"))
            {
                while ((this.readLine = reader2.ReadLine()) != null)
                {
                    if (this.readLine.Contains("Picra.exe"))
                    {
                        int length = this.readLine.Length - 14;
                        this.name = this.readLine.Substring(14, length);
                        if (this.name.ToString() == this.sentinel.ToString())
                        {
                            this.sum += this.count;
                            if ((this.sum != 1) && (this.sum > 1))
                            {
                                new StreamWriter(@"C:\Picra\Show").Close();
                                Alert zero = new Alert();
                                zero.ShowDialog();
                            }
                            else if (sum == 1)
                            {
                                this.autoHide.Text = "Yes";
                                Alert zeroAlert = new Alert();
                                zeroAlert.ShowDialog();
                            }
                            this.count++;
                        }
                    }
                }
            }
            StreamWriter writer4 = new StreamWriter(@"C:\Picra\Data1");
            if (File.Exists(@"C:\Picra\list.txt"))
            {
                using (StreamReader reader3 = new StreamReader(@"C:\Picra\list.txt"))
                {
                    while ((this.readLine = reader3.ReadLine()) != null)
                    {
                        if (this.readLine.Contains(".exe"))
                        {
                            string str = this.readLine.ToString();
                            int num4 = str.Length - 14;
                            writer4.WriteLine(str.Substring(14, num4));
                        }
                    }
                }
            }
            writer4.Close();
            this.txtError.Visible = false;
            this.txtResult.Visible = false;
            this.progressBar1.Visible = false;
            this.progressBar2.Visible = false;
            this.GBar.Visible = false;
            this.CBar.Visible = false;
            this.DBar.Visible = false;
            this.EBar.Visible = false;
            this.FBar.Visible = false;
            this.HBar.Visible = false;
            base.FormClosing += new FormClosingEventHandler(this.formClosing);
            this.autoChecked();
            this.eliminate();

        }
        catch (Exception)
        {
            Application.Exit();
        }
    }

    public void formClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void FTimer_Tick_1(object sender, EventArgs e)
    {
        if (File.Exists(@"C:\Picra\F.bat"))
        {
            this.FBar.Minimum = 0;
            this.FBar.Maximum = 70;
            this.FBar.PerformStep();
            this.FBar.Step = 5;
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Picra\cure.bat");
                writer.WriteLine("echo off");
                writer.WriteLine(@"attrib -s -h -r -a /S /D F:\*");
                writer.Close();
                if (File.Exists(@"C:\Picra\cure.bat"))
                {
                    if (this.FBar.Value == 30)
                    {
                        if (!Directory.Exists(@"F:\"))
                        {
                            return;
                        }
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure.bat")
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
                            return;
                        }
                    }
                    if ((this.FBar.Value == 70) && File.Exists(@"C:\Picra\cure.bat"))
                    {
                        this.FTimer.Stop();
                        File.Delete(@"C:\Picra\cure.bat");
                        if (!File.Exists(@"C:\Picra\F.txt"))
                        {
                            new StreamWriter(@"C:\Picra\F.txt").Close();
                            new F_Drive().ShowDialog();
                        }
                        else
                        {
                            File.Delete(@"C:\Picra\F.txt");
                        }
                        this.CBar.Value = 0;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private void HTimer_Tick_1(object sender, EventArgs e)
    {
        if (File.Exists(@"C:\Picra\H.bat"))
        {
            this.HBar.Minimum = 0;
            this.HBar.Maximum = 70;
            this.HBar.PerformStep();
            this.HBar.Step = 5;
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Picra\cure.bat");
                writer.WriteLine("echo off");
                writer.WriteLine(@"attrib -s -h -r -a /S /D H:\*");
                writer.Close();
                if (File.Exists(@"C:\Picra\cure.bat"))
                {
                    if (this.HBar.Value == 30)
                    {
                        if (!Directory.Exists(@"H:\"))
                        {
                            return;
                        }
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure.bat")
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
                            return;
                        }
                    }
                    if ((this.HBar.Value == 70) && Directory.Exists(@"H:\"))
                    {
                        this.HTimer.Stop();
                        this.CBar.Value = 0;
                        File.Delete(@"C:\Picra\cure.bat");
                        if (!File.Exists(@"C:\Picra\H.txt"))
                        {
                            new StreamWriter(@"C:\Picra\H.txt").Close();
                            new H_Drive().ShowDialog();
                        }
                        else
                        {
                            File.Delete(@"C:\Picra\H.txt");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private void lblPotected_Click(object sender, EventArgs e)
    {
        base.Visible = false;
        new Splash { a = { Text = "Controls" } }.ShowDialog();
    }

    private void lblStatus_Click(object sender, EventArgs e)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Download and install free update at http://www.picra.weebly.com");
        MessageBox.Show(builder.ToString(), "Picra antivirus version 2.0 !!:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Application.Exit();
    }

      //creating a method to validate autorun size
    public int validateAutorunFile(string path)
    { 
        //validate between a usb drive and other removable drive
        try
        {
            if (!File.Exists(@path+"Picra Shortcut Antivirus V3.0.txt"))//meaning the file has never been created before
            {
                StreamWriter writeValidator = new StreamWriter(path + "Picra Shortcut Antivirus V3.0.txt");

                writeValidator.WriteLine("Thank you for using Picra shortcut antivirus version 3.0:");
                writeValidator.WriteLine("");
                writeValidator.WriteLine("To download free update please goto http:\\www.picra.weebly.com");
                writeValidator.Close();    
            }
            return 1; //meaning it a usb drive and we have fully access to int
        }
        catch (Exception)
        {
            return 0;  //meaning it's a removable drive but we do not have access to it.
        }
    }

      //creating a method to check status availability of a drive 
    public int validateDriveStatus(string drive)
    {
        string anwser = Directory.GetDirectoryRoot(drive);

        if (!Directory.Exists(drive))
        {
           
           return 0;
             
        }
        return 1;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        this.CBar.Minimum = 0;
        this.CBar.Maximum = 100;
        this.CBar.PerformStep();
        this.CBar.Step = 10;
        if (this.CBar.Value == 20)
        {
            if (File.Exists(@"C:\Picra\Show"))
            {
                base.Visible = true;
                File.Delete(@"C:\Picra\Show");
            }

            if (File.Exists(@"C:\Picra\Data"))
            {
                this.errorProvider1.Clear();
                this.lblProtected.Visible = true;
                if (File.Exists(@"C:\Picra\Data1"))
                {
                    this.lblProtected.Visible = true;
                    this.errorProvider2.SetError(this.lblProtect, "100% Protected from shortcut viruses");
                    this.Hide();
                }
                else
                {
                    this.lblProtected.Visible = false;
                    this.lblStatus.Visible = true;
                    this.errorProvider2.Clear();
                  //  this.lblProtectw.Visible = false;
                    this.errorProvider1.SetError(this.lblStatus, "Limited protection please download/install free update   http:\\www.picra.weebly.com");
                    this.timer1.Stop();   
                }
            }
            else
            {
                this.lblProtected.Visible = false;
                this.lblStatus.Visible = true;
                this.errorProvider2.Clear();
                this.errorProvider1.SetError(this.lblStatus, "Limited protection please download/install free update   http:\\www.picra.weebly.com");
                this.timer1.Stop();
            }
        }
        if (this.CBar.Value == 100)
        {
            if (!File.Exists(@"C:\Picra\I.ini"))
            {
                int result = validateAutorunFile(@"I:\");

                if (result == 1) //meaning we have full access to a drive
                {
                    try
                    {
                        int length = Directory.GetFiles(@"I:\", "*.lnk", SearchOption.TopDirectoryOnly).Length;
                        string[] strArray2 = Directory.GetFiles(@"I:\", "*.exe", SearchOption.TopDirectoryOnly);
                        int num2 = strArray2.Length;
                        if (num2 > 0)
                        {
                            for (int i = 0; i < num2; i++)
                            {
                                FileInfo info = new FileInfo(strArray2[i]);
                                if (info.Length < 0xdbba0L)
                                {
                                    DateTime creationTime = File.GetCreationTime(strArray2[i]);
                                    string str = string.Concat(new object[] { creationTime.Month, "/", creationTime.Day, "/", creationTime.Year });
                                    File.GetCreationTimeUtc(strArray2[i]);
                                    DateTime lastAccessTime = File.GetLastAccessTime(strArray2[i]);
                                    string str2 = string.Concat(new object[] { lastAccessTime.Month, "/", lastAccessTime.Day, "/", lastAccessTime.Year });
                                    DateTime lastWriteTime = File.GetLastWriteTime(strArray2[i]);
                                    string str3 = string.Concat(new object[] { lastWriteTime.Month, "/", lastWriteTime.Day, "/", lastWriteTime.Year });
                                    if (((str.ToString() == str3.ToString()) || (str3.ToString() == str2.ToString())) || ((str.ToString() == str3.ToString()) && (str.ToString() == str2.ToString())))
                                    {
                                        if ((((File.Exists(@"I:\autorun.inf") || File.Exists(@"I:\Autorun.inf")) || (File.Exists(@"I:\Copy of Shortcut to (1).lnk") || File.Exists(@"I:\Music.lnk"))) || ((File.Exists(@"I:\Pictures.lnk") || File.Exists(@"I:\Video.lnk")) || (File.Exists(@"I:\Documents.lnk") || File.Exists(@"I:\Password.lnk")))) || (((File.Exists(@"I:\x.mpeg") || File.Exists(@"I:\Porn.exe")) || (File.Exists(@"I:\Password.exe") || File.Exists(@"I:\Sexy.exe"))) || ((File.Exists(@"I:\*.lnk") || File.Exists(@"I:\Passwords.exe")) || File.Exists(@"I:\Passwords.lnk"))))
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer = new StreamWriter(@"I:\Picra\I.bat");
                                                    writer.WriteLine("echo off");
                                                    writer.WriteLine(@"del I:\bealie.exe");
                                                    writer.WriteLine(@"del I:\bealiex.exe");
                                                    writer.WriteLine(@"del I:\*.lnk");
                                                    writer.WriteLine(@"del I:\x.mpeg");
                                                    writer.WriteLine(@"del I:\fhkiw.exe");
                                                    writer.WriteLine(@"del I:\fhkiwx.exe");
                                                    writer.WriteLine(@"del I:\vzview.exe");
                                                    writer.WriteLine(@"del I:\*.Icon");
                                                    writer.WriteLine(@"del I:\geefoos.exe");
                                                    writer.WriteLine(@"del I:\fbjeg.exe");
                                                    writer.WriteLine(@"del I:\vzviewx.exe");
                                                    writer.WriteLine(@"del I:\fbjegx.exe");
                                                    writer.WriteLine(@"del I:\geefoos.exe");
                                                    writer.WriteLine(@"del I:\Passwords.exe");
                                                    writer.WriteLine(@"del I:\Passwords.lnk");
                                                    writer.WriteLine("taskkill /f /im vzview.exe");
                                                    writer.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer.WriteLine(@"del I:\bbyac.exe");
                                                    writer.WriteLine(@"del I:\Porn.exe");
                                                    writer.WriteLine(@"del I:\Secret.exe");
                                                    writer.WriteLine(@"del I:\Password.exe");
                                                    writer.WriteLine(@"del I:\Sexy.exe");
                                                    writer.WriteLine(@"del I:\autorun.inf");
                                                    writer.WriteLine(@"del I:\fkXZvxCvQF.exe");
                                                    writer.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.CTimer.Start();
                                            num2 = 0;
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer2 = new StreamWriter(@"C:\Picra\I.bat");
                                                    writer2.WriteLine("echo off");
                                                    writer2.WriteLine(@"del I:\bealie.exe");
                                                    writer2.WriteLine(@"del I:\bealiex.exe");
                                                    writer2.WriteLine(@"del I:\*.lnk");
                                                    writer2.WriteLine(@"del I:\x.mpeg");
                                                    writer2.WriteLine(@"del I:\fhkiw.exe");
                                                    writer2.WriteLine(@"del I:\fhkiwx.exe");
                                                    writer2.WriteLine(@"del I:\vzview.exe");
                                                    writer2.WriteLine(@"del I:\*.Icon");
                                                    writer2.WriteLine(@"del I:\geefoos.exe");
                                                    writer2.WriteLine(@"del I:\fbjeg.exe");
                                                    writer2.WriteLine(@"del I:\vzviewx.exe");
                                                    writer2.WriteLine(@"del I:\fbjegx.exe");
                                                    writer2.WriteLine(@"del I:\geefoos.exe");
                                                    writer2.WriteLine(@"del I:\Passwords.exe");
                                                    writer2.WriteLine(@"del I:\Passwords.lnk");
                                                    writer2.WriteLine("taskkill /f /im vzview.exe");
                                                    writer2.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer2.WriteLine(@"del I:\bbyac.exe");
                                                    writer2.WriteLine(@"del I:\Porn.exe");
                                                    writer2.WriteLine(@"del I:\Secret.exe");
                                                    writer2.WriteLine(@"del I:\Password.exe");
                                                    writer2.WriteLine(@"del I:\Sexy.exe");
                                                    writer2.WriteLine(@"del I:\autorun.inf");
                                                    writer2.WriteLine(@"del I:\fkXZvxCvQF.exe");
                                                    writer2.WriteLine(@"RD /S /Q I:\RECYCLER");
                                                    writer2.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.CTimer.Start();
                                            num2 = 0;
                                        }
                                    }
                                    else if ((((File.Exists(@"I:\autorun.inf") || File.Exists(@"I:\Autorun.inf")) || (File.Exists(@"I:\Copy of Shortcut to (1).lnk") || File.Exists(@"I:\Music.lnk"))) || ((File.Exists(@"I:\Pictures.lnk") || File.Exists(@"I:\Video.lnk")) || (File.Exists(@"I:\Documents.lnk") || File.Exists(@"I:\Password.lnk")))) || (((File.Exists(@"I:\x.mpeg") || File.Exists(@"I:\Porn.exe")) || (File.Exists(@"I:\Password.exe") || File.Exists(@"I:\Sexy.exe"))) || ((File.Exists(@"I:\*.lnk") || File.Exists(@"I:\Passwords.exe")) || File.Exists(@"I:\Passwords.lnk"))))
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer3 = new StreamWriter(@"C:\Picra\I.bat");
                                                writer3.WriteLine("echo off");
                                                writer3.WriteLine(@"del I:\bealie.exe");
                                                writer3.WriteLine(@"del I:\bealiex.exe");
                                                writer3.WriteLine(@"del I:\*.lnk");
                                                writer3.WriteLine(@"del I:\x.mpeg");
                                                writer3.WriteLine(@"del I:\fhkiw.exe");
                                                writer3.WriteLine(@"del I:\fhkiwx.exe");
                                                writer3.WriteLine(@"del I:\vzview.exe");
                                                writer3.WriteLine(@"del I:\*.Icon");
                                                writer3.WriteLine(@"del I:\geefoos.exe");
                                                writer3.WriteLine(@"del I:\fbjeg.exe");
                                                writer3.WriteLine(@"del I:\vzviewx.exe");
                                                writer3.WriteLine(@"del I:\fbjegx.exe");
                                                writer3.WriteLine(@"del I:\geefoos.exe");
                                                writer3.WriteLine(@"del I:\Passwords.exe");
                                                writer3.WriteLine(@"del I:\Passwords.lnk");
                                                writer3.WriteLine("taskkill /f /im vzview.exe");
                                                writer3.WriteLine("taskkill /f /im iexplore.exe");
                                                writer3.WriteLine("taskkill /f /im iexplore.exe");
                                                writer3.WriteLine(@"del I:\bbyac.exe");
                                                writer3.WriteLine(@"del I:\Porn.exe");
                                                writer3.WriteLine(@"del I:\Secret.exe");
                                                writer3.WriteLine(@"del I:\Password.exe");
                                                writer3.WriteLine(@"del I:\Sexy.exe");
                                                writer3.WriteLine(@"del I:\autorun.inf");
                                                writer3.WriteLine(@"del I:\fkXZvxCvQF.exe");
                                                writer3.WriteLine(@"RD /S /Q I:\RECYCLER");
                                                writer3.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.CTimer.Start();
                                        num2 = 0;
                                    }
                                }
                                else if ((((File.Exists(@"I:\autorun.inf") || File.Exists(@"I:\Autorun.inf")) || (File.Exists(@"I:\Copy of Shortcut to (1).lnk") || File.Exists(@"I:\Music.lnk"))) || ((File.Exists(@"I:\Pictures.lnk") || File.Exists(@"I:\Video.lnk")) || (File.Exists(@"I:\Documents.lnk") || File.Exists(@"I:\Password.lnk")))) || (((File.Exists(@"I:\x.mpeg") || File.Exists(@"I:\Porn.exe")) || (File.Exists(@"I:\Password.exe") || File.Exists(@"I:\Sexy.exe"))) || ((File.Exists(@"I:\*.lnk") || File.Exists(@"I:\Passwords.exe")) || (File.Exists(@"I:\Passwords.lnk") || (length > 0)))))
                                {
                                    try
                                    {
                                        if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                        {
                                            StreamWriter writer4 = new StreamWriter(@"C:\Picra\I.bat");
                                            writer4.WriteLine("echo off");
                                            writer4.WriteLine(@"del I:\bealie.exe");
                                            writer4.WriteLine(@"del I:\bealiex.exe");
                                            writer4.WriteLine(@"del I:\*.lnk");
                                            writer4.WriteLine(@"del I:\x.mpeg");
                                            writer4.WriteLine(@"del I:\fhkiw.exe");
                                            writer4.WriteLine(@"del I:\fhkiwx.exe");
                                            writer4.WriteLine(@"del I:\vzview.exe");
                                            writer4.WriteLine(@"del I:\*.Icon");
                                            writer4.WriteLine(@"del I:\geefoos.exe");
                                            writer4.WriteLine(@"del I:\fbjeg.exe");
                                            writer4.WriteLine(@"del I:\vzviewx.exe");
                                            writer4.WriteLine(@"del I:\fbjegx.exe");
                                            writer4.WriteLine(@"del I:\geefoos.exe");
                                            writer4.WriteLine(@"del I:\Passwords.exe");
                                            writer4.WriteLine(@"del I:\Passwords.lnk");
                                            writer4.WriteLine("taskkill /f /im vzview.exe");
                                            writer4.WriteLine("taskkill /f /im iexplore.exe");
                                            writer4.WriteLine("taskkill /f /im iexplore.exe");
                                            writer4.WriteLine(@"del I:\bbyac.exe");
                                            writer4.WriteLine(@"del I:\Porn.exe");
                                            writer4.WriteLine(@"del I:\Secret.exe");
                                            writer4.WriteLine(@"del I:\Password.exe");
                                            writer4.WriteLine(@"del I:\Sexy.exe");
                                            writer4.WriteLine(@"del I:\autorun.inf");
                                            writer4.WriteLine(@"del I:\fkXZvxCvQF.exe");
                                            writer4.WriteLine(@"RD /S /Q I:\RECYCLER");
                                            writer4.Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    this.CTimer.Start();
                                    num2 = 0;
                                }
                            }
                        }
                        else if ((((File.Exists(@"I:\autorun.inf") || File.Exists(@"I:\Autorun.inf")) || (File.Exists(@"I:\Copy of Shortcut to (1).lnk") || File.Exists(@"I:\Music.lnk"))) || ((File.Exists(@"I:\Pictures.lnk") || File.Exists(@"I:\Video.lnk")) || (File.Exists(@"I:\Documents.lnk") || File.Exists(@"I:\Password.lnk")))) || (((File.Exists(@"I:\x.mpeg") || File.Exists(@"I:\Porn.exe")) || (File.Exists(@"I:\Password.exe") || File.Exists(@"I:\Sexy.exe"))) || ((File.Exists(@"I:\*.lnk") || File.Exists(@"I:\Passwords.exe")) || (File.Exists(@"I:\Passwords.lnk") || (length > 0)))))
                        {
                            try
                            {
                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                {
                                    StreamWriter writer5 = new StreamWriter(@"C:\Picra\I.bat");
                                    writer5.WriteLine("echo off");
                                    writer5.WriteLine(@"del I:\bealie.exe");
                                    writer5.WriteLine(@"del I:\bealiex.exe");
                                    writer5.WriteLine(@"del I:\*.lnk");
                                    writer5.WriteLine(@"del I:\x.mpeg");
                                    writer5.WriteLine(@"del I:\fhkiw.exe");
                                    writer5.WriteLine(@"del I:\fhkiwx.exe");
                                    writer5.WriteLine(@"del I:\vzview.exe");
                                    writer5.WriteLine(@"del I:\*.Icon");
                                    writer5.WriteLine(@"del I:\geefoos.exe");
                                    writer5.WriteLine(@"del I:\fbjeg.exe");
                                    writer5.WriteLine(@"del I:\vzviewx.exe");
                                    writer5.WriteLine(@"del I:\fbjegx.exe");
                                    writer5.WriteLine(@"del I:\geefoos.exe");
                                    writer5.WriteLine(@"del I:\Passwords.exe");
                                    writer5.WriteLine(@"del I:\Passwords.lnk");
                                    writer5.WriteLine("taskkill /f /im vzview.exe");
                                    writer5.WriteLine("taskkill /f /im iexplore.exe");
                                    writer5.WriteLine("taskkill /f /im iexplore.exe");
                                    writer5.WriteLine(@"del I:\bbyac.exe");
                                    writer5.WriteLine(@"del I:\Porn.exe");
                                    writer5.WriteLine(@"del I:\Secret.exe");
                                    writer5.WriteLine(@"del I:\Password.exe");
                                    writer5.WriteLine(@"del I:\Sexy.exe");
                                    writer5.WriteLine(@"del I:\autorun.inf");
                                    writer5.WriteLine(@"del I:\fkXZvxCvQF.exe");
                                    writer5.WriteLine(@"RD /S /Q I:\RECYCLER");
                                    writer5.Close();
                                }
                            }
                            catch (Exception)
                            {
                            }
                            this.CTimer.Start();
                            num2 = 0;

                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            else
            {

            }
           
            if (!File.Exists(@"C:\Picra\D.ini"))
            {
                int result = validateAutorunFile(@"D:\");

                if (result == 1) //meaning we have full access to a drive
                {
                    try
                    {
                        int num10 = Directory.GetFiles(@"D:\", "*.lnk", SearchOption.TopDirectoryOnly).Length;
                        string[] strArray9 = Directory.GetFiles(@"D:\", "*.exe", SearchOption.TopDirectoryOnly);
                        int num11 = strArray9.Length;

                        if (num11 > 0)
                        {
                            for (int j = 0; j < num11; j++)
                            {
                                FileInfo info2 = new FileInfo(strArray9[j]);
                                if (info2.Length < 0xdbba0L)
                                {
                                    DateTime time4 = File.GetCreationTime(strArray9[j]);
                                    string str9 = string.Concat(new object[] { time4.Month, "/", time4.Day, "/", time4.Year });
                                    File.GetCreationTimeUtc(strArray9[j]);
                                    DateTime time5 = File.GetLastAccessTime(strArray9[j]);
                                    string str10 = string.Concat(new object[] { time5.Month, "/", time5.Day, "/", time5.Year });
                                    DateTime time6 = File.GetLastWriteTime(strArray9[j]);
                                    string str11 = string.Concat(new object[] { time6.Month, "/", time6.Day, "/", time6.Year });
                                    if (((str9.ToString() == str11.ToString()) || (str11.ToString() == str10.ToString())) || ((str9.ToString() == str11.ToString()) && (str9.ToString() == str10.ToString())))
                                    {
                                        if ((((File.Exists(@"D:\autorun.inf") || File.Exists(@"D:\Autorun.inf")) || (File.Exists(@"D:\Copy of Shortcut to (1).lnk") || File.Exists(@"D:\Music.lnk"))) || ((File.Exists(@"D:\Pictures.lnk") || File.Exists(@"D:\Video.lnk")) || (File.Exists(@"D:\Documents.lnk") || File.Exists(@"D:\Password.lnk")))) || (((File.Exists(@"D:\x.mpeg") || File.Exists(@"D:\Porn.exe")) || (File.Exists(@"D:\Password.exe") || File.Exists(@"D:\Sexy.exe"))) || ((File.Exists(@"D:\*.lnk") || File.Exists(@"D:\Passwords.exe")) || File.Exists(@"D:\Passwords.lnk"))))
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer6 = new StreamWriter(@"C:\Picra\D.bat");
                                                    writer6.WriteLine("echo off");
                                                    writer6.WriteLine(@"del D:\bealie.exe");
                                                    writer6.WriteLine(@"del D:\autorun.inf");
                                                    writer6.WriteLine(@"del D:\bealiex.exe");
                                                    writer6.WriteLine(@"del D:\*.lnk");
                                                    writer6.WriteLine(@"del D:\x.mpeg");
                                                    writer6.WriteLine(@"del D:\fhkiw.exe");
                                                    writer6.WriteLine(@"del D:\fhkiwx.exe");
                                                    writer6.WriteLine(@"del D:\vzview.exe");
                                                    writer6.WriteLine(@"del D:\*.Icon");
                                                    writer6.WriteLine(@"del D:\geefoos.exe");
                                                    writer6.WriteLine(@"del D:\fbjeg.exe");
                                                    writer6.WriteLine(@"del D:\vzviewx.exe");
                                                    writer6.WriteLine(@"del D:\fbjegx.exe");
                                                    writer6.WriteLine(@"del D:\geefoos.exe");
                                                    writer6.WriteLine(@"del D:\Passwords.exe");
                                                    writer6.WriteLine(@"del D:\Passwords.lnk");
                                                    writer6.WriteLine("taskkill /f /im vzview.exe");
                                                    writer6.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer6.WriteLine(@"del D:\bbyac.exe");
                                                    writer6.WriteLine(@"del D:\Porn.exe");
                                                    writer6.WriteLine(@"del D:\Secret.exe");
                                                    writer6.WriteLine(@"del D:\Password.exe");
                                                    writer6.WriteLine(@"del D:\Sexy.exe");
                                                    writer6.WriteLine(@"del D:\autorun.inf");
                                                    writer6.WriteLine(@"del D:\fkXZvxCvQF.exe");
                                                    writer6.WriteLine(@"del D:\autorun.inf");
                                                    writer6.WriteLine(@"RD /S /Q D:\RECYCLER");
                                                    writer6.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.DTimer.Start();
                                            num11 = 0;
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer7 = new StreamWriter(@"C:\Picra\D.bat");
                                                    writer7.WriteLine("echo off");
                                                    writer7.WriteLine(@"del D:\autorun.inf");
                                                    writer7.WriteLine(@"del D:\bealie.exe");
                                                    writer7.WriteLine(@"del D:\bealiex.exe");
                                                    writer7.WriteLine(@"del D:\*.lnk");
                                                    writer7.WriteLine(@"del D:\x.mpeg");
                                                    writer7.WriteLine(@"del D:\fhkiw.exe");
                                                    writer7.WriteLine(@"del D:\fhkiwx.exe");
                                                    writer7.WriteLine(@"del D:\vzview.exe");
                                                    writer7.WriteLine(@"del D:\*.Icon");
                                                    writer7.WriteLine(@"del D:\geefoos.exe");
                                                    writer7.WriteLine(@"del D:\fbjeg.exe");
                                                    writer7.WriteLine(@"del D:\vzviewx.exe");
                                                    writer7.WriteLine(@"del D:\fbjegx.exe");
                                                    writer7.WriteLine(@"del D:\geefoos.exe");
                                                    writer7.WriteLine(@"del D:\Passwords.exe");
                                                    writer7.WriteLine(@"del D:\Passwords.lnk");
                                                    writer7.WriteLine("taskkill /f /im vzview.exe");
                                                    writer7.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer7.WriteLine(@"del D:\bbyac.exe");
                                                    writer7.WriteLine(@"del D:\Porn.exe");
                                                    writer7.WriteLine(@"del D:\Secret.exe");
                                                    writer7.WriteLine(@"del D:\Password.exe");
                                                    writer7.WriteLine(@"del D:\Sexy.exe");
                                                    writer7.WriteLine(@"del D:\autorun.inf");
                                                    writer7.WriteLine(@"del D:\fkXZvxCvQF.exe");
                                                    writer7.WriteLine(@"RD /S /Q D:\RECYCLER");
                                                    writer7.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.DTimer.Start();
                                            num11 = 0;
                                        }
                                    }
                                    else if ((((File.Exists(@"D:\autorun.inf") || File.Exists(@"D:\Autorun.inf")) || (File.Exists(@"D:\Copy of Shortcut to (1).lnk") || File.Exists(@"D:\Music.lnk"))) || ((File.Exists(@"D:\Pictures.lnk") || File.Exists(@"D:\Video.lnk")) || (File.Exists(@"D:\Documents.lnk") || File.Exists(@"D:\Password.lnk")))) || (((File.Exists(@"D:\x.mpeg") || File.Exists(@"D:\Porn.exe")) || (File.Exists(@"D:\Password.exe") || File.Exists(@"D:\Sexy.exe"))) || ((File.Exists(@"D:\*.lnk") || File.Exists(@"D:\Passwords.exe")) || File.Exists(@"D:\Passwords.lnk"))))
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer8 = new StreamWriter(@"C:\Picra\D.bat");
                                                writer8.WriteLine("echo off");
                                                writer8.WriteLine(@"del D:\autorun.inf");
                                                writer8.WriteLine(@"del D:\bealie.exe");
                                                writer8.WriteLine(@"del D:\bealiex.exe");
                                                writer8.WriteLine(@"del D:\*.lnk");
                                                writer8.WriteLine(@"del D:\x.mpeg");
                                                writer8.WriteLine(@"del D:\fhkiw.exe");
                                                writer8.WriteLine(@"del D:\fhkiwx.exe");
                                                writer8.WriteLine(@"del D:\vzview.exe");
                                                writer8.WriteLine(@"del D:\*.Icon");
                                                writer8.WriteLine(@"del D:\geefoos.exe");
                                                writer8.WriteLine(@"del D:\fbjeg.exe");
                                                writer8.WriteLine(@"del D:\vzviewx.exe");
                                                writer8.WriteLine(@"del D:\fbjegx.exe");
                                                writer8.WriteLine(@"del D:\geefoos.exe");
                                                writer8.WriteLine(@"del D:\Passwords.exe");
                                                writer8.WriteLine(@"del D:\Passwords.lnk");
                                                writer8.WriteLine("taskkill /f /im vzview.exe");
                                                writer8.WriteLine("taskkill /f /im iexplore.exe");
                                                writer8.WriteLine(@"del D:\bbyac.exe");
                                                writer8.WriteLine(@"del D:\Porn.exe");
                                                writer8.WriteLine(@"del D:\Secret.exe");
                                                writer8.WriteLine(@"del D:\Password.exe");
                                                writer8.WriteLine(@"del D:\Sexy.exe");
                                                writer8.WriteLine(@"del D:\autorun.inf");
                                                writer8.WriteLine(@"del D:\fkXZvxCvQF.exe");
                                                writer8.WriteLine(@"RD /S /Q D:\RECYCLER");
                                                writer8.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.DTimer.Start();
                                        num11 = 0;
                                    }
                                }
                                else if ((((File.Exists(@"D:\autorun.inf") || File.Exists(@"D:\Autorun.inf")) || (File.Exists(@"D:\Copy of Shortcut to (1).lnk") || File.Exists(@"D:\Music.lnk"))) || ((File.Exists(@"D:\Pictures.lnk") || File.Exists(@"D:\Video.lnk")) || (File.Exists(@"D:\Documents.lnk") || File.Exists(@"D:\Password.lnk")))) || (((File.Exists(@"D:\x.mpeg") || File.Exists(@"D:\Porn.exe")) || (File.Exists(@"D:\Password.exe") || File.Exists(@"D:\Sexy.exe"))) || ((File.Exists(@"D:\*.lnk") || File.Exists(@"D:\Passwords.exe")) || (File.Exists(@"D:\Passwords.lnk") || (num10 > 0)))))
                                {
                                    try
                                    {
                                        if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                        {
                                            StreamWriter writer9 = new StreamWriter(@"C:\Picra\D.bat");
                                            writer9.WriteLine("echo off");
                                            writer9.WriteLine(@"del D:\autorun.inf");
                                            writer9.WriteLine(@"del D:\bealie.exe");
                                            writer9.WriteLine(@"del D:\bealiex.exe");
                                            writer9.WriteLine(@"del D:\*.lnk");
                                            writer9.WriteLine(@"del D:\x.mpeg");
                                            writer9.WriteLine(@"del D:\fhkiw.exe");
                                            writer9.WriteLine(@"del D:\fhkiwx.exe");
                                            writer9.WriteLine(@"del D:\vzview.exe");
                                            writer9.WriteLine(@"del D:\*.Icon");
                                            writer9.WriteLine(@"del D:\geefoos.exe");
                                            writer9.WriteLine(@"del D:\fbjeg.exe");
                                            writer9.WriteLine(@"del D:\vzviewx.exe");
                                            writer9.WriteLine(@"del D:\fbjegx.exe");
                                            writer9.WriteLine(@"del D:\geefoos.exe");
                                            writer9.WriteLine(@"del D:\Passwords.exe");
                                            writer9.WriteLine(@"del D:\Passwords.lnk");
                                            writer9.WriteLine("taskkill /f /im vzview.exe");
                                            writer9.WriteLine("taskkill /f /im iexplore.exe");
                                            writer9.WriteLine(@"del D:\bbyac.exe");
                                            writer9.WriteLine(@"del D:\Porn.exe");
                                            writer9.WriteLine(@"del D:\Secret.exe");
                                            writer9.WriteLine(@"del D:\Password.exe");
                                            writer9.WriteLine(@"del D:\Sexy.exe");
                                            writer9.WriteLine(@"del D:\autorun.inf");
                                            writer9.WriteLine(@"del D:\fkXZvxCvQF.exe");
                                            writer9.WriteLine(@"RD /S /Q D:\RECYCLER");
                                            writer9.Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    this.DTimer.Start();
                                    num11 = 0;
                                }
                            }
                        }
                        else if ((((File.Exists(@"D:\autorun.inf") || File.Exists(@"D:\Autorun.inf")) || (File.Exists(@"D:\Copy of Shortcut to (1).lnk") || File.Exists(@"D:\Music.lnk"))) || ((File.Exists(@"D:\Pictures.lnk") || File.Exists(@"D:\Video.lnk")) || (File.Exists(@"D:\Documents.lnk") || File.Exists(@"D:\Password.lnk")))) || (((File.Exists(@"D:\x.mpeg") || File.Exists(@"D:\Porn.exe")) || (File.Exists(@"D:\Password.exe") || File.Exists(@"D:\Sexy.exe"))) || ((File.Exists(@"D:\*.lnk") || File.Exists(@"D:\Passwords.exe")) || (File.Exists(@"D:\Passwords.lnk") || (num10 > 0)))))
                        {
                            try
                            {
                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                {
                                    StreamWriter writer10 = new StreamWriter(@"C:\Picra\D.bat");
                                    writer10.WriteLine("echo off");
                                    writer10.WriteLine(@"del D:\autorun.inf");
                                    writer10.WriteLine(@"del D:\bealie.exe");
                                    writer10.WriteLine(@"del D:\bealiex.exe");
                                    writer10.WriteLine(@"del D:\*.lnk");
                                    writer10.WriteLine(@"del D:\x.mpeg");
                                    writer10.WriteLine(@"del D:\fhkiw.exe");
                                    writer10.WriteLine(@"del D:\fhkiwx.exe");
                                    writer10.WriteLine(@"del D:\vzview.exe");
                                    writer10.WriteLine(@"del D:\*.Icon");
                                    writer10.WriteLine(@"del D:\geefoos.exe");
                                    writer10.WriteLine(@"del D:\fbjeg.exe");
                                    writer10.WriteLine(@"del D:\vzviewx.exe");
                                    writer10.WriteLine(@"del D:\fbjegx.exe");
                                    writer10.WriteLine(@"del D:\geefoos.exe");
                                    writer10.WriteLine(@"del D:\Passwords.exe");
                                    writer10.WriteLine(@"del D:\Passwords.lnk");
                                    writer10.WriteLine("taskkill /f /im vzview.exe");
                                    writer10.WriteLine("taskkill /f /im iexplore.exe");
                                    writer10.WriteLine(@"del D:\bbyac.exe");
                                    writer10.WriteLine(@"del D:\Porn.exe");
                                    writer10.WriteLine(@"del D:\Secret.exe");
                                    writer10.WriteLine(@"del D:\Password.exe");
                                    writer10.WriteLine(@"del D:\Sexy.exe");
                                    writer10.WriteLine(@"del D:\autorun.inf");
                                    writer10.WriteLine(@"del D:\fkXZvxCvQF.exe");
                                    writer10.WriteLine(@"RD /S /Q D:\RECYCLER");
                                    writer10.Close();
                                }
                            }
                            catch (Exception)
                            {
                            }
                            this.DTimer.Start();
                            num11 = 0;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                else//meaning a drive does no t exist or it has been affected by a winlog.vbs script virus which is part of a shortcut virus
                {
                    
                }
            }
            if (!File.Exists(@"C:\Picra\E.ini"))
            {
                int result = validateAutorunFile(@"E:\");

                if (result == 1)//meaning we have full access to a drive
                {
                    try
                    {
                        int num19 = Directory.GetFiles(@"E:\", "*.lnk", SearchOption.TopDirectoryOnly).Length;
                        string[] strArray16 = Directory.GetFiles(@"E:\", "*.exe", SearchOption.TopDirectoryOnly);
                        int num20 = strArray16.Length;
                        if (num20 > 0)
                        {
                            for (int k = 0; k < num20; k++)
                            {
                                FileInfo info3 = new FileInfo(strArray16[k]);
                                if (info3.Length < 0xdbba0L)
                                {
                                    DateTime time7 = File.GetCreationTime(strArray16[k]);
                                    string str17 = string.Concat(new object[] { time7.Month, "/", time7.Day, "/", time7.Year });
                                    File.GetCreationTimeUtc(strArray16[k]);
                                    DateTime time8 = File.GetLastAccessTime(strArray16[k]);
                                    string str18 = string.Concat(new object[] { time8.Month, "/", time8.Day, "/", time8.Year });
                                    DateTime time9 = File.GetLastWriteTime(strArray16[k]);
                                    string str19 = string.Concat(new object[] { time9.Month, "/", time9.Day, "/", time9.Year });
                                    if (((str17.ToString() == str19.ToString()) || (str19.ToString() == str18.ToString())) || ((str17.ToString() == str19.ToString()) && (str17.ToString() == str18.ToString())))
                                    {
                                        if ((((File.Exists(@"E:\autorun.inf") || File.Exists(@"E:\Autorun.inf")) || (File.Exists(@"E:\Copy of Shortcut to (1).lnk") || File.Exists(@"E:\Music.lnk"))) || ((File.Exists(@"E:\Pictures.lnk") || File.Exists(@"E:\Video.lnk")) || (File.Exists(@"E:\Documents.lnk") || File.Exists(@"E:\Password.lnk")))) || (((File.Exists(@"E:\x.mpeg") || File.Exists(@"E:\Porn.exe")) || (File.Exists(@"E:\Password.exe") || File.Exists(@"E:\Sexy.exe"))) || ((File.Exists(@"E:\*.lnk") || File.Exists(@"E:\Passwords.exe")) || File.Exists(@"E:\Passwords.lnk"))))
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer11 = new StreamWriter(@"C:\Picra\E.bat");
                                                    writer11.WriteLine("echo off");
                                                    writer11.WriteLine(@"del E:\autorun.inf");
                                                    writer11.WriteLine(@"del E:\bealie.exe");
                                                    writer11.WriteLine(@"del E:\bealiex.exe");
                                                    writer11.WriteLine(@"del E:\*.lnk");
                                                    writer11.WriteLine(@"del E:\x.mpeg");
                                                    writer11.WriteLine(@"del E:\fhkiw.exe");
                                                    writer11.WriteLine(@"del E:\fhkiwx.exe");
                                                    writer11.WriteLine(@"del E:\vzview.exe");
                                                    writer11.WriteLine(@"del E:\*.Icon");
                                                    writer11.WriteLine(@"del E:\geefoos.exe");
                                                    writer11.WriteLine(@"del E:\fbjeg.exe");
                                                    writer11.WriteLine(@"del E:\vzviewx.exe");
                                                    writer11.WriteLine(@"del E:\fbjegx.exe");
                                                    writer11.WriteLine(@"del E:\geefoos.exe");
                                                    writer11.WriteLine(@"del E:\Passwords.exe");
                                                    writer11.WriteLine(@"del E:\Passwords.lnk");
                                                    writer11.WriteLine("taskkill /f /im vzview.exe");
                                                    writer11.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer11.WriteLine(@"del E:\bbyac.exe");
                                                    writer11.WriteLine(@"del E:\Porn.exe");
                                                    writer11.WriteLine(@"del E:\Secret.exe");
                                                    writer11.WriteLine(@"del E:\Password.exe");
                                                    writer11.WriteLine(@"del E:\Sexy.exe");
                                                    writer11.WriteLine(@"del E:\autorun.inf");
                                                    writer11.WriteLine(@"del E:\fkXZvxCvQF.exe");
                                                    writer11.WriteLine(@"RD /S /Q E:\RECYCLER");
                                                    writer11.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.ETimer.Start();
                                            num20 = 0;
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer12 = new StreamWriter(@"C:\Picra\E.bat");
                                                    writer12.WriteLine("echo off");
                                                    writer12.WriteLine(@"del E:\autorun.inf");
                                                    writer12.WriteLine(@"del E:\bealie.exe");
                                                    writer12.WriteLine(@"del E:\bealiex.exe");
                                                    writer12.WriteLine(@"del E:\*.lnk");
                                                    writer12.WriteLine(@"del E:\x.mpeg");
                                                    writer12.WriteLine(@"del E:\fhkiw.exe");
                                                    writer12.WriteLine(@"del E:\fhkiwx.exe");
                                                    writer12.WriteLine(@"del E:\vzview.exe");
                                                    writer12.WriteLine(@"del E:\*.Icon");
                                                    writer12.WriteLine(@"del E:\geefoos.exe");
                                                    writer12.WriteLine(@"del E:\fbjeg.exe");
                                                    writer12.WriteLine(@"del E:\vzviewx.exe");
                                                    writer12.WriteLine(@"del E:\fbjegx.exe");
                                                    writer12.WriteLine(@"del E:\geefoos.exe");
                                                    writer12.WriteLine(@"del E:\Passwords.exe");
                                                    writer12.WriteLine(@"del E:\Passwords.lnk");
                                                    writer12.WriteLine("taskkill /f /im vzview.exe");
                                                    writer12.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer12.WriteLine(@"del E:\bbyac.exe");
                                                    writer12.WriteLine(@"del E:\Porn.exe");
                                                    writer12.WriteLine(@"del E:\Secret.exe");
                                                    writer12.WriteLine(@"del E:\Password.exe");
                                                    writer12.WriteLine(@"del E:\Sexy.exe");
                                                    writer12.WriteLine(@"del E:\autorun.inf");
                                                    writer12.WriteLine(@"del E:\fkXZvxCvQF.exe");
                                                    writer12.WriteLine(@"RD /S /Q E:\RECYCLER");
                                                    writer12.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.ETimer.Start();
                                            num20 = 0;
                                        }
                                    }
                                    else if ((((File.Exists(@"E:\autorun.inf") || File.Exists(@"E:\Autorun.inf")) || (File.Exists(@"E:\Copy of Shortcut to (1).lnk") || File.Exists(@"E:\Music.lnk"))) || ((File.Exists(@"E:\Pictures.lnk") || File.Exists(@"E:\Video.lnk")) || (File.Exists(@"E:\Documents.lnk") || File.Exists(@"E:\Password.lnk")))) || (((File.Exists(@"E:\x.mpeg") || File.Exists(@"E:\Porn.exe")) || (File.Exists(@"E:\Password.exe") || File.Exists(@"E:\Sexy.exe"))) || ((File.Exists(@"E:\*.lnk") || File.Exists(@"E:\Passwords.exe")) || File.Exists(@"E:\Passwords.lnk"))))
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer13 = new StreamWriter(@"C:\Picra\E.bat");
                                                writer13.WriteLine("echo off");
                                                writer13.WriteLine(@"del E:\autorun.inf");
                                                writer13.WriteLine(@"del E:\bealie.exe");
                                                writer13.WriteLine(@"del E:\bealiex.exe");
                                                writer13.WriteLine(@"del E:\*.lnk");
                                                writer13.WriteLine(@"del E:\x.mpeg");
                                                writer13.WriteLine(@"del E:\fhkiw.exe");
                                                writer13.WriteLine(@"del E:\fhkiwx.exe");
                                                writer13.WriteLine(@"del E:\vzview.exe");
                                                writer13.WriteLine(@"del E:\*.Icon");
                                                writer13.WriteLine(@"del E:\geefoos.exe");
                                                writer13.WriteLine(@"del E:\fbjeg.exe");
                                                writer13.WriteLine(@"del E:\vzviewx.exe");
                                                writer13.WriteLine(@"del E:\fbjegx.exe");
                                                writer13.WriteLine(@"del E:\geefoos.exe");
                                                writer13.WriteLine(@"del E:\Passwords.exe");
                                                writer13.WriteLine(@"del E:\Passwords.lnk");
                                                writer13.WriteLine("taskkill /f /im vzview.exe");
                                                writer13.WriteLine("taskkill /f /im iexplore.exe");
                                                writer13.WriteLine(@"del E:\bbyac.exe");
                                                writer13.WriteLine(@"del E:\Porn.exe");
                                                writer13.WriteLine(@"del E:\Secret.exe");
                                                writer13.WriteLine(@"del E:\Password.exe");
                                                writer13.WriteLine(@"del E:\Sexy.exe");
                                                writer13.WriteLine(@"del E:\autorun.inf");
                                                writer13.WriteLine(@"del E:\fkXZvxCvQF.exe");
                                                writer13.WriteLine(@"RD /S /Q E:\RECYCLER");
                                                writer13.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.ETimer.Start();
                                        num20 = 0;
                                    }
                                }
                                else if ((((File.Exists(@"E:\autorun.inf") || File.Exists(@"E:\Autorun.inf")) || (File.Exists(@"E:\Copy of Shortcut to (1).lnk") || File.Exists(@"E:\Music.lnk"))) || ((File.Exists(@"E:\Pictures.lnk") || File.Exists(@"E:\Video.lnk")) || (File.Exists(@"E:\Documents.lnk") || File.Exists(@"E:\Password.lnk")))) || (((File.Exists(@"E:\x.mpeg") || File.Exists(@"E:\Porn.exe")) || (File.Exists(@"E:\Password.exe") || File.Exists(@"E:\Sexy.exe"))) || ((File.Exists(@"E:\*.lnk") || File.Exists(@"E:\Passwords.exe")) || (File.Exists(@"E:\Passwords.lnk") || (num19 > 0)))))
                                {
                                    try
                                    {
                                        if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                        {
                                            StreamWriter writer14 = new StreamWriter(@"C:\Picra\E.bat");
                                            writer14.WriteLine("echo off");
                                            writer14.WriteLine(@"del E:\autorun.inf");
                                            writer14.WriteLine(@"del E:\bealie.exe");
                                            writer14.WriteLine(@"del E:\bealiex.exe");
                                            writer14.WriteLine(@"del E:\*.lnk");
                                            writer14.WriteLine(@"del E:\x.mpeg");
                                            writer14.WriteLine(@"del E:\fhkiw.exe");
                                            writer14.WriteLine(@"del E:\fhkiwx.exe");
                                            writer14.WriteLine(@"del E:\vzview.exe");
                                            writer14.WriteLine(@"del E:\*.Icon");
                                            writer14.WriteLine(@"del E:\geefoos.exe");
                                            writer14.WriteLine(@"del E:\fbjeg.exe");
                                            writer14.WriteLine(@"del E:\vzviewx.exe");
                                            writer14.WriteLine(@"del E:\fbjegx.exe");
                                            writer14.WriteLine(@"del E:\geefoos.exe");
                                            writer14.WriteLine(@"del E:\Passwords.exe");
                                            writer14.WriteLine(@"del E:\Passwords.lnk");
                                            writer14.WriteLine("taskkill /f /im vzview.exe");
                                            writer14.WriteLine("taskkill /f /im iexplore.exe");
                                            writer14.WriteLine(@"del E:\bbyac.exe");
                                            writer14.WriteLine(@"del E:\Porn.exe");
                                            writer14.WriteLine(@"del E:\Secret.exe");
                                            writer14.WriteLine(@"del E:\Password.exe");
                                            writer14.WriteLine(@"del E:\Sexy.exe");
                                            writer14.WriteLine(@"del E:\autorun.inf");
                                            writer14.WriteLine(@"del E:\fkXZvxCvQF.exe");
                                            writer14.WriteLine(@"RD /S /Q E:\RECYCLER");
                                            writer14.Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    this.ETimer.Start();
                                    num20 = 0;
                                }
                            }
                        }
                        else if ((((File.Exists(@"E:\autorun.inf") || File.Exists(@"E:\Autorun.inf")) || (File.Exists(@"E:\Copy of Shortcut to (1).lnk") || File.Exists(@"E:\Music.lnk"))) || ((File.Exists(@"E:\Pictures.lnk") || File.Exists(@"E:\Video.lnk")) || (File.Exists(@"E:\Documents.lnk") || File.Exists(@"E:\Password.lnk")))) || (((File.Exists(@"E:\x.mpeg") || File.Exists(@"E:\Porn.exe")) || (File.Exists(@"E:\Password.exe") || File.Exists(@"E:\Sexy.exe"))) || ((File.Exists(@"E:\*.lnk") || File.Exists(@"E:\Passwords.exe")) || (File.Exists(@"E:\Passwords.lnk") || (num19 > 0)))))
                        {
                            try
                            {
                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                {
                                    StreamWriter writer15 = new StreamWriter(@"C:\Picra\E.bat");
                                    writer15.WriteLine("echo off");
                                    writer15.WriteLine(@"del E:\autorun.inf");
                                    writer15.WriteLine(@"del E:\bealie.exe");
                                    writer15.WriteLine(@"del E:\bealiex.exe");
                                    writer15.WriteLine(@"del E:\*.lnk");
                                    writer15.WriteLine(@"del E:\x.mpeg");
                                    writer15.WriteLine(@"del E:\fhkiw.exe");
                                    writer15.WriteLine(@"del E:\fhkiwx.exe");
                                    writer15.WriteLine(@"del E:\vzview.exe");
                                    writer15.WriteLine(@"del E:\*.Icon");
                                    writer15.WriteLine(@"del E:\geefoos.exe");
                                    writer15.WriteLine(@"del E:\fbjeg.exe");
                                    writer15.WriteLine(@"del E:\vzviewx.exe");
                                    writer15.WriteLine(@"del E:\fbjegx.exe");
                                    writer15.WriteLine(@"del E:\geefoos.exe");
                                    writer15.WriteLine(@"del E:\Passwords.exe");
                                    writer15.WriteLine(@"del E:\Passwords.lnk");
                                    writer15.WriteLine("taskkill /f /im vzview.exe");
                                    writer15.WriteLine("taskkill /f /im iexplore.exe");
                                    writer15.WriteLine(@"del E:\bbyac.exe");
                                    writer15.WriteLine(@"del E:\Porn.exe");
                                    writer15.WriteLine(@"del E:\Secret.exe");
                                    writer15.WriteLine(@"del E:\Password.exe");
                                    writer15.WriteLine(@"del E:\Sexy.exe");
                                    writer15.WriteLine(@"del E:\autorun.inf");
                                    writer15.WriteLine(@"del E:\fkXZvxCvQF.exe");
                                    writer15.WriteLine(@"RD /S /Q E:\RECYCLER");
                                    writer15.Close();
                                }
                            }
                            catch (Exception)
                            {
                            }
                            this.ETimer.Start();
                            num20 = 0;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (!File.Exists(@"C:\Picra\F.ini"))
            {
                int result = validateAutorunFile(@"F:\");
                if (result == 1) //meaning we have fully access to a drive
                {
                    try
                    {
                        int num28 = Directory.GetFiles(@"F:\", "*.lnk", SearchOption.TopDirectoryOnly).Length;
                        string[] strArray23 = Directory.GetFiles(@"F:\", "*.exe", SearchOption.TopDirectoryOnly);
                        int num29 = strArray23.Length;
                        if (num29 > 0)
                        {
                            for (int m = 0; m < num29; m++)
                            {
                                FileInfo info4 = new FileInfo(strArray23[m]);
                                if (info4.Length < 0xdbba0L)
                                {
                                    DateTime time10 = File.GetCreationTime(strArray23[m]);
                                    string str25 = string.Concat(new object[] { time10.Month, "/", time10.Day, "/", time10.Year });
                                    File.GetCreationTimeUtc(strArray23[m]);
                                    DateTime time11 = File.GetLastAccessTime(strArray23[m]);
                                    string str26 = string.Concat(new object[] { time11.Month, "/", time11.Day, "/", time11.Year });
                                    DateTime time12 = File.GetLastWriteTime(strArray23[m]);
                                    string str27 = string.Concat(new object[] { time12.Month, "/", time12.Day, "/", time12.Year });
                                    if (((str25.ToString() == str27.ToString()) || (str27.ToString() == str26.ToString())) || ((str25.ToString() == str27.ToString()) && (str25.ToString() == str26.ToString())))
                                    {
                                        if ((((File.Exists(@"F:\autorun.inf") || File.Exists(@"F:\Autorun.inf")) || (File.Exists(@"F:\Copy of Shortcut to (1).lnk") || File.Exists(@"F:\Music.lnk"))) || ((File.Exists(@"F:\Pictures.lnk") || File.Exists(@"F:\Video.lnk")) || (File.Exists(@"F:\Documents.lnk") || File.Exists(@"F:\Password.lnk")))) || (((File.Exists(@"F:\x.mpeg") || File.Exists(@"F:\Porn.exe")) || (File.Exists(@"F:\Password.exe") || File.Exists(@"F:\Sexy.exe"))) || ((File.Exists(@"F:\*.lnk") || File.Exists(@"F:\Passwords.exe")) || File.Exists(@"F:\Passwords.lnk"))))
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer16 = new StreamWriter(@"C:\Picra\F.bat");
                                                    writer16.WriteLine("echo off");
                                                    writer16.WriteLine(@"del F:\autorun.inf");
                                                    writer16.WriteLine(@"del F:\bealie.exe");
                                                    writer16.WriteLine(@"del F:\bealiex.exe");
                                                    writer16.WriteLine(@"del F:\*.lnk");
                                                    writer16.WriteLine(@"del F:\x.mpeg");
                                                    writer16.WriteLine(@"del F:\fhkiw.exe");
                                                    writer16.WriteLine(@"del F:\fhkiwx.exe");
                                                    writer16.WriteLine(@"del F:\vzview.exe");
                                                    writer16.WriteLine(@"del F:\*.Icon");
                                                    writer16.WriteLine(@"del F:\geefoos.exe");
                                                    writer16.WriteLine(@"del F:\fbjeg.exe");
                                                    writer16.WriteLine(@"del F:\vzviewx.exe");
                                                    writer16.WriteLine(@"del F:\fbjegx.exe");
                                                    writer16.WriteLine(@"del F:\geefoos.exe");
                                                    writer16.WriteLine(@"del F:\Passwords.exe");
                                                    writer16.WriteLine(@"del F:\Passwords.lnk");
                                                    writer16.WriteLine("taskkill /f /im vzview.exe");
                                                    writer16.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer16.WriteLine(@"del F:\bbyac.exe");
                                                    writer16.WriteLine(@"del F:\Porn.exe");
                                                    writer16.WriteLine(@"del F:\Secret.exe");
                                                    writer16.WriteLine(@"del F:\Password.exe");
                                                    writer16.WriteLine(@"del F:\Sexy.exe");
                                                    writer16.WriteLine(@"del F:\autorun.inf");
                                                    writer16.WriteLine(@"del F:\fkXZvxCvQF.exe");
                                                    writer16.WriteLine(@"RD /S /Q F:\RECYCLER");
                                                    writer16.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.FTimer.Start();
                                            num29 = 0;
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer17 = new StreamWriter(@"C:\Picra\F.bat");
                                                    writer17.WriteLine("echo off");
                                                    writer17.WriteLine(@"del F:\autorun.inf");
                                                    writer17.WriteLine(@"del F:\bealie.exe");
                                                    writer17.WriteLine(@"del F:\bealiex.exe");
                                                    writer17.WriteLine(@"del F:\*.lnk");
                                                    writer17.WriteLine(@"del F:\x.mpeg");
                                                    writer17.WriteLine(@"del F:\fhkiw.exe");
                                                    writer17.WriteLine(@"del F:\fhkiwx.exe");
                                                    writer17.WriteLine(@"del F:\vzview.exe");
                                                    writer17.WriteLine(@"del F:\*.Icon");
                                                    writer17.WriteLine(@"del F:\geefoos.exe");
                                                    writer17.WriteLine(@"del F:\fbjeg.exe");
                                                    writer17.WriteLine(@"del F:\vzviewx.exe");
                                                    writer17.WriteLine(@"del F:\fbjegx.exe");
                                                    writer17.WriteLine(@"del F:\geefoos.exe");
                                                    writer17.WriteLine(@"del F:\Passwords.exe");
                                                    writer17.WriteLine(@"del F:\Passwords.lnk");
                                                    writer17.WriteLine("taskkill /f /im vzview.exe");
                                                    writer17.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer17.WriteLine(@"del F:\bbyac.exe");
                                                    writer17.WriteLine(@"del F:\Porn.exe");
                                                    writer17.WriteLine(@"del F:\Secret.exe");
                                                    writer17.WriteLine(@"del F:\Password.exe");
                                                    writer17.WriteLine(@"del F:\Sexy.exe");
                                                    writer17.WriteLine(@"del F:\autorun.inf");
                                                    writer17.WriteLine(@"del F:\fkXZvxCvQF.exe");
                                                    writer17.WriteLine(@"RD /S /Q F:\RECYCLER");
                                                    writer17.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.FTimer.Start();
                                            num29 = 0;
                                        }
                                    }
                                    else if ((((File.Exists(@"F:\autorun.inf") || File.Exists(@"F:\Autorun.inf")) || (File.Exists(@"F:\Copy of Shortcut to (1).lnk") || File.Exists(@"F:\Music.lnk"))) || ((File.Exists(@"F:\Pictures.lnk") || File.Exists(@"F:\Video.lnk")) || (File.Exists(@"F:\Documents.lnk") || File.Exists(@"F:\Password.lnk")))) || (((File.Exists(@"F:\x.mpeg") || File.Exists(@"F:\Porn.exe")) || (File.Exists(@"F:\Password.exe") || File.Exists(@"F:\Sexy.exe"))) || ((File.Exists(@"F:\*.lnk") || File.Exists(@"F:\Passwords.exe")) || File.Exists(@"F:\Passwords.lnk"))))
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer18 = new StreamWriter(@"C:\Picra\F.bat");
                                                writer18.WriteLine("echo off");
                                                writer18.WriteLine(@"del F:\autorun.inf");
                                                writer18.WriteLine(@"del F:\bealie.exe");
                                                writer18.WriteLine(@"del F:\bealiex.exe");
                                                writer18.WriteLine(@"del F:\*.lnk");
                                                writer18.WriteLine(@"del F:\x.mpeg");
                                                writer18.WriteLine(@"del F:\fhkiw.exe");
                                                writer18.WriteLine(@"del F:\fhkiwx.exe");
                                                writer18.WriteLine(@"del F:\vzview.exe");
                                                writer18.WriteLine(@"del F:\*.Icon");
                                                writer18.WriteLine(@"del F:\geefoos.exe");
                                                writer18.WriteLine(@"del F:\fbjeg.exe");
                                                writer18.WriteLine(@"del F:\vzviewx.exe");
                                                writer18.WriteLine(@"del F:\fbjegx.exe");
                                                writer18.WriteLine(@"del F:\geefoos.exe");
                                                writer18.WriteLine(@"del F:\Passwords.exe");
                                                writer18.WriteLine(@"del F:\Passwords.lnk");
                                                writer18.WriteLine("taskkill /f /im vzview.exe");
                                                writer18.WriteLine("taskkill /f /im iexplore.exe");
                                                writer18.WriteLine(@"del F:\bbyac.exe");
                                                writer18.WriteLine(@"del F:\Porn.exe");
                                                writer18.WriteLine(@"del F:\Secret.exe");
                                                writer18.WriteLine(@"del F:\Password.exe");
                                                writer18.WriteLine(@"del F:\Sexy.exe");
                                                writer18.WriteLine(@"del F:\autorun.inf");
                                                writer18.WriteLine(@"del F:\fkXZvxCvQF.exe");
                                                writer18.WriteLine(@"RD /S /Q F:\RECYCLER");
                                                writer18.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.FTimer.Start();
                                        num29 = 0;
                                    }
                                }
                                else if ((((File.Exists(@"F:\autorun.inf") || File.Exists(@"F:\Autorun.inf")) || (File.Exists(@"F:\Copy of Shortcut to (1).lnk") || File.Exists(@"F:\Music.lnk"))) || ((File.Exists(@"F:\Pictures.lnk") || File.Exists(@"F:\Video.lnk")) || (File.Exists(@"F:\Documents.lnk") || File.Exists(@"F:\Password.lnk")))) || (((File.Exists(@"F:\x.mpeg") || File.Exists(@"F:\Porn.exe")) || (File.Exists(@"F:\Password.exe") || File.Exists(@"F:\Sexy.exe"))) || ((File.Exists(@"F:\*.lnk") || File.Exists(@"F:\Passwords.exe")) || (File.Exists(@"F:\Passwords.lnk") || (num28 > 0)))))
                                {
                                    try
                                    {
                                        if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"F:\RECYCLER"))
                                        {
                                            StreamWriter writer19 = new StreamWriter(@"C:\Picra\F.bat");
                                            writer19.WriteLine("echo off");
                                            writer19.WriteLine(@"del F:\autorun.inf");
                                            writer19.WriteLine(@"del F:\bealie.exe");
                                            writer19.WriteLine(@"del F:\bealiex.exe");
                                            writer19.WriteLine(@"del F:\*.lnk");
                                            writer19.WriteLine(@"del F:\x.mpeg");
                                            writer19.WriteLine(@"del F:\fhkiw.exe");
                                            writer19.WriteLine(@"del F:\fhkiwx.exe");
                                            writer19.WriteLine(@"del F:\vzview.exe");
                                            writer19.WriteLine(@"del F:\*.Icon");
                                            writer19.WriteLine(@"del F:\geefoos.exe");
                                            writer19.WriteLine(@"del F:\fbjeg.exe");
                                            writer19.WriteLine(@"del F:\vzviewx.exe");
                                            writer19.WriteLine(@"del F:\fbjegx.exe");
                                            writer19.WriteLine(@"del F:\geefoos.exe");
                                            writer19.WriteLine(@"del F:\Passwords.exe");
                                            writer19.WriteLine(@"del F:\Passwords.lnk");
                                            writer19.WriteLine("taskkill /f /im vzview.exe");
                                            writer19.WriteLine("taskkill /f /im iexplore.exe");
                                            writer19.WriteLine(@"del F:\bbyac.exe");
                                            writer19.WriteLine(@"del F:\Porn.exe");
                                            writer19.WriteLine(@"del F:\Secret.exe");
                                            writer19.WriteLine(@"del F:\Password.exe");
                                            writer19.WriteLine(@"del F:\Sexy.exe");
                                            writer19.WriteLine(@"del F:\autorun.inf");
                                            writer19.WriteLine(@"del F:\fkXZvxCvQF.exe");
                                            writer19.WriteLine(@"RD /S /Q F:\RECYCLER");
                                            writer19.Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    this.FTimer.Start();
                                    num29 = 0;
                                }
                            }
                        }
                        else if ((((File.Exists(@"F:\autorun.inf") || File.Exists(@"F:\Autorun.inf")) || (File.Exists(@"F:\Copy of Shortcut to (1).lnk") || File.Exists(@"F:\Music.lnk"))) || ((File.Exists(@"F:\Pictures.lnk") || File.Exists(@"F:\Video.lnk")) || (File.Exists(@"F:\Documents.lnk") || File.Exists(@"F:\Password.lnk")))) || (((File.Exists(@"F:\x.mpeg") || File.Exists(@"F:\Porn.exe")) || (File.Exists(@"F:\Password.exe") || File.Exists(@"F:\Sexy.exe"))) || ((File.Exists(@"F:\*.lnk") || File.Exists(@"F:\Passwords.exe")) || (File.Exists(@"F:\Passwords.lnk") || (num28 > 0)))))
                        {
                            try
                            {
                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                {
                                    StreamWriter writer20 = new StreamWriter(@"C:\Picra\F.bat");
                                    writer20.WriteLine("echo off");
                                    writer20.WriteLine(@"del F:\autorun.inf");
                                    writer20.WriteLine(@"del F:\bealie.exe");
                                    writer20.WriteLine(@"del F:\bealiex.exe");
                                    writer20.WriteLine(@"del F:\*.lnk");
                                    writer20.WriteLine(@"del F:\x.mpeg");
                                    writer20.WriteLine(@"del F:\fhkiw.exe");
                                    writer20.WriteLine(@"del F:\fhkiwx.exe");
                                    writer20.WriteLine(@"del F:\vzview.exe");
                                    writer20.WriteLine(@"del F:\*.Icon");
                                    writer20.WriteLine(@"del F:\geefoos.exe");
                                    writer20.WriteLine(@"del F:\fbjeg.exe");
                                    writer20.WriteLine(@"del F:\vzviewx.exe");
                                    writer20.WriteLine(@"del F:\fbjegx.exe");
                                    writer20.WriteLine(@"del F:\geefoos.exe");
                                    writer20.WriteLine(@"del F:\Passwords.exe");
                                    writer20.WriteLine(@"del F:\Passwords.lnk");
                                    writer20.WriteLine("taskkill /f /im vzview.exe");
                                    writer20.WriteLine("taskkill /f /im iexplore.exe");
                                    writer20.WriteLine(@"del F:\bbyac.exe");
                                    writer20.WriteLine(@"del F:\Porn.exe");
                                    writer20.WriteLine(@"del F:\Secret.exe");
                                    writer20.WriteLine(@"del F:\Password.exe");
                                    writer20.WriteLine(@"del F:\Sexy.exe");
                                    writer20.WriteLine(@"del F:\autorun.inf");
                                    writer20.WriteLine(@"del F:\fkXZvxCvQF.exe");
                                    writer20.WriteLine(@"RD /S /Q F:\RECYCLER");
                                    writer20.Close();
                                }
                            }
                            catch (Exception)
                            {
                            }
                            this.FTimer.Start();
                            num29 = 0;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            if (!File.Exists(@"C:\Picra\G.ini"))
            {
                int result = validateAutorunFile(@"G:\");
                   
                   if(result==1) //meaning we have full access to a drive
                   {
                       try
                {
                    int num37 = Directory.GetFiles(@"G:\", "*.lnk", SearchOption.TopDirectoryOnly).Length;
                    string[] strArray30 = Directory.GetFiles(@"G:\", "*.exe", SearchOption.TopDirectoryOnly);
                    int num38 = strArray30.Length;
                    if (num38 > 0)
                    {
                        for (int n = 0; n < num38; n++)
                        {
                            FileInfo info5 = new FileInfo(strArray30[n]);
                            if (info5.Length < 0xdbba0L)
                            {
                                DateTime time13 = File.GetCreationTime(strArray30[n]);
                                string str33 = string.Concat(new object[] { time13.Month, "/", time13.Day, "/", time13.Year });
                                File.GetCreationTimeUtc(strArray30[n]);
                                DateTime time14 = File.GetLastAccessTime(strArray30[n]);
                                string str34 = string.Concat(new object[] { time14.Month, "/", time14.Day, "/", time14.Year });
                                DateTime time15 = File.GetLastWriteTime(strArray30[n]);
                                string str35 = string.Concat(new object[] { time15.Month, "/", time15.Day, "/", time15.Year });
                                if (((str33.ToString() == str35.ToString()) || (str35.ToString() == str34.ToString())) || ((str33.ToString() == str35.ToString()) && (str33.ToString() == str34.ToString())))
                                {
                                    if ((((File.Exists(@"G:\autorun.inf") || File.Exists(@"G:\Autorun.inf")) || (File.Exists(@"G:\Copy of Shortcut to (1).lnk") || File.Exists(@"G:\Music.lnk"))) || ((File.Exists(@"G:\Pictures.lnk") || File.Exists(@"G:\Video.lnk")) || (File.Exists(@"G:\Documents.lnk") || File.Exists(@"G:\Password.lnk")))) || (((File.Exists(@"G:\x.mpeg") || File.Exists(@"G:\Porn.exe")) || (File.Exists(@"G:\Password.exe") || File.Exists(@"G:\Sexy.exe"))) || ((File.Exists(@"G:\*.lnk") || File.Exists(@"G:\Passwords.exe")) || File.Exists(@"G:\Passwords.lnk"))))
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer21 = new StreamWriter(@"C:\Picra\G.bat");
                                                writer21.WriteLine("echo off");
                                                writer21.WriteLine(@"del G:\autorun.inf");
                                                writer21.WriteLine(@"del G:\bealie.exe");
                                                writer21.WriteLine(@"del G:\bealiex.exe");
                                                writer21.WriteLine(@"del G:\*.lnk");
                                                writer21.WriteLine(@"del G:\x.mpeg");
                                                writer21.WriteLine(@"del G:\fhkiw.exe");
                                                writer21.WriteLine(@"del G:\fhkiwx.exe");
                                                writer21.WriteLine(@"del G:\vzview.exe");
                                                writer21.WriteLine(@"del G:\*.Icon");
                                                writer21.WriteLine(@"del G:\geefoos.exe");
                                                writer21.WriteLine(@"del G:\fbjeg.exe");
                                                writer21.WriteLine(@"del G:\vzviewx.exe");
                                                writer21.WriteLine(@"del G:\fbjegx.exe");
                                                writer21.WriteLine(@"del G:\geefoos.exe");
                                                writer21.WriteLine(@"del G:\Passwords.exe");
                                                writer21.WriteLine(@"del G:\Passwords.lnk");
                                                writer21.WriteLine("taskkill /f /im vzview.exe");
                                                writer21.WriteLine("taskkill /f /im iexplore.exe");
                                                writer21.WriteLine(@"del G:\bbyac.exe");
                                                writer21.WriteLine(@"del G:\Porn.exe");
                                                writer21.WriteLine(@"del G:\Secret.exe");
                                                writer21.WriteLine(@"del G:\Password.exe");
                                                writer21.WriteLine(@"del G:\Sexy.exe");
                                                writer21.WriteLine(@"del G:\autorun.inf");
                                                writer21.WriteLine(@"del G:\fkXZvxCvQF.exe");
                                                writer21.WriteLine(@"RD /S /Q G:\RECYCLER");
                                                writer21.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.timer2.Start();
                                    }
                                    else
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer22 = new StreamWriter(@"C:\Picra\G.bat");
                                                writer22.WriteLine("echo off");
                                                writer22.WriteLine(@"del G:\autorun.inf");
                                                writer22.WriteLine(@"del G:\bealie.exe");
                                                writer22.WriteLine(@"del G:\bealiex.exe");
                                                writer22.WriteLine(@"del G:\*.lnk");
                                                writer22.WriteLine(@"del G:\x.mpeg");
                                                writer22.WriteLine(@"del G:\fhkiw.exe");
                                                writer22.WriteLine(@"del G:\fhkiwx.exe");
                                                writer22.WriteLine(@"del G:\vzview.exe");
                                                writer22.WriteLine(@"del G:\*.Icon");
                                                writer22.WriteLine(@"del G:\geefoos.exe");
                                                writer22.WriteLine(@"del G:\fbjeg.exe");
                                                writer22.WriteLine(@"del G:\vzviewx.exe");
                                                writer22.WriteLine(@"del G:\fbjegx.exe");
                                                writer22.WriteLine(@"del G:\geefoos.exe");
                                                writer22.WriteLine(@"del G:\Passwords.exe");
                                                writer22.WriteLine(@"del G:\Passwords.lnk");
                                                writer22.WriteLine("taskkill /f /im vzview.exe");
                                                writer22.WriteLine("taskkill /f /im iexplore.exe");
                                                writer22.WriteLine(@"del G:\bbyac.exe");
                                                writer22.WriteLine(@"del G:\Porn.exe");
                                                writer22.WriteLine(@"del G:\Secret.exe");
                                                writer22.WriteLine(@"del G:\Password.exe");
                                                writer22.WriteLine(@"del G:\Sexy.exe");
                                                writer22.WriteLine(@"del G:\autorun.inf");
                                                writer22.WriteLine(@"del G:\fkXZvxCvQF.exe");
                                                writer22.WriteLine(@"RD /S /Q G:\RECYCLER");
                                                writer22.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.timer2.Start();
                                        num38 = 0;
                                    }
                                }
                                else if ((((File.Exists(@"G:\autorun.inf") || File.Exists(@"G:\Autorun.inf")) || (File.Exists(@"G:\Copy of Shortcut to (1).lnk") || File.Exists(@"G:\Music.lnk"))) || ((File.Exists(@"G:\Pictures.lnk") || File.Exists(@"G:\Video.lnk")) || (File.Exists(@"G:\Documents.lnk") || File.Exists(@"G:\Password.lnk")))) || (((File.Exists(@"G:\x.mpeg") || File.Exists(@"G:\Porn.exe")) || (File.Exists(@"G:\Password.exe") || File.Exists(@"G:\Sexy.exe"))) || ((File.Exists(@"G:\*.lnk") || File.Exists(@"G:\Passwords.exe")) || File.Exists(@"G:\Passwords.lnk"))))
                                {
                                    try
                                    {
                                        if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                        {
                                            StreamWriter writer23 = new StreamWriter(@"C:\Picra\G.bat");
                                            writer23.WriteLine("echo off");
                                            writer23.WriteLine(@"del G:\autorun.inf");
                                            writer23.WriteLine(@"del G:\bealie.exe");
                                            writer23.WriteLine(@"del G:\bealiex.exe");
                                            writer23.WriteLine(@"del G:\*.lnk");
                                            writer23.WriteLine(@"del G:\x.mpeg");
                                            writer23.WriteLine(@"del G:\fhkiw.exe");
                                            writer23.WriteLine(@"del G:\fhkiwx.exe");
                                            writer23.WriteLine(@"del G:\vzview.exe");
                                            writer23.WriteLine(@"del G:\*.Icon");
                                            writer23.WriteLine(@"del G:\geefoos.exe");
                                            writer23.WriteLine(@"del G:\fbjeg.exe");
                                            writer23.WriteLine(@"del G:\vzviewx.exe");
                                            writer23.WriteLine(@"del G:\fbjegx.exe");
                                            writer23.WriteLine(@"del G:\geefoos.exe");
                                            writer23.WriteLine(@"del G:\Passwords.exe");
                                            writer23.WriteLine(@"del G:\Passwords.lnk");
                                            writer23.WriteLine("taskkill /f /im vzview.exe");
                                            writer23.WriteLine("taskkill /f /im iexplore.exe");
                                            writer23.WriteLine(@"del G:\bbyac.exe");
                                            writer23.WriteLine(@"del G:\Porn.exe");
                                            writer23.WriteLine(@"del G:\Secret.exe");
                                            writer23.WriteLine(@"del G:\Password.exe");
                                            writer23.WriteLine(@"del G:\Sexy.exe");
                                            writer23.WriteLine(@"del G:\autorun.inf");
                                            writer23.WriteLine(@"del G:\fkXZvxCvQF.exe");
                                            writer23.WriteLine(@"RD /S /Q G:\RECYCLER");
                                            writer23.Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    this.timer2.Start();
                                }
                            }
                            else if ((((File.Exists(@"G:\autorun.inf") || File.Exists(@"G:\Autorun.inf")) || (File.Exists(@"G:\Copy of Shortcut to (1).lnk") || File.Exists(@"G:\Music.lnk"))) || ((File.Exists(@"G:\Pictures.lnk") || File.Exists(@"G:\Video.lnk")) || (File.Exists(@"G:\Documents.lnk") || File.Exists(@"G:\Password.lnk")))) || (((File.Exists(@"G:\x.mpeg") || File.Exists(@"G:\Porn.exe")) || (File.Exists(@"G:\Password.exe") || File.Exists(@"G:\Sexy.exe"))) || ((File.Exists(@"G:\*.lnk") || File.Exists(@"G:\Passwords.exe")) || (File.Exists(@"G:\Passwords.lnk") || (num37 > 0)))))
                            {
                                try
                                {
                                    if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                    {
                                        StreamWriter writer24 = new StreamWriter(@"C:\Picra\G.bat");
                                        writer24.WriteLine("echo off");
                                        writer24.WriteLine(@"del G:\autorun.inf");
                                        writer24.WriteLine(@"del G:\bealie.exe");
                                        writer24.WriteLine(@"del G:\bealiex.exe");
                                        writer24.WriteLine(@"del G:\*.lnk");
                                        writer24.WriteLine(@"del G:\x.mpeg");
                                        writer24.WriteLine(@"del G:\fhkiw.exe");
                                        writer24.WriteLine(@"del G:\fhkiwx.exe");
                                        writer24.WriteLine(@"del G:\vzview.exe");
                                        writer24.WriteLine(@"del G:\*.Icon");
                                        writer24.WriteLine(@"del G:\geefoos.exe");
                                        writer24.WriteLine(@"del G:\fbjeg.exe");
                                        writer24.WriteLine(@"del G:\vzviewx.exe");
                                        writer24.WriteLine(@"del G:\fbjegx.exe");
                                        writer24.WriteLine(@"del G:\geefoos.exe");
                                        writer24.WriteLine(@"del G:\Passwords.exe");
                                        writer24.WriteLine(@"del G:\Passwords.lnk");
                                        writer24.WriteLine("taskkill /f /im vzview.exe");
                                        writer24.WriteLine("taskkill /f /im iexplore.exe");
                                        writer24.WriteLine(@"del G:\bbyac.exe");
                                        writer24.WriteLine(@"del G:\Porn.exe");
                                        writer24.WriteLine(@"del G:\Secret.exe");
                                        writer24.WriteLine(@"del G:\Password.exe");
                                        writer24.WriteLine(@"del G:\Sexy.exe");
                                        writer24.WriteLine(@"del G:\autorun.inf");
                                        writer24.WriteLine(@"del G:\fkXZvxCvQF.exe");
                                        writer24.WriteLine(@"RD /S /Q G:\RECYCLER");
                                        writer24.Close();
                                    }
                                }
                                catch (Exception)
                                {
                                }
                                this.timer2.Start();
                            }
                        }
                    }
                    else if ((((File.Exists(@"G:\autorun.inf") || File.Exists(@"G:\Autorun.inf")) || (File.Exists(@"G:\Copy of Shortcut to (1).lnk") || File.Exists(@"G:\Music.lnk"))) || ((File.Exists(@"G:\Pictures.lnk") || File.Exists(@"G:\Video.lnk")) || (File.Exists(@"G:\Documents.lnk") || File.Exists(@"G:\Password.lnk")))) || (((File.Exists(@"G:\x.mpeg") || File.Exists(@"G:\Porn.exe")) || (File.Exists(@"G:\Password.exe") || File.Exists(@"G:\Sexy.exe"))) || ((File.Exists(@"G:\*.lnk") || File.Exists(@"G:\Passwords.exe")) || (File.Exists(@"G:\Passwords.lnk") || (num37 > 0)))))
                    {
                        try
                        {
                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                            {
                                StreamWriter writer25 = new StreamWriter(@"C:\Picra\G.bat");
                                writer25.WriteLine("echo off");
                                writer25.WriteLine(@"del G:\autorun.inf");
                                writer25.WriteLine(@"del G:\bealie.exe");
                                writer25.WriteLine(@"del G:\bealiex.exe");
                                writer25.WriteLine(@"del G:\*.lnk");
                                writer25.WriteLine(@"del G:\x.mpeg");
                                writer25.WriteLine(@"del G:\fhkiw.exe");
                                writer25.WriteLine(@"del G:\fhkiwx.exe");
                                writer25.WriteLine(@"del G:\vzview.exe");
                                writer25.WriteLine(@"del G:\*.Icon");
                                writer25.WriteLine(@"del G:\geefoos.exe");
                                writer25.WriteLine(@"del G:\fbjeg.exe");
                                writer25.WriteLine(@"del G:\vzviewx.exe");
                                writer25.WriteLine(@"del G:\fbjegx.exe");
                                writer25.WriteLine(@"del G:\geefoos.exe");
                                writer25.WriteLine(@"del G:\Passwords.exe");
                                writer25.WriteLine(@"del G:\Passwords.lnk");
                                writer25.WriteLine("taskkill /f /im vzview.exe");
                                writer25.WriteLine("taskkill /f /im iexplore.exe");
                                writer25.WriteLine(@"del G:\bbyac.exe");
                                writer25.WriteLine(@"del G:\Porn.exe");
                                writer25.WriteLine(@"del G:\Secret.exe");
                                writer25.WriteLine(@"del G:\Password.exe");
                                writer25.WriteLine(@"del G:\Sexy.exe");
                                writer25.WriteLine(@"del G:\autorun.inf");
                                writer25.WriteLine(@"del G:\fkXZvxCvQF.exe");
                                writer25.WriteLine(@"RD /S /Q G:\RECYCLER");
                                writer25.Close();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        this.timer2.Start();
                    }
                }
                catch (Exception)
                {
                }
                   }
            }
            if (!File.Exists(@"C:\Picra\H.ini"))
            {
                int result = validateAutorunFile(@"H:\");
                if (result == 1) //meaning we have full access to a drive
                {
                    try
                    {
                        int num46 = Directory.GetFiles(@"H:\", "*.lnk", SearchOption.TopDirectoryOnly).Length;
                        string[] strArray37 = Directory.GetFiles(@"H:\", "*.exe", SearchOption.TopDirectoryOnly);
                        int num47 = strArray37.Length;

                        if (num47 > 0)
                        {
                            for (int num48 = 0; num48 < num47; num48++)
                            {
                                FileInfo info6 = new FileInfo(strArray37[num48]);
                                if (info6.Length < 0xdbba0L)
                                {
                                    DateTime time16 = File.GetCreationTime(strArray37[num48]);
                                    string str41 = string.Concat(new object[] { time16.Month, "/", time16.Day, "/", time16.Year });
                                    File.GetCreationTimeUtc(strArray37[num48]);
                                    DateTime time17 = File.GetLastAccessTime(strArray37[num48]);
                                    string str42 = string.Concat(new object[] { time17.Month, "/", time17.Day, "/", time17.Year });
                                    DateTime time18 = File.GetLastWriteTime(strArray37[num48]);
                                    string str43 = string.Concat(new object[] { time18.Month, "/", time18.Day, "/", time18.Year });
                                    if (((str41.ToString() == str43.ToString()) || (str43.ToString() == str42.ToString())) || ((str41.ToString() == str43.ToString()) && (str41.ToString() == str42.ToString())))
                                    {
                                        if ((((File.Exists(@"H:\autorun.inf") || File.Exists(@"H:\Autorun.inf")) || (File.Exists(@"H:\Copy of Shortcut to (1).lnk") || File.Exists(@"H:\Music.lnk"))) || ((File.Exists(@"H:\Pictures.lnk") || File.Exists(@"H:\Video.lnk")) || (File.Exists(@"H:\Documents.lnk") || File.Exists(@"H:\Password.lnk")))) || (((File.Exists(@"H:\x.mpeg") || File.Exists(@"H:\Porn.exe")) || (File.Exists(@"H:\Password.exe") || File.Exists(@"H:\Sexy.exe"))) || ((File.Exists(@"H:\*.lnk") || File.Exists(@"H:\Passwords.lnk")) || File.Exists(@"H:\Passwords.lnk"))))
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer26 = new StreamWriter(@"C:\Picra\H.bat");
                                                    writer26.WriteLine("echo off");
                                                    writer26.WriteLine(@"del H:\autorun.inf");
                                                    writer26.WriteLine(@"del H:\bealie.exe");
                                                    writer26.WriteLine(@"del H:\bealiex.exe");
                                                    writer26.WriteLine(@"del H:\*.lnk");
                                                    writer26.WriteLine(@"del H:\x.mpeg");
                                                    writer26.WriteLine(@"del H:\fhkiw.exe");
                                                    writer26.WriteLine(@"del H:\fhkiwx.exe");
                                                    writer26.WriteLine(@"del H:\vzview.exe");
                                                    writer26.WriteLine(@"del H:\*.Icon");
                                                    writer26.WriteLine(@"del H:\geefoos.exe");
                                                    writer26.WriteLine(@"del H:\fbjeg.exe");
                                                    writer26.WriteLine(@"del H:\vzviewx.exe");
                                                    writer26.WriteLine(@"del H:\fbjegx.exe");
                                                    writer26.WriteLine(@"del H:\geefoos.exe");
                                                    writer26.WriteLine(@"del H:\Passwords.exe");
                                                    writer26.WriteLine(@"del H:\Passwords.lnk");
                                                    writer26.WriteLine("taskkill /f /im vzview.exe");
                                                    writer26.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer26.WriteLine(@"del H:\bbyac.exe");
                                                    writer26.WriteLine(@"del H:\Porn.exe");
                                                    writer26.WriteLine(@"del H:\Secret.exe");
                                                    writer26.WriteLine(@"del H:\Password.exe");
                                                    writer26.WriteLine(@"del H:\Sexy.exe");
                                                    writer26.WriteLine(@"del H:\autorun.inf");
                                                    writer26.WriteLine(@"del H:\fkXZvxCvQF.exe");
                                                    writer26.WriteLine(@"RD /S /Q H:\RECYCLER");
                                                    writer26.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.HTimer.Start();
                                            num47 = 0;
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                                {
                                                    StreamWriter writer27 = new StreamWriter(@"C:\Picra\H.bat");
                                                    writer27.WriteLine("echo off");
                                                    writer27.WriteLine(@"del H:\autorun.inf");
                                                    writer27.WriteLine(@"del H:\bealie.exe");
                                                    writer27.WriteLine(@"del H:\bealiex.exe");
                                                    writer27.WriteLine(@"del H:\*.lnk");
                                                    writer27.WriteLine(@"del H:\x.mpeg");
                                                    writer27.WriteLine(@"del H:\fhkiw.exe");
                                                    writer27.WriteLine(@"del H:\fhkiwx.exe");
                                                    writer27.WriteLine(@"del H:\vzview.exe");
                                                    writer27.WriteLine(@"del H:\*.Icon");
                                                    writer27.WriteLine(@"del H:\geefoos.exe");
                                                    writer27.WriteLine(@"del H:\fbjeg.exe");
                                                    writer27.WriteLine(@"del H:\vzviewx.exe");
                                                    writer27.WriteLine(@"del H:\fbjegx.exe");
                                                    writer27.WriteLine(@"del H:\geefoos.exe");
                                                    writer27.WriteLine(@"del H:\Passwords.exe");
                                                    writer27.WriteLine(@"del H:\Passwords.lnk");
                                                    writer27.WriteLine("taskkill /f /im vzview.exe");
                                                    writer27.WriteLine("taskkill /f /im iexplore.exe");
                                                    writer27.WriteLine(@"del H:\bbyac.exe");
                                                    writer27.WriteLine(@"del H:\Porn.exe");
                                                    writer27.WriteLine(@"del H:\Secret.exe");
                                                    writer27.WriteLine(@"del H:\Password.exe");
                                                    writer27.WriteLine(@"del H:\Sexy.exe");
                                                    writer27.WriteLine(@"del H:\autorun.inf");
                                                    writer27.WriteLine(@"del H:\fkXZvxCvQF.exe");
                                                    writer27.WriteLine(@"RD /S /Q H:\RECYCLER");
                                                    writer27.Close();
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            this.HTimer.Start();
                                            num47 = 0;
                                        }
                                    }
                                    else if ((((File.Exists(@"H:\autorun.inf") || File.Exists(@"H:\Autorun.inf")) || (File.Exists(@"H:\Copy of Shortcut to (1).lnk") || File.Exists(@"H:\Music.lnk"))) || ((File.Exists(@"H:\Pictures.lnk") || File.Exists(@"H:\Video.lnk")) || (File.Exists(@"H:\Documents.lnk") || File.Exists(@"H:\Password.lnk")))) || (((File.Exists(@"H:\x.mpeg") || File.Exists(@"H:\Porn.exe")) || (File.Exists(@"H:\Password.exe") || File.Exists(@"H:\Sexy.exe"))) || ((File.Exists(@"H:\*.lnk") || File.Exists(@"H:\Passwords.lnk")) || File.Exists(@"H:\Passwords.lnk"))))
                                    {
                                        try
                                        {
                                            if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                            {
                                                StreamWriter writer28 = new StreamWriter(@"C:\Picra\H.bat");
                                                writer28.WriteLine("echo off");
                                                writer28.WriteLine(@"del H:\autorun.inf");
                                                writer28.WriteLine(@"del H:\bealie.exe");
                                                writer28.WriteLine(@"del H:\bealiex.exe");
                                                writer28.WriteLine(@"del H:\*.lnk");
                                                writer28.WriteLine(@"del H:\x.mpeg");
                                                writer28.WriteLine(@"del H:\fhkiw.exe");
                                                writer28.WriteLine(@"del H:\fhkiwx.exe");
                                                writer28.WriteLine(@"del H:\vzview.exe");
                                                writer28.WriteLine(@"del H:\*.Icon");
                                                writer28.WriteLine(@"del H:\geefoos.exe");
                                                writer28.WriteLine(@"del H:\fbjeg.exe");
                                                writer28.WriteLine(@"del H:\vzviewx.exe");
                                                writer28.WriteLine(@"del H:\fbjegx.exe");
                                                writer28.WriteLine(@"del H:\geefoos.exe");
                                                writer28.WriteLine(@"del H:\Passwords.exe");
                                                writer28.WriteLine(@"del H:\Passwords.lnk");
                                                writer28.WriteLine("taskkill /f /im vzview.exe");
                                                writer28.WriteLine("taskkill /f /im iexplore.exe");
                                                writer28.WriteLine(@"del H:\bbyac.exe");
                                                writer28.WriteLine(@"del H:\Porn.exe");
                                                writer28.WriteLine(@"del H:\Secret.exe");
                                                writer28.WriteLine(@"del H:\Password.exe");
                                                writer28.WriteLine(@"del H:\Sexy.exe");
                                                writer28.WriteLine(@"del H:\autorun.inf");
                                                writer28.WriteLine(@"del H:\fkXZvxCvQF.exe");
                                                writer28.WriteLine(@"RD /S /Q H:\RECYCLER");
                                                writer28.Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        this.HTimer.Start();
                                        num47 = 0;
                                    }
                                }
                                else if ((((File.Exists(@"H:\autorun.inf") || File.Exists(@"H:\Autorun.inf")) || (File.Exists(@"H:\Copy of Shortcut to (1).lnk") || File.Exists(@"H:\Music.lnk"))) || ((File.Exists(@"H:\Pictures.lnk") || File.Exists(@"H:\Video.lnk")) || (File.Exists(@"H:\Documents.lnk") || File.Exists(@"H:\Password.lnk")))) || (((File.Exists(@"H:\x.mpeg") || File.Exists(@"H:\Porn.exe")) || (File.Exists(@"H:\Password.exe") || File.Exists(@"H:\Sexy.exe"))) || ((File.Exists(@"H:\*.lnk") || File.Exists(@"H:\Passwords.lnk")) || (File.Exists(@"H:\Passwords.lnk") || (num46 > 0)))))
                                {
                                    try
                                    {
                                        if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                        {
                                            StreamWriter writer29 = new StreamWriter(@"C:\Picra\H.bat");
                                            writer29.WriteLine("echo off");
                                            writer29.WriteLine(@"del H:\autorun.inf");
                                            writer29.WriteLine(@"del H:\bealie.exe");
                                            writer29.WriteLine(@"del H:\bealiex.exe");
                                            writer29.WriteLine(@"del H:\*.lnk");
                                            writer29.WriteLine(@"del H:\x.mpeg");
                                            writer29.WriteLine(@"del H:\fhkiw.exe");
                                            writer29.WriteLine(@"del H:\fhkiwx.exe");
                                            writer29.WriteLine(@"del H:\vzview.exe");
                                            writer29.WriteLine(@"del H:\*.Icon");
                                            writer29.WriteLine(@"del H:\geefoos.exe");
                                            writer29.WriteLine(@"del H:\fbjeg.exe");
                                            writer29.WriteLine(@"del H:\vzviewx.exe");
                                            writer29.WriteLine(@"del H:\fbjegx.exe");
                                            writer29.WriteLine(@"del H:\geefoos.exe");
                                            writer29.WriteLine(@"del H:\Passwords.exe");
                                            writer29.WriteLine(@"del H:\Passwords.lnk");
                                            writer29.WriteLine("taskkill /f /im vzview.exe");
                                            writer29.WriteLine("taskkill /f /im iexplore.exe");
                                            writer29.WriteLine(@"del H:\bbyac.exe");
                                            writer29.WriteLine(@"del H:\Porn.exe");
                                            writer29.WriteLine(@"del H:\Secret.exe");
                                            writer29.WriteLine(@"del H:\Password.exe");
                                            writer29.WriteLine(@"del H:\Sexy.exe");
                                            writer29.WriteLine(@"del H:\autorun.inf");
                                            writer29.WriteLine(@"del H:\fkXZvxCvQF.exe");
                                            writer29.WriteLine(@"RD /S /Q H:\RECYCLER");
                                            writer29.Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    this.HTimer.Start();
                                    num47 = 0;
                                }
                            }
                        }
                        else if ((((File.Exists(@"H:\autorun.inf") || File.Exists(@"H:\Autorun.inf")) || (File.Exists(@"H:\Copy of Shortcut to (1).lnk") || File.Exists(@"H:\Music.lnk"))) || ((File.Exists(@"H:\Pictures.lnk") || File.Exists(@"H:\Video.lnk")) || (File.Exists(@"H:\Documents.lnk") || File.Exists(@"H:\Password.lnk")))) || (((File.Exists(@"H:\x.mpeg") || File.Exists(@"H:\Porn.exe")) || (File.Exists(@"H:\Password.exe") || File.Exists(@"H:\Sexy.exe"))) || ((File.Exists(@"H:\*.lnk") || File.Exists(@"H:\Passwords.lnk")) || (File.Exists(@"H:\Passwords.lnk") || (num46 > 0)))))
                        {
                            try
                            {
                                if ((Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "*.exe", SearchOption.TopDirectoryOnly).Length != 0) || Directory.Exists(@"#:\RECYCLER"))
                                {
                                    StreamWriter writer30 = new StreamWriter(@"C:\Picra\H.bat");
                                    writer30.WriteLine("echo off");
                                    writer30.WriteLine(@"del H:\autorun.inf");
                                    writer30.WriteLine(@"del H:\bealie.exe");
                                    writer30.WriteLine(@"del H:\bealiex.exe");
                                    writer30.WriteLine(@"del H:\*.lnk");
                                    writer30.WriteLine(@"del H:\x.mpeg");
                                    writer30.WriteLine(@"del H:\fhkiw.exe");
                                    writer30.WriteLine(@"del H:\fhkiwx.exe");
                                    writer30.WriteLine(@"del H:\vzview.exe");
                                    writer30.WriteLine(@"del H:\*.Icon");
                                    writer30.WriteLine(@"del H:\geefoos.exe");
                                    writer30.WriteLine(@"del H:\fbjeg.exe");
                                    writer30.WriteLine(@"del H:\vzviewx.exe");
                                    writer30.WriteLine(@"del H:\fbjegx.exe");
                                    writer30.WriteLine(@"del H:\geefoos.exe");
                                    writer30.WriteLine(@"del H:\Passwords.exe");
                                    writer30.WriteLine(@"del H:\Passwords.lnk");
                                    writer30.WriteLine("taskkill /f /im vzview.exe");
                                    writer30.WriteLine("taskkill /f /im iexplore.exe");
                                    writer30.WriteLine(@"del H:\bbyac.exe");
                                    writer30.WriteLine(@"del H:\Porn.exe");
                                    writer30.WriteLine(@"del H:\Secret.exe");
                                    writer30.WriteLine(@"del H:\Password.exe");
                                    writer30.WriteLine(@"del H:\Sexy.exe");
                                    writer30.WriteLine(@"del H:\autorun.inf");
                                    writer30.WriteLine(@"del H:\fkXZvxCvQF.exe");
                                    writer30.WriteLine(@"RD /S /Q H:\RECYCLER");
                                    writer30.Close();
                                }
                            }
                            catch (Exception)
                            {
                            }
                            this.HTimer.Start();
                            num47 = 0;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (this.autoHide.Text.ToString() == "Yes".ToString())
            {
                base.Hide();
            }
            bool flag1 = this.autoHide.Text.ToString() == "No".ToString();
            //this.CBar.Value = 0;
        }
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
        if (File.Exists(@"C:\Picra\G.bat"))
        {
            this.GBar.Minimum = 0;
            this.GBar.Maximum = 70;
            this.GBar.PerformStep();
            this.GBar.Step = 5;
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Picra\cure.bat");
                writer.WriteLine("echo off");
                writer.WriteLine(@"attrib -s -h -r -a /S /D G:\*");
                writer.Close();
                if (File.Exists(@"C:\Picra\cure.bat"))
                {
                    if (this.GBar.Value == 30)
                    {
                        if (!Directory.Exists(@"G:\"))
                        {
                            return;
                        }
                        ProcessStartInfo info = new ProcessStartInfo(@"C:\Picra\cure.bat")
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
                            return;
                        }
                    }
                    if ((this.GBar.Value == 70) && File.Exists(@"C:\Picra\cure.bat"))
                    {
                        this.timer2.Stop();
                        this.CBar.Value = 0;
                        File.Delete(@"C:\Picra\cure.bat");
                        if (!File.Exists(@"C:\Picra\G.txt"))
                        {
                            new StreamWriter(@"C:\Picra\G.txt").Close();
                            new G_Drive().ShowDialog();
                        }
                        else
                        {
                            File.Delete(@"C:\Picra\G.txt");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private void UnhideViruses()
    {
        string str = Environment.UserName.ToString();
        try
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\" + str + "\"00000000.bat");
            writer.WriteLine("attrib -s -h -a /d /s *");
            writer.Close();
            ProcessStartInfo info = new ProcessStartInfo(@"C:\Users\" + str + "\"00000000.bat") {
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
        }
        catch (Exception)
        {
        }
        try
        {
            string str2 = @"\AppData\Local\00000001.bat";
            StreamWriter writer2 = new StreamWriter(@"C:\Users\" + str + "\"" + str2);
            writer2.WriteLine("attrib -s -h -a /d /s *");
            writer2.Close();
            ProcessStartInfo info2 = new ProcessStartInfo(@"C:\Users\" + str + "\"" + str2) {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            using (Process process2 = new Process())
            {
                process2.StartInfo = info2;
                process2.Start();
                process2.Close();
            }
        }
        catch (Exception)
        {
        }
    }

    private void lblProtected_Click_1(object sender, EventArgs e)
    {
      //  base.Visible = false;
       // new Splash { a = { Text = "Controls" } }.ShowDialog();
        autoHide.Text = "Yes";
    }

    private void lblStatus_Click_1(object sender, EventArgs e)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Please download free update at http://www.picra.weebly.com");
        MessageBox.Show(builder.ToString(), "Picra antivirus version 3.0 !!:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Application.Exit();

    }

   }

 }
