using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_student
{
   static class register_students
    {

        static void Main(string[] args)
        {
            
            ushort[] data = { 0x36D7, 0x36D6, 0x26E0, 0x40CE, 0x5D38 ,0x7D8E, 0x41CC, 0x660E, 0x239E, 0x21F8};
            int[] allSensors = { 1, 2, 3 };//предполагаем, что сенсоров 3.
            Sensor.ParsingData(data, allSensors.Length);
 
            Console.ReadKey(true);
        }
            //меню для циклов
            ////Type type=typeof(Loops);

            ////System.Reflection.MethodInfo[] methods = type.GetMethods();

            ////for (int index = 0; index < methods.Length; index++)
            ////{
            ////    if (methods[index].IsStatic && methods[index].IsPublic)
            ////    {
            ////        Console.WriteLine("[{0}] " + methods[index], index);
            ////    }
            ////}

            ////int methodNumber;
            ////Console.WriteLine("Enter number of mrthod");
            ////while (!Int32.TryParse(Console.ReadLine(), out methodNumber)|| (methodNumber<0||methodNumber>methods.Length))
            ////{ Console.WriteLine("You enter not correct number. Please, enter number"); }

            ////methods[methodNumber].Invoke(null,null);

                //foreach(var method in type.GetMethods())
                //{
                //    if(method.IsPublic && method.IsStatic)
                //    {
                //        //method.Invoke(null, null);
                //        Console.WriteLine(method);
                //    }
                //}


                //Loops.Temperature();

                //Loops.Swimmer();



                //Loops.PrimeDigit();

                //Loops.GeeseRabbit();

                //Loops.Minimum();

                //Loops.Ameba();

                ////Loops.PrimeFromTo();

                //Loops.ABCD();

                //Loops.Year();

                //Loops.SummOfNumber();

                //Loops.WeekDay();

                //Loops.Taxi();

                //Loops.Game();

                //Loops.Triangle();

                // Loops.Square();
               // Console.ReadKey(true);

            //данные о студентах
            //int counter;
            //string firstName;
            //string middleName;
            //string lastName;
            //int berthYear;
            //int berthMonth;
            //int berthDay;
            //string fullName;
            //int age;
            //Student st;

            //try
            //{
            //    Console.WriteLine("Enter count of student");
            //    while (!Int32.TryParse(Console.ReadLine(), out counter))
            //    { Console.WriteLine("You enter not number. Please, enter number"); }


            //    Student[] group = new Student[counter];
            //    for (int i = 0; i < counter; i++)
            //    {
            //        Console.WriteLine("Enter ferst name of student");
            //        firstName = Console.ReadLine();
            //        Console.WriteLine("Enter middle name of student");
            //        middleName = Console.ReadLine();
            //        Console.WriteLine("Enter last name of student");
            //        lastName = Console.ReadLine();

            //        Console.WriteLine("Enter berth day of student");
            //        while (!Int32.TryParse(Console.ReadLine(), out berthDay))
            //        { Console.WriteLine("You enter not number."); }
            //        while (berthDay > 31 || berthDay < 1)
            //        {
            //            Console.WriteLine("It's not day of month. Enter Berth day");
            //            while (!Int32.TryParse(Console.ReadLine(), out berthDay))
            //            { Console.WriteLine("You enter not number. Enter Berth day"); }
            //        }

            //        Console.WriteLine("Enter berth month of student");
            //        while (!Int32.TryParse(Console.ReadLine(), out berthMonth))
            //        { Console.WriteLine("You enter not number."); }
            //        while (berthMonth > 12 || berthMonth < 1)
            //        {
            //            Console.WriteLine("It's not correct month. Enter month");
            //            while (!Int32.TryParse(Console.ReadLine(), out berthMonth))
            //            { Console.WriteLine("You enter not number. Enter month"); }
            //        }
            //        Console.WriteLine("Enter berth year of student");
            //        while (!Int32.TryParse(Console.ReadLine(), out berthYear))
            //        { Console.WriteLine("You enter not number."); }
            //        while (berthYear > (Convert.ToInt32(DateTime.Now.Year) - 10) || berthYear < (Convert.ToInt32(DateTime.Now.Year) - 100))
            //        {
            //            Console.WriteLine("It's not correct year. Enter year");
            //            while (!Int32.TryParse(Console.ReadLine(), out berthYear))
            //            { Console.WriteLine("You enter not number. Enter Berth year"); }
            //        }

            //        st = new Student(firstName, lastName, middleName, berthYear, berthMonth, berthDay);
            //        group[i] = st;



            //    }

            //    for (int j = 0; j < counter; j++)
            //    {
            //        st = group[j];
            //        fullName = st.GetFullName(group[j]);
            //        age = st.GetAgeYears(group[j]);
            //        Console.WriteLine("Stuudent {0} called {1}. He is {2}", j + 1, fullName, age);


            //    }

            //    Console.ReadKey(true);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("{0}", ex);
            //    Console.ReadKey(true);
            //}

       // }
    }
}
