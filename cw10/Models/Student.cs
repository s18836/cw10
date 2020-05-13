using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Models
{
    public class Student : Person
    {
        public string IndexNumber { get; set; }

        [ForeignKey("Subject")]
        public int? IdSubject { get; set; }

        public virtual Subject Subcjet { get; set; }
    }
}
