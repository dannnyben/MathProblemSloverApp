namespace MathProblemSloverApp
{
    partial class ExponentsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IntA = new TextBox();
            ExponentA = new TextBox();
            ExponentB = new TextBox();
            IntB = new TextBox();
            label1 = new Label();
            Back = new Button();
            Solve = new Button();
            ExponentAnwser = new Label();
            eAnwser = new Label();
            SuspendLayout();
            // 
            // IntA
            // 
            IntA.Location = new Point(209, 210);
            IntA.Name = "IntA";
            IntA.Size = new Size(25, 23);
            IntA.TabIndex = 0;
            // 
            // ExponentA
            // 
            ExponentA.Location = new Point(229, 181);
            ExponentA.Name = "ExponentA";
            ExponentA.Size = new Size(24, 23);
            ExponentA.TabIndex = 1;
            // 
            // ExponentB
            // 
            ExponentB.Location = new Point(318, 181);
            ExponentB.Name = "ExponentB";
            ExponentB.Size = new Size(24, 23);
            ExponentB.TabIndex = 3;
            // 
            // IntB
            // 
            IntB.Location = new Point(298, 210);
            IntB.Name = "IntB";
            IntB.Size = new Size(25, 23);
            IntB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 167);
            label1.Name = "label1";
            label1.Size = new Size(32, 54);
            label1.TabIndex = 4;
            label1.Text = ".";
            // 
            // Back
            // 
            Back.Location = new Point(-7, -1);
            Back.Name = "Back";
            Back.Size = new Size(98, 56);
            Back.TabIndex = 5;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Solve
            // 
            Solve.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Solve.Location = new Point(217, 291);
            Solve.Name = "Solve";
            Solve.Size = new Size(106, 63);
            Solve.TabIndex = 8;
            Solve.Text = "Solve";
            Solve.UseVisualStyleBackColor = true;
            Solve.Click += Solve_Click;
            // 
            // ExponentAnwser
            // 
            ExponentAnwser.AutoSize = true;
            ExponentAnwser.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExponentAnwser.Location = new Point(251, 431);
            ExponentAnwser.Name = "ExponentAnwser";
            ExponentAnwser.Size = new Size(21, 28);
            ExponentAnwser.TabIndex = 9;
            ExponentAnwser.Text = "?";
            // 
            // eAnwser
            // 
            eAnwser.AutoSize = true;
            eAnwser.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            eAnwser.Location = new Point(271, 403);
            eAnwser.Name = "eAnwser";
            eAnwser.Size = new Size(21, 28);
            eAnwser.TabIndex = 10;
            eAnwser.Text = "?";
            // 
            // ExponentsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 630);
            Controls.Add(eAnwser);
            Controls.Add(ExponentAnwser);
            Controls.Add(Solve);
            Controls.Add(Back);
            Controls.Add(label1);
            Controls.Add(ExponentB);
            Controls.Add(IntB);
            Controls.Add(ExponentA);
            Controls.Add(IntA);
            Name = "ExponentsPage";
            Text = "ExponentsPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IntA;
        private TextBox ExponentA;
        private TextBox ExponentB;
        private TextBox IntB;
        private Label label1;
        private Button Back;
        private Button Solve;
        private Label ExponentAnwser;
        private Label eAnwser;
    }
}