using System.IO;
using System;
using Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "l";
            textBoxResult.Text = ds.CollectTextFromFile(str, openFilePath);
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData + Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}
