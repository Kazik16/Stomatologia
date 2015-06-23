using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stomatologia.Models
{
    public class Wizyta
    {
       // [Key]
       // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Id { get; set; }

        public string LekarzId { get; set; }

        public string PacjentId { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]     
        //[Required]
        //public Nullable<DateTime> Data { get; set; }

        [Required]
        public int Hour { get; set; }
    }
}