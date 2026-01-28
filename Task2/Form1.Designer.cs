namespace Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(231, 78);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(339, 23);
            txtArrayInput.TabIndex = 0;
            txtArrayInput.Text = "Please input numbers separated by comma (eg. 10, 20)";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(318, 161);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(164, 23);
            btnCalculateSum.TabIndex = 1;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 15F);
            lblSumResult.Location = new Point(368, 235);
            lblSumResult.MaximumSize = new Size(100, 100);
            lblSumResult.MinimumSize = new Size(50, 20);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(64, 28);
            lblSumResult.TabIndex = 2;
            lblSumResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
    }
}
