using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaxPairwiseProduct
{
    class MaxPairwiseProduct
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            int n;

            if (Int32.TryParse(input, out n))
            {
                int[] numbers = new int[n];

                for (int i = 0; i < n; i++)
                {
                    var numberInput = Console.ReadLine();
                    int number;

                    if (Int32.TryParse(numberInput, out number))
                    {
                        numbers[i] = number;
                    }
                }

                Console.WriteLine(getMaxPairwiseProduct(numbers));
            }

       
        }

        static int getMaxPairwiseProduct(IEnumerable<int> numbers)
        {
            int result = 0;
            int n = numbers.Count();
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (numbers.ElementAt(i) * numbers.ElementAt(j) > result)
                    {
                        result = numbers.ElementAt(i) * numbers.ElementAt(j);
                    }
                }
            }
            return result;
        }
    }

}
