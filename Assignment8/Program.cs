namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SolutionQ1 q1 = new SolutionQ1();
            //int[] A1 = { 1, 2, 3, 4, 5 };

            SolutionQ2 q2 = new SolutionQ2();
            string multiplicationTable = q2.solution(1, 5, 1, 5);
            Console.WriteLine("Multiplication Table:");
            Console.WriteLine(multiplicationTable);

            SolutionQ3 q3 = new SolutionQ3();
            int[] A = { 1, 2, 3, 0, 4, 5 };
            int result = q3.solution(A);
            Console.WriteLine($"The sum of positive integers before the first zero is: {result}");
        }
    }
}
