namespace MathProblemSloverApp
{
    partial class PythagorasPage
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
            PYAInput = new Label();
            PYAInputBox = new TextBox();
            PYBInputBox = new TextBox();
            PYBInput = new Label();
            label1 = new Label();
            label2 = new Label();
            AnwserLabel = new Label();
            SolvePYProblem = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // PYAInput
            // 
            PYAInput.AutoSize = true;
            PYAInput.Font = new Font("MV Boli", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PYAInput.Location = new Point(241, 111);
            PYAInput.Name = "PYAInput";
            PYAInput.Size = new Size(26, 26);
            PYAInput.TabIndex = 0;
            PYAInput.Text = "A";
            // 
            // PYAInputBox
            // 
            PYAInputBox.Location = new Point(273, 114);
            PYAInputBox.Name = "PYAInputBox";
            PYAInputBox.Size = new Size(46, 23);
            PYAInputBox.TabIndex = 1;
            // 
            // PYBInputBox
            // 
            PYBInputBox.Location = new Point(273, 160);
            PYBInputBox.Name = "PYBInputBox";
            PYBInputBox.Size = new Size(46, 23);
            PYBInputBox.TabIndex = 3;
            // 
            // PYBInput
            // 
            PYBInput.AutoSize = true;
            PYBInput.Font = new Font("MV Boli", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PYBInput.Location = new Point(241, 157);
            PYBInput.Name = "PYBInput";
            PYBInput.Size = new Size(24, 26);
            PYBInput.TabIndex = 2;
            PYBInput.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 373);
            label1.Name = "label1";
            label1.Size = new Size(24, 26);
            label1.TabIndex = 4;
            label1.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 373);
            label2.Name = "label2";
            label2.Size = new Size(23, 26);
            label2.TabIndex = 5;
            label2.Text = "=";
            // 
            // AnwserLabel
            // 
            AnwserLabel.AutoSize = true;
            AnwserLabel.Font = new Font("MV Boli", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AnwserLabel.Location = new Point(248, 373);
            AnwserLabel.Name = "AnwserLabel";
            AnwserLabel.Size = new Size(23, 26);
            AnwserLabel.TabIndex = 6;
            AnwserLabel.Text = "?";
            // 
            // SolvePYProblem
            // 
            SolvePYProblem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SolvePYProblem.Location = new Point(213, 224);
            SolvePYProblem.Name = "SolvePYProblem";
            SolvePYProblem.Size = new Size(151, 78);
            SolvePYProblem.TabIndex = 7;
            SolvePYProblem.Text = "Solve";
            SolvePYProblem.UseVisualStyleBackColor = true;
            SolvePYProblem.Click += SolvePYProblem_Click;
            // 
            // Back
            // 
            Back.Location = new Point(-8, -3);
            Back.Name = "Back";
            Back.Size = new Size(94, 47);
            Back.TabIndex = 8;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // PythagorasPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 605);
            Controls.Add(Back);
            Controls.Add(SolvePYProblem);
            Controls.Add(AnwserLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PYBInputBox);
            Controls.Add(PYBInput);
            Controls.Add(PYAInputBox);
            Controls.Add(PYAInput);
            Name = "PythagorasPage";
            Text = "PythagorasPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PYAInput;
        private TextBox PYAInputBox;
        private TextBox PYBInputBox;
        private Label PYBInput;
        private Label label1;
        private Label label2;
        private Label AnwserLabel;
        private Button SolvePYProblem;
        private Button Back;
    }
}