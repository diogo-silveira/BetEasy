using dotnet_code_challenge.Domain.Model;
using System.Collections.Generic;

namespace dotnet_code_challenge.Domain.Interfaces.Service
{
    public interface IRaceService
    {
        List<HorseNames> GetHorseNamesInPriceAscending();
    }
}
