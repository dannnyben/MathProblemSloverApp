namespace MathProblemSloverApp
{
    partial class ChooseTopicPage
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
            Maths = new Button();
            Physics = new Button();
            Computing = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // Maths
            // 
            Maths.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Maths.Location = new Point(164, 77);
            Maths.Name = "Maths";
            Maths.Size = new Size(202, 94);
            Maths.TabIndex = 0;
            Maths.Text = "Maths";
            Maths.UseVisualStyleBackColor = true;
            Maths.Click += Maths_Click;
            // 
            // Physics
            // 
            Physics.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Physics.Location = new Point(167, 237);
            Physics.Name = "Physics";
            Physics.Size = new Size(202, 94);
            Physics.TabIndex = 1;
            Physics.Text = "Physics";
            Physics.UseVisualStyleBackColor = true;
            Physics.Click += Physics_Click;
            // 
            // Computing
            // 
            Computing.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Computing.Location = new Point(164, 396);
            Computing.Name = "Computing";
            Computing.Size = new Size(202, 94);
            Computing.TabIndex = 2;
            Computing.Text = "Computing";
            Computing.UseVisualStyleBackColor = true;
            Computing.Click += Computing_Click;
            // 
            // Back
            // 
            Back.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Back.Location = new Point(-8, -1);
            Back.Name = "Back";
            Back.Size = new Size(119, 61);
            Back.TabIndex = 3;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // ChooseTopicPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 569);
            Controls.Add(Back);
            Controls.Add(Computing);
            Controls.Add(Physics);
            Controls.Add(Maths);
            Name = "ChooseTopicPage";
            Text = "ChooseTopicPage";
            ResumeLayout(false);
        }

        #endregion

        private Button Maths;
        private Button Physics;
        private Button Computing;
        private Button Back;
    }
}