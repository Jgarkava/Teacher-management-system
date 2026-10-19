namespace TeacherSystem;

class Program
{
    static void Main(string[] args)
    {
        List<Teacher> teachers = new List<Teacher>();

        teachers.Add(new Teacher("Alan Turing", "Computer Science", 15));
        teachers.Add(new Teacher("Margaret Hamilton", "Software Engineering", 12));

        bool run = true;

        while (run)
        {
            Console.WriteLine();
            Console.WriteLine("--- Teacher Menu ---");
            Console.WriteLine("1. add teacher");
            Console.WriteLine("2. Show teachers");
            Console.WriteLine("3. Show total count");
            Console.WriteLine("4. Show average experience");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            string option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Subject: ");
                string subject = Console.ReadLine();

                Console.Write("Enter Experience: ");
                int exp = Convert.ToInt32(Console.ReadLine());

                Teacher t = new Teacher(name, subject, exp);
                teachers.Add(t);
                Console.WriteLine("Teacher added.");
            }
            else if (option == "2")
            {
                foreach (Teacher t in teachers)
                {
                    t.ShowProfile();
                }
            }
            else if (option == "3")
            {
                Console.WriteLine("Total teachers: " + Teacher.Count);
            }
            else if (option == "4")
            {
                if (teachers.Count > 0)
                {
                    double sum = 0;
                    foreach (Teacher t in teachers)
                    {
                        sum += t.YearsOfExperience;
                    }
                    double avg = sum / teachers.Count;
                    Console.WriteLine("Avarage experience: " + avg + " years");
                }
                else
                {
                    Console.WriteLine("there are not any teachers in the list.");
                }
            }
            else if (option == "5")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("There is no such option.");
            }
        }
    }
}