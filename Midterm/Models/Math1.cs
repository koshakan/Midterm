using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class Math1
    {
        public int Id { get; set; }
        [Required]
        public int A { get; set; }
        [Required]
        public int B { get; set; }
        [Required]
        public int Add { get; set; }
        public int Substract { get; set; }
        public double Multiply { get; set; }
        public double Division { get; set; }
    }
}
