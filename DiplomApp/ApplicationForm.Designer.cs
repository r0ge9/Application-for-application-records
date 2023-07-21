namespace DiplomApp
{
    partial class ApplicationForm
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
            label1 = new Label();
            userBut = new Button();
            phone = new TextBox();
            start = new TextBox();
            prim = new TextBox();
            desc = new TextBox();
            PCname = new TextBox();
            newApp = new Button();
            closeApp = new Button();
            delApp = new Button();
            dataGrid = new DataGridView();
            itemId = new TextBox();
            end = new TextBox();
            status = new TextBox();
            fio = new TextBox();
            button2 = new Button();
            label5 = new Label();
            criteria = new ComboBox();
            search = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 348);
            label1.Name = "label1";
            label1.Size = new Size(364, 37);
            label1.TabIndex = 6;
            label1.Text = "ФОРМА ДЛЯ ИЗМЕНЕНИЯ";
            // 
            // userBut
            // 
            userBut.FlatStyle = FlatStyle.Flat;
            userBut.ForeColor = Color.Red;
            userBut.Location = new Point(13, 9);
            userBut.Name = "userBut";
            userBut.Size = new Size(109, 38);
            userBut.TabIndex = 7;
            userBut.Text = "Пользователи";
            userBut.UseVisualStyleBackColor = true;
            userBut.Click += userBut_Click;
            // 
            // phone
            // 
            phone.ForeColor = Color.Black;
            phone.Location = new Point(333, 423);
            phone.MaxLength = 13;
            phone.Name = "phone";
            phone.PlaceholderText = "НОМЕР ТЕЛЕФОНА";
            phone.Size = new Size(384, 23);
            phone.TabIndex = 8;
            // 
            // start
            // 
            start.ForeColor = Color.Black;
            start.Location = new Point(333, 452);
            start.Name = "start";
            start.PlaceholderText = "ВРЕМЯ ПОДАЧИ";
            start.ReadOnly = true;
            start.Size = new Size(384, 23);
            start.TabIndex = 9;
            // 
            // prim
            // 
            prim.ForeColor = Color.Black;
            prim.Location = new Point(333, 481);
            prim.Name = "prim";
            prim.PlaceholderText = "ПРИМЕЧАНИЕ";
            prim.Size = new Size(384, 23);
            prim.TabIndex = 10;
            // 
            // desc
            // 
            desc.Location = new Point(333, 510);
            desc.Multiline = true;
            desc.Name = "desc";
            desc.PlaceholderText = "ОПИСАНИЕ";
            desc.Size = new Size(384, 67);
            desc.TabIndex = 11;
            // 
            // PCname
            // 
            PCname.ForeColor = Color.Black;
            PCname.Location = new Point(333, 583);
            PCname.Name = "PCname";
            PCname.PlaceholderText = "НАЗВАНИЕ КОМПЬЮТЕРА";
            PCname.ReadOnly = true;
            PCname.Size = new Size(384, 23);
            PCname.TabIndex = 12;
            // 
            // newApp
            // 
            newApp.FlatStyle = FlatStyle.Flat;
            newApp.ForeColor = Color.Red;
            newApp.Location = new Point(361, 724);
            newApp.Name = "newApp";
            newApp.Size = new Size(305, 36);
            newApp.TabIndex = 13;
            newApp.Text = "Подтвердить";
            newApp.UseVisualStyleBackColor = true;
            newApp.Click += newApp_Click;
            // 
            // closeApp
            // 
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.ForeColor = Color.OliveDrab;
            closeApp.Location = new Point(934, 348);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(94, 44);
            closeApp.TabIndex = 14;
            closeApp.Text = "Закрыть заявку";
            closeApp.UseVisualStyleBackColor = true;
            closeApp.Click += closeApp_Click;
            // 
            // delApp
            // 
            delApp.FlatStyle = FlatStyle.Flat;
            delApp.ForeColor = Color.Red;
            delApp.Location = new Point(784, 348);
            delApp.Name = "delApp";
            delApp.Size = new Size(94, 44);
            delApp.TabIndex = 15;
            delApp.Text = "Удалить заявку";
            delApp.UseVisualStyleBackColor = true;
            delApp.Click += delApp_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 53);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1016, 289);
            dataGrid.TabIndex = 17;
            dataGrid.CellClick += dataGrid_CellClick;
            // 
            // itemId
            // 
            itemId.ForeColor = Color.Black;
            itemId.Location = new Point(333, 394);
            itemId.Name = "itemId";
            itemId.PlaceholderText = "НОМЕР ЗАЯВКИ";
            itemId.ReadOnly = true;
            itemId.Size = new Size(384, 23);
            itemId.TabIndex = 18;
            // 
            // end
            // 
            end.ForeColor = Color.Black;
            end.Location = new Point(333, 612);
            end.Name = "end";
            end.PlaceholderText = "ВРЕМЯ ЗАКРЫТИЯ";
            end.ReadOnly = true;
            end.Size = new Size(384, 23);
            end.TabIndex = 19;
            // 
            // status
            // 
            status.ForeColor = Color.Black;
            status.Location = new Point(333, 641);
            status.Name = "status";
            status.PlaceholderText = "СТАТУС ЗАЯВКИ";
            status.ReadOnly = true;
            status.Size = new Size(384, 23);
            status.TabIndex = 20;
            // 
            // fio
            // 
            fio.ForeColor = Color.Black;
            fio.Location = new Point(333, 670);
            fio.Name = "fio";
            fio.PlaceholderText = "ФИО ПОЛЬЗОВАТЕЛЯ";
            fio.ReadOnly = true;
            fio.Size = new Size(384, 23);
            fio.TabIndex = 21;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(120, 9);
            button2.Name = "button2";
            button2.Size = new Size(123, 38);
            button2.TabIndex = 22;
            button2.Text = "Администраторы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(559, 26);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 32;
            label5.Text = "Критерий поиска:";
            // 
            // criteria
            // 
            criteria.FormattingEnabled = true;
            criteria.Location = new Point(432, 23);
            criteria.Name = "criteria";
            criteria.Size = new Size(121, 23);
            criteria.TabIndex = 31;
            // 
            // search
            // 
            search.ForeColor = Color.Black;
            search.Location = new Point(670, 23);
            search.Name = "search";
            search.PlaceholderText = "Введите текст...";
            search.Size = new Size(238, 23);
            search.TabIndex = 30;
            search.TextChanged += search_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(914, 9);
            label4.Name = "label4";
            label4.Size = new Size(114, 37);
            label4.TabIndex = 29;
            label4.Text = "ПОИСК";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 348);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 33;
            label2.Text = "ОТЧЕТ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(90, 432);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(149, 23);
            dateTimePicker2.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 397);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 36;
            label3.Text = "Дата начала";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 438);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 36;
            label6.Text = "Дата конца";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(98, 469);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 37;
            button1.Text = "Вывести отчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(249, 8);
            button3.Name = "button3";
            button3.Size = new Size(123, 38);
            button3.TabIndex = 38;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 766);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(criteria);
            Controls.Add(search);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(fio);
            Controls.Add(status);
            Controls.Add(end);
            Controls.Add(itemId);
            Controls.Add(dataGrid);
            Controls.Add(delApp);
            Controls.Add(closeApp);
            Controls.Add(newApp);
            Controls.Add(PCname);
            Controls.Add(desc);
            Controls.Add(prim);
            Controls.Add(start);
            Controls.Add(phone);
            Controls.Add(userBut);
            Controls.Add(label1);
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            FormClosed += ApplicationForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button userBut;
        private TextBox phone;
        private TextBox start;
        private TextBox prim;
        private TextBox desc;
        private TextBox PCname;
        private Button newApp;
        private Button closeApp;
        private Button delApp;
        private DataGridView dataGrid;
        private TextBox itemId;
        private TextBox end;
        private TextBox status;
        private TextBox fio;
        private Button button2;
        private Label label5;
        private ComboBox criteria;
        private TextBox search;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label6;
        private Button button1;
        private Button button3;
    }
}