using System.Collections.Generic;
using Karty.Interfaces;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Karty.Models
{
    public class Kart : IEntity
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [Version]
        public string Version { get; set; }

        public List<User> Members { get; set; }
    }
}
