using dotnet_code_challenge.Model.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotnet_code_challenge.Domain.Interfaces.Infrastructure;
using dotnet_code_challenge.Model.Soap;
using dotnet_code_challenge.Domain.Model;

namespace dotnet_code_challenge.Infrastructure
{
    public class RaceRepository : IRaceRepository
    {
        private static Race races;
        internal static readonly string jsonSource = @"C:\Users\diogo\Downloads\code-challenge\dotnet-code-challenge\FeedData\Wolferhampton_Race1.json";
        private Race Races { get; set; }

        public List<HorseNames> GetHorseNamesInPriceAscendingFromJson()
        {
            List<HorseNames> horseNames = new List<HorseNames>();

            //TODO: read Json file

            return horseNames;
        }


    }
}
