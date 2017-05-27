using Karty.Interfaces;
using Karty.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.Services
{
    public class KartManager : EntityManager<Kart>, IKartManager
    {
        public KartManager(IMobileServiceClient client) : base(client)
        {
        }
    }
}
