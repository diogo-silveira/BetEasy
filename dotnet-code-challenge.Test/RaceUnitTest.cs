using dotnet_code_challenge.Domain.Interfaces.Controller;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Presentation;
using System;
using System.Collections.Generic;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public class RaceUnitTest
    {
        private readonly IRaceController raceController;
        private List<string> HorseNames;
        public RaceUnitTest()
        {
            raceController = new RaceController();

            HorseNames = new List<string> { "Advancing", "Fikhaar", "Toolatetodelegate", "Coronel" };
        }

        [Fact]
        public void GetHorseNames_InPriceAscending_ReturnTrue()
        {
           List<string> names = new List<string>();
           
            var horses = raceController.GetHorseNamesInPriceAscending();

            horses.ForEach(name =>
            {
                names.Add(name.Names);
            });

            Assert.True(horses.Count > 0);
            Assert.IsType<List<HorseNames>>(horses);
            Assert.Equal(HorseNames, names);
        }
    }
}
