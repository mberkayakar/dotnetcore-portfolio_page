using AKARmpwebsite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARmpwebsite.Entities.Concrete
{
    // Buradaki classı 
    [Dapper.Contrib.Extensions.Table("SocialMediaİcons")]

    public class SocialMediaİcons:ITable
    {

        public int Id { get; set; }
        public string Link { get; set; }
        public string icon { get; set; }
        public int Kullanici { get; set; }

    }
}
