using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }


    }
}