namespace DiplomApp
{
    partial class AddAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            byro = new ComboBox();
            newApp = new Button();
            password = new TextBox();
            login = new TextBox();
            fio = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // byro
            // 
            byro.FormattingEnabled = true;
            byro.Location = new Point(181, 145);
            byro.Name = "byro";
            byro.Size = new Size(384, 23);
            byro.TabIndex = 33;
            // 
            // newApp
            // 
            newApp.FlatStyle = FlatStyle.Flat;
            newApp.ForeColor = Color.Red;
            newApp.Location = new Point(210, 191);
            newApp.Name = "newApp";
            newApp.Size = new Size(305, 44);
            newApp.TabIndex = 32;
            newApp.Text = "Добавить";
            newApp.UseVisualStyleBackColor = true;
            newApp.Click += newApp_Click;
            // 
            // password
            // 
            password.ForeColor = Color.Black;
            password.Location = new Point(181, 116);
            password.Name = "password";
            password.PlaceholderText = "ПАРОЛЬ";
            password.Size = new Size(384, 23);
            password.TabIndex = 31;
            // 
            // login
            // 
            login.ForeColor = Color.Black;
            login.Location = new Point(181, 87);
            login.Name = "login";
            login.PlaceholderText = "ЛОГИН";
            login.Size = new Size(384, 23);
            login.TabIndex = 30;
            // 
            // fio
            // 
            fio.ForeColor = Color.Black;
            fio.Location = new Point(181, 58);
            fio.MaxLength = 13;
            fio.Name = "fio";
            fio.PlaceholderText = "ФИО ПОЛЬЗОВАТЕЛЯ";
            fio.Size = new Size(384, 23);
            fio.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(699, 40);
            label1.TabIndex = 28;
            label1.Text = "ФОРМА ДЛЯ ДОБАВЛЕНИЯ АДМИНИСТРАТОРА";
            // 
            // AddAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 259);
            Controls.Add(byro);
            Controls.Add(newApp);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(fio);
            Controls.Add(label1);
            Name = "AddAdminForm";
            Text = "AddAdminForm";
            FormClosed += AddAdminForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox byro;
        private Button newApp;
        private TextBox password;
        private TextBox login;
        private TextBox fio;
        private Label label1;
    }
}