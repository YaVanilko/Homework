using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_student
{
   public static  class Loops
    {
        public static void Temperature()
        {
            Console.WriteLine("\n***** Temperature*****");

            double GradF;

            for (int GradC = 0; GradC <= 100; GradC+= 5)
            {
                GradF = 1.8 * GradC + 32;
                Console.WriteLine("Grad Celsia {0}, grad Faringeith {1}", GradC, GradF);
            }
        }


        //бегун

        public static void Sprinter()
        {
            Console.WriteLine("\n*****Sprinter*****");
            int day = 0;
            double km = 10;
            double allKm = 0;
            int dayKm = 0;
            int dayFKm = 0;


            for (day = 1; day <= 7; day++)
            {

                if (km > 15 && dayKm == 0)
                {
                    dayKm = day;
                }
                allKm += km;
                if (allKm > 50 && dayFKm == 0)
                {
                    dayFKm = day;
                }


                km *= 1.1;

            }
            Console.WriteLine("15 km Sprinter had run on {0} day", dayKm);
            Console.WriteLine("All way of sprinter is {0}", allKm);
            Console.WriteLine("Sprinter had run summ 50 km on {0} day", dayFKm);
        }

         //пловец
        public static void Swimmer()
        {
            Console.WriteLine("\n*****Swimmer*****");
            int day = 0;
            double km = 3;
            double allKm = 0;
            int dayKm = 0;
            int dayFKm = 0;
            int m = 1;


            for (day = 1; day <= m; day++)
            {

                //Console.WriteLine("Day {0}, {1} km", day, km);
                if (km > 5 && dayKm == 0)
                {
                    dayKm = day;
                }
                else { m++; }

                allKm += km;

                if (allKm > 30 && dayFKm == 0)
                {
                    dayFKm = day;
                    m=day;
                }
                else { m++; }


                km *=1.1;

            }
            Console.WriteLine("5 km Swimmer had run on {0} day", dayKm);
            Console.WriteLine("Swimmer had run summ 30 km on {0} day", dayFKm);

        }

        public static void PrimeDigit()
        {
            int dig;
            Console.WriteLine("\n*****Prime Digit*****");
            Console.WriteLine("Enter number");
            while (!Int32.TryParse(Console.ReadLine(), out dig))
            { Console.WriteLine("You enter not number. Please, enter number"); }
            double half = dig / 2;
            for (int i = 2; i <= half; i++)
            {
                if (dig % i == 0)
                {
                    Console.WriteLine("{0} is not prime", dig);
                    return;
                }

                else 
                {
                    Console.WriteLine("Its prime digit");
                }
            }

        }

        public static void GeeseRabbit()
        {
            const int feet = 64;
            int rabbit;
            Console.WriteLine("\n*****Geese, rabbits and feet*****");
            for(int geese = 0; geese<=feet/2; geese++)
            {

                if ((feet - geese * 2) % 4 == 0)
                {
                    rabbit = (feet - geese * 2) /4;
                    Console.WriteLine("There are {0} rabbits and {1} guses", rabbit, geese);
                }
            }

        }

        public static void Minimum()
        {
            Console.WriteLine("\n*****Minimum*****");
            int current;
            int min=0;
            Console.WriteLine("Enter number");
            while (!Int32.TryParse(Console.ReadLine(), out current))
            { Console.WriteLine("You enter not number. Please, enter number"); }

            while (current != 0)
            {
                
                    min = current;
                    Console.WriteLine("Enter next number");
                    while (!Int32.TryParse(Console.ReadLine(), out current))
                    { Console.WriteLine("You enter not number. Please, enter number"); }
                 if (current != 0)
                 {
                    if (min > current)
                    {
                        min = current;
                    }
                }

                else
                {
                    Console.WriteLine("Minimum is {0}", min);
                }
            }
        }

        public static void Ameba()
        {
            Console.WriteLine("\n*****Ameba*****");
            int amebaCount = 1;
            for (int hours = 3; hours <= 24; hours=hours + 3)
            {
                amebaCount = amebaCount * 2;
                Console.WriteLine("There are {0} amebas in {1} hours", amebaCount, hours);
            }

        }

        //public static void PrimeFromTo()
        //{
        //    Console.WriteLine("\n*****Prime number from 2 to N*****");
        //    int n;
        //    int p;
        //    while (!Int32.TryParse(Console.ReadLine(), out n))
        //    { Console.WriteLine("You enter not number. Please, enter number"); }
        //    List<int> SimpleNumber = new List<int>();
        //    for (int i = 2; i <= n; i++)
        //    {
        //        SimpleNumber.Add(i);
        //    }

        //    p = 2;
        //    while (p < n)
        //    {
        //        for (int j = 2; j < n / p; j++)
        //        {
        //            SimpleNumber.Remove(p * j);

        //           // p = SimpleNumber[j];
        //        }
        //    }


        //}

        public static void ABCD()
        {
            int A;
            int B;
            int C;
            int D;
            Console.WriteLine("\n*****Numbers A, B, C, D*****");
            Console.WriteLine("Enter number A");
            while (!Int32.TryParse(Console.ReadLine(), out A))
            { Console.WriteLine("You enter not number. Please, enter number"); }

            Console.WriteLine("Enter number B");
            while (!Int32.TryParse(Console.ReadLine(), out B))
            { Console.WriteLine("You enter not number. Please, enter number"); }

            Console.WriteLine("Enter number C");
            while (!Int32.TryParse(Console.ReadLine(), out C))
            { Console.WriteLine("You enter not number. Please, enter number"); }

            Console.WriteLine("Enter number D");
            while (!Int32.TryParse(Console.ReadLine(), out D))
            { Console.WriteLine("You enter not number. Please, enter number"); }

            if ((A % 2 == 0 && B % 2 == 0) || (A % 2 == 0 && C % 2 == 0) || (A % 2 == 0 && D % 2 == 0) || (B % 2 == 0 && C % 2 == 0) || (B % 2 == 0 && D % 2 == 0) || (C % 2 == 0 && D % 2 == 0))
            {
                Console.WriteLine("There are a couple of numbers");
            }

            else 
            {
                Console.WriteLine("There aren't couple numbers");
            }


        }

        public static void Year()
        {
            int year;
            Console.WriteLine("\n***** Leap-year*****");
            Console.WriteLine("Enter year");
            while (!Int32.TryParse(Console.ReadLine(), out year)||(year<0 && year>3000))
            { Console.WriteLine("You enter not year. Please, enter year"); }

            if (year % 4 == 0 && (year % 100 != 0 || year % 400==0))
            {
                Console.WriteLine("Its leap-year");
            }

            else
            {
                Console.WriteLine("It's not leap-year");
            }
        }

        public static void SummOfNumber()
        {
            int number;
            Console.WriteLine("\n***** Number*****");
            Console.WriteLine("Enter number");
            while (!Int32.TryParse(Console.ReadLine(), out number) )
            { Console.WriteLine("You enter not number. Please, enter number"); }

            int[] numb = new int[4];
            int summ=0;
            numb[0] = number / 1000;
            
            numb[1] = (number-numb[0]*1000) /100;
            numb[2] = (number - numb[0] * 1000 - numb[1] * 100) / 10;
            numb[3] = number - numb[0] * 1000 - numb[1] * 100 - numb[2] * 10;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}", numb[i]);
                summ=summ+numb[i];
                
            }

            Console.WriteLine("\n{0}",summ);

        }

        public static void WeekDay()
        {
            int day;
            Console.WriteLine("\n***** Day of week*****");
            Console.WriteLine("Enter number of day");
            while (!Int32.TryParse(Console.ReadLine(), out day)||(day<1&&day>7))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            if (day == 1)
            {
                Console.WriteLine("Monday");
            }

            else if (day == 2)
            {
                Console.WriteLine("Thurthday");
            }

            else if (day ==3)
            {
                Console.WriteLine("Wednesday");
            }

            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }

            else if (day == 5)
            {
                Console.WriteLine("Friday");
            }

            else if (day == 6)
            {
                Console.WriteLine("Saturday");
            }

            else if (day == 7)
            {
                Console.WriteLine("Sunday");
            }
        }

        public static void Taxi()
        {
            int km;
            int min;
            int summa;
            Console.WriteLine("\n***** Taxi*****");
            Console.WriteLine("Enter way km");
            while (!Int32.TryParse(Console.ReadLine(), out km) )
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            Console.WriteLine("Enter minutes");
            while (!Int32.TryParse(Console.ReadLine(), out min))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            if (km > 5)
            {
                summa = 20 + (km - 5)*3+min;
            }

            else 
            {
                summa = 20+min;
            }

            Console.WriteLine("You must pay {0} uah", summa);
        }

        public static void Game()
        {
            int rate;
            Console.WriteLine("\n***** Game*****");
            Console.WriteLine("Enter your rate");
            while (!Int32.TryParse(Console.ReadLine(), out rate))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            Random rd = new Random();
            int dice1=rd.Next(1,12);
            int dice2=rd.Next(1,12);

            if ((dice1 % 3 == 0 && dice2 % 5 == 0) || (dice2 % 3 == 0 && dice1 % 5 == 0))
            {
                Console.WriteLine("You win {0}", 5*rate);
            }

            if(dice1%2==0&&dice2%2==0)
            {
                Console.WriteLine("You win {0}", 2 * rate);
            }


            if ((dice1 % 2 == 0 && dice2 == 12) || (dice2 % 2 == 0 && dice1 == 12))
            {
                Console.WriteLine("You win {0}", 10 * rate);
            }

            if ((dice1 == 1 && dice2 == 12) || (dice2 == 1 && dice1 == 12) || (dice1 == 6 && dice2 == 6))
            {
                Console.WriteLine("You win {0}", 50 * rate);
            }

            else 
            {
                Console.WriteLine("You lose");
            }
        }

        public static void Triangle()
        {
            double side1;
            double side2;
            double side3;
            Console.WriteLine("\n***** Triangle*****");
            Console.WriteLine("Enter first side");
            while (!Double.TryParse(Console.ReadLine(), out side1))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            Console.WriteLine("Enter second side");
            while (!Double.TryParse(Console.ReadLine(), out side2))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            Console.WriteLine("Enter therd side");
            while (!Double.TryParse(Console.ReadLine(), out side3))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            if ((Math.Abs(side3 - Math.Sqrt(side1 * side1 + side2 * side2)) < 0.01) || (Math.Abs(side2 - Math.Sqrt(side1 * side1 + side3 * side3)) < 0.01) || (Math.Abs(side1 - Math.Sqrt(side3 * side3 + side2 * side2)) < 0.01))
            {
                Console.WriteLine("Its rectangular triangle");
            }

            else
            {
                Console.WriteLine("Its not rectangular triangle");
            }
        }



        public static void Square()
        {
            int numb;
            int i=1;
            Console.WriteLine("\n***** Square*****");
            Console.WriteLine("Enter number");
            while (!Int32.TryParse(Console.ReadLine(), out numb))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }

            while (numb >= i * i)
            {
                Console.WriteLine("{0}", i*i);
                i++;
            }

        }


    }
}
