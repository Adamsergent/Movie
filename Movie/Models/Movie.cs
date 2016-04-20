using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie.Models
{
    public class Movie
    {
        public virtual int MovieId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Category Category { get; set; }

    }
}