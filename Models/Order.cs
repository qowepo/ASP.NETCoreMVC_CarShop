using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="Enter Your Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "Lenght Name more 25 simbols or empty")]
        public string name { get; set; }

        [Display(Name = "Enter Your Surame")]
        [StringLength(25)]
        [Required(ErrorMessage = "Lenght Surame more 25 simbol or empty")]
        public string surname { get; set; }

        [Display(Name = "Enter Your Adress")]
        [StringLength(40)]
        [Required(ErrorMessage = "Lenght Adress more 40 simbol or empty")]
        public string adress { get; set; }

        [Display(Name = "Enter Your Phone")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Lenght Phone more 20 simbol or empty")]
        public string phone { get; set; }

        [Display(Name = "Enter Your E-Mail")]
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Lenght E-Mail more 30 simbol or empty")]
        public string email { get; set; }

        public DateTime orderTime { get; set; }
        public List<OrderDetail> OderDetails { get; set; }
    }
}
