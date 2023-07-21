using DiplomApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomApp
{
    public partial class UsersForm : Form
    {
        private DataManager dataManager;
        public UsersForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            UpdateGrid();
            var list = dataManager.db.Byros;
            byro.Items.Add("Выберите бюро");
            foreach (var item in list)
            {
                byro.Items.Add(item.Name);
            }
            byro.SelectedIndex = 0;
        }
        private void UpdateGrid()
        {
            var items = dataManager.users.GetUsers().ToList();
            dataGrid.DataSource = items;
            dataGrid.Columns[0].HeaderText = "Номер";
            dataGrid.Columns[1].HeaderText = "ФИО пользователя";
            dataGrid.Columns[2].HeaderText = "Логин";
            dataGrid.Columns[3].HeaderText = "Пароль";
            dataGrid.Columns[4].Visible = false;

        }

        private void delApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            var user = dataManager.users.GetUserById(Convert.ToInt32(id));
            if (MessageBox.Show($"Вы действительно хотите удалить пользователя {user.Fio}?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dataManager.users.DeleteUser(user);
            MessageBox.Show($"Пользователь {user.Fio} успешно удален!");
            UpdateGrid();
        }

        private void newApp_Click(object sender, EventArgs e)
        {
            if (fio.Text == "" || login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Поля не заполнены!");
                return;
            }
            Domain.User app = new Domain.User
            {
                Fio = fio.Text,
                Login = login.Text,
                Password = password.Text,
            };
            dataManager.users.SaveUser(app);
            MessageBox.Show("Пользователь добавлен успешно!");
            UpdateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Domain.User application = new Domain.User
            {
                Id = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value),
                Fio = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                Login = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                Password = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value.ToString(),


            };

            var item = dataManager.users.GetUserById(Convert.ToInt32(id));
            if (application != item)
            {
                dataManager.users.SaveUser(application);
                UpdateGrid();
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("Выберите пользователя!");
                return;
            }
            if (byro.SelectedIndex == 0)
            {
                MessageBox.Show("Выберите бюро!");
                return;
            }
            var user = dataManager.users.GetUserById(Convert.ToInt32(id));
            if (MessageBox.Show($"Вы уверены, что хотите присвоить пользователю {user.Fio} статус администратора?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            Admin admin = new Admin
            {
                Fio = user.Fio,
                Login = user.Login,
                Password = user.Password,
                ByroId = dataManager.db.Byros.FirstOrDefault(x => x.Name == byro.SelectedItem.ToString()).Id,
            };
            dataManager.users.DeleteUser(user);
            dataManager.admins.SaveAdmin(admin);
            MessageBox.Show($"Пользователю {user.Fio} успешно присвоен статус администратора!");
            UpdateGrid();
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            ApplicationForm f = new ApplicationForm();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminsForms f = new AdminsForms();
            f.Show();
            this.Close();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
