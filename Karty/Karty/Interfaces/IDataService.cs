using Karty.Models;
using Karty.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.Interfaces
{
    public interface IDataService
    {
        List<KartDTO> GetMyKarts(String userId);
        void CreateKart(KartDTO kart);
    }
}
