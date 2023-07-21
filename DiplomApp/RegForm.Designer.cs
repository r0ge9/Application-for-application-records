namespace DiplomApp
{
    partial class RegForm
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
            label2 = new Label();
            enter = new Button();
            password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            fio = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(107, 168);
            label2.Name = "label2";
            label2.Size = new Size(228, 17);
            label2.TabIndex = 9;
            label2.Text = "Войдите в существующий аккаунт!";
            label2.Click += label2_Click;
            label2.MouseLeave += label2_MouseLeave;
            label2.MouseHover += label2_MouseHover;
            // 
            // enter
            // 
            enter.FlatStyle = FlatStyle.Flat;
            enter.ForeColor = Color.Red;
            enter.Location = new Point(158, 192);
            enter.Name = "enter";
            enter.Size = new Size(129, 47);
            enter.TabIndex = 8;
            enter.Text = "Зарегистрироваться";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // password
            // 
            password.Location = new Point(78, 136);
            password.Name = "password";
            password.PlaceholderText = "ПАРОЛЬ";
            password.Size = new Size(280, 23);
            password.TabIndex = 7;
            password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Location = new Point(78, 98);
            username.Name = "username";
            username.PlaceholderText = "ЛОГИН";
            username.Size = new Size(280, 23);
            username.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 47);
            label1.TabIndex = 5;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // fio
            // 
            fio.Location = new Point(78, 59);
            fio.Name = "fio";
            fio.PlaceholderText = "ФИО";
            fio.Size = new Size(280, 23);
            fio.TabIndex = 10;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 251);
            Controls.Add(fio);
            Controls.Add(label2);
            Controls.Add(enter);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "RegForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button enter;
        private TextBox password;
        private TextBox username;
        private Label label1;
        private TextBox fio;
    }
}