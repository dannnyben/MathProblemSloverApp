using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProblemSloverApp
{
    public partial class MathsSection : Form
    {
        public MathsSection()
        {
            InitializeComponent();
        }

        private void PythagorasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PythagorasPage PY = new PythagorasPage();
            PY.Show();
        }

        private void ExponentsPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExponentsPage exponentsPage = new ExponentsPage();
            exponentsPage.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseTopicPage TopicsPage = new ChooseTopicPage();
            TopicsPage.Show();
        }
    }
}
