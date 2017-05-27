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
    public class ItemManager : EntityManager<Item>, IItemManager
    {
        public ItemManager(IMobileServiceClient client) : base(client)
        {
        }
    }
}
