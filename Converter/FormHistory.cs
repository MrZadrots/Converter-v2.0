using System;
using System.Windows.Forms;
using Converter.src;
namespace Converter { 
        public partial class FormHistory : Form
        {
            History history = Program.HstoryObject;
            public FormHistory()
            {
                InitializeComponent();
                dataGridView1.Columns.Add("1", "Исходное число ");
                dataGridView1.Columns.Add("2", "Система счисления p1");
                dataGridView1.Columns.Add("3", "Система счисления p2");
                dataGridView1.Columns.Add("4", "Результат");
                dataGridView1.Columns.Add("5", "Дата");
                dataGridView1.Columns.Add("6", "Время");
                this.UpdateTable();
            }

            private void DoCleanHistory(object sender, EventArgs e) // очищение истории
            {
                history.EraseHistory(); // очистка файла с историей
                while (dataGridView1.Rows.Count != 0) // очистка таблицы 
                    dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
                this.UpdateTable(); // показать таблицу
            }

            public void UpdateTable() // показать таблицу
            {
                label1.Visible = !history.FillData(dataGridView1);
                //dataGridView1.Invalidate();
            }

            private void CloseWindow(object sender, EventArgs e) // закрыть историю
            {
                this.Close();
            }

            private void FormHistory_Load(object sender, EventArgs e)
            {
                this.UpdateTable();
            }
        }
}
