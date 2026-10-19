namespace TeacherSystem;

public class Teacher
{
    private string name;
    private string subject;
    private int yearsOfExperience;

    public static int Count = 0;

    public string Name
    {
        get { return name; }
        set
        {
            if (value != "")
            {
                name = value;
            }
            else
            {
                name = "Unknown";
            }
        }
    }

    public string Subject
    {
        get { return subject; }
        set
        {
            if (value != "")
            {
                subject = value;
            }
            else
            {
                subject = "General";
            }
        }
    }

    public int YearsOfExperience
    {
        get { return yearsOfExperience; }
        set
        {
            if (value >= 0)
            {
                yearsOfExperience = value;
            }
            else
            {
                yearsOfExperience = 0;
            }
        }
    }

    public Teacher(string name, string subject, int yearsOfExperience)
    {
        Name = name;
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
        Count++;
    }

    public void ShowProfile()
    {
        Console.WriteLine("Name: " + Name + ", Subject: " + Subject + ", Experience: " + YearsOfExperience + " years");
    }
}