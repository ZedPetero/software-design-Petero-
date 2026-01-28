namespace Task3Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int FibonacciSequence(int n)
        {
            if (n <= 1) {
                return n;
            }
            else
            {
                return FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int result = FibonacciSequence(number);
            if (number == 1) {
                label3.Text = "The " + number + "st term of the Fibonacci Sequence is " + result;
            } else if (number == 2) {
                label3.Text = "The " + number + "nd term of the Fibonacci Sequence is " + result;
            } else if (number == 3){
                label3.Text = "The " + number + "rd term of the Fibonacci Sequence is " + result;
            } else { 
                label3.Text = "The " + number + "th term of the Fibonacci Sequence is " + result;
            }
        }
    }
}
