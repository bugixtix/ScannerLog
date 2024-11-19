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

namespace Scanner_Log
{

    public partial class Form1 : Form
    {

        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();

            LoadAvailablePorts();
        }

        private void LoadAvailablePorts()
        {
            // init: string array with ports names inside
            string[] ports = SerialPort.GetPortNames();
            // update ui: clear 'Ports Combobox'
            ports_cb.Items.Clear();
            // update ui: put 'ports' inside 'Ports Combobox'
            ports_cb.Items.AddRange(ports);
        }
        private async void SerialPort_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        { // await task
            await Task.Run(() =>
            {
                // init: assign the alerady read barcode to the string 'data'
                string data = serialPort.ReadExisting();
                textLog.Focus();

                textLog.Text += data.ToString();
            });
        }
        private void InitializeSerialPort(string portName)
        {
            try
            {
                // condition: if serial port is alerady opened
                if (serialPort != null && serialPort.IsOpen)
                {   // condition: if user selects the alerady connected serial port.
                    if (serialPort.PortName == portName)
                    {   // inform
                        MessageBox.Show("Der ausgewählte Scanner ist schon ausgewählt *_* ");
                        return;
                    }
                    else
                    {   // close the connection
                        serialPort.Close();
                    }
                } // when the connection is not alerady opened
                serialPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                // add eventlistener
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecieved);
                // open connection
                serialPort.Open();
                // update values
                portConnected.Text = "Connected";
                // call to update ui
            }
            catch (Exception ex)
            {   // inform
                MessageBox.Show("Fehler beim Verbinden: " + ex.Message);
                // update value
                portConnected.Text = "Not Connected";
            } //
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            textLog.Focus();
            // condition: if value was alerady selected from 'Ports Combobox'
            if (ports_cb.SelectedItem != null)
            {   // update value
                string selectedPort = ports_cb.SelectedItem.ToString();
                portConnected.Text = "Connecting";
                // call to initialise serial port
                InitializeSerialPort(selectedPort);
                // calls to update ui
            }
            else
            {   // inform
                MessageBox.Show("Bitte wählen Sie einen COM-Port aus.");
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (portConnected.Text != "Not Connected")
            {
                //
                if (serialPort != null && serialPort.IsOpen)
                {   //
                    try
                    {   // close the connection to the scanner
                        serialPort.Close();
                        // update value
                        // call to update ui
                        LoadAvailablePorts();
                    }
                    catch (Exception ex)
                    {   // inform
                        MessageBox.Show("Exception in Trennen: " + ex.Message);
                    }
                }
            }
            // update values
            portConnected.Text = "Not Connected";
        }
    }
}
