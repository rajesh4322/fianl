using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tarigopula_FinalProject.Models
{
    public class Book
    {
  
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }
        public string publisher { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Written> Writtens { get; set; }
    }
}