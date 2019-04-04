using System;

namespace KinzOnnu_practice
{
    class Program
    {
        //1. what is the main method
        //2. variables
        //3. how variables change values
        //4. what you do with variables
        //5. inputs and outputs

        static void Main(string[] args) {
            int ticketPrice = 20;
            string watchAnother = "yes";

            while (watchAnother.ToLower() == "yes") {

                Console.WriteLine("What movie you wanna see: ");
                string movie = Console.ReadLine();

                if (movie.ToLower() == "john wick") {

                    Console.WriteLine("How many tickets?");
                    int tickets = Convert.ToInt32(Console.ReadLine());

                    int total = tickets * ticketPrice;

                    Console.WriteLine($"Yo total is ${total}, enjoy the movie!");
                }
                else {
                    Console.WriteLine("you wack");
                }

                Console.WriteLine("You wanna watch another movie?");
                watchAnother = Console.ReadLine();
            }

            Console.WriteLine("aight cool see ya!");
            Console.ReadLine();

        }

    }
}
