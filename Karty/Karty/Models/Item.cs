using Karty.Interfaces;
using Newtonsoft.Json;

namespace Karty.Models
{
    public class Item : IEntity
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty(PropertyName = "kartId")]
        public string KartId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }
    }
}
