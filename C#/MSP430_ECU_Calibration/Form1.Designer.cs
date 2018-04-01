namespace LineFollower_v0._1
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRecive = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.KpTrackBar = new System.Windows.Forms.TrackBar();
            this.KiTrackBar = new System.Windows.Forms.TrackBar();
            this.KdTrackBar = new System.Windows.Forms.TrackBar();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKp = new System.Windows.Forms.TextBox();
            this.textBoxKd = new System.Windows.Forms.TextBox();
            this.textBoxKi = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KpTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(18, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(165, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(365, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Without Trim";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Constants";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(171, 86);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(133, 23);
            this.buttonReceive.TabIndex = 4;
            this.buttonReceive.Text = "Auto Receive";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRecive);
            this.groupBox2.Controls.Add(this.buttonReceive);
            this.groupBox2.Location = new System.Drawing.Point(699, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 203);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive";
            // 
            // textBoxRecive
            // 
            this.textBoxRecive.Location = new System.Drawing.Point(8, 27);
            this.textBoxRecive.Multiline = true;
            this.textBoxRecive.Name = "textBoxRecive";
            this.textBoxRecive.ReadOnly = true;
            this.textBoxRecive.Size = new System.Drawing.Size(296, 30);
            this.textBoxRecive.TabIndex = 0;
            this.textBoxRecive.TextChanged += new System.EventHandler(this.textBoxRecive_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Open Port";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(678, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Close Port";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baundrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Statues";
            // 
            // KpTrackBar
            // 
            this.KpTrackBar.Location = new System.Drawing.Point(18, 127);
            this.KpTrackBar.Maximum = 100;
            this.KpTrackBar.Name = "KpTrackBar";
            this.KpTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KpTrackBar.Size = new System.Drawing.Size(422, 45);
            this.KpTrackBar.TabIndex = 10;
            this.KpTrackBar.Scroll += new System.EventHandler(this.kpTrackBar_Scroll);
            // 
            // KiTrackBar
            // 
            this.KiTrackBar.Location = new System.Drawing.Point(18, 229);
            this.KiTrackBar.Maximum = 100;
            this.KiTrackBar.Name = "KiTrackBar";
            this.KiTrackBar.Size = new System.Drawing.Size(422, 45);
            this.KiTrackBar.TabIndex = 11;
            this.KiTrackBar.Scroll += new System.EventHandler(this.KiTrackBar_Scroll);
            // 
            // KdTrackBar
            // 
            this.KdTrackBar.Location = new System.Drawing.Point(18, 178);
            this.KdTrackBar.Maximum = 100;
            this.KdTrackBar.Name = "KdTrackBar";
            this.KdTrackBar.Size = new System.Drawing.Size(422, 45);
            this.KdTrackBar.TabIndex = 12;
            this.KdTrackBar.Scroll += new System.EventHandler(this.KdTrackBar_Scroll);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(18, 280);
            this.SpeedTrackBar.Maximum = 6000;
            this.SpeedTrackBar.Minimum = 11;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(422, 45);
            this.SpeedTrackBar.TabIndex = 13;
            this.SpeedTrackBar.Value = 11;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "WaitBeforeIgnition Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ignition Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "WaitSecondIgnition Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Throttle";
            // 
            // textBoxKp
            // 
            this.textBoxKp.Location = new System.Drawing.Point(572, 127);
            this.textBoxKp.Name = "textBoxKp";
            this.textBoxKp.Size = new System.Drawing.Size(100, 20);
            this.textBoxKp.TabIndex = 18;
            // 
            // textBoxKd
            // 
            this.textBoxKd.Location = new System.Drawing.Point(572, 178);
            this.textBoxKd.Name = "textBoxKd";
            this.textBoxKd.Size = new System.Drawing.Size(100, 20);
            this.textBoxKd.TabIndex = 19;
            // 
            // textBoxKi
            // 
            this.textBoxKi.Location = new System.Drawing.Point(572, 229);
            this.textBoxKi.Name = "textBoxKi";
            this.textBoxKi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKi.TabIndex = 20;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(572, 280);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ignition Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 10;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(41, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(399, 104);
            this.button5.TabIndex = 23;
            this.button5.Text = "EMERGENCY STOP";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(921, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sami_Unlu_2017";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 493);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxKi);
            this.Controls.Add(this.textBoxKd);
            this.Controls.Add(this.textBoxKp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.KdTrackBar);
            this.Controls.Add(this.KiTrackBar);
            this.Controls.Add(this.KpTrackBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Name = "Form1";
            this.Text = "MSP430 ECU Calibration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KpTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRecive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar KpTrackBar;
        private System.Windows.Forms.TrackBar KiTrackBar;
        private System.Windows.Forms.TrackBar KdTrackBar;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKp;
        private System.Windows.Forms.TextBox textBoxKd;
        private System.Windows.Forms.TextBox textBoxKi;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
    }
}

