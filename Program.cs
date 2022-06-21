namespace test
{
    internal class Program
    {
        public double Rem(double x, double y)
        {
            return x % y;
        }
        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double Percent(double x, double y)
        {
            return (x / y) * 100;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Select the action: \n1. Rem.\n2. Pow.\n3. percent.\n4. Mul.");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter 1st value:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter 2nd value:");
            double y = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            Program p = new Program();
            switch (selection)
            {
                case 1:
                    result = p.Rem(x, y);
                    Console.WriteLine("Result is:" + result);
                    break;

                case 2:
                    result = p.Pow(x, y);
                    Console.WriteLine("Result is:" + result);
                    break;

                case 3:
                    result = p.Percent(x, y);
                    Console.WriteLine("Result is:" + result);
                    break;

                case 4:
                    result = p.Mul(x, y);
                    Console.WriteLine("Result is:" + result);
                    break;
            }
            goto start;


        }
    }
}