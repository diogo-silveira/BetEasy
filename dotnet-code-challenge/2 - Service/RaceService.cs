using dotnet_code_challenge.Domain.Interfaces.Infrastructure;
using dotnet_code_challenge.Domain.Interfaces.Service;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Infrastructure;
using System.Collections.Generic;
using System.Linq;

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

            var horseListXml = _raceRepository.GetHorseNamesInPriceAscendingFromXml();

            if (horseListJson != null)
                horseNames.AddRange(horseListJson);

            if (horseListXml != null)
                horseNames.AddRange(horseListXml);

            if (horseNames != null)
                horseNames = horseNames.OrderBy(x => x.Price).ToList();

            return horseNames;
        }
    }
}
