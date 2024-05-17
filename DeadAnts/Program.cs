using System;
public class Kata
{
    public static int DeadAntCount(string ants)
    {
        if (ants == null)
        {
            return 0;
        }
        string notComplete = ants.Replace("ant", "");
        int a = 0, n = 0, t = 0;
        foreach (char car in notComplete)
        {
            if (car == 'a')
            {
                a++;
            }
            else if (car == 'n')
            {
                n++;
            }
            else if (car == 't')
            {
                t++;
            }

        }

        return Math.Max(Math.Max(a, n), t);
    }
    public static void Main()
    {
        string deadAnts = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
        int muertas = DeadAntCount(deadAnts);

        Console.WriteLine("Muertas: " + muertas);
    }

}