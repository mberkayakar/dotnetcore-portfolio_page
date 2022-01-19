using AKARmpwebsite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARmpwebsite.Entities.Concrete
{
    // Buradaki classı 
  [Dapper.Contrib.Extensions.Table("kullanici")] 

    public class kullanici :ITable
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string İmageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string shortdescription { get; set; }
    }
}
