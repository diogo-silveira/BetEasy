using dotnet_code_challenge.Domain.Interfaces.Infrastructure;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Json;
using dotnet_code_challenge.Model.Json;
using dotnet_code_challenge.Model.Soap;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_code_challenge.Infrastructure
{
    public class RaceRepository : IRaceRepository
    {
        private static Race races;
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

        private static meeting meeting;
        internal static readonly string xmlSource = @"C:\Users\diogo\Downloads\code-challenge\dotnet-code-challenge\FeedData\Caulfield_Race1.xml";

        private meeting Meeting
        {
            get
            {
                if (meeting == null)
                {
                    meeting = new meeting();
                    //load data to races
                    meeting = Deserialize.LoadXml<meeting>(xmlSource);
                }

                return meeting;
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

        public List<HorseNames> GetHorseNamesInPriceAscendingFromXml()
        {
            List<HorseNames> horseNames = new List<HorseNames>();

            var xmlIds = Meeting.races.race.prices.price.horses.Select(t => new { t.number, t.Price }).ToList();

            xmlIds.ForEach(ids =>
            {
                var xmlNames = Meeting.races.race.horses.Where(x => x.number == ids.number).Select(t => new { t.name, ids.Price }).ToList();

                xmlNames.ForEach(f =>
                {
                    horseNames.Add(new HorseNames { Names = f.name, Price = f.Price });
                });
            });

            return horseNames;
        }

    }
}
