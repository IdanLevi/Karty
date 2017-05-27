using System.Collections.Generic;

namespace KartyModel
{
    public class KartDetailsDTO : BaseDTO
    {
        public string Name { get; set; }

        public List<ItemDTO> Items { get; set; }

        public List<UserDTO> Members { get; set; }
    }
}