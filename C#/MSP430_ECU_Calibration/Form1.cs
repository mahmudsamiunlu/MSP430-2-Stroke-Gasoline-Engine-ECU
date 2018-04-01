using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LineFollower_v0._1
{
    public partial class Form1 : Form
    {
        double Kp;
        double Kd;
        double Ki;
        int LineWB=0;
        // 0 Siyah çizgi 
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();

            button1.Enabled = false;
            SpeedTrackBar.Enabled = false;
            buttonReceive.Enabled = false;
            textBox1.Enabled = false;
            textBoxRecive.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            KiTrackBar.Enabled = false;
            KdTrackBar.Enabled = false;
            KpTrackBar.Enabled = false;
            textBoxKd.Enabled = false;
            textBoxKp.Enabled = false;
            textBoxKi.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();

            comboBox3.Items.AddRange(ports);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox2.Text=="" || comboBox3.Text=="")
                {
                    textBoxRecive.Text = "Port Sec";
                }
                else
                {
                    serialPort1.PortName = comboBox3.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    button1.Enabled = true;
                    buttonReceive.Enabled = true;
                    textBox1.Enabled = false; // test icin kapattık 
                    button3.Enabled = false;
                    textBoxRecive.Enabled = true; //TEST ICIN
                    button4.Enabled = true;
                    buttonReceive.Enabled = false;
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
                textBoxRecive.Text = "Unauthorized Access";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button1.Enabled = false;
            buttonReceive.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
            textBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("a");
            if(textBox1.Text!="")
            { serialPort1.WriteLine(textBox1.Text); }
            else
                //serialPort1.WriteLine("Kp="+ Kp.ToString()+"Kd="+ Kd.ToString() + "Ki=" + Ki.ToString() + "Speed="+textBoxSpeed.Text+"LineWB="+LineWB.ToString()+"EStop=1"+"&");
                serialPort1.Write(textBoxSpeed.Text+"\r");
                //textBox1.Text = "";
                try
                {
                textBoxRecive.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                textBoxRecive.Text = "Timeout Exeption";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                textBoxRecive.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                textBoxRecive.Text = "Timeout Exeption";
            }

            /*
           catch(Exception ex )
           {
               MessageBox.Show(ex.Message);
               textBoxRecive.Text = "Unauthorized Access";
           }

           */
        }

        private void kpTrackBar_Scroll(object sender, EventArgs e)
        {

             Kp = KpTrackBar.Value;
                Kp /= 1000;
            textBoxKp.Text = Kp.ToString();
            Kp *= 1000;
        }

        private void KdTrackBar_Scroll(object sender, EventArgs e)
        {
             Kd = KdTrackBar.Value;
            Kd /= 100;
            textBoxKd.Text = Kd.ToString();
            Kd *= 100;
        }

        private void KiTrackBar_Scroll(object sender, EventArgs e)
        {
             Ki = KiTrackBar.Value;
            Ki /= 10000;
            textBoxKi.Text = Ki.ToString();
            Ki *= 10000;
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            textBoxSpeed.Text = SpeedTrackBar.Value.ToString();
            serialPort1.Write(textBoxSpeed.Text + "\r");
            //textBox1.Text = "";
            try
            {
                textBoxRecive.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                textBoxRecive.Text = "Timeout Exeption";
            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (LineWB == 0)
            {
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
            }
            if (LineWB == 1)
            {
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
               
            }
            LineWB++;

             if (LineWB > 1) LineWB = 0;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Try catch koy çünkü burdada send ediyorsun 

            //serialPort1.WriteLine("a");
            if (textBox1.Text != "")
            { serialPort1.WriteLine(textBox1.Text); }
            else
                serialPort1.WriteLine("Kp=" + Kp.ToString() + "Kd=" + Kd.ToString() + "Ki=" + Ki.ToString() + "Speed=" + textBoxSpeed.Text + "LineWB=" + LineWB.ToString() +"EStop=0"+"&");
            //textBox1.Text = "";
            try
            {
                textBoxRecive.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                textBoxRecive.Text = "Timeout Exeption";
            }
        }

        private void textBoxRecive_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
