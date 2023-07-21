namespace DiplomApp
{
    partial class AddApplicationForm
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
            fio = new TextBox();
            status = new TextBox();
            newApp = new Button();
            PCname = new TextBox();
            desc = new TextBox();
            prim = new TextBox();
            start = new TextBox();
            phone = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // fio
            // 
            fio.ForeColor = Color.Black;
            fio.Location = new Point(52, 267);
            fio.Name = "fio";
            fio.PlaceholderText = "ФИО ПОЛЬЗОВАТЕЛЯ";
            fio.ReadOnly = true;
            fio.Size = new Size(384, 23);
            fio.TabIndex = 32;
            // 
            // status
            // 
            status.ForeColor = Color.Black;
            status.Location = new Point(52, 238);
            status.Name = "status";
            status.PlaceholderText = "СТАТУС ЗАЯВКИ";
            status.ReadOnly = true;
            status.Size = new Size(384, 23);
            status.TabIndex = 31;
            // 
            // newApp
            // 
            newApp.FlatStyle = FlatStyle.Flat;
            newApp.ForeColor = Color.Red;
            newApp.Location = new Point(79, 306);
            newApp.Name = "newApp";
            newApp.Size = new Size(305, 36);
            newApp.TabIndex = 28;
            newApp.Text = "Подтвердить";
            newApp.UseVisualStyleBackColor = true;
            newApp.Click += newApp_Click;
            // 
            // PCname
            // 
            PCname.ForeColor = Color.Black;
            PCname.Location = new Point(52, 209);
            PCname.Name = "PCname";
            PCname.PlaceholderText = "НАЗВАНИЕ КОМПЬЮТЕРА";
            PCname.ReadOnly = true;
            PCname.Size = new Size(384, 23);
            PCname.TabIndex = 27;
            // 
            // desc
            // 
            desc.Location = new Point(52, 136);
            desc.Multiline = true;
            desc.Name = "desc";
            desc.PlaceholderText = "ОПИСАНИЕ";
            desc.Size = new Size(384, 67);
            desc.TabIndex = 26;
            // 
            // prim
            // 
            prim.ForeColor = Color.Black;
            prim.Location = new Point(52, 107);
            prim.Name = "prim";
            prim.PlaceholderText = "ПРИМЕЧАНИЕ";
            prim.Size = new Size(384, 23);
            prim.TabIndex = 25;
            // 
            // start
            // 
            start.ForeColor = Color.Black;
            start.Location = new Point(52, 78);
            start.Name = "start";
            start.PlaceholderText = "ВРЕМЯ ПОДАЧИ";
            start.ReadOnly = true;
            start.Size = new Size(384, 23);
            start.TabIndex = 24;
            // 
            // phone
            // 
            phone.ForeColor = Color.Black;
            phone.Location = new Point(52, 49);
            phone.MaxLength = 13;
            phone.Name = "phone";
            phone.PlaceholderText = "НОМЕР ТЕЛЕФОНА";
            phone.Size = new Size(384, 23);
            phone.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(495, 37);
            label1.TabIndex = 22;
            label1.Text = "ФОРМА ДЛЯ ДОБАВЛЕНИЯ ЗАЯВКИ";
            // 
            // AddApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 356);
            Controls.Add(fio);
            Controls.Add(status);
            Controls.Add(newApp);
            Controls.Add(PCname);
            Controls.Add(desc);
            Controls.Add(prim);
            Controls.Add(start);
            Controls.Add(phone);
            Controls.Add(label1);
            Name = "AddApplicationForm";
            Text = "AddApplicationForm";
            FormClosed += AddApplicationForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fio;
        private TextBox status;
        private Button newApp;
        private TextBox PCname;
        private TextBox desc;
        private TextBox prim;
        private TextBox start;
        private TextBox phone;
        private Label label1;
    }
}