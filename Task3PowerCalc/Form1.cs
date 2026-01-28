using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3PowerCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int PowerSequence(int b, int n)
        {
            if (n == 1) return b;
            return b * PowerSequence(b, n - 1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int baseNum = int.Parse(textBox1.Text);
            int exponent = int.Parse(textBox2.Text);
            int result = PowerSequence(baseNum, exponent);
            label4.Text = "The answer of " + baseNum + " raised to " + exponent + " is " + result;
        }
    }
}
