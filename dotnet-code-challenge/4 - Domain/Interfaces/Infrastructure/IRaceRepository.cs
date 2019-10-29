using dotnet_code_challenge.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain.Interfaces.Infrastructure
{
    public interface IRaceRepository
    {
        List<HorseNames> GetHorseNamesInPriceAscendingFromJson();
    }
}
