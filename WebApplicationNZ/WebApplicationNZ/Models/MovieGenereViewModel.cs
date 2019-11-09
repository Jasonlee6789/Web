using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationNZ.Models
{
    public class MovieGenereViewModel
    {
        public List<Movie> Movies { get; set; }
        //A list of movies.
        public SelectList Genres { get; set; }
        //A SelectList containing the list of genres. This allows the user to select a genre from the list.
        public string MovieGenre { get; set; }
        //MovieGenre, which contains the selected genre.
        public string SearchString { get; set; }
        //SearchString, which contains the text users enter in the search text box.
    }
}
