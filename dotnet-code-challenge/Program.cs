using dotnet_code_challenge.Domain.Interfaces.Controller;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Presentation;
using System;
using System.Collections.Generic;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IRaceController raceController = new RaceController();

            List<HorseNames> horses = raceController.GetHorseNamesInPriceAscending();

            Console.WriteLine("Horse list names in ascending order of price.");

            horses.ForEach(name =>
            {
                Console.WriteLine(name.Names);
            });
            Console.ReadLine();
        }
    }
}
