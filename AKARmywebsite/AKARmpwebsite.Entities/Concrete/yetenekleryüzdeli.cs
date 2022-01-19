using AKARmpwebsite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARmpwebsite.Entities.Concrete
{

    /*
     
    ID int identity(1,1) primary key,
YETENEK_İSMİ nvarchar(max),
YETENEK_yuzdesi int ,
YETENEK_RENGİ nvarchar (max),
     
     */

    [Dapper.Contrib.Extensions.Table("yetenekleryüzdeli")]

    public class yetenekleryüzdeli:ITable
    {
        public int ID { get; set; }
        public string YETENEK_İSMİ { get; set; }
        public string YETENEK_RENGİ { get; set; }
        public int YETENEK_yuzdesi { get; set; }
    }
}
