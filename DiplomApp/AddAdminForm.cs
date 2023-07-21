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
    public partial class AddAdminForm : Form
    {
        private DataManager dataManager;
        public AddAdminForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            var list = dataManager.db.Byros;
            byro.Items.Add("Выберите бюро");
            foreach (var item in list)
            {
                byro.Items.Add(item.Name);
            }
            byro.SelectedIndex = 0;
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
                Fio = fio.Text,
                Login = login.Text,
                Password = password.Text,
                ByroId = dataManager.db.Byros.FirstOrDefault(x => x.Name == byro.SelectedItem.ToString()).Id,
            };
            dataManager.admins.SaveAdmin(app);
            MessageBox.Show("Администратор добавлен успешно!");
            AdminsForms f = new AdminsForms();
            f.Show();
            this.Close();
        }

        private void AddAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
