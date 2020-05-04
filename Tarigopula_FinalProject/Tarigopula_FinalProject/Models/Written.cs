using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarigopula_FinalProject.Models
{
    public class Written
    {
        public int BookID { get; set; }

        public int AuthorID { get; set; }
        public int WittenID { get; set; }

        public DateTime ReleaseDate { get; set; }



        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }

    }
}