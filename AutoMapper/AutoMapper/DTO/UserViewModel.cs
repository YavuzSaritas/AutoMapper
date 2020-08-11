using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.DTO
{
    public class UserViewModel
    {
        /*UserProfile da configure edildi.*/
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullAdress { get; set; }
        public string Country { get; set; }


        /*User.cs FirstName GetFirstName() ile eşleşiyor*/
        public string FullName { get; set; }
        /*aynı property ismiyle eşleşiyor*/
        public string Email { get; set; }

    }
}
