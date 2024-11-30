using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KorobeinikovaDD.Sprint6.Task2.V2.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task2.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void label7_Click(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textboxST.Text);
                int stopValue = Convert.ToInt32(textboxEND.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                
                this.chart1.Titles.Add("График функции");

                this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                Series series = new Series
                {
                    ChartType = SeriesChartType.Line 
                };

                this.chart1.Series.Clear(); 
                this.chart1.Series.Add(series);

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chart1.Series[0].Points.AddXY(startValue, valueArray[i]);
                    
                    startValue++;
                }

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
        private void buttonDone_Mouse(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 2 выполнила студент группы ПКТБ-24-1 Коробейникова Дарья Денисовна");
        }
    }
}
