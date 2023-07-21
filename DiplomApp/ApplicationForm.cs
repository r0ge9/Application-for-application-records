using DiplomApp.Domain;
using NPOI.XWPF.UserModel;
using System.Data;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace DiplomApp
{
    public partial class ApplicationForm : Form
    {
        private DataManager dataManager;
        private List<ApplicationView> copy = new List<ApplicationView>();
        public ApplicationForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            UpdateGrid();
            criteria.Items.AddRange(new string[] { "Описание", "Примечание", "Имя компьютера", "Номер телефона", "Статус", "ФИО пользователя" });
            criteria.SelectedIndex = 0;
            itemId.Text = dataGrid.Rows[0].Cells[0].Value.ToString();
            start.Text = dataGrid.Rows[0].Cells[1].Value.ToString();
            var descr = dataGrid.Rows[0].Cells[2].Value ?? "";
            desc.Text = descr.ToString();
            var endT = dataGrid.Rows[0].Cells[3].Value ?? "";
            end.Text = endT.ToString();
            var prime = dataGrid.Rows[0].Cells[4].Value ?? "";
            prim.Text = prime.ToString();
            PCname.Text = dataGrid.Rows[0].Cells[5].Value.ToString();
            phone.Text = dataGrid.Rows[0].Cells[6].Value.ToString();
            status.Text = dataGrid.Rows[0].Cells[7].Value.ToString();
            fio.Text = dataGrid.Rows[0].Cells[8].Value.ToString();

        }
        private void UpdateGrid()
        {
            var items = from a in dataManager.db.Applications
                        join u in dataManager.db.Users on a.UserId equals u.Id
                        select new ApplicationView
                        {
                            Id = a.Id,
                            Start = a.DateTimeStart,
                            Descriprion = a.Opis,
                            End = a.DateTimeEnd,
                            Prim = a.Prim,
                            PC = a.CompName,
                            Phone = a.Tel,
                            Status = a.AppState,
                            Fio = u.Fio,
                        };
            copy = items.ToList();
            dataGrid.DataSource = items.ToList();
            dataGrid.Columns[0].HeaderText = "Номер заявки";
            dataGrid.Columns[1].HeaderText = "Дата подачи";
            dataGrid.Columns[2].HeaderText = "Описание";
            dataGrid.Columns[3].HeaderText = "Дата закрытия";
            dataGrid.Columns[4].HeaderText = "Примечание";
            dataGrid.Columns[5].HeaderText = "Название компьютера";
            dataGrid.Columns[6].HeaderText = "Номер телефона";
            dataGrid.Columns[7].HeaderText = "Статус заявки";
            dataGrid.Columns[8].HeaderText = "ФИО пользователя";


        }

        private void newApp_Click(object sender, EventArgs e)
        {
            //if (phone.Text == null || desc.Text == null)
            //{
            //    MessageBox.Show("Заполните поля 'Номер телефона' и 'Описание'!");
            //    return;
            //}
            //Domain.Application app = new Domain.Application
            //{
            //    DateTimeStart = DateTime.UtcNow,
            //    Opis = desc.Text,
            //    Prim = prim.Text,
            //    CompName = PCname.Text,
            //    Tel = phone.Text,
            //    AppState = "Открыта"
            //};
            //dataManager.applications.SaveApplication(app);
            //MessageBox.Show("Заявка добавлена успешно!");
            //UpdateGrid();
            if (phone.Text == "" || desc.Text == "")
            {
                MessageBox.Show("Заполните поля 'Номер телефона' и 'Описание'!");
                return;
            }

            //Regex regex = new Regex(@"\+375\d{9}");
            //if (!regex.IsMatch(phone.Text))
            //{
            //    MessageBox.Show("Неверный формат номер телефона (+375123456789)!");
            //    return;
            //}
            Domain.Application app = new Domain.Application();
            if (end.Text != "")
            {
                app.Id = Convert.ToInt32(itemId.Text);
                app.DateTimeStart = Convert.ToDateTime(start.Text);
                app.Opis = desc.Text;
                app.Prim = prim.Text;
                app.CompName = PCname.Text;
                app.Tel = phone.Text;
                app.AppState = status.Text;

                app.DateTimeEnd = Convert.ToDateTime(end.Text);
                app.UserId = dataManager.users.GetUserByFio(fio.Text).Id;
            }
            else
            {
                app.Id = Convert.ToInt32(itemId.Text);
                app.DateTimeStart = Convert.ToDateTime(start.Text);
                app.Opis = desc.Text;
                app.Prim = prim.Text;
                app.CompName = PCname.Text;
                app.Tel = phone.Text;
                app.AppState = status.Text;

                app.UserId = dataManager.users.GetUserByFio(fio.Text).Id;
            }


            dataManager.applications.SaveApplication(app);
            MessageBox.Show("Заявка изменена успешно!");
            UpdateGrid();
        }

        private void delApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (MessageBox.Show($"Вы действительно хотите удалить заявку №{id}?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dataManager.applications.DeleteApplication(dataManager.applications.GetApplicationById(Convert.ToInt32(id)));
            MessageBox.Show($"Заявка №{id} успешно удалена!");
            UpdateGrid();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (MessageBox.Show($"Вы действительно хотите закрыть заявку №{id}?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = dataManager.applications.GetApplicationById(Convert.ToInt32(id));
            item.AppState = "Закрыта";
            item.DateTimeEnd = DateTime.Now;
            dataManager.applications.SaveApplication(item);
            MessageBox.Show($"Заявка №{id} закрыта!");
            UpdateGrid();
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //var id = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();

            //Domain.Application application = new Domain.Application
            //{
            //    Id = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value),
            //    DateTimeStart = Convert.ToDateTime(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value),
            //    Opis = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString(),
            //    DateTimeEnd = Convert.ToDateTime(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value),
            //    Prim = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[4].Value.ToString(),
            //    CompName = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[5].Value.ToString(),
            //    Tel = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[6].Value.ToString(),
            //    AppState = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString(),

            //};

            //var item = dataManager.applications.GetApplicationById(Convert.ToInt32(id));
            //if (application != item)
            //{
            //    dataManager.applications.SaveApplication(application);
            //    UpdateGrid();
            //}
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            UsersForm f = new UsersForm();
            f.Show();
            this.Close();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemId.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            start.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            var descr = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[2].Value ?? "";
            desc.Text = descr.ToString();
            var endT = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value ?? "";
            end.Text = endT.ToString();
            var prime = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[4].Value ?? "";
            prim.Text = prime.ToString();
            PCname.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[5].Value.ToString();
            phone.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[6].Value.ToString();
            status.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString();
            fio.Text = dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[8].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminsForms f = new AdminsForms();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddApplicationForm f = new AddApplicationForm();
            //f.Show();
            //this.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            List<Domain.ApplicationView> res = new List<ApplicationView>();
            foreach (var item in copy)
            {
                switch (criteria.SelectedItem.ToString())
                {
                    case "Описание":
                        if (item.Descriprion is null)
                        {
                            break;
                        }
                        if (item.Descriprion.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Примечание":
                        if (item.Prim is null)
                        {
                            break;
                        }
                        if (item.Prim.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Имя компьютера":
                        if (item.PC.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Номер телефона":
                        if (item.Phone.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "Статус":
                        if (item.Status.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    case "ФИО пользователя":
                        if (item.Fio.ToLower().StartsWith(search.Text.ToLower()))
                        {
                            res.Add(item);
                        }
                        break;
                    default:
                        MessageBox.Show("Ошибка выборки критерия, попробуйте снова!");
                        break;
                }
            }
            if (search.Text.Length > 0)
                dataGrid.DataSource = res;
            else UpdateGrid();
        }
        //private static void SerializeToXlsx(List<ApplicationView> obj, string nameFile = null)
        //{
        //    if (obj is null)
        //        throw new Exception("Данные пустые!");
        //    try
        //    {
        //        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        //        ExcelPackage excelPackage = new();
        //        var worksheet = excelPackage.Workbook.Worksheets.Add(nameFile ?? $"NewFile{obj.GetHashCode()}");

        //        worksheet.Cells[1, 1].Value = "Номер заявки";
        //        worksheet.Cells[1, 2].Value = "Дата подачи";
        //        worksheet.Cells[1, 3].Value = "Описание";
        //        worksheet.Cells[1, 4].Value = "Дата закрытия";
        //        worksheet.Cells[1, 5].Value = "Примечание";
        //        worksheet.Cells[1, 6].Value = "Название компьютера";
        //        worksheet.Cells[1, 7].Value = "Номер телефона";
        //        worksheet.Cells[1, 8].Value = "Статус заявки";
        //        worksheet.Cells[1, 9].Value = "ФИО пользователя";


        //        ushort row = 2;
        //        foreach (var item in obj)
        //        {
        //            worksheet.Cells[row, 1].Value = item.Id;
        //            worksheet.Cells[row, 2].Value = item.Start;
        //            worksheet.Cells[row, 3].Value = item.Descriprion;
        //            worksheet.Cells[row, 4].Value = item.End;
        //            worksheet.Cells[row, 5].Value = item.Prim;
        //            worksheet.Cells[row, 6].Value = item.PC;
        //            worksheet.Cells[row, 7].Value = item.Phone;
        //            worksheet.Cells[row, 8].Value = item.Status;
        //            worksheet.Cells[row, 9].Value = item.Fio;

        //            row++;

        //        }

        //        FileInfo excelFile = new((nameFile ?? $"ОтчетПоЗаявкам{obj.GetHashCode()}") + @".xlsx");
        //        excelPackage.SaveAs(excelFile);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Произошла ошибка во время сохранения файла.\nПодробности: {ex.Message}", "Ошибка сохранения", MessageBoxButtons.OK);
        //    }
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата начала не может быть больше даты конца!");
                return;
            }
            var items = from a in dataManager.db.Applications
                        join u in dataManager.db.Users on a.UserId equals u.Id
                        where a.DateTimeStart > dateTimePicker1.Value && a.DateTimeStart < dateTimePicker2.Value
                        select new ApplicationView
                        {
                            Id = a.Id,
                            Start = a.DateTimeStart,
                            Descriprion = a.Opis,
                            End = a.DateTimeEnd,
                            Prim = a.Prim,
                            PC = a.CompName,
                            Phone = a.Tel,
                            Status = a.AppState,
                            Fio = u.Fio,
                        };
            var list = items.ToList();
            dataGrid.DataSource = list;
            XWPFDocument doc = new XWPFDocument();
            var p = doc.CreateParagraph();
            p.Alignment = ParagraphAlignment.CENTER;
            XWPFRun r = p.CreateRun();
            r.FontSize = 20;

            r.SetText($"Отчет за {dateTimePicker1.Value.ToShortDateString()}-{dateTimePicker2.Value.ToShortDateString()}");
            r.IsBold = true;
            XWPFTable table = doc.CreateTable(dataGrid.RowCount, 9);
            table.GetRow(0).GetCell(0).SetText("Номер заявки");
            table.GetRow(0).GetCell(1).SetText("Дата подачи");
            table.GetRow(0).GetCell(2).SetText("Описание");
            table.GetRow(0).GetCell(3).SetText("Дата закрытия");
            table.GetRow(0).GetCell(4).SetText("Примечание");
            table.GetRow(0).GetCell(5).SetText("Название компьютера");
            table.GetRow(0).GetCell(6).SetText("Номер телефона");
            table.GetRow(0).GetCell(7).SetText("Статус заявки");
            table.GetRow(0).GetCell(8).SetText("ФИО пользователя");
            for (int i = 1; i < dataGrid.RowCount; i++)
            {
                for (int x = 0; x < dataGrid.ColumnCount; x++)
                {
                    if (dataGrid.Rows[i].Cells[x].Value != null)
                        table.GetRow(i).GetCell(x).SetText(dataGrid.Rows[i].Cells[x].Value.ToString() ?? "");
                    else
                        table.GetRow(i).GetCell(x).SetText("");
                }
            }
            using (FileStream f = File.Create($"Отчет.docx"))
            {
                doc.Write(f);
            }
            MessageBox.Show("Отчет сформирован успешно! Он находится в корневой папке программы.");
            UpdateGrid();
        }

        private void ApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignForm f=new SignForm();
            f.Show();
            this.Close();
        }
    }
}
