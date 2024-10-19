namespace Test_5
{
    internal class Program
    {


        public delegate bool IsEligibleforScholarship(Student std);
        public class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }
            public char SportsGrade { get; set; }
            public Student()
            {

            }

            public static string GetEligibleStudents(List<Student> studentsList, IsEligibleforScholarship isEligible)
            {

                string res = "";
                foreach (var i in studentsList)
                {
                    if (isEligible(i))
                    {
                        if (res == "")
                        {
                            res += i.Name;
                        }
                        else
                        {
                            res += "," + i.Name;
                        }
                    }
                }
                return res;
            }
        }
        public class Test
        {
            public static bool ScholarshipEligibility(Student std)
            {
                return std.Marks > 80 && std.SportsGrade == 'A';
            }

            static void Main(string[] args)
            {
                List<Student> lstStudents = new List<Student>();
                Student obj1 = new Student() { RollNo = 1, Name = "Raj", Marks = 75, SportsGrade = 'A' };
                Student obj2 = new Student() { RollNo = 2, Name = "Rahul", Marks = 82, SportsGrade = 'A' };
                Student obj3 = new Student() { RollNo = 3, Name = "Kiran", Marks = 89, SportsGrade = 'B' };
                Student obj4 = new Student() { RollNo = 4, Name = "Sunil", Marks = 86, SportsGrade = 'A' };

                lstStudents.Add(obj1);
                lstStudents.Add(obj2);
                lstStudents.Add(obj3);
                lstStudents.Add(obj4);

                IsEligibleforScholarship iseligible = new IsEligibleforScholarship(ScholarshipEligibility);
                var eligibleStudents = Student.GetEligibleStudents(lstStudents, iseligible);
                Console.WriteLine(eligibleStudents);



            }
        }
    }
}

