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

namespace Shortcut_Killer
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private void Key_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtKey.Text.ToString() == "ycfhq9dwcydkv88t2tmhg7bhp")
                {
                    StreamWriter writeUpdate1 = new StreamWriter(@"C:\Picra\Data");  //creating a stream to write update
                    StreamWriter writeUpdate2 = new StreamWriter(@"C:\Picra\Data1"); //creating a stream to write update
                    writeUpdate1.Close();  //closing stream
                    writeUpdate2.Close(); //closing strewam

                    StreamWriter activator = new StreamWriter(@"C:\Picra\key.txt");  //creating a stresam to write activation key into a text file
                    activator.WriteLine("Ultimate picra shortcut antivirus version 3.0 key activator");
                    activator.WriteLine("ycfhq9dwcydkv88t2tmhg7bhp");
                    activator.Close(); //closing stream


                    errorProvider1.SetError(lblKeyAlert, "");//clear error message

                    progressBar1.Visible = true;

                    timer1.Start();
                }
                else
                {
                    errorProvider1.SetError(lblKeyAlert, "Entered Key is invalid"); //activating error message 
                }
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.PerformStep();

            if (progressBar1.Value==100)
            {
                Application.Restart();//restating  application
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
