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
            SorterClass Sorter = new SorterClass();
            int[] numbers = [2, 5, 7, 8, 9, 3, 4, 10, 1, 6];
            int[] sortedNumbers = Sorter.BubbleSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
