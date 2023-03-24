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
    public partial class ChooseTopicPage : Form
    {
        public ChooseTopicPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 StartingForm = new Form1();
            StartingForm.Show();
        }

        private void Maths_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathsSection MathsTopic = new MathsSection();
            MathsTopic.Show();
        }

        private void Physics_Click(object sender, EventArgs e)
        {

        }

        private void Computing_Click(object sender, EventArgs e)
        {

        }
    }
}
