using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ArduiForm : Form
    {
        SerialPort port;
        public ArduiForm()
        {
            InitializeComponent();
            InitializePort("COM4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        public void InitializePort(string portName)
        {
            if(port == null)
            {
                port = new SerialPort(portName, 9600);
                port.Open();
            }
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void PortWrite(string message)
        {
            if(port != null && port.IsOpen)
            {
                port.Write(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }
    }
}
