using System.Collections;

namespace Assignment02
{
    internal class Program
    {
        #region Q01
        public static int IsGreater(List<int> arr, int num)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i > num)
                    count++;
            }
            return count;

        } 
        #endregion

        public static bool IsPalindrome(int [] arr)
        {
            int left = 0, right = arr.Length-1;
            while (left < right)
            {
                if(arr[left] != arr[right])
                    return false;
                left++;
                right--;



            }
            return true;
        }


        static void Main(string[] args)
        {
            #region Q01
            //List<int> Numbers = new List<int>() { 11, 5, 3 };

            //Console.WriteLine($"Numbers is grreater than num in list is {IsGreater(Numbers,1)}");
            //Console.WriteLine($"Numbers is grreater than num in list is {IsGreater(Numbers,7)}");


            #endregion

            #region Q02
            int[] Numbers = { 1, 3, 2, 3, 1 };
            Console.WriteLine(IsPalindrome(Numbers));
            #endregion
        }
    }
}
