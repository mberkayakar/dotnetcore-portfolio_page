using AKARmpwebsite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARmpwebsite.Entities.Concrete
{

    /*
     
     Id int identity (1,1),
BASLİK nvarchar (max),
POZİSYON nvarchar (max),
ZAMAN_DİLİMİ_BASLANGİC date,
ZAMAN_DİLİMİ_BİTİS date,
Adress nvarchar(max),
ACİKLAMASİ nvarchar(max),
RESMİ nvarchar(max),
 
     
     */

    [Dapper.Contrib.Extensions.Table("DENEYİM")]

    public class DENEYİM:ITable
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
