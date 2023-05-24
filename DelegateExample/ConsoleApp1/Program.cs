namespace DelegatePart1App
{
    internal class Program
    {
        public delegate void Mydel<T>(T n1,T n2);
        public void Add(int num1,int num2)
        {
            int result = 0;
            result = num1+ num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {result}");
        }
        public void Multiply(int num1, int num2)
        {
            int result = 0;
            result = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is {result}");
        }
        public void Subtract(int num1, int num2)
        {
            int result = 0;
            result = num1 - num2;
            Console.WriteLine($"The balance of {num2} subtracted from {num1} is {result}");

        }
        public void Divide(int num1, int num2)
        {
            int result = 0;
            result = num1 / num2;
            Console.WriteLine($"The result of {num1} divided by {num2} is {result}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //Mydel<int> del = new Mydel<int>(program.Add);
            Mydel<int> del = new Mydel<int>((num1,num2)=> Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}"));
            User user = new User();
            user.Calculate(del);
            Console.ReadKey();
        }
    }
}