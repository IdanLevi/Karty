using Karty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karty.Models;
using Karty.DTOs;

namespace Karty
{
    public sealed class AspDataService : IDataService
    {
        private static volatile AspDataService s_Instance = new AspDataService();
        private List<KartDTO> _Karts = new List<KartDTO>();

        static AspDataService()
        {
        }

        private AspDataService()
        {
            _Karts.Add(new KartDTO() { Name = "Kart 1" });
            _Karts.Add(new KartDTO() { Name = "Kart 2" });
            _Karts.Add(new KartDTO() { Name = "Kart 3" });
            _Karts.Add(new KartDTO() { Name = "Kart 4" });
            _Karts.Add(new KartDTO() { Name = "Kart 5" });
        }

        public static AspDataService Instance
        {
            get { return s_Instance; }
        }

        public List<KartDTO> GetMyKarts(string userId)
        {
            return _Karts;
        }

        public void CreateKart(KartDTO kart)
        {
            _Karts.Add(kart);
        }
    }
}