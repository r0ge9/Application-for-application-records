namespace DiplomApp
{
    partial class AdminsForms
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
            delApp = new Button();
            closeApp = new Button();
            newApp = new Button();
            password = new TextBox();
            login = new TextBox();
            fio = new TextBox();
            label1 = new Label();
            dataGrid = new DataGridView();
            byro = new ComboBox();
            button2 = new Button();
            userBut = new Button();
            button1 = new Button();
            id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // delApp
            // 
            delApp.FlatStyle = FlatStyle.Flat;
            delApp.ForeColor = Color.Red;
            delApp.Location = new Point(916, 329);
            delApp.Name = "delApp";
            delApp.Size = new Size(121, 44);
            delApp.TabIndex = 26;
            delApp.Text = "Удалить администратора";
            delApp.UseVisualStyleBackColor = true;
            delApp.Click += delApp_Click;
            // 
            // closeApp
            // 
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.ForeColor = Color.OliveDrab;
            closeApp.Location = new Point(21, 329);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(111, 44);
            closeApp.TabIndex = 25;
            closeApp.Text = "Убрать администратора";
            closeApp.UseVisualStyleBackColor = true;
            closeApp.Click += closeApp_Click;
            // 
            // newApp
            // 
            newApp.FlatStyle = FlatStyle.Flat;
            newApp.ForeColor = Color.Red;
            newApp.Location = new Point(373, 544);
            newApp.Name = "newApp";
            newApp.Size = new Size(305, 44);
            newApp.TabIndex = 24;
            newApp.Text = "Изменить";
            newApp.UseVisualStyleBackColor = true;
            newApp.Click += newApp_Click;
            // 
            // password
            // 
            password.ForeColor = Color.Black;
            password.Location = new Point(336, 478);
            password.Name = "password";
            password.PlaceholderText = "ПАРОЛЬ";
            password.Size = new Size(384, 23);
            password.TabIndex = 21;
            // 
            // login
            // 
            login.ForeColor = Color.Black;
            login.Location = new Point(336, 449);
            login.Name = "login";
            login.PlaceholderText = "ЛОГИН";
            login.Size = new Size(384, 23);
            login.TabIndex = 20;
            // 
            // fio
            // 
            fio.ForeColor = Color.Black;
            fio.Location = new Point(336, 420);
            fio.MaxLength = 13;
            fio.Name = "fio";
            fio.PlaceholderText = "ФИО ПОЛЬЗОВАТЕЛЯ";
            fio.Size = new Size(384, 23);
            fio.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(194, 333);
            label1.Name = "label1";
            label1.Size = new Size(680, 40);
            label1.TabIndex = 18;
            label1.Text = "ФОРМА ДЛЯ ИЗМЕНЕНИЯ АДМИНИСТРАТОРА";
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(21, 27);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1016, 299);
            dataGrid.TabIndex = 17;
            dataGrid.CellClick += dataGrid_CellClick;
            dataGrid.CellEndEdit += dataGrid_CellEndEdit;
            // 
            // byro
            // 
            byro.FormattingEnabled = true;
            byro.Location = new Point(336, 507);
            byro.Name = "byro";
            byro.Size = new Size(384, 23);
            byro.TabIndex = 27;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(125, 2);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 29;
            button2.Text = "Заяки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userBut
            // 
            userBut.FlatStyle = FlatStyle.Flat;
            userBut.ForeColor = Color.Red;
            userBut.Location = new Point(18, 2);
            userBut.Name = "userBut";
            userBut.Size = new Size(101, 23);
            userBut.TabIndex = 28;
            userBut.Text = "Пользователи";
            userBut.UseVisualStyleBackColor = true;
            userBut.Click += userBut_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(916, 382);
            button1.Name = "button1";
            button1.Size = new Size(121, 44);
            button1.TabIndex = 30;
            button1.Text = "Добавить администратора";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // id
            // 
            id.ForeColor = Color.Black;
            id.Location = new Point(336, 391);
            id.MaxLength = 13;
            id.Name = "id";
            id.PlaceholderText = "ID";
            id.ReadOnly = true;
            id.Size = new Size(384, 23);
            id.TabIndex = 31;
            // 
            // AdminsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 600);
            Controls.Add(id);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(userBut);
            Controls.Add(byro);
            Controls.Add(delApp);
            Controls.Add(closeApp);
            Controls.Add(newApp);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(fio);
            Controls.Add(label1);
            Controls.Add(dataGrid);
            Name = "AdminsForms";
            Text = "UsersForm";
            FormClosed += AdminsForms_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button delApp;
        private Button closeApp;
        private Button newApp;
        private TextBox password;
        private TextBox login;
        private TextBox fio;
        private Label label1;
        private DataGridView dataGrid;
        private ComboBox byro;
        private Button button2;
        private Button userBut;
        private Button button1;
        private TextBox id;
    }
}