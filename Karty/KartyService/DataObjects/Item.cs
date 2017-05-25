using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyService.DataObjects
{
    public class Item : EntityData
    {
        public string Name { get; set; }

        public string OwnerId { get; set; }
    }
}