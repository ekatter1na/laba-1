namespace laba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество шагов, если оно будет отрицательным, то программа закроется");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double S = 0;
            for (int i = 0; i <= n; i++)
            {
                if (n < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число шагов");
                    break;
                }
                else
                {
                    x = (Math.Pow(-1, i)) * (Math.Pow(x, (i + 1))) / (i + 1);
                    S += x;
                    Console.WriteLine(S);
                }
            }
        }
    }
}