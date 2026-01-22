namespace Task4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers1 = [9, 8, 3, 5, 7, 4, 6];
            int[] sortedNumbers1 = ProceduralSort(numbers1);
            listBoxResults.DataSource = sortedNumbers1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
