using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
       
        public int PaymentDetailId { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [StringLength(16)]
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(5)]
        [Column(TypeName = "nvarchar(5)")] //dd/yy
        public string ExpirationDate { get; set; }

        [Required]
        [StringLength(3)]
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }
    }
}
