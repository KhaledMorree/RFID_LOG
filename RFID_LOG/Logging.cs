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
using System.Windows.Forms.DataVisualization.Charting;

namespace RFID_LOG
{
    public partial class Logging : Form
    {
        string rfidTag;
        SerialPort port = new System.IO.Ports.SerialPort("COM3", 9600, System.IO.Ports.Parity.None, 8
         , System.IO.Ports.StopBits.One);
        public Logging()
        {
            InitializeComponent();

        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            try
            {
                port.Open();
                port.DtrEnable = true;
                txtTagData.Text = "";
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int numberBytesToRead = 4;
                byte[] data = new byte[numberBytesToRead];
                port.ReadTimeout = 1000;
                port.Read(data, 0, numberBytesToRead);

                rfidTag = "";
                for (int i = 0; i < numberBytesToRead; i++)
                {
                    rfidTag = rfidTag + data[i].ToString("X");
                };


                txtTagData.Text = rfidTag;
                port.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegiserId regiserId = new RegiserId();
        
            if (txtTagData.Text.Equals("B59D3847"))
            {
                regiserId.ShowDialog();
            }
            else if (txtTagData.Text.Equals("8BBC5547"))
            {
                regiserId.ShowDialog();
            }
            else if (txtTagData.Text.Equals("CB62247"))
            {
                regiserId.ShowDialog();
            }
            else if (txtTagData.Text.Equals("DB7C4F47"))
            {
                regiserId.ShowDialog();
            }
            else if (txtTagData.Text.Equals("F93584D6"))
            {
                regiserId.ShowDialog();
            }
            else
            {
                btnNext.Enabled=true;
                MessageBox.Show("Feil innlogging, bruk gyldig Kort");
            }



        }

      
    }
}
