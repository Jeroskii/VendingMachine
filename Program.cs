using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vendymachines_2
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine(" ░░░░░▄▄▀▀▀▀▀▀▀▀▀▄▄░░░░░");
            Console.WriteLine(" ░░░░█░░░░░░░░░░░░░█░░░░");
            Console.WriteLine(" ░░░█░░░░░░░░░░▄▄▄░░█░░░");
            Console.WriteLine(" ░░░█░░▄▄▄░░▄░░███░░█░░░");
            Console.WriteLine(" ░░░▄█░▄░░░▀▀▀░░░▄░█▄░░░");
            Console.WriteLine(" ░░░█░░▀█▀█▀█▀█▀█▀░░█░░░");
            Console.WriteLine(" ░░░▄██▄▄▀▀▀▀▀▀▀▄▄██▄░░░");
            Console.WriteLine(" ░▄█░█▀▀█▀▀▀█▀▀▀█▀▀█░█▄░");

            Console.WriteLine(" █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine(" █░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Console.WriteLine(" █░░║║║╠─║─║─║║║║║╠─░░█");
            Console.WriteLine(" █░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Console.WriteLine(" █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            First();
            Console.ReadLine();

        }
        public static void First()
        {
            int user;
            Console.WriteLine("Welcome to Jester's Vending Machine");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Snacks");
            Console.WriteLine("2. Drinks");                            //this the code for the menu
            Console.WriteLine("3. Exit");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Please select your choice.");
            Console.WriteLine("Press the number");
            user = Convert.ToInt32(Console.ReadLine());

            switch (user)
            {
                case 1:
                    Snack();
                    break;
                case 2:
                    Drinks();                     //i used switch to make it simple and clean, compare to using other methods
                    break;
                case 3:
                    exit();
                    break;
            }
            


        }
        public static void Snack()
        {
            int user2;
            float money = 0, cost = 0, change;
            int LaysFornoBlackPepper = 2, Quavers = 1, Combos  = 5, QuinoaChips = 14, DoritosNachos = 5;

            Console.WriteLine("Welcome to Jester's Vending Machine");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Items that are available:");
            Console.WriteLine("1. Lays Forno Black Pepper - 2 AED");
            Console.WriteLine("2. Quavers - 1 AED");
            Console.WriteLine("3. Combos - 5 AED");              //i used the same design on the menu design because it looks clean and doesnt look complicated
            Console.WriteLine("4. Quinoa Chips - 14 AED");
            Console.WriteLine("5. Doritos Nachos - 5 AED");


            Console.WriteLine("\n6. Go Back?\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Please select your choice.");
            Console.WriteLine("Press the number");
            user2 = Convert.ToInt32(Console.ReadLine());



            switch (user2)
            {
                case 1:
                    Console.WriteLine("You Have Selected Lays Forno Black Pepper");

                    Console.WriteLine("\n Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - LaysFornoBlackPepper;
                    break;
                case 2:
                    Console.WriteLine("You Have Selected Quavers");

                    Console.WriteLine("\n Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - Quavers;
                    break;
                case 3:
                    Console.WriteLine("You Have Selected Combos");

                    Console.WriteLine("\n Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - Combos;
                    break;
                case 4:
                    Console.WriteLine("You Have Selected Quinoa Chips");

                    Console.WriteLine("\n Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - QuinoaChips;
                    break;
                case 5:
                    Console.WriteLine("You Have Selected Doritos Nachos");

                    Console.WriteLine("\n Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - DoritosNachos;
                    break;

                case 6:
                    Console.WriteLine("Go Back?");
                    First();
                    break;

                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }
            if (money >= cost)
            {
                Console.WriteLine("Transaction Succeed");
                change = money - cost;
                Console.WriteLine("Please Collect {0} AED and Snack. \n     Enjoy", change);
            }
            else
            {
                Console.WriteLine("Not Enough Money, Please Enter More");

            }
            Console.WriteLine("Press Y to Continue N to Exit");
            char user4;
            user4 = Convert.ToChar(Console.ReadLine());


            switch (user4)
            {
                case 'Y':
                    First();
                    break;
                case 'N':
                    exit();
                    break;

            }
        }

        public static void exit()
        {
            Console.WriteLine("Thank you for using Jester's Vending Machine");  //code for terminating the cmd
            Console.WriteLine("Have a Nice Day :)");
            Console.ReadLine();
        }
        public static void Drinks()
        {
            int user3;
            float money = 0, cost = 0, change;
            int AppleJuice = 3, MasafiWater = 1, HotChocolate = 2, Cappucino = 2, Frappucino = 1;


            Console.WriteLine("Welcome to Jester's Vending Machine");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("1. Apple Juice - 3 AED");
            Console.WriteLine("2. Masafi Water - 1 AED");
            Console.WriteLine("3. Hot Chocolate - 2 AED");      //i used another function similar to the other one for cleaner look again but this is for drinks the codes below are for drinks also.
            Console.WriteLine("4. Cappucino - 2 AED");
            Console.WriteLine("5. Frappucino - 1 AED");

            Console.WriteLine("\n6. Go Back?\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Please select your choice.");
            Console.WriteLine("Press the number");

            user3 = Convert.ToInt32(Console.ReadLine());

            switch (user3)
            {
                case 1:
                    Console.WriteLine("You Have Selected Apple Juice");

                    Console.WriteLine("Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - AppleJuice;
                    break;
                case 2:
                    Console.WriteLine("You Have Selected Masafi Water");

                    Console.WriteLine("Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - MasafiWater;
                    break;

                case 3:
                    Console.WriteLine("You Have Selected Hot Chocolate");

                    Console.WriteLine("Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - HotChocolate;
                    break;
                case 4:
                    Console.WriteLine("You Have Selected Cappucino");

                    Console.WriteLine("Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - Cappucino;
                    break;
                case 5:
                    Console.WriteLine("You Have Selected Frappucino");

                    Console.WriteLine("Input Money");
                    Console.WriteLine("---------------------------------------");

                    money = Convert.ToSingle(Console.ReadLine());
                    money = money - Frappucino;
                    break;
                case 6:
                    Console.WriteLine("Go Back?");
                    First();
                    break;

                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }

            if (money >= cost)
            {
                Console.WriteLine("Transaction Succeed");
                change = money - cost;
                Console.WriteLine("Please Collect {0} AED and Snack.     Enjoy   ", change);
            }
            else               //this set of codes are for the transaction whether you completed it or you dont have enough money
            {
                Console.WriteLine("Not Enough Money, Please Enter More");

            }
            Console.WriteLine("Press Y to Continue N to Exit"); //this execute when the transacion is completed

            char user4;
            user4 = Convert.ToChar(Console.ReadLine());
            switch (user4)
            {
                case 'Y':
                case 'y':
                    First();     //another switch to bring the question above alive
                    break;
                case 'N':
                case 'n':
                    exit();
                    break;

            }
        }
    }
}


