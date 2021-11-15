using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace List.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Satın Alan")]
        public string Buyer { get; set; }
        [DisplayName("Gönderen")]
        public string Lender { get; set; }
        [DisplayName("Eşya Adı")]
        public string ItemName { get; set; }




    }
}
