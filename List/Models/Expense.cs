using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace List.Models
{
    public class Expense
    {
        [Key]
        public  int Id { get; set; }
        [DisplayName("Masraflar")]
        [Required]
        public string ExpenseName { get; set; }
        [DisplayName("Fiyat")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Fiyat 0 dan büyük olmalı")]
        public int Amount  { get; set; }
    }
}
