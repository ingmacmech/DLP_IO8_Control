using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace DLP_IO8_Control
{
    public partial class Form1 : Form
    {
        private SerialPort sPort = new SerialPort(); 
        bool keepGoing = true;
        string value;




        public Form1()
        {
            InitializeComponent();
            ToggleState();
            initSerial();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ToggleState();

            sPort.Close();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ToggleState();
            sPort.Open();
            //serialPort.WriteLine("\\");
            //serialPort.WriteLine("'");
            StartRead();
        }

        private void ToggleState()
        {
            // Flip the value of the loop control flag  
            keepGoing = !keepGoing;

            // Enable/disable buttons  
            buttonStop.Enabled = keepGoing;
            buttonStart.Enabled = !keepGoing;
        }
        private void StartRead()
        {

            // Set up a new thread to do the counting  
            ThreadStart ts = new ThreadStart(Count);
            Thread t = new Thread(ts);

            // Start the thread  
            t.Start();

            // While this thread is running, the form will continue to respond  
        }
        private void Count()
        {
            // Loop until stopped or the number reaches its maximum value  
            while (keepGoing)
            {
                sPort.WriteLine("X");
                try
                {
                    value = sPort.ReadLine();
                    //label5.Invoke((MethodInvoker)(() => label5.Text = "Requested" + repeats + "Times"));
                    labelValue.Invoke((MethodInvoker)(() => labelValue.Text = value));
                }
                catch (TimeoutException) { }
                // Pause for 100 milliseconds  
                Thread.Sleep(1);
            }

        }

        private void initSerial()
        {
            if (!sPort.IsOpen)
            {
                sPort.BaudRate = 115200;
                sPort.Parity = Parity.None;
                sPort.DataBits = 8;
                sPort.StopBits = StopBits.One;

                try
                {
                    sPort.PortName = this.cBoxSerialPort.GetItemText(this.cBoxSerialPort.SelectedItem);

                    try
                    {
                        sPort.Open();
                        btnConect.Text = "Disconect";
                    }
                    catch
                    {
                        MessageBox.Show("COM port not available!");
                    }
                }
                catch
                {
                    MessageBox.Show("No COM port selected!");
                }
            }
            else
            {
                sPort.Close();
                btnConect.Text = "Conect";
            }
        }

        private void SearchPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            cBoxSerialPort.Items.Clear();
            foreach (string port in ports)
            {
                cBoxSerialPort.Items.Add(port);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchPorts();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            // Open Device Manager
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "devmgmt.msc";
            process.Start();
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            initSerial();

        }

        

        

    }
}
