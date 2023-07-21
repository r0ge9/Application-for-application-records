namespace DiplomApp
{
    partial class SignForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            username = new TextBox();
            password = new TextBox();
            enter = new Button();
            label2 = new Label();
            isAdmin = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 47);
            label1.TabIndex = 0;
            label1.Text = "ВХОД";
            // 
            // username
            // 
            username.Location = new Point(57, 72);
            username.Name = "username";
            username.PlaceholderText = "ЛОГИН";
            username.Size = new Size(280, 23);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(57, 110);
            password.Name = "password";
            password.PlaceholderText = "ПАРОЛЬ";
            password.Size = new Size(280, 23);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // enter
            // 
            enter.FlatStyle = FlatStyle.Flat;
            enter.ForeColor = Color.Red;
            enter.Location = new Point(150, 192);
            enter.Name = "enter";
            enter.Size = new Size(95, 40);
            enter.TabIndex = 3;
            enter.Text = "Войти";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(88, 150);
            label2.Name = "label2";
            label2.Size = new Size(216, 17);
            label2.TabIndex = 4;
            label2.Text = "Зарегистрируйте новый аккаунт!";
            label2.Click += label2_Click;
            label2.MouseLeave += label2_MouseLeave;
            label2.MouseHover += label2_MouseHover;
            // 
            // isAdmin
            // 
            isAdmin.AutoSize = true;
            isAdmin.ForeColor = Color.Red;
            isAdmin.Location = new Point(272, 213);
            isAdmin.Name = "isAdmin";
            isAdmin.Size = new Size(135, 19);
            isAdmin.TabIndex = 5;
            isAdmin.Text = "Вы администратор?";
            isAdmin.UseVisualStyleBackColor = true;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 244);
            Controls.Add(isAdmin);
            Controls.Add(label2);
            Controls.Add(enter);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "SignForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username;
        private TextBox password;
        private Button enter;
        private Label label2;
        private CheckBox isAdmin;
    }
}