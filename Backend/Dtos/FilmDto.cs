using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Dtos
{
    public class FilmDto
{
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public string Synopsis { get; set; } // New property
    public string CoverImage { get; set; } // New property
    public int Duration { get; set; } // New property
}
}
