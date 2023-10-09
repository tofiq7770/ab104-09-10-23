using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = CheckGraduation();
        }

        public void GetInfo()
        {
            Console.WriteLine($" {Name}");
            Console.WriteLine($" {Surname}");
            Console.WriteLine($" {Group}");
            Console.WriteLine($" {Point}");
            Console.WriteLine($"{IsGraduated}");
        }
        public string CheckGraduationStatus()
        {
            if (IsGraduated)
            {
                return ($"{Name} {Surname}  mezun olub.");

            }

            else
            {
                return($"{Name} {Surname} mezun olmayıb.");
            }

        }
        private bool CheckGraduation()
        {
            return Point > 65;
        }
        public string GraduationStatus()
        {
            if (IsGraduated)
            {
                return ($"{Name} {Surname}  mezun olub.");

            }

            else
            {
                return ($"{Name} {Surname} mezun olmayıb.");
            }

        }
        private bool Graduation()
        {
            return Point > 65;
        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Diplom NO.");
            }
            else if (Point >= 65 && Point < 80)
            {
                Console.WriteLine("Simple diplom.");
            }
            else if (Point >= 80 && Point < 90)
            {
                Console.WriteLine("Honor.");
            }
            else
            {
                Console.WriteLine("High Honor diplom.");
            }

        }
    }
}
