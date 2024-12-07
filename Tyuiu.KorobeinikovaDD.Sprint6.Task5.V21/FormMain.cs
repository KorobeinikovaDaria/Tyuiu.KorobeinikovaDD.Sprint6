using Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        string path = @"C:\DataSprint6\InPutDataFileTask5V21.txt";
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                this.chartOut.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartOut.ChartAreas[0].AxisY.Title = "Ось Y";

                chartOut.Series[0].Points.Clear();

                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 20;
                dataGridViewNums.Columns[1].Width = 50;

                double[] numMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numMass.Length; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                    chartOut.Series[0].Points.AddXY(i, numMass[i]);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Произошла ошибка.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 5 выполнила студент группы ПКТБ-24-1 Коробейникова Дарья Денисовна", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
