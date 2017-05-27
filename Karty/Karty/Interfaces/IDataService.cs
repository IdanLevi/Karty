using Karty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.Interfaces
{
    public interface IDataService
    {
        List<Kart> GetMyKarts(String userId);
		
        Kart GetKart(String kartId);
		
        Kart CreateKart(Kart kart);
    }
}
