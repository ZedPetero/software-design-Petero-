namespace Task5ProceduralBubbleSort
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
            btnSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(0, 0, 192);
            btnSort.Dock = DockStyle.Top;
            btnSort.Font = new Font("Segoe UI Black", 30F);
            btnSort.ForeColor = SystemColors.ControlLightLight;
            btnSort.Location = new Point(0, 0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(800, 93);
            btnSort.TabIndex = 0;
            btnSort.Text = "Bubble Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.Teal;
            listBoxResults.Dock = DockStyle.Fill;
            listBoxResults.Font = new Font("Segoe UI Light", 15F);
            listBoxResults.ForeColor = SystemColors.Window;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 28;
            listBoxResults.Location = new Point(0, 93);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(800, 357);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
    }
}
