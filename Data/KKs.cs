using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KrazyKookiesWeb.Data
{
    public class KKs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        //foreign key connects Manufacturer table
        public int MID { get; set; }
        [ForeignKey("MID")]
        public Manufacturer Manufacturers { get; set; }

        //foreign key connects KookieStore table
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public KookieStore Stores { get; set; }
      
    }
}
