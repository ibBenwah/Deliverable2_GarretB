// See https://aka.ms/new-console-template for more information
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        double eating = 9.99;
        int eatingTotal = Convert.ToInt32(eating);
        double coffee = 2.00;
        int coffeeTotal = Convert.ToInt32(coffee);
        double water = 0.00;
        int waterTotal = Convert.ToInt32(water);
        double waterCount = 0;
        int coffeeCount = 0;



        //Greating
        Console.Write("Hello, Welcome to our Buffet. All you can eat for $" + eating + " ! We only charge extra for coffee. How many people are in your party? Please, parties of 6 or fewer. ");
        string userInput = Console.ReadLine();

        if (Int32.Parse(userInput) <= 6)
        {
            Console.WriteLine("party of " + Int32.Parse(userInput) + "! Please follow me and take a seat.");
            Console.WriteLine("Let's get everyone started with some drinks. We have coffee and water.");
            Console.WriteLine("");
            // Need to create array 
            string[] person = { "Person 1", "Person 2", "Person 3", "Person 4", "Person 5", "Person 6" };

            for (int i = 0; i < Int32.Parse(userInput); i++)
            {
                Console.Write(person[i] + " what would you like? coffee or water? ");
                string order = Console.ReadLine().ToLower();

                if (order == "water" || order == "coffee")
                {
                    Console.WriteLine(order);
                    if (order == "water")
                    {
                        waterCount++;
                    }
                    else
                    {

                        coffeeCount++;
                    }

                }
                else
                {
                    Console.WriteLine("Sorry we dont have that");
                }
            }
            double total = (Int32.Parse(userInput) * eating) + (coffee * coffeeCount);



            string totalstring = ("you ordered ");
            if (waterCount == 1)
            {
                totalstring = totalstring + " " + waterCount + " water";

            }
            else
            {
                totalstring = totalstring + " " + waterCount + " waters";

            }

            if (coffeeCount == 1)
            {
                totalstring = totalstring + " " + coffeeCount + " coffee";

            }
            else
            {
                totalstring = totalstring + " " + coffeeCount + " Coffees";


            }
            if (Int32.Parse(userInput) == 1)
            {
                totalstring = totalstring + " " + Int32.Parse(userInput) + " dinner";

            }
            else
            {
                totalstring = totalstring + " " + Int32.Parse(userInput) + " dinners";
            }
            Console.WriteLine(totalstring + " your total is " + total);

            Console.WriteLine("Thank you and have a great day!");


        }
        else
        {

            Console.WriteLine("Sorry we only seat partes of 6 or fewer");
        }
    }
}

