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
using System.Threading;



namespace RedwoodV2
{
    public partial class S2070 : Form
    {
        //variables
        static bool _continue;
        static SerialPort serialPort1;

        public S2070()
        {
            InitializeComponent();
        }

        private void Establish_Connection()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsolePanel_Scroll(object sender, ScrollEventArgs e)
        {

        }

        //Opens Serial Port Connection
        private void Btn_estb_connect_Click(object sender, EventArgs e)
        {
            /*
            * Slot #1 =COMM101, Slot #2 =COMM102, Slot #3 =COMM103, Slot #4 =COMM104
            * Slot #5 =COMM105, Slot #6 =COMM106, Slot #7 =COMM107, Slot #8 =COMM108
            * Slot #9 =COMM109, Slot #10 =COMM110, Slot #11 =COMM111, Slot #12 =COMM112
            * Slot #13 =COMM113, Slot #14 =COMM114, Slot #15 =COMM115, Slot #16 =COMM116
            */

            Btn_estb_connect.Enabled = false;
            Btn_Close_Connection.Enabled = true;
            try
            {
                serialPort1.PortName = AvailablePortsComboBox1.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // S2070.exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ConsoleScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        //Loads List of Available COMMs
        private void S2070_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            AvailablePortsComboBox1.Items.AddRange(ports);
            AvailablePortsComboBox1.SelectedIndex = 0;
            Btn_Close_Connection.Enabled = false;

        }

        //Closes Serial Connection
        private void Btn_Close_Connection_Click(object sender, EventArgs e)
        {
            Btn_estb_connect.Enabled = true;
            Btn_Close_Connection.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Send_Comm1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(Console_SendTextBox.Text + Environment.NewLine);
                    Console_SendTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Console_RecieveRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Receive_Comm1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    Console_RecieveRichTextBox.Text = serialPort1.ReadExisting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void S2070_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void AvailablePortsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InitializeComponent();
            foreach (string s in SerialPort.GetPortNames())
            {
                AvailablePortsComboBox1.Items.Add(s);

            }
        }
    }
}


