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
using Word = Microsoft.Office.Interop.Word;

namespace MessageForYou
{
    public partial class MultiMessageForm : MetroForm
    {
        UseDataBase db;
        string mail;

        public MultiMessageForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            //mf.Show();
            this.Hide();
        }

        private void MinimizedBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MultiMessageForm_Load(object sender, EventArgs e)
        {
            db = new UseDataBase();
            metroComboBox1.DataSource = db.SQLQuery("Select * from groups");
            metroComboBox1.DisplayMember = "NAME";
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            dt = db.SQLQuery("SELECT distinct Parents.FIO FROM Parents INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent INNER JOIN Students ON ParentsSudents.idStudent = Students.idStudent INNER JOIN Groups ON Students.idGroup = Groups.idGroup WHERE Groups.Name='" + metroComboBox1.Text +"'");
            checkedListBox1.Items.Clear();
            for (int i = 0; i<dt.Rows.Count;i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i][0].ToString(),true);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count != 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count != 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SaveAndSend saveSend = new SaveAndSend();
            string filename = comboBox1.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                string currDir = Environment.CurrentDirectory.ToString() + @"\examples\Собрание.dotx";
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    if (checkedListBox1.GetItemChecked(j) == true)
                    {
                        saveSend.WordMarks(filename, currDir, metroTextBox3.Text, metroTextBox1.Text, checkedListBox1.Items[j].ToString(), metroComboBox1.Text, metroComboBox1.Text, checkedListBox1.Items[j].ToString());
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string currDir = Environment.CurrentDirectory.ToString() + @"\examples\Мероприятие.dotx";
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    if (checkedListBox1.GetItemChecked(j) == true)
                    {
                        saveSend.WordMarks(filename, currDir, metroTextBox3.Text, metroTextBox1.Text, checkedListBox1.Items[j].ToString(), metroTextBox2.Text, metroComboBox1.Text, metroComboBox1.Text, checkedListBox1.Items[j].ToString());
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                string currDir = Environment.CurrentDirectory.ToString() + @"\examples\Отчисление.dotx";
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    if (checkedListBox1.GetItemChecked(j) == true)
                    {
                        saveSend.WordMarks(filename, currDir, metroTextBox3.Text, metroTextBox1.Text, checkedListBox1.Items[j].ToString(), metroTextBox2.Text, metroComboBox1.Text, metroComboBox1.Text, checkedListBox1.Items[j].ToString());
                    }
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                string currDir = Environment.CurrentDirectory.ToString() + @"\examples\Другое.dotx";
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    if (checkedListBox1.GetItemChecked(j) == true)
                    {
                        saveSend.WordMarks(filename, currDir, metroTextBox3.Text, metroTextBox1.Text, checkedListBox1.Items[j].ToString(), metroTextBox2.Text, metroComboBox1.Text, metroComboBox1.Text, checkedListBox1.Items[j].ToString());
                    }
                }
            }
            MessageBox.Show("Письма отправлены");
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel7.Text = comboBox1.Text;
            if(comboBox1.Text=="Мероприятие" | comboBox1.Text == "Другое")
            {
                metroLabel9.Visible = true;
                metroTextBox2.Visible = true;
                label1.Visible = true;
            }
            else
            {
                metroLabel9.Visible = false;
                metroTextBox2.Visible = false;
                label1.Visible = false;
            }
            if (comboBox1.Text == "Отчисление")
            {
                //comboBox2.Visible = true;
                label2.Visible = true;
                metroTextBox2.Visible = true;
                metroLabel6.Text = "Дата отчисления:";
            }
            else
            {
                metroLabel6.Text = "Дата мероприятия:";
                //comboBox2.Visible = false;
                label2.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
