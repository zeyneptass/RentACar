using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto: IDto //bir veritabanı tablosu değil birkaç tablonun joinlenmiş hali olabilir.
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
