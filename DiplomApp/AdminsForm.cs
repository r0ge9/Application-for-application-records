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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DiplomApp
{
    public partial class AdminsForms : Form
    {
        private DataManager dataManager;
        public AdminsForms()
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
            var items = from a in dataManager.db.Admins
                        join u in dataManager.db.Byros on a.ByroId equals u.Id
                        select new
                        {
                            Id = a.Id,
                            Fio = a.Fio,
                            Login = a.Login,
                            Password = a.Password,
                            Byro = u.Name
                        };
            dataGrid.DataSource = items.ToList();
            dataGrid.Columns[0].HeaderText = "Номер";
            dataGrid.Columns[1].HeaderText = "ФИО пользователя";
            dataGrid.Columns[2].HeaderText = "Логин";
            dataGrid.Columns[3].HeaderText = "Пароль";
            dataGrid.Columns[4].HeaderText = "Бюро";

        }

        private void delApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            var user = dataManager.admins.GetAdminById(Convert.ToInt32(id));
            if (MessageBox.Show($"Вы действительно хотите удалить администратора {user.Fio}?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dataManager.admins.DeleteAdmin(user);
            MessageBox.Show($"Администратор {user.Fio} успешно удален!");
            UpdateGrid();
        }

        private void newApp_Click(object sender, EventArgs e)
        {
            if (fio.Text == "" || login.Text == "" || password.Text == "" || byro.SelectedItem.ToString() == "Выберите бюро")
            {
                MessageBox.Show("Поля не заполнены!");
                return;
            }
            Domain.Admin app = new Domain.Admin
            {
                Id = Convert.ToInt32(id.Text),
                Fio = fio.Text,
                Login = login.Text,
                Password = password.Text,
                ByroId = dataManager.db.Byros.FirstOrDefault(x => x.Name == byro.SelectedItem.ToString()).Id,
            };
            dataManager.admins.SaveAdmin(app);
            MessageBox.Show("Администратор измненен успешно!");
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

            var user = dataManager.admins.GetAdminById(Convert.ToInt32(id));
            if (MessageBox.Show($"Вы уверены, что хотите убрать у администратора {user.Fio} его статус?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            User admin = new User
            {
                Fio = user.Fio,
                Login = user.Login,
                Password = user.Password,
            };
            dataManager.admins.DeleteAdmin(user);
            dataManager.users.SaveUser(admin);
            MessageBox.Show($"У администратора {user.Fio} успешно убран статус администратора!");
            UpdateGrid();
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            UsersForm f = new UsersForm();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationForm forms = new ApplicationForm();
            forms.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddAdminForm form = new AddAdminForm();
            form.Show();
            this.Close();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            fio.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            login.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            password.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            byro.SelectedIndex = byro.Items.IndexOf(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[4].Value.ToString());
        }

        private void AdminsForms_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
