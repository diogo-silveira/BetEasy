using dotnet_code_challenge.Domain.Model;
using System.Collections.Generic;

namespace dotnet_code_challenge.Domain.Interfaces.Controller
{
    public interface IRaceController
    {
        List<HorseNames> GetHorseNamesInPriceAscending();
    }
}
