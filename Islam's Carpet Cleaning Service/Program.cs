namespace Islam_s_Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceSmall = 25;
            int priceLarge = 35;
            double taxRet = 0.06;

            Console.WriteLine("please, enter the Number of Small carpet  : ");
            int small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please, enter the Number of Large carpet  : ");
            int large = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The Price small room :$25\nThe Price Large room :$35");
            Console.WriteLine("The Price small room :$25");
            Console.WriteLine("The Price Large room :$35");


            int cost = (small * priceSmall) + (large * priceLarge);
            double tax = cost * taxRet;
            double totalCost = tax + cost;


            Console.WriteLine("the Cost :$ " + cost);
            Console.WriteLine("the Tax :$ " + tax);
            Console.WriteLine("======================================");
            Console.WriteLine("the Total estimate :$ " +totalCost);
            Console.WriteLine("This estimate is valid for 30 days ");

        }
    }
}
