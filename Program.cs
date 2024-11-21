namespace Week_3_Challenge_Labs._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("home"));
            Console.WriteLine(IsPalindrome("eye"));
        }

        static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
