using System;

namespace practice_assessment
{
    class Program
    {
        
            static void Main(string[] args) {
            
            int number;
               Console.WriteLine("hey there! Lets play a little guessing game. Guess the number between 0 and 25");
                
               for (number = 10; 1 < 10; number++)
               
                   if (number == 10)
                   
                    break;
                    else
                    if (number > 10)
                    Console.WriteLine("guess again");
                    else
                    if (number < 10 )
                    Console.WriteLine("guess again");
                   {
                   
                    number = int.Parse(Console.ReadLine());
                        if (number < 10) 
                      Console.WriteLine("Nope the number is higher than that"); 
                    else 
                        if (number > 10)
                        Console.WriteLine("Nope the number is less than that");
                    else
                        if (number == 10)
                        Console.WriteLine("correct");       
                   
                    Console.WriteLine(number);
                    
             }
         }
    }
}    

