using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring_Break_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " hello how are you how can i Help you";
            var result = RemoveDuplicates(s);
            var ReverseString = ReverseTheString(s);
            Console.WriteLine(ReverseString);
            int[] array = new int[] { 1, 4, 20, 3, 10, 5 };
            int n = array.Length;
            Console.ReadLine();
        }

        public static string RemoveDuplicates(string input)
        { 
            var array = input.Trim().ToLower().Split(' ');
            if (array.Length > 1)
            {
                List<string> result = new List<string>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (!result.Contains(array[i]))
                    {
                        result.Add(array[i]);
                    }
                }
                return string.Join(" ",result.ToArray());
            }
            else
            {
                List<char> result = new List<char>();
                char[] chr = array[0].ToCharArray();
                for (int i = 0; i < chr.Length; i++)
                {
                    if (!result.Contains(chr[i]))
                    {
                        result.Add(chr[i]);
                    }
                }
                string str = new string(result.ToArray());
                return str;
            }
        }

        public static string ReverseTheString(string s)
        {
            var array = s.Trim().ToLower().Split(' ');
            List<string> result = new List<string>();
            for (int i = array.Length-1; i >= 0 ; i--)
            {
                result.Add(array[i]);
            }
            return string.Join(" ", result.ToArray());
        }

        public static bool GetIndexOfElementForGivenSum(int[] arr, int sum)
        {
            int currentSum;
            for(int i = 0; i < arr.Length; i++)
            {
                currentSum = arr[i];
                for(int j = i + 1; j <= arr.Length; j++)
                {
                    if (currentSum == sum)
                    {
                        int index = j - 1;
                        Console.WriteLine("The Sum is between index {0} and {1}",i,index);
                        return true;
                    }
                    if(currentSum>sum || j == arr.Length)
                    { 
                        break;
                    }

                    currentSum += arr[j];
                }
            }
            Console.WriteLine("No indexes found for given sum");
            return false;
        }

    }
}
