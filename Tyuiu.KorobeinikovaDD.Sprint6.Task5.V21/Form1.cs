using Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V21.txt";
            DataService ds = new DataService();
            try
            {
                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 20;
                dataGridViewNums.Columns[1].Width = 50;

                double[] numMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numMass.Length; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
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
    }
}
