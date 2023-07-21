using DiplomApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = DiplomApp.Domain.Application;

namespace DiplomApp
{
    public partial class UserForm : Form
    {
        private DataManager dataManager;
        private List<Domain.Application> copy;

        public UserForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            UpdateGrid();
            criteria.Items.AddRange(new string[] { "Описание", "Примечание", "Имя компьютера", "Номер телефона", "Статус" });
            criteria.SelectedIndex = 0;
        }
        private void UpdateGrid()
        {
            var items = dataManager.applications.GetApplicationByUserId(dataManager.users.GetUserByName(Program.login).Id);
            copy = items.ToList();
            dataGrid.DataSource = items.ToList();
            dataGrid.Columns[0].HeaderText = "Номер";
            dataGrid.Columns[1].HeaderText = "Дата подачи";
            dataGrid.Columns[2].HeaderText = "Описание";
            dataGrid.Columns[3].HeaderText = "Дата закрытия";
            dataGrid.Columns[4].HeaderText = "Примечание";
            dataGrid.Columns[5].HeaderText = "Название компьютера";
            dataGrid.Columns[6].HeaderText = "Номер телефона";
            dataGrid.Columns[7].HeaderText = "Статус заявки";
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;
            dataGrid.Columns[10].Visible = false;
            dataGrid.Columns[11].Visible = false;

            PCname.Text = Environment.MachineName;
            start.Text = DateTime.Now.ToString();
            fio.Text = Program.fio;
        }

        private void newApp_Click(object sender, EventArgs e)
        {
            if (phone.Text == null || desc.Text == null)
            {
                MessageBox.Show("Заполните поля 'Номер телефона' и 'Описание'!");
                return;
            }
            //Regex regex = new Regex(@"\+375\d{9}");
            //if (!regex.IsMatch(phone.Text))
            //{
            //    MessageBox.Show("Неверный формат номер телефона (+375123456789)!");
            //    return;
            //}
            Domain.Application app = new Domain.Application
            {
                DateTimeStart = DateTime.Now,
                Opis = desc.Text,
                Prim = prim.Text,
                CompName = PCname.Text,
                Tel = phone.Text,
                AppState = "Открыта",
                UserId = dataManager.users.GetUserByName(Program.login).Id
            };
            dataManager.applications.SaveApplication(app);
            MessageBox.Show("Заявка добавлена успешно!");
            UpdateGrid();

        }

        private void delApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (MessageBox.Show($"Вы действительно хотите удалить заявку №{id}?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dataManager.applications.DeleteApplication(dataManager.applications.GetApplicationById(Convert.ToInt32(id)));
            MessageBox.Show($"Заявка №{id} успешно удалена!");
            UpdateGrid();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (MessageBox.Show($"Вы действительно хотите закрыть заявку №{id}?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = dataManager.applications.GetApplicationById(Convert.ToInt32(id));
            item.AppState = "Закрыта";
            item.DateTimeEnd = DateTime.Now;
            dataManager.applications.SaveApplication(item);
            MessageBox.Show($"Заявка №{id} закрыта!");
            UpdateGrid();
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Domain.Application application = new Domain.Application
            {
                Id = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value),
                DateTimeStart = Convert.ToDateTime(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value),
                Opis = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                DateTimeEnd = Convert.ToDateTime(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value),
                Prim = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[4].Value.ToString(),
                CompName = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                Tel = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[6].Value.ToString(),
                AppState = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString(),
                UserId = dataManager.users.GetUserByName(Program.login).Id,
            };

            var item = dataManager.applications.GetApplicationById(Convert.ToInt32(id));
            if (application != item)
            {
                dataManager.applications.SaveApplication(application);
                UpdateGrid();
            }
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            UsersForm f = new UsersForm();
            f.Show();
            this.Close();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemId.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            start.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            var descr = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[2].Value ?? "";
            desc.Text = descr.ToString();
            var endT = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value ?? "";
            end.Text = endT.ToString();
            var prime = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[4].Value ?? "";
            prim.Text = prime.ToString();
            PCname.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[5].Value.ToString();
            phone.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[6].Value.ToString();
            status.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminsForms f = new AdminsForms();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddApplicationForm f = new AddApplicationForm();
            f.Show();
            this.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            List<Domain.Application> res = new List<Application>();
            foreach (var item in copy)
            {
                switch (criteria.SelectedItem.ToString())
                {
                    case "Описание":
                        if (item.Opis is null)
                        {
                            break;
                        }
                        if (item.Opis.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Примечание":
                        if (item.Prim is null)
                        {
                            break;
                        }
                        if (item.Prim.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Имя компьютера":
                        if (item.CompName.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Номер телефона":
                        if (item.Tel.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Статус":
                        if (item.AppState.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;

                    default:
                        MessageBox.Show("Ошибка выборки критерия, попробуйте снова!");
                        break;
                }
            }
            if (search.Text.Length > 0)
                dataGrid.DataSource = res;
            else UpdateGrid();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignForm f = new SignForm();
            f.Show();
            this.Close();
        }
    }
}
