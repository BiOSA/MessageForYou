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
using System.IO;

namespace MessageForYou
{
    public partial class SingleMessageForm : MetroForm
    {
        bool isChecked=false; //Для проверки вкл или выкл фильтр по группам
        OpenFileDialog ofd; //Переменная для открытия файла с помощью проводника Windows
        List<string> filepath = new List<string>(); //объявляем коллекцию
        string path;
        UseDataBase db;


        public SingleMessageForm()
        {
            InitializeComponent();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizedBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e) //переход на главную форму с закрытием текущей
        {
            MainForm mf = new MainForm();
            //mf.Show();
            this.Dispose();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text !="")
            {
                SendAnEmail mail = new SendAnEmail();// объявление переменной класса SendAnEmail
                                                     //Вызов метода для отправки письма одному адресату
                mail.SendOneEmail(metroTextBox3.Text, metroTextBox1.Text, metroTextBox2.Text, @filepath);
                MessageBox.Show("Письмо отправлено");
            }
            else MessageBox.Show("Введите адрес");
        }
        
        private void metroToggle1_CheckedChanged(object sender, EventArgs e) //Проверка включена ли фильтрация по группам
        {
            if (isChecked == false)//Если НЕ включена 
            {
                metroComboBox3.Enabled = true; //Включаем комбобокс
                isChecked = true; //меняем значение переменной
            }
            else //Иначе отключаем комбобокс и присваиваем переменной значение "false"
            {
                metroComboBox3.Enabled = false;
                isChecked = false;
            }
        }

        private void AddFile_Click(object sender, EventArgs e)// Добавляем файл во вложение
        {
            ofd = new OpenFileDialog(); //открываем проводник
            string filename; //переменная для имени файла
           
            try //Заглушка для ошибки, которая возникнет, если закроем проводник не выбрав файл и т.п.
            {
                if (ofd.ShowDialog() == DialogResult.OK) //Если выбрали файл и нажали ОК, то
                {
                    path = ofd.FileName;// в эту переменную пишем полный путь до файла
                    filename = Path.GetFileNameWithoutExtension(ofd.FileName); //в эту переменную только имя файла
                    listBox1.Items.Add(filename); //Добавляем имя файла как новый индекс в ЛистБокс
                    filepath.Add(path);
                }
            }
            catch { }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            //Удаление из listbox и коллекции
            filepath.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new UseDataBase();
            //По ID группы находим всех студентов этой группы, а по их ID находим родителей и заполняем комбобокс1.
            string query = "SELECT DISTINCT Parents.Email FROM Groups, Parents INNER JOIN Students ON Students.idGroup = Groups.idGroup INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent AND ParentsSudents.idStudent = Students.idStudent where Groups.Name like '" + metroComboBox3.Text + "'";

            metroComboBox1.DataSource = db.SQLQuery(query);
            metroComboBox1.DisplayMember = "Email";
            metroComboBox1.ValueMember = "Email";
        }

        private void SingleMessageForm_Load(object sender, EventArgs e)
        {
            db = new UseDataBase();
            metroComboBox3.DataSource = db.SQLQuery("Select * from groups");
            metroComboBox3.DisplayMember = "NAME";
            //metroComboBox3.ValueMember = "idGroup";

            
            //По ID группы находим всех студентов этой группы, а по их ID находим родителей и заполняем комбобокс1.
            string query = "SELECT DISTINCT Parents.Email FROM Groups, Parents INNER JOIN Students ON Students.idGroup = Groups.idGroup INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent AND ParentsSudents.idStudent = Students.idStudent";

            metroComboBox1.DataSource = db.SQLQuery(query);
            metroComboBox1.DisplayMember = "Email";
            //metroComboBox1.ValueMember = "Email";
            metroTextBox3.Text = "";
        }

        //private void metroButton2_Click(object sender, EventArgs e)
        //{
        //    db = new UseDataBase();
        //    //По ID группы находим всех студентов этой группы, а по их ID находим родителей и заполняем комбобокс1.
        //    string query = "SELECT DISTINCT Parents.Email FROM Groups, Parents INNER JOIN Students ON Students.idGroup = Groups.idGroup INNER JOIN ParentsSudents ON ParentsSudents.idParent = Parents.idParent AND ParentsSudents.idStudent = Students.idStudent where Groups.Name like '"+metroComboBox3.Text+"'";
            
        //    metroComboBox1.DataSource = db.SQLQuery(query);
        //    metroComboBox1.DisplayMember = "Email";
        //    metroComboBox1.ValueMember = "Email";
        //}

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTextBox3.Text != "")
            {
                metroTextBox3.Text += ", " + metroComboBox1.Text;
            }
            else metroTextBox3.Text = metroComboBox1.Text;
        }
    }
}
