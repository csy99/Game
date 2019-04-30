namespace LightsOut
{
    partial class Form1
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
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moveCount = new System.Windows.Forms.TextBox();
            this.Undo = new System.Windows.Forms.Button();
            this.Difficulty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(179, 29);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(112, 32);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(312, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move";
            // 
            // moveCount
            // 
            this.moveCount.Location = new System.Drawing.Point(362, 29);
            this.moveCount.Multiline = true;
            this.moveCount.Name = "moveCount";
            this.moveCount.Size = new System.Drawing.Size(41, 32);
            this.moveCount.TabIndex = 2;
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(42, 29);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(112, 32);
            this.Undo.TabIndex = 3;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Difficulty
            // 
            this.Difficulty.Location = new System.Drawing.Point(422, 29);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(112, 32);
            this.Difficulty.TabIndex = 4;
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.UseVisualStyleBackColor = true;
            this.Difficulty.Click += new System.EventHandler(this.Difficulty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 623);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.moveCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lights Out";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AutoSize = true;

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moveCount;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Difficulty;
    }
}

