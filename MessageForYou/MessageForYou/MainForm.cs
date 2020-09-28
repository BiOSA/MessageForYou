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
    public partial class MainForm : MetroForm
    {
        LoginForm lgf = new LoginForm();

        public MainForm()
        {
            InitializeComponent();
        }

        //---------------------------- БЛОК Изменения цвета при наведении ----------------------------
        private void SingleMessage_MouseEnter(object sender, EventArgs e)
        {
            SingleMessage.ForeColor = Color.Gold;
        }

        private void SingleMessage_MouseLeave(object sender, EventArgs e)
        {
            SingleMessage.ForeColor = Color.DeepSkyBlue;
        }

        private void MultiMessage_MouseEnter(object sender, EventArgs e)
        {
            MultiMessage.ForeColor = Color.Gold;
        }

        private void MultiMessage_MouseLeave(object sender, EventArgs e)
        {
            MultiMessage.ForeColor = Color.DeepSkyBlue;
        }

        private void DataBaseEdit_MouseEnter(object sender, EventArgs e)
        {
            DataBaseEdit.ForeColor = Color.Gold;
        }

        private void DataBaseEdit_MouseLeave(object sender, EventArgs e)
        {
            DataBaseEdit.ForeColor = Color.DeepSkyBlue;
        }

        private void InfoButton_MouseEnter(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.Gold;
        }

        private void InfoButton_MouseLeave(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.DeepSkyBlue;
        }

        private void ChangeUser_MouseEnter(object sender, EventArgs e)
        {
            ChangeUser.ForeColor = Color.DarkRed;
        }

        private void ChangeUser_MouseLeave(object sender, EventArgs e)
        {
            ChangeUser.ForeColor = Color.Red;
        }
    
        //---------------------------- КОНЕЦ БЛОКА Изменения цвета при наведении ------------------------
    
        private void DataBaseEdit_Click(object sender, EventArgs e)
        {
            DBEditForm dbeditform = new DBEditForm();
            dbeditform.ShowDialog();
            //this.Hide();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            lgf.Show();
            this.Close();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рассылка сообщений \n\nОрганизация - РКРИПТ \n\nАвтор - Дзреян К.Е.", "О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MinimizedBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SingleMessage_Click(object sender, EventArgs e)
        {
            SingleMessageForm smf = new SingleMessageForm();
            smf.ShowDialog();
            //this.Hide();
        }

        private void MultiMessage_Click(object sender, EventArgs e)
        {
            MultiMessageForm mmf = new MultiMessageForm();
            mmf.ShowDialog();
            //this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
