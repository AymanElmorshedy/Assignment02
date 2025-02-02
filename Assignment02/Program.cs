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

        #region Q02
        public static bool IsPalindrome(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;
                left++;
                right--;



            }
            return true;
        }
        #endregion

        #region Q03
        public static void ReverseQueue( Queue<int> queue )
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            
        }
        #endregion

        #region Q05
        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (!list.Contains(i))
                    list.Add(i);
            }
            return list.ToArray();
        }
        #endregion



        static void Main(string[] args)
        {
            #region Q01
            //List<int> Numbers = new List<int>() { 11, 5, 3 };

            //Console.WriteLine($"Numbers is grreater than num in list is {IsGreater(Numbers,1)}");
            //Console.WriteLine($"Numbers is grreater than num in list is {IsGreater(Numbers,7)}");


            #endregion

            #region Q02
            //int[] Numbers = { 1, 3, 2, 3, 1 };
            //Console.WriteLine(IsPalindrome(Numbers));
            #endregion

            #region Q03
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));



            #endregion

            #region Q04

            #endregion

            #region Q05
            int[] Numbers = { 1, 3, 2, 3, 1 };
            int[] result = RemoveDuplicates(Numbers);
            Console.WriteLine(string.Join(", ", result));
            #endregion

        }
    }
}
