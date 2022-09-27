using Converter.src;
using System;
using System.Windows.Forms;

namespace Converter
{
    public partial class FormMain : Form
    {
        protected bool has_dot = false;
        protected byte p1 = 2, p2 = 10;
        internal Editor editor = new Editor();
        protected History history = Program.HstoryObject;
        public FormMain()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; // value for 2
            comboBox2.SelectedIndex = 8; // value for 10
            textBox1.Text = "0";
            textBox2.Text = "";
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //Метод замены знака
        private void ChangeSign(object sender, EventArgs e) // +-
        {
            string str = textBox1.Text;
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                else
                    textBox1.Text = "-" + str;
            }
        }
        //Метод удаления последнего символа
        private void DoBackspace(object sender, EventArgs e) // backspace
        {
            if (textBox1.Text.Length >= 1) {
                if (textBox1.Text[textBox1.Text.Length - 1] == Program.DecimalPoint[0])
                    has_dot = false;
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "-")
                    textBox1.Text = "0";
            }
            if(textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
        }
        //Метод очистки поля
        private void DoClean(object sender, EventArgs e) // очистка
        {
            if (textBox1.Text.Length != 0)
            {
                has_dot = false;
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
        }
        private void AddDigit(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // проверка, которая запрещает ставить ноль первым в число
            if (button.Text != "0" || !textBox1.Text.Equals(String.Empty))
                textBox1.Text += button.Text;

            // this breaks history
            //this.DoConversion(null, null); // WARNING: костыль
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) // изменение исходного числа
        {
            if (textBox1.Text.Equals("0"))
                textBox1.Text = "";
            textBox1.Text = editor.DoEditing(textBox1.Text, p1);
            textBox1.SelectionStart = textBox1.Text.Length; // установить курсор в конце строки
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoConversion(object sender, EventArgs ev)
        {
            byte p1, p2;
            try
            {
                if (!Byte.TryParse(comboBox1.Text, out p1))
                    throw new Exception("Основание исходной системы счисления введено неверно.");
                if (!Byte.TryParse(comboBox2.Text, out p2))
                    throw new Exception("Основание желаемой системы счисления введено неверно.");
                if (textBox1.Text == "")
                    throw new Exception("Пожалуйста, введите исходное число для конвертации.");

                // если последний элемент строки точка, то поставить ноль
                if (textBox1.Text[textBox1.Text.Length - 1].ToString() == Program.DecimalPoint)
                    textBox1.Text += "0";

               textBox2.Text = src.Control.DoConversion(textBox1.Text, p1, p2);
               history.AddToHistory(textBox2.Text, p1, p2, textBox1.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка при конвертации");
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AboutForm.ShowDialog();
        }

        private void ExitApplaction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.HistoryForm.ShowDialog();
        }
        private void ClearHistory(object sender, EventArgs e) // очищение истории
        {
            Program.HstoryObject.EraseHistory();
        }

        private void ChangeSourceBasis(object sender, EventArgs e)
        {
            this.p1 = Byte.Parse(comboBox1.Text);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button13.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;

            if (p1 > 2)
                button8.Enabled = true;
            if (p1 > 3)
                button25.Enabled = true;
            if (p1 > 4)
                button26.Enabled = true;
            if (p1 > 5)
                button27.Enabled = true;
            if (p1 > 6)
                button28.Enabled = true;
            if (p1 > 7)
                button13.Enabled = true;
            if (p1 > 8)
                button21.Enabled = true;
            if (p1 > 9)
                button22.Enabled = true;
            if (p1 > 10)
                button1.Enabled = true;
            if (p1 > 11)
                button2.Enabled = true;
            if (p1 > 12)
                button3.Enabled = true;
            if (p1 > 13)
                button4.Enabled = true;
            if (p1 > 14)
                button5.Enabled = true;
            if (p1 > 15)
                button6.Enabled = true;

            DoClean(null, null); // небольшой костыль
            textBox1.Text = "0";
        }
        private void ChangeDestinBasis(object sender, EventArgs e)
        {
            p2 = Byte.Parse(comboBox2.Text);
        }
    }
}
