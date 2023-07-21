namespace DiplomApp
{
    partial class UserForm
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
            phone = new TextBox();
            start = new TextBox();
            prim = new TextBox();
            desc = new TextBox();
            PCname = new TextBox();
            newApp = new Button();
            delApp = new Button();
            dataGrid = new DataGridView();
            itemId = new TextBox();
            end = new TextBox();
            status = new TextBox();
            fio = new TextBox();
            label2 = new Label();
            label4 = new Label();
            search = new TextBox();
            criteria = new ComboBox();
            label5 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(298, 343);
            label1.Name = "label1";
            label1.Size = new Size(428, 37);
            label1.TabIndex = 6;
            label1.Text = "ФОРМА ДЛЯ ПОДАЧИ ЗАЯВКИ";
            // 
            // phone
            // 
            phone.ForeColor = Color.Black;
            phone.Location = new Point(324, 418);
            phone.MaxLength = 13;
            phone.Name = "phone";
            phone.PlaceholderText = "НОМЕР ТЕЛЕФОНА";
            phone.Size = new Size(384, 23);
            phone.TabIndex = 8;
            // 
            // start
            // 
            start.ForeColor = Color.Black;
            start.Location = new Point(324, 447);
            start.Name = "start";
            start.PlaceholderText = "ВРЕМЯ ПОДАЧИ";
            start.ReadOnly = true;
            start.Size = new Size(384, 23);
            start.TabIndex = 9;
            // 
            // prim
            // 
            prim.ForeColor = Color.Black;
            prim.Location = new Point(324, 476);
            prim.Name = "prim";
            prim.PlaceholderText = "ПРИМЕЧАНИЕ";
            prim.Size = new Size(384, 23);
            prim.TabIndex = 10;
            // 
            // desc
            // 
            desc.Location = new Point(324, 505);
            desc.Multiline = true;
            desc.Name = "desc";
            desc.PlaceholderText = "ОПИСАНИЕ";
            desc.Size = new Size(384, 67);
            desc.TabIndex = 11;
            // 
            // PCname
            // 
            PCname.ForeColor = Color.Black;
            PCname.Location = new Point(324, 578);
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
            newApp.Location = new Point(352, 719);
            newApp.Name = "newApp";
            newApp.Size = new Size(305, 36);
            newApp.TabIndex = 13;
            newApp.Text = "Подтвердить";
            newApp.UseVisualStyleBackColor = true;
            newApp.Click += newApp_Click;
            // 
            // delApp
            // 
            delApp.FlatStyle = FlatStyle.Flat;
            delApp.ForeColor = Color.Red;
            delApp.Location = new Point(934, 346);
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
            dataGrid.Location = new Point(12, 49);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1016, 289);
            dataGrid.TabIndex = 17;
            dataGrid.CellClick += dataGrid_CellClick;
            // 
            // itemId
            // 
            itemId.ForeColor = Color.Black;
            itemId.Location = new Point(324, 389);
            itemId.Name = "itemId";
            itemId.PlaceholderText = "НОМЕР ЗАЯВКИ";
            itemId.ReadOnly = true;
            itemId.Size = new Size(384, 23);
            itemId.TabIndex = 18;
            // 
            // end
            // 
            end.ForeColor = Color.Black;
            end.Location = new Point(324, 607);
            end.Name = "end";
            end.PlaceholderText = "ВРЕМЯ ЗАКРЫТИЯ";
            end.ReadOnly = true;
            end.Size = new Size(384, 23);
            end.TabIndex = 19;
            // 
            // status
            // 
            status.ForeColor = Color.Black;
            status.Location = new Point(324, 636);
            status.Name = "status";
            status.PlaceholderText = "СТАТУС ЗАЯВКИ";
            status.ReadOnly = true;
            status.Size = new Size(384, 23);
            status.TabIndex = 20;
            // 
            // fio
            // 
            fio.ForeColor = Color.Black;
            fio.Location = new Point(324, 665);
            fio.Name = "fio";
            fio.PlaceholderText = "ФИО ПОЛЬЗОВАТЕЛЯ";
            fio.ReadOnly = true;
            fio.Size = new Size(384, 23);
            fio.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(614, 9);
            label2.Name = "label2";
            label2.Size = new Size(215, 37);
            label2.TabIndex = 22;
            label2.Text = "ВАШИ ЗАЯВКИ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(114, 37);
            label4.TabIndex = 25;
            label4.Text = "ПОИСК";
            // 
            // search
            // 
            search.ForeColor = Color.Black;
            search.Location = new Point(132, 20);
            search.Name = "search";
            search.PlaceholderText = "Введите текст...";
            search.Size = new Size(238, 23);
            search.TabIndex = 26;
            search.TextChanged += search_TextChanged;
            // 
            // criteria
            // 
            criteria.FormattingEnabled = true;
            criteria.Location = new Point(487, 20);
            criteria.Name = "criteria";
            criteria.Size = new Size(121, 23);
            criteria.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 23);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 28;
            label5.Text = "Критерий поиска:";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(872, 8);
            button3.Name = "button3";
            button3.Size = new Size(123, 38);
            button3.TabIndex = 39;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 794);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(criteria);
            Controls.Add(search);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(fio);
            Controls.Add(status);
            Controls.Add(end);
            Controls.Add(itemId);
            Controls.Add(dataGrid);
            Controls.Add(delApp);
            Controls.Add(newApp);
            Controls.Add(PCname);
            Controls.Add(desc);
            Controls.Add(prim);
            Controls.Add(start);
            Controls.Add(phone);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "ApplicationForm";
            FormClosed += UserForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox phone;
        private TextBox start;
        private TextBox prim;
        private TextBox desc;
        private TextBox PCname;
        private Button newApp;
        private Button delApp;
        private DataGridView dataGrid;
        private TextBox itemId;
        private TextBox end;
        private TextBox status;
        private TextBox fio;
        private Label label2;
        private Label label4;
        private TextBox search;
        private ComboBox criteria;
        private Label label5;
        private Button button3;
    }
}