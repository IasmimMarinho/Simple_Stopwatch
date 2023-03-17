using System;
using System.Threading;
//objetivo: fixar sobre loop e time
class Program
{
    static void Start(int time)
    {
        int CurrentTime = 0;

        //faz aplicação esperar 1 seg a cada iteração 
        while (CurrentTime != time)
        {
            Console.Clear();
            CurrentTime++;
            Console.WriteLine(CurrentTime);
            Thread.Sleep(1000);

        }
        Console.Clear();
        Console.WriteLine("Stopwatch finalizado...");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }
    static void Count(char type, int time)
    {
        //por padrão o valor é 1 (segundo)
        int multiplier = 1;
        if (type == 'm')
            multiplier = 60;

        PreStart(time * multiplier);

    }
    static void Menu()
    {
        Console.WriteLine("Até quanto deseja contar?");
        Console.WriteLine("Minutos => 1m = 1 minuto");
        Console.WriteLine("Segundos => 1s = 1 segundo");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("");

        string data = Console.ReadLine().ToLower();

        if (data.Length >= 2)
        {
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            if (type == 'm' || type == 's')
                Count(type, time);
            else Menu();

        }
        else
            if (data == "0")
            System.Environment.Exit(0);

        else Menu();

    }
    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go!");
        Thread.Sleep(1000);

        Start(time);
    }
    public static void Main(string[] args)
    {
        //inicia a aplicação
        Menu();
    }
}