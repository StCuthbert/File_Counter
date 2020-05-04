using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Counter
{
    public partial class Form1 : Form
    {
        FileCounter counter;
        string path;
        public Form1()
        {
            InitializeComponent();
            counter = new FileCounter();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath;
                this.DirectoryPath.Text = path;
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                counter.FileCount(path, SearchPattern.Text);
                this.FilesCount.Text = counter.files_count.ToString();
            }
            else
            {
                MessageBox.Show("Выберите путь к директории!");
            }
        }
    }
}
