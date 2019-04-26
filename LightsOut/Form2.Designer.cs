namespace LightsOut
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.question = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 3;
            // 
            // question
            // 
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("SimSun", 12F);
            this.question.Location = new System.Drawing.Point(36, 31);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(356, 75);
            this.question.TabIndex = 1;
            this.question.Text = "What board size do you want? (Please enter an integer between 3 and 7)";
            this.question.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(229, 129);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 28);
            this.submit.TabIndex = 2;
            this.submit.Text = "OK";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 291);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.question);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Difficulty Level";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button submit;
    }
}