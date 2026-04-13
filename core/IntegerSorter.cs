namespace AssignmentPW.Core
{
    public class IntegerSorter
    {
        public static int[] Sort(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            int[] copy = (int[])numbers.Clone();

            int n = copy.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (copy[j] > copy[j + 1])
                    {
                        int temp = copy[j];
                        copy[j] = copy[j + 1];
                        copy[j + 1] = temp;
                    }
                }
            }

            return copy;
        }
    }
}