using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNZ.Models
{
    public class Movie
    {
        public int Id { get; set; }
        // The Id field which is required by the database for the primary key.
        public string Title { get; set; }

        [DataType(DataType.Date)]
        //The DataType attribute specifies the type of the data (Date). With this attribute:
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
