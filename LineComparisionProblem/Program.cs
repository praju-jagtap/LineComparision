namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparision comparison = new Comparision(1,2,3,4);
            double line1 = comparison.CalculateLength();
            Console.WriteLine("Length of 1st Line: " +line1);

            Comparision linecomparison = new Comparision(1,2,3,4);
            double line2 = linecomparison.CalculateLength();
            Console.WriteLine("Length of 2nd Line: " + line2);

            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Line1 and Line 2 Length are Preferable.");
            else
                Console.WriteLine("Line1 and Line 2 Length are Not Preferable.");
        }
    }
}