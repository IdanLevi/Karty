using Karty.Interfaces;
using Karty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty
{
    public sealed class AspDataService : IDataService
    {
        private static volatile AspDataService s_Instance = new AspDataService();
        private List<Kart> _Karts = new List<Kart>();

        static AspDataService()
        {
        }

        private AspDataService()
        {
            _Karts.Add(new Kart() { Name = "Kart 1" });
            _Karts.Add(new Kart() { Name = "Kart 2" });
            _Karts.Add(new Kart() { Name = "Kart 3" });
            _Karts.Add(new Kart() { Name = "Kart 4" });
            _Karts.Add(new Kart() { Name = "Kart 5" });
        }

        public static AspDataService Instance
        {
            get { return s_Instance; }
        }

        public List<Kart> GetMyKarts(string userId)
        {
            return _Karts;
        }

        public Kart CreateKart(Kart kart)
        {
            _Karts.Add(new Kart() { Name = kart.Name });

            return kart;
        }
    }
}