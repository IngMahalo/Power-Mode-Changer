using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Management;
using PowerModeChanger.Properties;
using System.Net.NetworkInformation;


namespace PowerModeChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //thisispogchamp
            InitializeComponent();
            GetActiveScheme();
            Battery();
            checkIfNirAndCmdExist();
            applyDefaultSettings();
            setEnableDisableCheckBoxPower();
            // this.Size = new Size(800, 400);
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            

            PingUnlimitedLimitedOnOff();
        }



        private void applyDefaultSettings()
        {
            //setting the size so that the Panel_PowerMode is correct  
            this.Size = new Size(397, 346);

            //changing background color for buttons
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button_Settings_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button_Settings_notsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);
            button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 38, 38);
            button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(59, 49, 48);

            //recall and apply settings for Power Mode 
            button1.Text = Settings.Default["mode_Name_1"].ToString();
            button2.Text = Settings.Default["mode_Name_2"].ToString();
            button3.Text = Settings.Default["mode_Name_3"].ToString();
            textBox1.Text = Settings.Default["mode_Name_1"].ToString();
            textBox2.Text = Settings.Default["mode_Name_2"].ToString();
            textBox3.Text = Settings.Default["mode_Name_3"].ToString();
            textBox4.Text = Settings.Default["mode_String_1"].ToString();
            textBox5.Text = Settings.Default["mode_String_2"].ToString();
            textBox6.Text = Settings.Default["mode_String_3"].ToString();
            checkBox_power1.Checked = Convert.ToBoolean(Settings.Default["checkBox_power1"]);
            checkBox_power2.Checked = Convert.ToBoolean(Settings.Default["checkBox_power2"]);
            checkBox_power3.Checked = Convert.ToBoolean(Settings.Default["checkBox_power3"]);
            checkBox_powerupdate.Checked = Convert.ToBoolean(Settings.Default["checkBox_powerupdate"]);
            timer1.Enabled = Convert.ToBoolean(Settings.Default["StateAutoPowerModeUpdate"]);
            setCurrentPowerUpdateTimer(Convert.ToBoolean(Settings.Default["StateAutoPowerModeUpdate"]));

            //recall and apply settings for Sound changer
            textBox9.Text = Settings.Default["sound_In_Mic1"].ToString();
            textBox10.Text = Settings.Default["sound_In_Mic2"].ToString();
            textBox7.Text = Settings.Default["sound_out_headphones1"].ToString();
            textBox8.Text = Settings.Default["sound_out_headphones2"].ToString();
            button12.Text = Settings.Default["sound_In_Mic1"].ToString();
            button13.Text = Settings.Default["sound_In_Mic2"].ToString();
            button10.Text = Settings.Default["sound_out_headphones1"].ToString();
            button11.Text = Settings.Default["sound_out_headphones2"].ToString();

            //recall and apply settings for ping
            textBox11.Text = Settings.Default["pingAdress"].ToString();
            //numericUpDown1.Value = 
            //= System.Convert.ToString( Settings.Default["pingNumberOfPingsLimited"]);
            checkBox1.Checked = Convert.ToBoolean(Settings.Default["pingNumberOfPingsUnlimited"]);
        }

        private void checkIfNirAndCmdExist()
        {
            //check if nircmd exists. 
            if (!File.Exists("C:\\Windows\\nircmd.exe"))
            {
                MessageBox.Show("Nircmd does not exists, go and download it from //www.nirsoft.net/utils/nircmd.html and copie it to C:\\Windows\\");
                System.Environment.Exit(1);
            }
            //check if cmd.exe exists
            if (!File.Exists("C:\\Windows\\system32\\cmd.exe"))
            {
                MessageBox.Show("cmd.exe is not found under the location 'C:\\Windows\\system32\\cmd.exe', make shure that cmd.exe exists and restart the program");
                System.Environment.Exit(1);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetWindowsPowerMode(string.Concat(" /setactive " , Settings.Default["mode_String_1"].ToString()) );
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetWindowsPowerMode(string.Concat(" /setactive ", Settings.Default["mode_String_2"].ToString()));
        }

        private void Button3_Click(object sender, EventArgs e)
        {        
            SetWindowsPowerMode(string.Concat(" /setactive ", Settings.Default["mode_String_3"].ToString()));
        }


        private void Button_refresh_Click(object sender, EventArgs e)
        {
            GetActiveScheme();
        }


        private void Button4_Click_2(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            
            //setting the size of the form
            this.Size = new Size(471, 466);


            //set the sidebars so that the correct one is visable.
            Panel_Sidebar.Visible = false;
            Panel_Sidebar_Settings.Visible = true;
            panel_Ping.Visible = false;

            //set the the settings windows on top 
            Panel_PowerMode.Visible = false;
            Panel_Sound.Visible = false;
            Panel_Settings.Visible = true;

            
        }


       private void PingUnlimitedLimitedOnOff()
        {
            if(checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
            }
        }


        private void SetWindowsIO(string IO, string type)
        {

            ProcessStartInfo psi = new ProcessStartInfo("nircmd.exe", " setdefaultsounddevice " + IO + " " + type);
            //MessageBox.Show("nircmd setdefaultsounddevice " + IO + " " + type);
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            var proc = Process.Start(psi);


        }

        private void GetActiveScheme()
        {
            ProcessStartInfo psi = new ProcessStartInfo("powercfg.exe", " /GETACTIVESCHEME");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            var proc = Process.Start(psi);
            string s = proc.StandardOutput.ReadToEnd();

            //s is the string that is beeing returned.
            int startPos = s.LastIndexOf("(") + "(".Length + 0;
            int length = s.IndexOf(")") - startPos;
            string sub = s.Substring(startPos, length);

            label1.Text = sub;
            label4.Text = DateTime.Now.ToString("h:mm:ss tt");

        }


        private void SetWindowsPowerMode(string Var_Type)
        {
            //powercfg /LIST
            ProcessStartInfo psi = new ProcessStartInfo("powercfg.exe", Var_Type);
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            var proc = Process.Start(psi);
            GetActiveScheme();
        }


        private void Battery()
        {
            String batterylife;
            batterylife = SystemInformation.PowerStatus.BatteryLifePercent.ToString();


            //int e = int.Parse(batterylife);
            label7.Text = "Battery persentage: " + batterylife;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
            Panel_PowerMode.Visible = true;
            Panel_Sound.Visible = false;
            panel_Ping.Visible = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
            Panel_Sound.Visible = true;
            Panel_PowerMode.Visible = false;
            panel_Ping.Visible = false;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button_Settings_notsave_Click(object sender, EventArgs e)
        {
            //ask the user if he actually wants to exit the settings
            if (MessageBox.Show("Are you shure you want to exit the settings without saving?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //set windows size
                this.Size = new Size(397, 346);
                //set the sidebars so that the correct one is visable.
                Panel_Sidebar.Visible = true;
                Panel_Sidebar_Settings.Visible = false;

                //set the the settings windows on top
                Panel_PowerMode.Visible = true;
                Panel_Sound.Visible = false;
                Panel_Settings.Visible = false;
                
            }

        }

        private void Button_Settings_save_Click(object sender, EventArgs e)
        {

            //power mod changer settings
            Settings.Default["mode_Name_1"] = textBox1.Text;
            Settings.Default["mode_Name_2"] = textBox2.Text;
            Settings.Default["mode_Name_3"] = textBox3.Text;

            Settings.Default["mode_String_1"] = textBox4.Text;
            Settings.Default["mode_String_2"] = textBox5.Text;
            Settings.Default["mode_String_3"] = textBox6.Text;

            //sound settings
            Settings.Default["sound_In_Mic1"] = textBox9.Text;
            Settings.Default["sound_In_Mic2"] = textBox10.Text;
            Settings.Default["sound_out_headphones1"] = textBox7.Text;
            Settings.Default["sound_out_headphones2"] = textBox8.Text;


            //save settings
            Settings.Default.Save();

            //write input to button text - Power
            button1.Text = Settings.Default["mode_Name_1"].ToString();
            button2.Text = Settings.Default["mode_Name_2"].ToString();
            button3.Text = Settings.Default["mode_Name_3"].ToString();

            //write input to button text - Sound
            button12.Text = Settings.Default["sound_In_Mic1"].ToString();
            button13.Text = Settings.Default["sound_In_Mic2"].ToString();
            button10.Text = Settings.Default["sound_out_headphones1"].ToString();
            button11.Text = Settings.Default["sound_out_headphones2"].ToString();



            //set windows size to default
            this.Size = new Size(397, 346);
            
            //setting the sidebar back to the default one
            Panel_Sidebar.Visible = true;
            Panel_Sidebar_Settings.Visible = false;

            //set the the settings windows on top
            Panel_PowerMode.Visible = true;
            Panel_Sound.Visible = false;
            Panel_Settings.Visible = false;

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("powercfg.exe", " /L");
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            var proc = Process.Start(psi);
            
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {

        }

        //next 4 Buttons are to change the windows IO settings.
        private void Button10_Click(object sender, EventArgs e)
        {
            SetWindowsIO(Settings.Default["sound_out_headphones1"].ToString(), "1");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            SetWindowsIO(Settings.Default["sound_out_headphones2"].ToString(), "1");
        }

        private void Button12_Click(object sender, EventArgs e)
        {

            SetWindowsIO(Settings.Default["sound_In_Mic1"].ToString(), "2");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            SetWindowsIO(Settings.Default["sound_In_Mic2"].ToString(), "2");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pannel_Sound_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Process.Start("nircmd", "setsysvolume " + (Convert.ToInt32(trackBar1.Value.ToString())* Convert.ToInt32(655.35)));
        }

        private void Panel_volume_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel_Ping.Visible = true;
            Panel_PowerMode.Visible = false;
            Panel_Sound.Visible = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool pingable;
            string i = textBox11.Text.ToString();
            // pingable = PingHost(i);
            string echoRequest;
            if (checkBox1.Checked == true) { 
                echoRequest = "0";
            }
            else
            {
                echoRequest = numericUpDown1.Value.ToString();
            }

            pingable = PingHost(i, echoRequest);

            button14.Text = pingable.ToString();
        }
        public static bool PingHost(String Adress, string i)
        {
            int a = Convert.ToInt32(i);
            bool pingable = false;
            Ping pinger = null;
            for (int y = 0; a == 0 || y < a; y++) { 
                

                try
                {
                    pinger = new Ping();
                    PingReply reply = pinger.Send(Adress);
                    pingable = reply.Status == IPStatus.Success;
                    
                }
                catch (PingException)
                {

                }
                finally
                {
                    if (pinger != null)
                    {
                        pinger.Dispose();

                    }
                }
            }

            return pingable;

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["pingAdress"] = textBox11.Text.ToString();
            Settings.Default.Save();
        }



        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           Settings.Default["pingNumberOfPingsLimited"] = numericUpDown1.Value.ToString();
            Settings.Default.Save();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["pingNumberOfPingsUnlimited"] = checkBox1.Checked.ToString();
            Settings.Default.Save();

            PingUnlimitedLimitedOnOff();
        }

        private void Panel_PowerMode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //test;
            AutoUpdatePowerMode();
        }

        private void checkBox_powerupdate_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["checkBox_powerupdate"] = checkBox_powerupdate.Checked.ToString();
            Settings.Default.Save();
        }

        private void checkBox_power1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["checkBox_power1"] = checkBox_power1.Checked.ToString();
            Settings.Default.Save();
            setEnableDisableCheckBoxPower();



        }

        private void checkBox_power2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["checkBox_power2"] = checkBox_power2.Checked.ToString();
            Settings.Default.Save();
            setEnableDisableCheckBoxPower();
        }

        private void checkBox_power3_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["checkBox_power3"] = checkBox_power3.Checked.ToString();
            Settings.Default.Save();
            setEnableDisableCheckBoxPower();
        }

        private void AutoUpdatePowerMode()
        {
            if(checkBox_power1.Checked == true)
            {
                SetWindowsPowerMode(string.Concat(" /setactive ", Settings.Default["mode_String_1"].ToString()));
            }

            if (checkBox_power2.Checked == true)
            {
                SetWindowsPowerMode(string.Concat(" /setactive ", Settings.Default["mode_String_2"].ToString()));
            }

            if (checkBox_power3.Checked == true)
            {
                SetWindowsPowerMode(string.Concat(" /setactive ", Settings.Default["mode_String_3"].ToString()));
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            setEnableDisableCheckBoxPower();
            if (timer1.Enabled == true)
            {
                setCurrentPowerUpdateTimer(false);

            }
            else if (timer1.Enabled == false)
            {
                setCurrentPowerUpdateTimer(true);
            }


        }
        private void setCurrentPowerUpdateTimer(Boolean status)
        {
            timer1.Enabled = status;
            button15.Text = status.ToString();
            checkBox_power1.Visible = status;
            checkBox_power2.Visible = status;
            checkBox_power3.Visible = status;
            Settings.Default["StateAutoPowerModeUpdate"] = status.ToString();
            Settings.Default.Save();

        }
        private int setEnableDisableCheckBoxPower()
        {
            if(checkBox_power1.Checked == true)
            {
                checkBox_power2.Checked = false;
                checkBox_power3.Checked = false;
                checkBox_power2.Visible = false;
                checkBox_power3.Visible = false;
                return 0;
            }else {
                setEnableDisableCheckBoxPowerReset();
            }

            if (checkBox_power2.Checked == true)
            {
                checkBox_power1.Checked = false;
                checkBox_power3.Checked = false;
                checkBox_power1.Visible = false;
                checkBox_power3.Visible = false;
                return 0;
            }
            else
            {
                setEnableDisableCheckBoxPowerReset();
            }

            if (checkBox_power3.Checked == true)
            {
                checkBox_power2.Checked = false;
                checkBox_power1.Checked = false;
                checkBox_power2.Visible = false;
                checkBox_power1.Visible = false;
                return 0;
            }
            else
            {
                setEnableDisableCheckBoxPowerReset();
            }




            return 0;

        }

        private void setEnableDisableCheckBoxPowerReset()
        {
            checkBox_power1.Visible = true;
            checkBox_power2.Visible = true;
            checkBox_power3.Visible = true;


        }
    }
}
