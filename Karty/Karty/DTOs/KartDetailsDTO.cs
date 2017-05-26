using System.Collections.Generic;

namespace Karty.DTOs
{
    public class KartDetailsDTO : BaseDTO
    {
        public string Name { get; set; }

        public List<ItemDTO> Items { get; set; }

        public List<UserDTO> Members { get; set; }
    }
}