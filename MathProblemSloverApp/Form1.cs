namespace MathProblemSloverApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseTopicPage TopicsPage = new ChooseTopicPage();
            TopicsPage.Show();
        }
    }
}