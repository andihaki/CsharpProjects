namespace TestProject.Challenge;

class StudentsGrade
{
    static string ScoreToGrade(decimal score)
    {
        if (score >= 97) return "A+";
        else if (score >= 93) return "A";
        else if (score >= 90) return "A-";
        else if (score >= 87) return "B+";
        else if (score >= 83) return "B";
        else if (score >= 80) return "B-";
        else if (score >= 77) return "C+";
        else if (score >= 73) return "C";
        else if (score >= 70) return "C-";
        else if (score >= 67) return "D+";
        else if (score >= 63) return "D";
        else if (score >= 60) return "D-";
        else return "F";
    }

    public static void Run()
    {
        // initialize variables - graded assignments 
        int currentAssignments = 5;

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };


        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        decimal sophiaScore;
        decimal andrewScore;
        decimal emmaScore;
        decimal loganScore;

        int sophiaSum = 0;
        int andrewSum = 0;
        int emmaSum = 0;
        int loganSum = 0;

        for (int i = 0; i < currentAssignments; i++)
        {
            sophiaSum += sophiaScores[i];
            andrewSum += andrewScores[i];
            emmaSum += emmaScores[i];
            loganSum += loganScores[i];
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;
        andrewScore = (decimal)andrewSum / currentAssignments;
        emmaScore = (decimal)emmaSum / currentAssignments;
        loganScore = (decimal)loganSum / currentAssignments;



        Console.WriteLine("Student\t\tGrade\n");
        foreach (string name in studentNames)
        {
            if (name == "Sophia")
            {
                Console.WriteLine($"{name}:\t\t" + sophiaScore + $"\t{ScoreToGrade(sophiaScore)}");
            }
            else if (name == "Andrew")
            {
                Console.WriteLine($"{name}:\t\t" + andrewScore + $"\t{ScoreToGrade(andrewScore)}");
            }
            else if (name == "Emma")
            {
                Console.WriteLine($"{name}:\t\t" + emmaScore + $"\t{ScoreToGrade(emmaScore)}");
            }
            else if (name == "Logan")
            {
                Console.WriteLine($"{name}:\t\t" + loganScore + $"\t{ScoreToGrade(loganScore)}");
            }
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

    }

    // convert the message into a char array



}
