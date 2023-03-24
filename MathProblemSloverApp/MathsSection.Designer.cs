namespace MathProblemSloverApp
{
    partial class MathsSection
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
            PythagorasButton = new Button();
            ExponentsPageButton = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // PythagorasButton
            // 
            PythagorasButton.Location = new Point(204, 98);
            PythagorasButton.Name = "PythagorasButton";
            PythagorasButton.Size = new Size(152, 70);
            PythagorasButton.TabIndex = 0;
            PythagorasButton.Text = "Pythagoras Theorem";
            PythagorasButton.UseVisualStyleBackColor = true;
            PythagorasButton.Click += PythagorasButton_Click;
            // 
            // ExponentsPageButton
            // 
            ExponentsPageButton.Location = new Point(204, 200);
            ExponentsPageButton.Name = "ExponentsPageButton";
            ExponentsPageButton.Size = new Size(152, 70);
            ExponentsPageButton.TabIndex = 1;
            ExponentsPageButton.Text = "Exponents";
            ExponentsPageButton.UseVisualStyleBackColor = true;
            ExponentsPageButton.Click += ExponentsPageButton_Click;
            // 
            // Back
            // 
            Back.Location = new Point(-8, -1);
            Back.Name = "Back";
            Back.Size = new Size(95, 58);
            Back.TabIndex = 2;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // MathsSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 584);
            Controls.Add(Back);
            Controls.Add(ExponentsPageButton);
            Controls.Add(PythagorasButton);
            Name = "MathsSection";
            Text = "MathsSection";
            ResumeLayout(false);
        }

        #endregion

        private Button PythagorasButton;
        private Button ExponentsPageButton;
        private Button Back;
    }
}