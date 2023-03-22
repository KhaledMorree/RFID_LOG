using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_LOG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        int StartPoint = 0;
        int MyProgress;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 1;
            MyProgress= StartPoint;
            if (MyProgress==50)
            {
                MyProgress = 0;
                timer1.Stop();
                this.Hide();
                Logging logging = new Logging();
                logging.ShowDialog();
            }

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
