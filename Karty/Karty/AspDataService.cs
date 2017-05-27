using Karty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartyModel;

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

        public KartDetailsDTO CreateKart(KartDetailsDTO kart)
        {
            _Karts.Add(new KartDTO() { Name = kart.Name });

            return kart;
        }

        public KartDetailsDTO GetKart(String kartId)
        {
            KartDTO kart = _Karts.Find(item => item.Name == kartId);

            return new KartDetailsDTO() { Name = kart.Name };
        }
    }
}