using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Gün sayısı:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
            Console.WriteLine("Pazartesi");
            break;

            case 2:
            Console.WriteLine("Salı");
            break;

            case 3:
            Console.WriteLine("Çarşamba");
            break;

            case 4:
            Console.WriteLine("Perşembe");
            break;
        }
    }
    }