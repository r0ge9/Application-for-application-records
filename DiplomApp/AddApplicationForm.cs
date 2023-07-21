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
    public partial class AddApplicationForm : Form
    {
        private DataManager dataManager;
        public AddApplicationForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            start.Text = DateTime.Now.ToString();
            PCname.Text = Environment.MachineName;
            status.Text = "Открыта";
            fio.Text = Program.fio;
        }

        private void newApp_Click(object sender, EventArgs e)
        {
            if (phone.Text == null || desc.Text == null)
            {
                MessageBox.Show("Заполните поля 'Номер телефона' и 'Описание'!");
                return;
            }
            Domain.Application app = new Domain.Application
            {
                DateTimeStart = DateTime.Now,
                Opis = desc.Text,
                Prim = prim.Text,
                CompName = PCname.Text,
                Tel = phone.Text,
                AppState = "Открыта",
                UserId=-(dataManager.admins.GetAdminByName(Program.login).Id),
            };
            dataManager.applications.SaveApplication(app);
            MessageBox.Show("Заявка добавлена успешно!");
            ApplicationForm f = new ApplicationForm();
            f.Show();
            this.Close();
        }

        private void AddApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
