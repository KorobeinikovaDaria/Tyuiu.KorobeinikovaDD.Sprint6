using System.Windows.Forms.VisualStyles;
using Tyuiu.KorobeinikovaDD.Sprint6.Task1.V29.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task1.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                string strLine;

                int startValue = Convert.ToInt32(textboxST.Text);
                int stopValue = Convert.ToInt32(textboxEND.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                Tablica.Text = "";
                Tablica.AppendText("+---------+---------+" + Environment.NewLine);
                Tablica.AppendText("+     X      +     f(x)   +" + Environment.NewLine);
                Tablica.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = string.Format("|{0,5:d}       |   {1,5:f2}    |", startValue, valueArray[i]);
                    Tablica.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                Tablica.AppendText("+---------+--------+" + Environment.NewLine);

            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректное целое число.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 1 выполнила студент группы ПКТБ-24-1 Коробейникова Дарья Денисовна");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

