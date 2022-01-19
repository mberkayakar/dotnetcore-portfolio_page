using AKARmpwebsite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARmpwebsite.Entities.Concrete
{

    [Dapper.Contrib.Extensions.Table("EGİTİM")]
    public class EGİTİM:ITable
    {
        public int Id { get; set; }
        public string BASLİK { get; set; }
        public string POZİSYON { get; set; }
        public DateTime ZAMAN_DİLİMİ_BASLANGİC { get; set; }
        public DateTime ZAMAN_DİLİMİ_BİTİS { get; set; }
        public string Adress { get; set; }
        public string ACİKLAMASİ { get; set; }
        public string RESMİ { get; set; }
    }
}
