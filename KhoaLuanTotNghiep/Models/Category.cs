using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Models
{
    public class Category
    {
        [Key]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual List<RealEstate> RealEstates { get; set; }
    }

}
