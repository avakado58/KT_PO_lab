
using System.IO;
using System.Windows.Forms;

namespace KT_PO_lab
{
    public partial class MainForm : Form
    {
        Masiv Masiv = new Masiv();
        string pathSaveFile;
        public MainForm()
        {
            InitializeComponent();
            butFromFile.Click += ButFromFile_Click;
            butGenerate.Click += ButGenerate_Click;
            butPerform.Click += ButPerform_Click;
            textBoxOriginal.TextChanged += TextBoxOriginal_TextChanged;
            butActInput.Click += ButActInput_Click;
            butFileSeting.Click += ButFileSeting_Click;
        }

        private void ButFileSeting_Click(object sender, System.EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Text Files | *.txt";
                saveFile.DefaultExt = "txt";
                if (saveFile.ShowDialog()==DialogResult.OK)
                {
                    pathSaveFile = saveFile.FileName;
                    
                }
                
                
            }
        }

        private void ButActInput_Click(object sender, System.EventArgs e)
        {
            textBoxOriginal.ReadOnly = false;
        }

        private void TextBoxOriginal_TextChanged(object sender, System.EventArgs e)
        {
            if(textBoxOriginal.ReadOnly==false)
            {
                Masiv.Value = textBoxOriginal.Text;
                Masiv.FlagPerformChangeOnTrue(); 
            }
            
        }

        private void ButPerform_Click(object sender, System.EventArgs e)
        {
            Masiv.Perform();
            textBoxPerform.Clear();
            ValueK.Text = "Значение К " + Masiv.K;
            if (onTheScreen.Checked)
            {
                textBoxPerform.Text = Masiv.Value;
            }
            else
            {
                if(pathSaveFile ==null)
                {
                    MessageBox.Show("Выберите путь для сохранения файла","Предупреждение",MessageBoxButtons.OK);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(pathSaveFile))
                    {
                        writer.WriteLine(Masiv.Value);
                    }
                }
            }
            
        }

        private void ButGenerate_Click(object sender, System.EventArgs e)
        {
            textBoxOriginal.ReadOnly = true;
            Masiv.Generate();
            textBoxOriginal.Clear();
            textBoxOriginal.Text = Masiv.Value;
            ValueK.Text = "Значение К " + Masiv.K;
        }

        private void ButFromFile_Click(object sender, System.EventArgs e)
        {
            textBoxOriginal.ReadOnly = true;
            Masiv.LoadFromFile();
            textBoxOriginal.Text = Masiv.Value;
            ValueK.Text = "Значение К " + Masiv.K;


        }
    }
}
