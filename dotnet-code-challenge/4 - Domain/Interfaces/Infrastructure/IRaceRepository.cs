using dotnet_code_challenge.Domain.Model;
using System.Collections.Generic;

namespace dotnet_code_challenge.Domain.Interfaces.Infrastructure
{
    public interface IRaceRepository
    {
        List<HorseNames> GetHorseNamesInPriceAscendingFromJson();
        List<HorseNames> GetHorseNamesInPriceAscendingFromXml();
    }
}
