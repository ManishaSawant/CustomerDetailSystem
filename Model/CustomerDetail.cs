using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerDetailSystem.Model
{
    public class CustomerDetail
    {
        [Key]
       public int CUST_ID { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
       public string CUST_FIRST_NM { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CUST_MID_NM { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CUST_LAST_NM { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string CUST_ADDRESS { get; set; }
        [Required]
        [Column(TypeName = "varchar(12)")]
        public string CUST_MOBILE_NO { get; set; }
    }
}
