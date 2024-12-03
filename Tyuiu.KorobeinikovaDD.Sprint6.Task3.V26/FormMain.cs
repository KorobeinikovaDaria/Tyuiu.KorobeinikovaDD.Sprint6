using System.Drawing.Drawing2D;
using Tyuiu.KorobeinikovaDD.Sprint6.Task3.V26.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task3.V26
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
                int[,] matrix = new int[5, 5]{ {16, 19, 17, 2 ,8 },

                                             { -17 ,8 ,-17 ,-8 ,1 },

                                             {-7 ,17 ,-2 ,1 ,-3 },

                                             {-12 ,0 ,-17 ,15 ,6 },

                                             {17 ,-6 ,-17 ,18 ,-19 } };

                int rows = matrix.GetUpperBound(0) + 1;
                int columns = matrix.Length / rows;

                dataGridMatrix.ColumnCount = columns;
                dataGridMatrix.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridMatrix.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                    }
                }



                int[,] res = ds.Calculate(matrix);
                int rows2 = res.GetUpperBound(0) + 1;
                int columns2 = res.Length / rows;

                dataGridRes.ColumnCount = columns2;
                dataGridRes.RowCount = rows2;

                for (int i = 0; i < columns; i++)
                {
                    dataGridRes.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridRes.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                    }
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
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 3 выполнила студент группы ПКТБ-24-1 Коробейникова Дарья Денисовна", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

