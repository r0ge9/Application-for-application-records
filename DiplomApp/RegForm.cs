using DiplomApp.Domain;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiplomApp
{
    public partial class RegForm : Form
    {
        private DataManager dataManager;
        public RegForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignForm f = new SignForm();
            f.Show();
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "" || fio.Text == "")
            {
                MessageBox.Show("Поля не заполнены!");
                return;
            }
            if (username.Text.Length < 5)
            {
                MessageBox.Show("Длина имени пользователя должна быть не менее 5 символов!");
                return;
            }
            if (password.Text.Length < 7)
            {
                MessageBox.Show("Длина пароля должна быть не менее 7 символов!");
                return;
            }
            if (dataManager.users.GetUserByName(username.Text) != null)
            {
                MessageBox.Show("Пользователь с таким именем уже существует, попробуйте другое.");
                username.Text = "";
                password.Text = "";
                return;
            }
            Domain.User users = new Domain.User
            {
                Login = username.Text,
                Password = password.Text,
                Fio = fio.Text
            };


            dataManager.users.SaveUser(users);
            Program.fio = users.Fio;
            Program.login = users.Login;
            MessageBox.Show($"Регистрация прошла успешно! Добро пожаловать {users.Fio}!");
            UserForm f = new UserForm();
            f.Show();
            this.Close();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;

        }
    }
}