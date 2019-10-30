using dotnet_code_challenge.Model.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotnet_code_challenge.Domain.Interfaces.Infrastructure;
using dotnet_code_challenge.Model.Soap;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Json;

namespace dotnet_code_challenge.Infrastructure
{
    public class RaceRepository : IRaceRepository
    {
        private static Race races;
        //TODO: Get the Full Path
        internal static readonly string jsonSource = @"C:\Users\diogo\Downloads\code-challenge\dotnet-code-challenge\FeedData\Wolferhampton_Race1.json";
        private Race Races
        {
            get
            {
                if (races == null)
                {
                    races = new Race();
                    //load data to races
                    races = Deserialize.LoadJson<Race>(jsonSource);
                }

                return races;
            }
        }

        public List<HorseNames> GetHorseNamesInPriceAscendingFromJson()
        {
            List<HorseNames> horseNames = new List<HorseNames>();

            var jsonNames = Races.RawData.Markets
                              .SelectMany(s => s.Selections)
                              .Select(t => new { t.Tags.name, t.Price }).ToList();

            jsonNames.ForEach(f =>
            {
                horseNames.Add(new HorseNames
                {
                    Names = f.name,
                    Price = (decimal)f.Price
                });
            });

            return horseNames;
        }


    }
}
