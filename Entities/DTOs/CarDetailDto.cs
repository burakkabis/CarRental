using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{

    //IEntitiy implement edemeyiz.Cunku bir veritabani tablosu degil CarDetailDto
    //CarDetailDto Birden fazla tablonun joini oalbilir.
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public int DailyPrice { get; set; }

    }
}
