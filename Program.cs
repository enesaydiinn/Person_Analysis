using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            string surname;

            System.Console.Write("İsminiz:");
            name = Console.ReadLine();

            
            System.Console.Write("soyisminiz:");
            surname = Console.ReadLine();


            System.Console.Write("Birthday Year:");
            int YearOld=int.Parse(Console.ReadLine());
            System.Console.Write("Present Year:");
            int YearNew=int.Parse(Console.ReadLine());

            int age=YearNew-YearOld;
            System.Console.WriteLine("Your age:"+age);

            if(age<13){
                System.Console.WriteLine("You are child person.");
            }

            else if(age<40){
                System.Console.WriteLine("You are young person.");
            }

            else{
                System.Console.WriteLine("You are old person.");
            }

            System.Console.WriteLine("Do you curious whats your generation?");
            System.Console.WriteLine("Please select:1 is YES  0 is NO");
            int curious=int.Parse(Console.ReadLine());

            if(curious==1){
                if(YearOld>1995){
                System.Console.WriteLine("Your generation is Z");
                }
                else if(YearOld>1980){
                System.Console.WriteLine("Your generation is Y");
                }
                
                else if(YearOld>1960){
                System.Console.WriteLine("Your generation is X");
                }
            }
            else{
            System.Console.WriteLine("Thanks");
            }

            


                

            

        

        }
    }
}
