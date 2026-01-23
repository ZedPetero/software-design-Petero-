namespace Task5OOPBubbleSort
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
            listBoxResults = new ListBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = SystemColors.MenuHighlight;
            listBoxResults.Dock = DockStyle.Bottom;
            listBoxResults.Font = new Font("MS Reference Sans Serif", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBoxResults.ForeColor = Color.MidnightBlue;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 26;
            listBoxResults.Location = new Point(0, 108);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(800, 342);
            listBoxResults.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.BackColor = SystemColors.ActiveCaptionText;
            btnSort.Dock = DockStyle.Top;
            btnSort.Font = new Font("Rockwell Extra Bold", 30F, FontStyle.Bold);
            btnSort.ForeColor = SystemColors.ButtonFace;
            btnSort.Location = new Point(0, 0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(800, 89);
            btnSort.TabIndex = 1;
            btnSort.Text = "Bubble Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSort;
    }
}
