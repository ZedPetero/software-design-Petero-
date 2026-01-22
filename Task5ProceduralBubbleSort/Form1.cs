using System.Security.Cryptography.X509Certificates;

namespace Task5ProceduralBubbleSort
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



            int[] BubbleSort(int[] numbers)
                {
                    int size = numbers.Length;
                    int[] ints = new int[size];
                    ints = numbers;

                    for (int i = 0; i < size - 1; i++) {
                        for (int j = 0; j < size - 1; j++)
                        {
                            if (ints[j] > ints[j + 1])
                            {
                                int temp = ints[j];
                                ints[j] = ints[j + 1];
                                ints[j + 1] = temp;
                            }
                        }
                    }

                    return ints;
                }
        }
    }
}
