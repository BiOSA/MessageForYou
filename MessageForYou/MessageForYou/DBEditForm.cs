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
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace MessageForYou
{
    public partial class DBEditForm : MetroForm
    {
        UseDataBase db;
        MainForm mf = new MainForm();

        int studNum;
        int TeacherIndex;
        int Groupid;
        int Parentid;
        int Userid;

        public string selectedStudentID;
        public string selectedStudentFIO;


        public DBEditForm()
        {
            InitializeComponent();
        }

        

        private void MinimizedBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db = new UseDataBase();
            string GroupIndex;
            string Temp;
            if (metroTextBox1.Text != "" & metroTextBox2.Text != "")
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    Temp = "0";
                }
                else
                {
                    Temp = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString();//код
                } 
                studNum = Convert.ToInt32(Temp);
                studNum++;
                dt = db.SQLQuery("select idGroup from Groups where name='" + comboBox6.Text + "'");
                GroupIndex = dt.Rows[0][0].ToString();
                dataGridView1.DataSource = db.SQLQuery("Insert INTO Students Values (" + studNum + ",'" + metroTextBox1.Text + "'," + metroTextBox2.Text + ",'" + metroTextBox3.Text + "'," + GroupIndex + ")");
                dataGridView1.DataSource = db.SQLQuery("Select idStudent,FIO,TelNum,Adres,idGroup from Students");
                pictureBox2.BackColor = Color.Green;
            }
            else  MessageBox.Show("Заполните все поля");
        }

        //________________________________Окрашивание кнопок "Добавить"___________________________________
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Gray;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }
        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.Gray;
        }
        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.White;
        }
        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.Gray;
        }
        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.White;
        }
        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Gray;
        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.White;
        }
        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Gray;
        }
        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.White;
        }

        //________________________________Окрашивание кнопок "Изменить"___________________________________
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }
        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.Gray;
        }
        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.White;
        }
        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.Gray;
        }
        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.White;
        }
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Gray;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.White;
        }
        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.Gray;
        }
        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.White;
        }

        //________________________________Окрашивание кнопок "Удалить"____________________________________
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Gray;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }
        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.Gray;
        }
        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.White;
        }
        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.Gray;
        }
        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.White;
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Gray;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.White;
        }
        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.Gray;
        }
        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.White;
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            string GroupIndex;
            DataTable dt = new DataTable();
            if (metroTextBox1.Text != "" & metroTextBox2.Text != "")
            {
                dt = db.SQLQuery("select idGroup from Groups where name='" + comboBox6.Text + "'");
            GroupIndex = dt.Rows[0][0].ToString();
            db.SQLQuery("Update Students Set FIO='" + metroTextBox1.Text + "',TelNum=" + metroTextBox2.Text + ",Adres='" + metroTextBox3.Text + "',idGroup="+ GroupIndex + " where idStudent='" + metroTextBox21.Text + "'");
            dataGridView1.DataSource = db.SQLQuery("Select * from Students");
            pictureBox3.BackColor = Color.NavajoWhite;
            }
            else  MessageBox.Show("Заполните все поля"); 
        }

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить запись: \"" + metroTextBox1.Text + "\" из БД?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                db = new UseDataBase();
                db.SQLQuery("Delete from Students where idStudent='" + metroTextBox21.Text + "'");
                dataGridView1.DataSource = db.SQLQuery("Select * from Students");
                pictureBox4.BackColor = Color.Crimson;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //mf.Show();
            this.Close();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void DBEditForm_Load(object sender, EventArgs e)
        {
            db = new UseDataBase();

            //1 - Студенты
            //2 - Группы
            //3 - Родители
            //4 - Преподаватели
            //5 - пользователи

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = db.SQLQuery("Select * from Students");
            dataGridView2.DataSource = db.SQLQuery("Select * from Groups");
            dataGridView3.DataSource = db.SQLQuery("Select * from Parents");
            dataGridView4.DataSource = db.SQLQuery("Select * from Teachers");
            dataGridView5.DataSource = db.SQLQuery("Select * from Users");

            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox2.Text = comboBox2.Items[0].ToString();
            comboBox3.Text = comboBox3.Items[0].ToString();
            comboBox4.Text = comboBox4.Items[0].ToString();
            comboBox5.Text = comboBox5.Items[0].ToString();
            
            comboBox6.DataSource = db.SQLQuery("Select name from Groups");
            comboBox6.DisplayMember = "name";
            //comboBox6.ValueMember = "idGroup";

            comboBox7.DataSource = db.SQLQuery("Select FIO from Teachers");
            comboBox7.DisplayMember = "FIO";
        }

        //Students
        private void button1_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView1.DataSource = db.Find("students", comboBox5.Text, metroTextBox16.Text);
        } //Students
        private void button2_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView1.DataSource = db.SQLQuery("Select * from Students");
        } //Students

        //Groups
        private void metroButton4_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView4.DataSource = db.Find("Teachers", comboBox1.Text, metroTextBox17.Text);
        } 
        private void metroButton3_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView4.DataSource = db.SQLQuery("Select * from Teachers");
        } 

        //Parents
        private void metroButton6_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView2.DataSource = db.Find("Groups", comboBox2.Text, metroTextBox18.Text);
        } 
        private void metroButton5_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView2.DataSource = db.SQLQuery("Select * from Groups");
        } 

        //Teachers
        private void metroButton8_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView3.DataSource = db.Find("Parents", comboBox3.Text, metroTextBox19.Text);
        } 
        private void metroButton7_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView3.DataSource = db.SQLQuery("Select * from Parents");
        } 
        
        //Users
        private void metroButton10_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView5.DataSource = db.Find("Users", comboBox4.Text, metroTextBox20.Text);
        } //Users
        private void metroButton9_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            dataGridView5.DataSource = db.SQLQuery("Select * from Users");
        } //Users

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new UseDataBase();
            try
            {
                studNum = int.Parse(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString()); //код
                //MessageBox.Show(studNum.ToString());
                metroTextBox21.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //код
                metroTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); //ФИО
                metroTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); //Телефон
                metroTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); //Адрес
                DataTable dt = new DataTable();
                dt = db.SQLQuery("Select Name from Groups where idGroup="+ dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                string GroupIndex = dt.Rows[0][0].ToString();
                //comboBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); 
                comboBox6.Text = GroupIndex;//Группа
            }
            catch { }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db = new UseDataBase();
            
            string Temp;
            if (metroTextBox5.Text != "" & metroTextBox7.Text != "") //Добавить
            {
                dt = new DataTable();
                dt = db.SQLQuery("Select id from Users");
                TeacherIndex++;
                if (dt.Rows.Count == 0) { Temp = "0"; }
                else { Temp = dt.Rows[dt.Rows.Count - 1][0].ToString(); }
                Userid = Convert.ToInt32(Temp);
                Userid++;
                dataGridView4.DataSource = db.SQLQuery("Insert INTO Teachers Values (" + TeacherIndex + ",'" + metroTextBox5.Text + "'," + metroTextBox11.Text + ",'" + metroTextBox7.Text + "')");
                db.SQLQuery("Insert into Users Values ("+ Userid + ", '"+metroTextBox7.Text+"','"+metroTextBox10.Text+"','"+metroTextBox5.Text+"')");
                dataGridView4.DataSource = db.SQLQuery("Select * from Teachers");
                pictureBox15.BackColor = Color.Green;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void pictureBox13_Click(object sender, EventArgs e) //удалить
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить запись: \"" + metroTextBox5.Text + "\" из БД?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                db = new UseDataBase();
                db.SQLQuery("Delete from Teachers where idTeacher='" + metroTextBox22.Text + "'");
                dataGridView4.DataSource = db.SQLQuery("Select * from Teachers");
                pictureBox13.BackColor = Color.Crimson;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)//Обновить
        {
            db = new UseDataBase();
            if (metroTextBox5.Text != "" & metroTextBox7.Text != "")
            {
                db.SQLQuery("Update Teachers Set FIO='" + metroTextBox5.Text + "',TelNum=" + metroTextBox11.Text + ", Email='" + metroTextBox7.Text + "' where idTeacher='" + metroTextBox22.Text + "'");
                dataGridView4.DataSource = db.SQLQuery("Select * from Teachers");
                pictureBox14.BackColor = Color.NavajoWhite;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new UseDataBase();
            try
            {
                TeacherIndex = int.Parse(dataGridView4.Rows[dataGridView4.RowCount - 1].Cells[0].Value.ToString()); //код
                metroTextBox22.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString(); //Код
                metroTextBox5.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString(); //ФИО
                metroTextBox11.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString(); //Телефон
                metroTextBox7.Text = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString(); //Почта
            }
            catch { }
        }

        private void pictureBox9_Click(object sender, EventArgs e) //Добавить группу
        {
            DataTable dt = new DataTable();
            db = new UseDataBase();
            string TeacherId;
            string Temp;
            if (metroTextBox6.Text != "" & comboBox7.Text != "") //Добавить
            {
                dt = new DataTable();
                dt = db.SQLQuery("Select idGroup from Groups");
                if (dt.Rows.Count == 0) { Temp = "0"; }
                else { Temp = dt.Rows[dt.Rows.Count - 1][0].ToString(); }
                Groupid = Convert.ToInt32(Temp);
                Groupid++;
                dt = db.SQLQuery("Select idTeacher from Teachers where FIO='" + comboBox7.Text+"'");
                TeacherId = dt.Rows[0][0].ToString();
                dataGridView2.DataSource = db.SQLQuery("Insert INTO Groups Values (" + Groupid + ",'" + metroTextBox6.Text + "','" + TeacherId + "')");
                dataGridView2.DataSource = db.SQLQuery("Select * from Groups");
                pictureBox9.BackColor = Color.Green;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void pictureBox6_Click(object sender, EventArgs e) //Изменить группу
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            string TeacherId;
            if (metroTextBox6.Text != "" & comboBox7.Text != "")
            {
                dt = db.SQLQuery("Select idTeacher from Teachers where FIO='" + comboBox7.Text + "'");
                TeacherId = dt.Rows[dt.Rows.Count - 1][0].ToString();
                db.SQLQuery("Update Groups Set Name='" + metroTextBox6.Text + "',idTeacher='" + TeacherId + "'  where idGroup='" + metroTextBox23.Text + "'");
                dataGridView2.DataSource = db.SQLQuery("Select * from Groups");
                pictureBox14.BackColor = Color.NavajoWhite;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void pictureBox5_Click(object sender, EventArgs e) //Удалить группу
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить запись: \"" + metroTextBox6.Text + "\" из БД?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                db = new UseDataBase();
                db.SQLQuery("Delete from Groups where idGroup='" + metroTextBox23.Text + "'");
                dataGridView2.DataSource = db.SQLQuery("Select * from Groups");
                pictureBox5.BackColor = Color.Crimson;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            try
            {
                Groupid = int.Parse(dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value.ToString()); //код
                metroTextBox23.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString(); //Код
                metroTextBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(); //Наименование
                dt = db.SQLQuery("Select FIO from Teachers where idTeacher='"+ dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                comboBox7.Text = dt.Rows[0][0].ToString(); //Преподаватель
            }
            catch { }
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            string indexToDel;
            db = new UseDataBase();
            DataTable dt = new DataTable();
            try
            {
                dt = db.SQLQuery("Select idStudent from ParentsSudents where idParent='"+metroTextBox24.Text+"'");
                indexToDel = dt.Rows[listBox1.SelectedIndex][0].ToString();
                db.SQLQuery("Delete from ParentsSudents where idStudent='"+indexToDel+ "' and idParent='" + metroTextBox24.Text + "'");
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch { }
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
            }
            catch { }
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            try
            {
                db = new UseDataBase();
                SelectStudentForm ssf = new SelectStudentForm();
                ssf.ShowDialog();
                selectedStudentID = ssf.selectedStudentID;
                selectedStudentFIO = ssf.selectedStudentFIO;
                listBox1.Items.Add(selectedStudentFIO);
                db.SQLQuery("Insert Into ParentsSudents Values('" + metroTextBox24.Text + "','" + selectedStudentID + "')");
            }
            catch { }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            DataTable Temp = new DataTable();
            try
            {
                Parentid = int.Parse(dataGridView3.Rows[dataGridView3.RowCount - 1].Cells[0].Value.ToString()); //код
                metroTextBox24.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString(); //Код
                metroTextBox9.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString(); //ФИО
                metroTextBox8.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString(); //Телефон
                metroTextBox4.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString(); //Почта
                listBox1.Items.Clear();
                dt = db.SQLQuery("SELECT Students.idStudent FROM Parents INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent INNER JOIN Students ON ParentsSudents.idStudent = Students.idStudent WHERE Parents.idParent='"+ metroTextBox24.Text + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Temp = db.SQLQuery("Select FIO from Students where idStudent='"+dt.Rows[i][0].ToString()+"'");
                    listBox1.Items.Add(Temp.Rows[0][0].ToString());
                }
            }
            catch { }
        }

        private void pictureBox10_Click(object sender, EventArgs e) //Удалить
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить запись: \"" +metroTextBox9.Text +"\" из БД?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                db = new UseDataBase();
                db.SQLQuery("Delete from Parents where idParent='" + metroTextBox24.Text + "'");
                db.SQLQuery("Delete from ParentsSudents where idParent='" + metroTextBox24.Text + "'");
                dataGridView3.DataSource = db.SQLQuery("Select * from Parents");
                pictureBox10.BackColor = Color.Crimson;
            }
            
            
        }

        private void pictureBox12_Click(object sender, EventArgs e) //Добавить
        {
            DataTable dt = new DataTable();
            db = new UseDataBase();
            string Temp;
            if (metroTextBox9.Text != "" & comboBox4.Text != "")
            {
                dt = new DataTable();
                dt = db.SQLQuery("Select idParent from Parents");
                if (dt.Rows.Count == 0)
                {
                    Temp = "0";
                }
                else
                {
                    Temp = dt.Rows[dt.Rows.Count - 1][0].ToString();
                }
                Parentid = Convert.ToInt32(Temp);
                Parentid++;
                dataGridView3.DataSource = db.SQLQuery("Insert INTO Parents Values (" + Parentid + ",'" + metroTextBox9.Text + "','" + metroTextBox8.Text + "','"+ metroTextBox4.Text + "')");
                dataGridView3.DataSource = db.SQLQuery("Select * from Parents");
                pictureBox12.BackColor = Color.Green;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void pictureBox11_Click(object sender, EventArgs e) //Изменить
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            if (metroTextBox9.Text != "" & comboBox4.Text != "")
            {
                db.SQLQuery("Update Parents Set FIO='" + metroTextBox9.Text + "',TelNum='" + metroTextBox8.Text + "',Email='" + metroTextBox4.Text + "'  where idParent='" + metroTextBox24.Text + "'");
                dataGridView3.DataSource = db.SQLQuery("Select * from Parents");
                pictureBox11.BackColor = Color.NavajoWhite;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void pictureBox16_Click(object sender, EventArgs e) //Удалить пользователя
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить запись: \"" + metroTextBox15.Text + "\" из БД?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                db = new UseDataBase();
                db.SQLQuery("Delete from Users where id='" + metroTextBox25.Text + "'");
                dataGridView5.DataSource = db.SQLQuery("Select * from Users");
                pictureBox16.BackColor = Color.Crimson;
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            DataTable Temp = new DataTable();
            try
            {
                Userid = int.Parse(dataGridView5.Rows[dataGridView5.RowCount - 1].Cells[0].Value.ToString()); //код
                metroTextBox25.Text = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString(); //Код
                metroTextBox15.Text = dataGridView5.Rows[e.RowIndex].Cells[3].Value.ToString(); //Имя пользователя
                metroTextBox14.Text = dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString(); //Логин
                metroTextBox13.Text = dataGridView5.Rows[e.RowIndex].Cells[2].Value.ToString(); //Пароль
                comboBox8.Text = dataGridView5.Rows[e.RowIndex].Cells[4].Value.ToString(); //Роль
            }
            catch { }
        }

        private void pictureBox18_Click(object sender, EventArgs e) //Добавить пользователя
        {
            db = new UseDataBase();
            if (metroTextBox15.Text != "" & metroTextBox14.Text != "" & metroTextBox13.Text != "" & comboBox8.Text != "")
            {                 
                Userid++;
                dataGridView5.DataSource = db.SQLQuery("Insert INTO Users Values (" + Userid + ",'" + metroTextBox14.Text + "','" + metroTextBox13.Text + "','" + metroTextBox15.Text + "','" + comboBox8.Text + "')");
                dataGridView5.DataSource = db.SQLQuery("Select * from Users");
                pictureBox18.BackColor = Color.Green;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void pictureBox17_Click(object sender, EventArgs e) //Изменить пользователя
        {
            db = new UseDataBase();
            if (metroTextBox15.Text != "" & metroTextBox14.Text != "" & metroTextBox13.Text != "" & comboBox8.Text != "")
            {
                db.SQLQuery("Update Users Set Login='" + metroTextBox14.Text + "', Password='" + metroTextBox13.Text + "', UserName='" + metroTextBox15.Text + "', Role='" + comboBox8.Text + "'  where id='" + metroTextBox25.Text + "'");
                dataGridView5.DataSource = db.SQLQuery("Select * from Users");
                pictureBox17.BackColor = Color.NavajoWhite;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
