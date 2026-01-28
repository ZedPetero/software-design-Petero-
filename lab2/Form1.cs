namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 1) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int result = RecursiveFactorial(number);
            label1.Text = $"Factorial : {result}";
        }
    }
}
