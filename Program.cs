namespace WorkingWithDelegatesExercise2
{
    public class MathSolutions
    {
        static void GetSum(double x, double y)
        {
            Console.WriteLine($"The result is {x + y}");
        }
        static double GetProduct(double a, double b)
        {
            return a * b;
        }
        static void GetSmaller(double a, double b)
        {
            if (a < b)
            
                Console.WriteLine($" {a} is smaller than {b}");
            
            else if (b < a)
            
                Console.WriteLine($" {b} is smaller than {a}");
            
            else

                Console.WriteLine($" {a} is equal to {b}");
            
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double x = Math.Round(r.NextDouble() * 100);
            double y = Math.Round(r.NextDouble() * 100);
            double a = Math.Round(r.NextDouble() * 100);
            double b = Math.Round(r.NextDouble() * 100);
            
            //action delegate
            Action < double, double > calculate = GetSum;
            calculate(x, y);

            //anonymous method with a Func delegate
            Func <double, double, double> calcResult = delegate (double a, double b) { return a * b; };
            Console.WriteLine($"The product is {calcResult(a, b)}");

            Action <double, double> calcResult2 = GetSmaller;
            calcResult2(a, b);

            
            //Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            //Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            //answer.GetSmaller(num1, num2);
        }
    }  
}