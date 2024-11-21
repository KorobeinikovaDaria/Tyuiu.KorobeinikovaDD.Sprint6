using Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21
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

                int x = Convert.ToInt32(textBoxVarA.Text);

                textBoxResult.Text = Convert.ToString(ds.Calculate(x));
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
            MessageBox.Show("Task 0 выполнила студент группы ПКТБ-24-1 Коробейникова Дарья Денисовна");
        }
    }
}
