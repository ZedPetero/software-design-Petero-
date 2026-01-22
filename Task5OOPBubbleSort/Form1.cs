namespace Task5OOPBubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = [2, 5, 7, 8, 9, 3, 4, 10, 1, 6];
            int[] sortedNumbers = BubbleSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }

    private class Sort
    {
        public int[] Sort() 
    }
}
