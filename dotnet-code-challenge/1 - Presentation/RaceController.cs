using dotnet_code_challenge.Domain.Interfaces.Controller;
using dotnet_code_challenge.Domain.Interfaces.Service;
using dotnet_code_challenge.Domain.Model;
using dotnet_code_challenge.Service;
using System.Collections.Generic;

namespace dotnet_code_challenge.Presentation
{
    public class RaceController : IRaceController
    {
        private readonly IRaceService _raceService;
        public RaceController()
        {
            _raceService = new RaceService();
        }

        public List<HorseNames> GetHorseNamesInPriceAscending()
        {
            return _raceService.GetHorseNamesInPriceAscending();
        }

    }
}
