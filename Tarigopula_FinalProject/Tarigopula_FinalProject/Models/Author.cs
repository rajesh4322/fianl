using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarigopula_FinalProject.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Written> Writtens { get; set; }
    }
}