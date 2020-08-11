using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper.Entities
{
    public class Adress: BaseEntity 
    {
        public string City { get; set; }
        public string Country { get; set; }

        public string GetFullAdress
        {
            get
            {
                return $"{City}/{Country}";
            }
        }
    }
}
