using System;

namespace PowerModeChanger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel_Sidebar = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Panel_PowerMode = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.checkBox_power3 = new System.Windows.Forms.CheckBox();
            this.checkBox_power2 = new System.Windows.Forms.CheckBox();
            this.checkBox_power1 = new System.Windows.Forms.CheckBox();
            this.checkBox_powerupdate = new System.Windows.Forms.CheckBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.Panel_volume = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Panel_Sound = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.panel_Ping = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.Panel_Sidebar_Settings = new System.Windows.Forms.Panel();
            this.button_Settings_notsave = new System.Windows.Forms.Button();
            this.button_Settings_save = new System.Windows.Forms.Button();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_Sidebar.SuspendLayout();
            this.Panel_PowerMode.SuspendLayout();
            this.Panel_volume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.Panel_Sound.SuspendLayout();
            this.panel_Ping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Panel_Sidebar_Settings.SuspendLayout();
            this.Panel_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button1.Location = new System.Drawing.Point(40, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Power Saver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button2.Location = new System.Drawing.Point(40, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Balanced";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button3.Location = new System.Drawing.Point(40, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "High Performance";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Power Plan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Updated:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(93, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(37, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Set Power Plan:";
            // 
            // Panel_Sidebar
            // 
            this.Panel_Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.Panel_Sidebar.Controls.Add(this.button9);
            this.Panel_Sidebar.Controls.Add(this.button7);
            this.Panel_Sidebar.Controls.Add(this.button6);
            this.Panel_Sidebar.Controls.Add(this.label7);
            this.Panel_Sidebar.Controls.Add(this.button5);
            this.Panel_Sidebar.Controls.Add(this.button4);
            this.Panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Panel_Sidebar.Name = "Panel_Sidebar";
            this.Panel_Sidebar.Size = new System.Drawing.Size(101, 427);
            this.Panel_Sidebar.TabIndex = 20;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button9.Location = new System.Drawing.Point(23, 93);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 25);
            this.button9.TabIndex = 20;
            this.button9.Text = "Ping";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button7.Location = new System.Drawing.Point(23, 57);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 25);
            this.button7.TabIndex = 19;
            this.button7.Text = "Sound";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button6.Location = new System.Drawing.Point(23, 27);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 25);
            this.button6.TabIndex = 18;
            this.button6.Text = "Mode";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(30, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button5.Location = new System.Drawing.Point(23, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 25);
            this.button5.TabIndex = 15;
            this.button5.Text = "Settings";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button4.Location = new System.Drawing.Point(23, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 25);
            this.button4.TabIndex = 14;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click_2);
            // 
            // Panel_PowerMode
            // 
            this.Panel_PowerMode.Controls.Add(this.label16);
            this.Panel_PowerMode.Controls.Add(this.button15);
            this.Panel_PowerMode.Controls.Add(this.checkBox_power3);
            this.Panel_PowerMode.Controls.Add(this.checkBox_power2);
            this.Panel_PowerMode.Controls.Add(this.checkBox_power1);
            this.Panel_PowerMode.Controls.Add(this.checkBox_powerupdate);
            this.Panel_PowerMode.Controls.Add(this.button_refresh);
            this.Panel_PowerMode.Controls.Add(this.button1);
            this.Panel_PowerMode.Controls.Add(this.label4);
            this.Panel_PowerMode.Controls.Add(this.label5);
            this.Panel_PowerMode.Controls.Add(this.label3);
            this.Panel_PowerMode.Controls.Add(this.button2);
            this.Panel_PowerMode.Controls.Add(this.label2);
            this.Panel_PowerMode.Controls.Add(this.label1);
            this.Panel_PowerMode.Controls.Add(this.button3);
            this.Panel_PowerMode.Location = new System.Drawing.Point(98, 6);
            this.Panel_PowerMode.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_PowerMode.Name = "Panel_PowerMode";
            this.Panel_PowerMode.Size = new System.Drawing.Size(287, 323);
            this.Panel_PowerMode.TabIndex = 13;
            this.Panel_PowerMode.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_PowerMode_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label16.Location = new System.Drawing.Point(37, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "AutoUpdate: ";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button15.Location = new System.Drawing.Point(109, 245);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(165, 23);
            this.button15.TabIndex = 16;
            this.button15.Text = "DefaultAutoUpdate";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // checkBox_power3
            // 
            this.checkBox_power3.AutoSize = true;
            this.checkBox_power3.Location = new System.Drawing.Point(20, 213);
            this.checkBox_power3.Name = "checkBox_power3";
            this.checkBox_power3.Size = new System.Drawing.Size(15, 14);
            this.checkBox_power3.TabIndex = 15;
            this.checkBox_power3.UseVisualStyleBackColor = true;
            this.checkBox_power3.CheckedChanged += new System.EventHandler(this.checkBox_power3_CheckedChanged);
            // 
            // checkBox_power2
            // 
            this.checkBox_power2.AutoSize = true;
            this.checkBox_power2.Location = new System.Drawing.Point(20, 177);
            this.checkBox_power2.Name = "checkBox_power2";
            this.checkBox_power2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_power2.TabIndex = 14;
            this.checkBox_power2.UseVisualStyleBackColor = true;
            this.checkBox_power2.CheckedChanged += new System.EventHandler(this.checkBox_power2_CheckedChanged);
            // 
            // checkBox_power1
            // 
            this.checkBox_power1.AutoSize = true;
            this.checkBox_power1.Location = new System.Drawing.Point(20, 140);
            this.checkBox_power1.Name = "checkBox_power1";
            this.checkBox_power1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_power1.TabIndex = 13;
            this.checkBox_power1.UseVisualStyleBackColor = true;
            this.checkBox_power1.CheckedChanged += new System.EventHandler(this.checkBox_power1_CheckedChanged);
            // 
            // checkBox_powerupdate
            // 
            this.checkBox_powerupdate.AutoSize = true;
            this.checkBox_powerupdate.Location = new System.Drawing.Point(20, 63);
            this.checkBox_powerupdate.Name = "checkBox_powerupdate";
            this.checkBox_powerupdate.Size = new System.Drawing.Size(15, 14);
            this.checkBox_powerupdate.TabIndex = 12;
            this.checkBox_powerupdate.UseVisualStyleBackColor = true;
            this.checkBox_powerupdate.CheckedChanged += new System.EventHandler(this.checkBox_powerupdate_CheckedChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button_refresh.BackgroundImage = global::PowerModeChanger.Properties.Resources._615a48529d;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button_refresh.Location = new System.Drawing.Point(40, 57);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(236, 25);
            this.button_refresh.TabIndex = 7;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // Panel_volume
            // 
            this.Panel_volume.Controls.Add(this.trackBar1);
            this.Panel_volume.Location = new System.Drawing.Point(6, 232);
            this.Panel_volume.Name = "Panel_volume";
            this.Panel_volume.Size = new System.Drawing.Size(281, 77);
            this.Panel_volume.TabIndex = 41;
            this.Panel_volume.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_volume_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.Location = new System.Drawing.Point(11, 14);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(262, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Panel_Sound
            // 
            this.Panel_Sound.Controls.Add(this.Panel_volume);
            this.Panel_Sound.Controls.Add(this.button13);
            this.Panel_Sound.Controls.Add(this.button12);
            this.Panel_Sound.Controls.Add(this.button11);
            this.Panel_Sound.Controls.Add(this.label13);
            this.Panel_Sound.Controls.Add(this.label6);
            this.Panel_Sound.Controls.Add(this.button10);
            this.Panel_Sound.Location = new System.Drawing.Point(98, 6);
            this.Panel_Sound.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Sound.Name = "Panel_Sound";
            this.Panel_Sound.Size = new System.Drawing.Size(287, 321);
            this.Panel_Sound.TabIndex = 12;
            this.Panel_Sound.Visible = false;
            this.Panel_Sound.Paint += new System.Windows.Forms.PaintEventHandler(this.Pannel_Sound_Paint);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button13.Location = new System.Drawing.Point(40, 202);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(210, 25);
            this.button13.TabIndex = 5;
            this.button13.Text = "It up";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button12.Location = new System.Drawing.Point(40, 171);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(210, 25);
            this.button12.TabIndex = 4;
            this.button12.Text = "To Set ";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button11.Location = new System.Drawing.Point(40, 76);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(210, 25);
            this.button11.TabIndex = 3;
            this.button11.Text = "Settings";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label13.Location = new System.Drawing.Point(40, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Input Devices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(38, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Output Devices";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button10.Location = new System.Drawing.Point(40, 42);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(210, 25);
            this.button10.TabIndex = 0;
            this.button10.Text = "Visit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // panel_Ping
            // 
            this.panel_Ping.Controls.Add(this.checkBox1);
            this.panel_Ping.Controls.Add(this.label17);
            this.panel_Ping.Controls.Add(this.label15);
            this.panel_Ping.Controls.Add(this.numericUpDown1);
            this.panel_Ping.Controls.Add(this.textBox11);
            this.panel_Ping.Controls.Add(this.button14);
            this.panel_Ping.Location = new System.Drawing.Point(97, 6);
            this.panel_Ping.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Ping.Name = "panel_Ping";
            this.panel_Ping.Size = new System.Drawing.Size(287, 321);
            this.panel_Ping.TabIndex = 42;
            this.panel_Ping.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBox1.Location = new System.Drawing.Point(25, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Ping Until Stop is Pressed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label17.Location = new System.Drawing.Point(22, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Number of echo requests to send:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label15.Location = new System.Drawing.Point(22, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Target DomainName/IPv4 Adress:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.numericUpDown1.Location = new System.Drawing.Point(25, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 16);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox11.Location = new System.Drawing.Point(25, 29);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(170, 13);
            this.textBox11.TabIndex = 1;
            this.textBox11.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button14.Location = new System.Drawing.Point(25, 129);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 0;
            this.button14.Text = "Go";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Panel_Sidebar_Settings
            // 
            this.Panel_Sidebar_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.Panel_Sidebar_Settings.Controls.Add(this.button_Settings_notsave);
            this.Panel_Sidebar_Settings.Controls.Add(this.button_Settings_save);
            this.Panel_Sidebar_Settings.Location = new System.Drawing.Point(-9, -35);
            this.Panel_Sidebar_Settings.Name = "Panel_Sidebar_Settings";
            this.Panel_Sidebar_Settings.Size = new System.Drawing.Size(101, 556);
            this.Panel_Sidebar_Settings.TabIndex = 20;
            this.Panel_Sidebar_Settings.Visible = false;
            // 
            // button_Settings_notsave
            // 
            this.button_Settings_notsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_Settings_notsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings_notsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button_Settings_notsave.Location = new System.Drawing.Point(15, 84);
            this.button_Settings_notsave.Margin = new System.Windows.Forms.Padding(2);
            this.button_Settings_notsave.Name = "button_Settings_notsave";
            this.button_Settings_notsave.Size = new System.Drawing.Size(81, 25);
            this.button_Settings_notsave.TabIndex = 1;
            this.button_Settings_notsave.Text = "Back /w save";
            this.button_Settings_notsave.UseVisualStyleBackColor = false;
            this.button_Settings_notsave.Click += new System.EventHandler(this.Button_Settings_notsave_Click);
            // 
            // button_Settings_save
            // 
            this.button_Settings_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_Settings_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button_Settings_save.Location = new System.Drawing.Point(15, 54);
            this.button_Settings_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Settings_save.Name = "button_Settings_save";
            this.button_Settings_save.Size = new System.Drawing.Size(81, 25);
            this.button_Settings_save.TabIndex = 0;
            this.button_Settings_save.Text = "Back && Save";
            this.button_Settings_save.UseVisualStyleBackColor = false;
            this.button_Settings_save.Click += new System.EventHandler(this.Button_Settings_save_Click);
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.label14);
            this.Panel_Settings.Controls.Add(this.textBox10);
            this.Panel_Settings.Controls.Add(this.textBox9);
            this.Panel_Settings.Controls.Add(this.textBox8);
            this.Panel_Settings.Controls.Add(this.label12);
            this.Panel_Settings.Controls.Add(this.textBox7);
            this.Panel_Settings.Controls.Add(this.button8);
            this.Panel_Settings.Controls.Add(this.panel3);
            this.Panel_Settings.Controls.Add(this.label11);
            this.Panel_Settings.Controls.Add(this.panel2);
            this.Panel_Settings.Controls.Add(this.label10);
            this.Panel_Settings.Controls.Add(this.panel1);
            this.Panel_Settings.Controls.Add(this.button_Help);
            this.Panel_Settings.Controls.Add(this.label9);
            this.Panel_Settings.Controls.Add(this.label8);
            this.Panel_Settings.Controls.Add(this.textBox4);
            this.Panel_Settings.Controls.Add(this.textBox6);
            this.Panel_Settings.Controls.Add(this.textBox5);
            this.Panel_Settings.Controls.Add(this.textBox3);
            this.Panel_Settings.Controls.Add(this.textBox2);
            this.Panel_Settings.Controls.Add(this.textBox1);
            this.Panel_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Settings.Location = new System.Drawing.Point(93, 0);
            this.Panel_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(362, 427);
            this.Panel_Settings.TabIndex = 13;
            this.Panel_Settings.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label14.Location = new System.Drawing.Point(16, 325);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Audio Input Device Name:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox10.Location = new System.Drawing.Point(19, 366);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(153, 20);
            this.textBox10.TabIndex = 39;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox9.Location = new System.Drawing.Point(19, 342);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 20);
            this.textBox9.TabIndex = 38;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox8.Location = new System.Drawing.Point(19, 284);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(153, 20);
            this.textBox8.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label12.Location = new System.Drawing.Point(16, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Audio Output Device Name:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox7.Location = new System.Drawing.Point(19, 262);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 20);
            this.textBox7.TabIndex = 35;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::PowerModeChanger.Properties.Resources.QuestionMark;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button8.Location = new System.Drawing.Point(116, 198);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(15, 16);
            this.button8.TabIndex = 34;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(10, 219);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 2);
            this.panel3.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label11.Location = new System.Drawing.Point(11, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Sound Input Output:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(13, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 2);
            this.panel2.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label10.Location = new System.Drawing.Point(11, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "PowerModeChanger:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(10, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 2);
            this.panel1.TabIndex = 27;
            // 
            // button_Help
            // 
            this.button_Help.BackgroundImage = global::PowerModeChanger.Properties.Resources.QuestionMark;
            this.button_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_Help.Location = new System.Drawing.Point(176, 43);
            this.button_Help.Margin = new System.Windows.Forms.Padding(2);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(15, 16);
            this.button_Help.TabIndex = 26;
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label9.Location = new System.Drawing.Point(137, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "String";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(16, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox4.Location = new System.Drawing.Point(137, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox6.Location = new System.Drawing.Point(137, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox5.Location = new System.Drawing.Point(137, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox3.Location = new System.Drawing.Point(19, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox2.Location = new System.Drawing.Point(19, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.textBox1.Location = new System.Drawing.Point(19, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(455, 427);
            this.Controls.Add(this.Panel_Sidebar);
            this.Controls.Add(this.Panel_Sidebar_Settings);
            this.Controls.Add(this.Panel_PowerMode);
            this.Controls.Add(this.panel_Ping);
            this.Controls.Add(this.Panel_Sound);
            this.Controls.Add(this.Panel_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerModeChanger";
            this.Panel_Sidebar.ResumeLayout(false);
            this.Panel_Sidebar.PerformLayout();
            this.Panel_PowerMode.ResumeLayout(false);
            this.Panel_PowerMode.PerformLayout();
            this.Panel_volume.ResumeLayout(false);
            this.Panel_volume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.Panel_Sound.ResumeLayout(false);
            this.Panel_Sound.PerformLayout();
            this.panel_Ping.ResumeLayout(false);
            this.panel_Ping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Panel_Sidebar_Settings.ResumeLayout(false);
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel Panel_Sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Panel_PowerMode;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel Panel_Sound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Panel_Sidebar_Settings;
        private System.Windows.Forms.Button button_Settings_notsave;
        private System.Windows.Forms.Button button_Settings_save;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel Panel_volume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel_Ping;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_power3;
        private System.Windows.Forms.CheckBox checkBox_power2;
        private System.Windows.Forms.CheckBox checkBox_power1;
        private System.Windows.Forms.CheckBox checkBox_powerupdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label16;
    }
}

