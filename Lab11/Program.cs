using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Frank","1111 Road");
            Student student1 = new Student("Tim", "1234 Drive", "Business", 3, 20000);
            Staff staff1 = new Staff("John", "4444 Ave.", "WAYNE State", 35000);

            List <Person> SchoolList = new List<Person>();
            SchoolList.Add(person1);
            SchoolList.Add(student1);
            SchoolList.Add(staff1);

            for(int i = 0; i < SchoolList.Count; i++)
            {
                Console.WriteLine(SchoolList[i].ToString());
                Console.WriteLine();
            }

        }
    }
}
