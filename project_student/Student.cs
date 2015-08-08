using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_student
{
    class Student
    {
        string firstName;
        string lastName;
        string middleName;
        int berthYear;
        int berthMonth;
        int berthDay;

        public int GetAgeYears(Student st)
        {
            int age;
            DateTime dtnow = DateTime.Now;
            DateTime dtbth = new DateTime(st.berthYear, st.berthMonth, st.berthDay);
            TimeSpan ts = dtnow - dtbth;
            age = Convert.ToInt32(ts.TotalDays) / 365;
            return age;
        }
        


        public string GetFullName(Student st)
        {
            string full_name = String.Format("{0,15} {1,15} {2,15}", st.firstName, st.middleName, st.lastName);
            return full_name;
        }

        public Student() { }
        public Student(string fn, string ln, string mn, int by, int bm, int bd)
        {
            firstName = fn;
            lastName = ln;
            middleName = mn;
            if (bd < 31 || bd > 1)
            { berthDay = bd; }

            if (bm < 12 || bm > 1)
            { berthMonth = bm; }

            //предположим, что студенту не может быть меньше 10 лет и больше 100
            if (by < (Convert.ToInt32(DateTime.Now.Year) - 10) || by > (Convert.ToInt32(DateTime.Now.Year) - 100))
            { berthYear = by; }


        }
    }
}
