using DiplomApp.Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiplomApp
{
    public partial class SignForm : Form
    {
        private DataManager dataManager;
        public SignForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void reg_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("���� �� ���������!");
                return;
            }
            if (isAdmin.Checked == false)
            {
                var user = dataManager.users.GetUserByName(username.Text);
                if (user == null)
                {
                    MessageBox.Show("������������ � ����� ������ �� ����������, ���������� ������.");
                    username.Text = "";
                    password.Text = "";
                    return;
                }
                if (user.Password != password.Text)
                {
                    MessageBox.Show("�������� ������, ���������� ��� ���.");
                    username.Text = "";
                    password.Text = "";
                    return;
                }
                MessageBox.Show($"����� ����������, {user.Fio}!");
                Program.fio = user.Fio;
                Program.login = user.Login;
                UserForm f = new UserForm();
                f.Show();
                this.Hide();
            }
            else
            {
                var user = dataManager.admins.GetAdminByName(username.Text);
                if (user == null)
                {
                    MessageBox.Show("�������������� � ����� ������ �� ����������, ���������� ������.");
                    username.Text = "";
                    password.Text = "";
                    return;
                }
                if (user.Password != password.Text)
                {
                    MessageBox.Show("�������� ������, ���������� ��� ���.");
                    password.Text = "";
                    return;
                }
                MessageBox.Show($"����� ����������, {user.Fio}!");
                Program.fio = user.Fio;
                Program.login = user.Login;
                ApplicationForm f = new ApplicationForm();
                f.Show();
                this.Hide();
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
            RegForm f = new RegForm();
            f.Show();
            this.Hide();
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