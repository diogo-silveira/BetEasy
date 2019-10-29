﻿using dotnet_code_challenge.Domain.Interfaces.Infrastructure;
using dotnet_code_challenge.Domain.Interfaces.Service;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Infrastructure;
using dotnet_code_challenge.Model.Soap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnet_code_challenge.Service
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository _raceRepository;
        public RaceService()
        {
            _raceRepository = new RaceRepository();
        }

        public List<HorseNames> GetHorseNamesInPriceAscending()
        {
            List<HorseNames> horseNames = new List<HorseNames>();

            var horseListJson = _raceRepository.GetHorseNamesInPriceAscendingFromJson();

            if (horseListJson != null)
                horseNames.AddRange(horseListJson);

            if (horseNames != null)
                horseNames = horseNames.OrderBy(x => x.Price).ToList();

            return horseNames;
        }
    }
}