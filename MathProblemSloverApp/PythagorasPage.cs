using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProblemSloverApp
{
    public partial class PythagorasPage : Form
    {

        double C;

        public PythagorasPage()
        {
            InitializeComponent();
        }

        private void SolvePYProblem_Click(object sender, EventArgs e)
        {
            if (PYAInputBox.Text != null && PYBInput.Text != null)
            {
                Debug.WriteLine("Solve");
                C = Hypotenuse(double.Parse(PYAInputBox.Text), double.Parse(PYBInputBox.Text));
                AnwserLabel.Text = "" + C;
            }
            else if (PYAInputBox.Text != null && PYBInput.Text == null)
            {
                Debug.WriteLine("No B Input");
            }
            else if (PYAInputBox.Text == null && PYBInput.Text != null)
            {
                Debug.WriteLine("No A Input");
            }
            else if (PYAInputBox.Text == null && PYBInput.Text == null)
            {
                Debug.WriteLine("No Input For A Or B");
            }
        }

        public static double Hypotenuse(double side1, double side2)
        {
            return Math.Sqrt((side1 * side1) + (side2 * side2));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathsSection mathsSection = new MathsSection();
            mathsSection.Show();
        }
    }
}
