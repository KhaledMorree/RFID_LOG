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
using System.Data.SqlClient;
using System.Configuration;

namespace RFID_LOG
{
    public partial class RegiserId : Form
    {
         string Employeeconfig = ConfigurationManager.ConnectionStrings
         ["Rfid"].ConnectionString;
        string ComboBoxId =
        @"
        SELECT TagsId
        FROM Tags
        ORDER BY TagsId
             ";
        string ComboBoxName =
            @"
            SELECT TagsNavn
            FROM Tags
            ORDER BY TagsNavn
            ";
        string rfidTag;
        SerialPort port = new System.IO.Ports.SerialPort("COM3", 9600, System.IO.Ports.Parity.None, 8
         , System.IO.Ports.StopBits.One);
        public RegiserId()
        {
            InitializeComponent();
            imporTOcomboBox(cboId, ComboBoxId);
            imporTOcomboBox(cboAnsatNAvnn, ComboBoxName);
        }

        private void btnInitiall_Click(object sender, EventArgs e)
        {

            try
            {
                port.Open();
                port.DtrEnable = true;
                txtBoxId.Text = "";
            }
            catch (Exception)
            {

             
            }
        }

        private void btnScann_Click(object sender, EventArgs e)
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


                txtBoxId.Text = rfidTag;
                port.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
          
        }
        void ViewData(string sqlQuery)
        {
            SqlConnection connectionToId =
            new SqlConnection(Employeeconfig);
            SqlDataAdapter sda;
            DataTable dt;
            try
            {
                connectionToId.Open();
                sda = new SqlDataAdapter(sqlQuery, connectionToId);
                dt = new DataTable();
                sda.Fill(dt);
                dgvId.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        void imporTOcomboBox(ComboBox comboBox, string sqlQuery)
        {
            try
            {
                SqlConnection conEmployee = new SqlConnection(Employeeconfig);
                SqlCommand sql = new SqlCommand(sqlQuery, conEmployee);
                sql.CommandType = CommandType.Text;
                conEmployee.Open();
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read() == true)
                {
                    sqlQuery = dr[0].ToString();
                    comboBox.Items.Add(sqlQuery);
                }

                conEmployee.Close();
                comboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }
        void ViewTag()
        {
            String sqlQuery =
                @"
               SELECT TagsId,TagsNavn,DateTime,TagsUID
        FROM Tags
        ORDER BY TagsId
            ";
            ViewData(sqlQuery);
        }
   

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Tag,TagName;

            Tag = txtBoxId.Text;
            TagName = txtAnsattName.Text;
            try
            {
                void ViewTag()
                {
                    String sqlQuery =
                        @"
               SELECT TagsId,TagsNavn,DateTime,TagsUID
        FROM Tags
        ORDER BY TagsId
            ";
                    ViewData(sqlQuery);
                }
                ViewTag();
                cboId.Items.Clear();
                cboAnsatNAvnn.Items.Clear();
                imporTOcomboBox(cboId , ComboBoxId);
                imporTOcomboBox(cboAnsatNAvnn, ComboBoxName);
                cboId.SelectedIndex = 0;
                cboAnsatNAvnn.SelectedIndex = 0;
                txtBoxId.Clear();
                txtAnsattName.Clear();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }
        private void btnVeiw_Click(object sender, EventArgs e)
        {
            ViewTag();
        }

        private void btnDeletTag_Click(object sender, EventArgs e)
        {
            string Tag, TagName;
            Tag = cboId.Text;
            TagName = cboAnsatNAvnn.Text;
            try
            {
                SqlConnection conTag = new SqlConnection(Employeeconfig);
                SqlCommand sql = new SqlCommand("UPDeleteTAG", conTag);
                sql.CommandType = CommandType.StoredProcedure;
                conTag.Open();
                sql.Parameters.Add(new SqlParameter("@tagsId", Tag));
                sql.Parameters.Add(new SqlParameter("@tagsNavn", TagName));
                sql.ExecuteNonQuery();
                conTag.Close();
                ViewTag();
                cboId.Items.Clear();
                cboAnsatNAvnn.Items.Clear();
                imporTOcomboBox(cboId, ComboBoxId);
                imporTOcomboBox(cboAnsatNAvnn, ComboBoxName);
                cboId.SelectedIndex = 0;
                cboAnsatNAvnn.SelectedIndex = 0;
                txtBoxId.Clear();
                txtAnsattName.Clear();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string TagToBeUpdated, TagNewValue;
            TagToBeUpdated = cboId.Text;
            TagNewValue = txtBoxId.Text;
            try
            {
                SqlConnection conTag = new SqlConnection(Employeeconfig);
                SqlCommand sql = new SqlCommand("usUpdateTAG", conTag);
                sql.CommandType = CommandType.StoredProcedure;
                conTag.Open();
                sql.Parameters.Add(new SqlParameter("@tagsIdUpdate", TagToBeUpdated));
                sql.Parameters.Add(new SqlParameter("@newTagValue", TagNewValue));
                sql.ExecuteNonQuery();
                conTag.Close();
                ViewTag();
                cboId.Items.Clear();
                cboAnsatNAvnn.Items.Clear();
                imporTOcomboBox(cboId, ComboBoxId);
                cboId.SelectedIndex = 0;
                cboAnsatNAvnn.SelectedIndex = 0;
                txtBoxId.Clear();
                txtAnsattName.Clear();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            string NameToBeUpdated, NameNewValue;
            NameToBeUpdated = cboAnsatNAvnn.Text;
            NameNewValue = txtAnsattName.Text;
            try
            {
                SqlConnection conTag = new SqlConnection(Employeeconfig);
                SqlCommand sql = new SqlCommand("usUPDATEName", conTag);
                sql.CommandType = CommandType.StoredProcedure;
                conTag.Open();
                sql.Parameters.Add(new SqlParameter("@nameToBeUpdated", NameToBeUpdated));
                sql.Parameters.Add(new SqlParameter("@newNameValue", NameNewValue));
                sql.ExecuteNonQuery();
                conTag.Close();
                ViewTag();
                cboId.Items.Clear();
                cboAnsatNAvnn.Items.Clear();
                imporTOcomboBox(cboAnsatNAvnn, ComboBoxName);
                cboId.SelectedIndex = 0;
                cboAnsatNAvnn.SelectedIndex = 0;
                txtBoxId.Clear();
                txtAnsattName.Clear();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }
    }
}
