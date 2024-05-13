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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arduinoilkdeneme
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            goder(guna2TextBox1.Text, "c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  
            foreach (string port in ports)
                guna2ComboBox1.Items.Add(port); 
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            goder(guna2TextBox1.Text, "d");
        }
        public string portkey;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = guna2ComboBox1.SelectedItem.ToString(); 
           
            serialPort1.Open();
            guna2ComboBox1.Enabled = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = true; if (serialPort1.IsOpen) serialPort1.Close();
        }
       public void goder(string adim,string yon)
        {

            
            serialPort1.WriteLine(adim+yon);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            goder(guna2TextBox1.Text,"a");
            
        }
        string data;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(dspevent));
        }
        private void dspevent(object sender, EventArgs e)
        {
            label1.Text = serialPort1.ReadLine();
            

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            goder(guna2TextBox1.Text, "b");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        { 
            pictureBox1.Visible=false;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
