using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MathProblemSloverApp
{
    public partial class ExponentsPage : Form
    {
        public ExponentsPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathsSection MS = new MathsSection();
            MS.Show();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            string A = IntA.Text;
            string B = IntB.Text;

            string Ae = ExponentA.Text;
            string Be = ExponentB.Text;

            if (A == B && Ae != "1" && Be != "1")
            {
                int TotalInt = int.Parse(A);
                string Total = Ae + "+" + Be;

                ExponentAnwser.Text = TotalInt.ToString();
                eAnwser.Text = Total;
            }
            else if(A == B && Ae == "1" && Be == "1")
            {
                string TotalInt = A;
                int Total = int.Parse(Ae);
                int Total2 = int.Parse(Be);

                ExponentAnwser.Text = TotalInt.ToString();
                int EAnwser = Total * Total2;
                eAnwser.Text = EAnwser.ToString();
            }
            else
            {
                ExponentAnwser.Text = "Cannot Simplify";
            }
        }
    }
}
