using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int n = 1;

            for(int i = 1; i <= input; i++)
            {
                n = n * i;
            }
            Console.WriteLine("Factorial of {0}: {1}", input, n);

            n = 1;

            for (int i = input; i >= 1; i--)
            {
                n = n * i;
            }
            Console.WriteLine("Factorial of {0}: {1}", input, n);
        }
    }
}
