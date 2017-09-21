using System;

namespace monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool playing = true;
            Character Monster = new Character(100, 3,12);
            Character Player = new Character(120, 2, 10);
            System.Console.WriteLine("A monster Aproaches what do you do?");

            //game logic
            while(playing)
            {

                System.Console.WriteLine($"Monster Health: {Monster.getHealth()}");
                System.Console.WriteLine($"Player Health: {Player.getHealth()}");
                System.Console.WriteLine("1. Hit \n 2. Heal");
                string input = Console.ReadLine();
                Console.Clear();
                //validating and runing user input
                if(input == "1")
                {
                    Monster.takeHit(Player.Hit());
                }
                else if(input == "2")
                {
                    Player.Heal();
                }
                else 
                {
                    System.Console.WriteLine("He will kill you this is no game!!!");
                }
                Random rand = new Random();
                int MChoice = rand.Next(1,11);
                if(MChoice < 8)
                {
                    Player.takeHit(Monster.Hit());
                    System.Console.WriteLine("The Monster Swings out and Hits you!");
                }
                else 
                {
                    Monster.Heal();
                    System.Console.WriteLine(" The monster heals cuz why not");
                }
                if(Player.getHealth() <= 0){
                    System.Console.WriteLine("You DIE! Play again?");
                    System.Console.WriteLine("Y/N");
                    string choice = Console.ReadLine().ToUpper();
                    if(choice == "N")
                    {
                        System.Console.WriteLine("Coward");
                        playing = false;
                    }
                    else
                    {
                        System.Console.WriteLine("I will take that as a yes!");
                        Player.Reset();
                        Monster.Reset();
                    }
                }
            }


        }
    }
}
