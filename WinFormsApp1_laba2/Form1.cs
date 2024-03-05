using System.Text.RegularExpressions;

namespace WinFormsApp1_laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // считывем значения из настроек
            width.Text = Properties.Settings.Default.widht.ToString();
            height.Text = Properties.Settings.Default.height.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputWidht, inputHeight;
            try
            {
                inputWidht = this.width.Text;
                inputHeight = this.height.Text;
            }
            catch (FormatException)
            {
                return;
            }

            //  передаем введенные значения в параметры
            Properties.Settings.Default.widht = inputWidht;
            Properties.Settings.Default.height = inputHeight;
            Properties.Settings.Default.Save(); // сохраняем переданные значения, чтобы они восстановились пре очередном запуске

            var outMassage = Logic.Compare(inputWidht, inputHeight);
            MessageBox.Show(outMassage);
        }

        public class Logic
        {
            public static string Compare(string inputWidht, string inputHeight)
            {
                string outMessage = "";
                int count = 0;

                if (CheckInput(inputHeight) && CheckInput(inputWidht))
                {
                    int width = int.Parse(inputWidht);
                    int height = int.Parse(inputHeight);

                    outMessage = "Квадраты имеют размерности: ";
                    for (; width >= 1 && height >= 1; count++)
                    {
                        if (width < height)
                        {
                            int temp = width;
                            width = height;
                            height = temp;
                        }
                        width -= height;

                        outMessage += height + " ";
                    }
                    outMessage += $"\nКоличество квадратов: {count}\n";
                }
                else
                {
                    outMessage = "Ошибка ввода\n";
                }
                return outMessage;
            }
            static bool CheckInput(string size)
            {
                return Regex.IsMatch(size, @"^[0-9]+$");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ctrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дан прямоугольник с размерами a × b. От него отрезают квадраты максимального размера, пока это возможно. " +
                "Затем от оставшегося прямоугольника вновь отрезают квадраты максимально возможного размера и т. д. " +
                "На какие квадраты и в каком их количестве будет разрезан исходный прямоугольник?");
        }
    }
}
