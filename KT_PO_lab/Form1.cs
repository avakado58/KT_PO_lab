
using System.Windows.Forms;

namespace KT_PO_lab
{
    public partial class MainForm : Form
    {
        Masiv Masiv = new Masiv();
        public MainForm()
        {
            InitializeComponent();
            butFromFile.Click += ButFromFile_Click;
            butGenerate.Click += ButGenerate_Click;
            butPerform.Click += ButPerform_Click;
            textBoxOriginal.TextChanged += TextBoxOriginal_TextChanged;
            butActInput.Click += ButActInput_Click;
        }

        private void ButActInput_Click(object sender, System.EventArgs e)
        {
            textBoxOriginal.ReadOnly = false;
        }

        private void TextBoxOriginal_TextChanged(object sender, System.EventArgs e)
        {
            if(textBoxOriginal.ReadOnly==false)
            {
                 Masiv.FlagPerformChangeOnTrue();
                Masiv.Value = textBoxOriginal.Text;
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

            }
            
        }

        private void ButGenerate_Click(object sender, System.EventArgs e)
        {

            Masiv.Generate();
            textBoxOriginal.Clear();
            textBoxOriginal.Text = Masiv.Value;
            ValueK.Text = "Значение К " + Masiv.K;
        }

        private void ButFromFile_Click(object sender, System.EventArgs e)
        {
            Masiv.LoadFromFile();
            textBoxOriginal.Text = Masiv.Value;
            ValueK.Text = "Значение К " + Masiv.K;


        }
    }
}
