using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
            int Stamina;
            float Health;
            string Yelling;
            bool StoveIsOn;
            char Input;
            double Time;

        //int Multiply(int a, int b)
        //{
        //    int result = a * b;
        //    return result;
        //}

        float SmallerNumber(float a, float b)
        {
            if (a > b)
            {
                return b;
            }
                return a;

        }


        void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }   
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Run()
        {


            FizzBuzz(78);




            //Console.WriteLine(SmallerNumber(235f, 235f));



            //Console.WriteLine(Multiply(7, 2));



            //string choice = "";
            //while (choice != "1" || choice != "2" || choice != "3" || choice != "4")
            //{
            //    Console.Clear();
            //    Console.WriteLine("Select character");
            //    Console.WriteLine("1: assassin");
            //    Console.WriteLine("2: enforcer");
            //    Console.WriteLine("3: wizard");
            //    Console.WriteLine("4: gaurdian \n");
            //    choice = Console.ReadLine();
            //    if (choice == "1")
            //    {
            //        Console.WriteLine("You are now a assassin");

            //    }
            //    else if (choice == "2")
            //    {
            //        Console.WriteLine("You are now a enforcer");
            //    }
            //    else if (choice == "3")
            //    {
            //        Console.WriteLine("You are now a wizard");

            //    }
            //    else if (choice == "4")
            //    {
            //        Console.WriteLine("You are now a gaurdian");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input Please try again");
            //        Console.ReadKey(true);
            //    }
            //}

            //for (string choice = ""; choice == "1" || choice == "2" || choice == "3" || choice == "4"; Console.WriteLine("Invalid Input Please try again"), Console.ReadKey(true))
            //{
            //    Console.Clear();
            //    Console.WriteLine("Select character");
            //    Console.WriteLine("1: assassin");
            //    Console.WriteLine("2: enforcer");
            //    Console.WriteLine("3: wizard");
            //    Console.WriteLine("4: gaurdian \n");
            //    choice = Console.ReadLine();
            //    if (choice == "1")
            //    {
            //        Console.WriteLine("You are now a assassin");

            //    }
            //    else if (choice == "2")
            //    {
            //        Console.WriteLine("You are now a enforcer");
            //    }
            //    else if (choice == "3")
            //    {
            //        Console.WriteLine("You are now a wizard");

            //    }
            //    else if (choice == "4")
            //    {
            //        Console.WriteLine("You are now a gaurdian");

            //    }

            //}





            //int num = 1;
            //while (num <= 10)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}

            //these two do the same exact thing

            //for (int num = 0; num<= 10; num+=2)
            //{
            //    Console.WriteLine(num);
            //}



            //int playerHealth = 1;
            //bool gameOver = true;
            //if (playerHealth <= 0 || gameOver)
            //{
            //    Console.WriteLine("it's all over");
            //}



            //Console.WriteLine("breakfast");
            //string breakfast = Console.ReadLine();
            //if (breakfast == "toast" )
            //{
            //    Console.WriteLine("egg");
            //}
            //else if (breakfast == "pancake")
            //{
            //    Console.WriteLine("bacon");
            //}
            //else
            //{
            //    Console.WriteLine("Then STARVE");
            //}    
            //Console.WriteLine("input first name");
            //string FirstName = Console.ReadLine();



            //Console.WriteLine("input second name");
            //string SecondName = Console.ReadLine();

            //Console.WriteLine("Your name is "+ FirstName+" "+ SecondName);

            //int num1 = 2;
            //int num2 = 3;


            //Console.WriteLine("number 1 is "+num1);
            //Console.WriteLine("number 2 is " + num2);

            //num1 = 3;
            //num2 = 2;

            //Console.WriteLine("number 1 is "+num1);
            //Console.WriteLine("number 2 is " + num2);

            //int SwapNumbers(int FirstNum, int Second)
            //{

            //}
        }
    }
}
