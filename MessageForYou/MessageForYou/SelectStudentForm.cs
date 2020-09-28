using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace MessageForYou
{
    public partial class SelectStudentForm : MetroForm
    {
        DBEditForm dbForm = new DBEditForm();
        UseDataBase db;
        bool isChecked = false;
        public string selectedStudentID;
        public string selectedStudentFIO;

        public SelectStudentForm()
        {
            InitializeComponent();
        }

        private void SelectStudentForm_Load(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = db.SQLQuery("Select * from Students");
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            db = new UseDataBase();
            if (isChecked == false)
            {
                isChecked = true;
                comboBox1.Enabled = true;
                comboBox1.DataSource = db.SQLQuery("Select name from Groups");
                comboBox1.ValueMember = "name";
                string idGroup;
                DataTable dt = new DataTable();
                dt = db.SQLQuery("Select idGroup from Groups where name ='" + comboBox1.Text + "'");
                idGroup = dt.Rows[0][0].ToString();
                dataGridView1.DataSource = db.SQLQuery("Select * from Students where idGroup='" + idGroup + "'");
            }
            else
            {
                isChecked = false;
                comboBox1.Enabled = false;
                comboBox1.Text = "Все";
                dataGridView1.DataSource = db.SQLQuery("Select * from Students");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectedStudentFIO = null;
            selectedStudentID = null;
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView1.DataSource = db.SQLQuery("Select * from Students");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            string idGroup;
            DataTable dt = new DataTable();
            
            if (isChecked == false)
            {
                dataGridView1.DataSource = db.SQLQuery("Select * from Students where FIO='"+metroTextBox1.Text+"'");
            }
            else
            {
                dt = db.SQLQuery("Select idGroup from Groups where name ='" + comboBox1.Text + "'");
                idGroup = dt.Rows[0][0].ToString();
                dataGridView1.DataSource = db.SQLQuery("Select * from Students where FIO='" + metroTextBox1.Text + "' and idGroup='"+ idGroup + "'");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db = new UseDataBase();
                string idGroup;
                DataTable dt = new DataTable();
                dt = db.SQLQuery("Select idGroup from Groups where name ='" + comboBox1.Text + "'");
                idGroup = dt.Rows[0][0].ToString();
                dataGridView1.DataSource = db.SQLQuery("Select * from Students where idGroup='" + idGroup + "'");
            }
            catch { }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudentID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedStudentFIO = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
