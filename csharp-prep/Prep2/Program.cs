using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Prince Eli's Grade Calculator.");

        Console.Write("What is your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int userGrade = int.Parse(gradePercentage);

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            letter = "B";
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            letter = "C";
        }
        else if (userGrade >= 60 && userGrade <70)
        {
            letter = "D";
        }
        else if (userGrade < 60)
        {
            letter = "F";
        }


        string message = "";

        if (userGrade >= 70)
        {
            message = "Congratulations! You passed the course.";
        }
        else if (userGrade < 70)
        {
            message = "Sorry. You did not pass the course. You can take the course again.";
        }

        Console.WriteLine($"Grade: {letter}. {message}");
    }
}