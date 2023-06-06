// See https://aka.ms/new-console-template for more information

namespace  C__Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            int winNumber = r.Next(0, 100);
            
            bool win = false;
            do
            {
                Console.WriteLine("Enter a number to guess!");
                string s = Console.ReadLine()!;
                if (!int.TryParse(s, out int intResult))
                {
                    Console.WriteLine("You did not specify an integer");
                    continue;
                    
                }
                int number = int.Parse(s);

                string result = (number > winNumber) ? "The number guessed is too high try something lower!" : (number < winNumber) ? "The number is too low guess higher!" : "You guessed correctly!";
                if(number == winNumber)
                {
                    win = true;
                }
                Console.WriteLine(result);
                
            } while (win == false);
           
            Console.ReadLine();
        }
        
        
    }
}

