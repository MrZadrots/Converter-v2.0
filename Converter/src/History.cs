using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Converter.src
{
    public class History
    {
        ArrayList history_list = new ArrayList();
        public History()
        {
            try
            {
                foreach (string line in File.ReadAllLines(Program.HistoryFile, Encoding.UTF8));

            }
            catch
            {
                // TODO: workaround
                /*MessageBox.Show(
                "Не удалось обработать файл истории " + Program.HistoryFile +"\n"+ e.Message, 
                "Ошибка!");
                */
            }
        }

        //<summary>
        //Полная очистка истории
        //</summary>
        public void EraseHistory()
        {
            history_list.Clear();
            FileInfo file = new FileInfo(Program.HistoryFile);
            if (file.Exists)
                file.Delete();
        }

        //<summary>
        //Добавление записи в историю
        //</summary>
        public void AddToHistory(string new_data,byte p1,byte p2,string old_data)
        {
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();
            string str = old_data + " " + p1.ToString() + " " + p2.ToString() + " " + new_data + " " + date + " " + time;
            history_list.Add(str);
        }

        /// <summary>
        /// Заполняет DataGridView данными из ArrayList.
        /// </summary>
        /// <param name="Data">Ссылка на компонент DataGridView.</param>
        /// <returns>false, если ArrayList пуст, иначе true.</returns>
        /// 
        public bool FillData(DataGridView data)
        {
            data.Rows.Clear();
            if (history_list.Count > 0)
            {
                string[] A;
                int i = 0;
                foreach(string line in history_list)
                {
                    A = line.Split(' ');
                    data.Rows.Add();
                    for(int j = 0; j < 6; j++)
                    {
                        data[j, i].Value = A[j];
                    }
                    i++;
                }
                return true;
            }
            return false;
        }

    }
}
