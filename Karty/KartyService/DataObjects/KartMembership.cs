using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyService.DataObjects
{
    public class KartMembership : EntityData
    {
        public string UserId { get; set; }

        public string KartId { get; set; }
    }
}