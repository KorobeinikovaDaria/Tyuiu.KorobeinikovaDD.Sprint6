using Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21
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

                int x = Convert.ToInt32(textBoxVarA.Text);
                textBoxResult.Text = Convert.ToString(ds.Calculate(x));
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� ����� �����.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}");
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 ��������� ������� ������ ����-24-1 ������������� ����� ���������");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
