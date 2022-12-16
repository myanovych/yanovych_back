using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yanovych_back.Models
{
    public class Lab
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public double? Mark { get; set; }
        public int StudentID { get; set; }
    }
}
