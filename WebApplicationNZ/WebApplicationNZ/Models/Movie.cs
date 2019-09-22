using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationNZ.Models
{
    public class Movie
    {
        public int Id { get; set; }
        // The Id field which is required by the database for the primary key.
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        //The DataType attribute specifies the type of the data (Date). With this attribute:
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        //The above data annotation is required so Entity Framework Core can correctly map "Price" to currency in the database.
        public decimal Price { get; set; }
    }
}
