namespace FIrst_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning service ");
            Console.WriteLine("$25 per small carpet");
            Console.WriteLine("$35 per large carpet");

            int carpetSmall = Convert.ToInt32(Console.ReadLine());
            carpetSmall = carpetSmall * 25;
            Console.WriteLine($"price of carpetsmall {carpetSmall}");


            int carpetLarge = Convert.ToInt32(Console.ReadLine());
            carpetLarge = carpetLarge * 35;
            Console.WriteLine($"price of carpetlarge {carpetLarge}");

            int cost;
            cost = carpetSmall + carpetLarge;
            Console.WriteLine($"cost {cost}\n");



            double tax;
            tax = cost * 0.06;

            Console.WriteLine($"tax {tax}\n");

            double total;
            total = cost + tax;
            Console.WriteLine($"total {total}");
            Console.WriteLine("This estimate is valid for 30 days");


            




        }
    }
}
