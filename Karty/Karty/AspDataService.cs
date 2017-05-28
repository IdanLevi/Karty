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
            _Karts.Add(new Kart() { Name = "Kart 1", Id = "Kart 1" });
            _Karts.Add(new Kart() { Name = "Kart 2", Id = "Kart 2" });
            _Karts.Add(new Kart() { Name = "Kart 3", Id = "Kart 3" });
            _Karts.Add(new Kart() { Name = "Kart 4", Id = "Kart 4" });
            _Karts.Add(new Kart() { Name = "Kart 5", Id = "Kart 5" });
        }

        public List<User> GetKartMembers(String kartId)
        {
            return new List<User>();
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
            _Karts.Add(new Kart() { Name = kart.Name, Id = kart.Id });

            return kart;
        }

        public Kart GetKart(String kartId)
        {
            Kart kart = _Karts.Find(item => item.Name == kartId);
            List<Item> items = new List<Item>()
            {
                new Item(){Name="Item 1", Quantity=2},
                new Item(){Name="Item 2", Quantity=5},
                new Item(){Name="Item 3", Quantity=1},
            };

            return new Kart() { Name = kart.Name, Items = items, Id = kart.Name };
        }

        public Item CreateItem(Item item)
        {
            // need to add item to kart
            return item;
        }
    }
}