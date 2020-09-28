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
using System.Data.SQLite;

namespace MessageForYou
{

    public partial class LoginForm : MetroForm
    {
        UseDataBase db;
        public string login;
        public string UserMail;


        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void PasswordRecovery_Click(object sender, EventArgs e)
        {
            db = new UseDataBase();
            DataTable dt = new DataTable();
            //При нажатии на кнопку сработает проверка:
            // 1. Введён ли e-mail. 
            // 2. Есть ли такой e-mail в БД
            // Затем отправить пароль на почту и вывести msgBox
            db = new UseDataBase();
            dt = db.SQLQuery("Select login,password from Users where login='"+metroTextBox1.Text+"'");
            try
            {
                if (metroTextBox1.Text == dt.Rows[0][0].ToString())
                {
                    SendAnEmail mail = new SendAnEmail();
                    mail.SendOneEmail(metroTextBox1.Text, "Восстановление пароля", "Пароль от Вашей учётной записи:\n" + dt.Rows[0][1].ToString());
                }
                if (metroTextBox1.Text == "") MessageBox.Show("Заполните поле \"Электронная почта\"");
            }
            catch
            {
                if (metroTextBox1.Text == "") MessageBox.Show("Заполните поле \"Электронная почта\"");
                else MessageBox.Show("Указанный логин не существует");
            }
        }

        private void MainFormOpen_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db = new UseDataBase();
            dt = db.SQLQuery("Select login,password from Users where login='" + metroTextBox1.Text + "'");
            try
            {
                if (metroTextBox1.Text == dt.Rows[0][0].ToString())
                {
                    if (metroTextBox2.Text == dt.Rows[0][1].ToString())
                    {
                        DataTable tempTable = new DataTable();
                        tempTable = db.SQLQuery("Select login,username from Users where login='" + metroTextBox1.Text + "'");
                        MainForm mf = new MainForm();
                        UserMail = tempTable.Rows[0][1].ToString();
                        login = tempTable.Rows[0][0].ToString();
                        mf.UserNameLabel.Text = UserMail;
                        mf.MailLabel.Text = login;
                        mf.Show();
                        this.Hide();
                    }
                    if (metroTextBox2.Text != dt.Rows[0][1].ToString()) MessageBox.Show("Пароль не введён, либо введён некорректно", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch { MessageBox.Show("Неправильный логин и/или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void metroButton2_Click(object sender, EventArgs e)
        //{
        //    string conString = @"DataSource=E:\DataBase.db3; Version = 3;";
        //    SQLiteConnection connection = new SQLiteConnection(conString);
        //    //connection.Open();
        //    connection.SetPassword("password");
        //    MessageBox.Show("Test");

        //}
    }
}
