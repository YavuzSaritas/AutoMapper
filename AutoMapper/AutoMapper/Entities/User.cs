using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AdressId { get; set; }
        public Adress Adress { get; set; }


        public string GetFullName{ 
            get {
                return $"{FirstName} {LastName}";
            } 
        }
    }
}
