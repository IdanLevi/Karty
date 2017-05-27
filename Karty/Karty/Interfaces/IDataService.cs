using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartyModel;

namespace Karty.Interfaces
{
    public interface IDataService
    {
        List<KartDTO> GetMyKarts(String userId);
        KartDetailsDTO CreateKart(KartDetailsDTO kart);
        KartDetailsDTO GetKart(String kartId);
    }
}
