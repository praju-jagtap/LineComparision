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
            if (line1 == line2)
                Console.WriteLine("Line1 and Line 2 both are Equal");
            else
                Console.WriteLine("Both Lines are not Equal");
        }
    }
}