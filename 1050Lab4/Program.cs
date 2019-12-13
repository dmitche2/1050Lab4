using System;

namespace _1050Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Pricing for Night At The Movies");
            System.Console.Write("How many child tickets: "); 
            int ticketsChild = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many adult tickets: ");
            int ticketsAdult = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many senior tickets: ");
            int ticketsSenior = int.Parse(System.Console.ReadLine());


            System.Console.Write("Is this a matinee or evening show? ");
            string showtimeAnswer = System.Console.ReadLine().ToLower();
            bool showtimeEvening = showtimeAnswer.Contains("matinee") || showtimeAnswer.Contains("evening");


            System.Console.Write("How many small sodas? ");
            int snacksSmallSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many large sodas? ");
            int snacksLargeSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Hot Dogs? ");
            int snacksHotDog = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Popcorns? ");
            int snacksPopcorn = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Candies? ");
            int snacksCandy = int.Parse(System.Console.ReadLine());


            double ticketsTotal = 0;
            if (showtimeEvening == true)
            {
                ticketsTotal = ticketsChild * 6.99;
                ticketsTotal += ticketsAdult * 10.99;
                ticketsTotal += ticketsSenior * 8.5;
            }
            else
            {
                ticketsTotal = ticketsChild * 3.99;
                ticketsTotal += ticketsAdult * 5.99;
                ticketsTotal += ticketsSenior * 4.5;
            }

            double priceSmallSoda = 3.50;
            double priceLargeSoda = 5.99;
            double priceHotDog = 3.99;
            double pricePopcorn = 4.50;
            double priceCandy = 1.99;


            double snacksTotal = snacksSmallSoda * priceSmallSoda;
            snacksTotal += snacksLargeSoda * priceLargeSoda;
            snacksTotal += snacksHotDog * priceHotDog;
            snacksTotal += snacksPopcorn * pricePopcorn;
            snacksTotal += snacksCandy * priceCandy;

            int ticketsNumber = ticketsAdult + ticketsChild + ticketsSenior;

            int discountPosibility = Math.Min(snacksPopcorn, snacksLargeSoda);
            int discount1 = Math.Min(discountPosibility, ticketsNumber) * 2;

            double discount2 = 0;
            if (ticketsNumber >= 3 && showtimeEvening == true && snacksPopcorn >= 1)
            {
                discount2 = 4.50;
            }

            double discount3 = 0;
            if (snacksCandy >= 3)
            {
                discount3 = (snacksCandy / 4) * 1.99;
            }

            double discountTotal = discount1 + discount2 + discount3;

            double finalTotal = ticketsTotal + snacksTotal - discountTotal;

            System.Console.WriteLine("Tickets: $ " + ticketsTotal + " Snacks: $ " + snacksTotal + " Discounts: " + discountTotal);

            System.Console.WriteLine("The total for your night at the movies is: $" + finalTotal);
            System.Console.WriteLine("Press any key to end");
            System.Console.ReadKey();

        }
    }
}
