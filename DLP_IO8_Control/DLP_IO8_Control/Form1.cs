using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DLP_IO8_Control
{
    public partial class Form1 : Form
    {
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

            serialPort.Close();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ToggleState();
            serialPort.Open();
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
                serialPort.WriteLine("X");
                try
                {
                    value = serialPort.ReadLine();
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
            serialPort.PortName = "COM7";
            serialPort.BaudRate = 115200;
            serialPort.ReadTimeout = 50;
            serialPort.WriteTimeout = 50;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
