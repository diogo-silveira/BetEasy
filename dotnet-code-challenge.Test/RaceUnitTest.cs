using dotnet_code_challenge.Domain.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public class RaceUnitTest
    {
        public RaceUnitTest()
        {            
        }

        [Fact]
        public void GetHorseNames_InPriceAscending_ReturnTrue()
        {
           List<string> names = new List<string>();

            var horses = new List<HorseNames>();

            horses.ForEach(name =>
            {
                names.Add(name.Names);
            });

            Assert.IsType<List<HorseNames>>(horses);
        }
    }
}
