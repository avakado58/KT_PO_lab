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
        }

        private void ButPerform_Click(object sender, System.EventArgs e)
        {
            Masiv.Perform();
            textBoxPerform.Clear();
            textBoxPerform.Text = Masiv.Value;
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
            throw new System.NotImplementedException();
        }
    }
}
