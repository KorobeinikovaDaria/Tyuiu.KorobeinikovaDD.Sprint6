using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KorobeinikovaDD.Sprint6.Task4.V16.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task4.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
                TextBoxIn.Text = "";

                this.chartResult.Titles.Add("График функции");

                this.chartResult.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                Series series = new Series
                {
                    ChartType = SeriesChartType.Line
                };

                this.chartResult.Series.Clear();
                this.chartResult.Series.Add(series);

                for (int i = 0; i <= len - 1; i++)
                {
                    TextBoxIn.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartResult.Series[0].Points.AddXY(startValue, valueArray[i]);
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V16.txt" });
                File.WriteAllText(path, TextBoxIn.Text);

                DialogResult dialogResult = MessageBox.Show("Файл\n" + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Cбой при сохрании файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 4 выполнила студент группы ПКТБ-24-1 Коробейникова Дарья Денисовна", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void Tablica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

