using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyService.DTOs
{
    public class KartDetailsDTO : BaseDTO
    {
        public string Name { get; set; }

        public List<ItemDTO> Items { get; set; }

        public List<UserDTO> Members { get; set; }
    }
}