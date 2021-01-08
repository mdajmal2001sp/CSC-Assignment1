using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRecords.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public int PercentageMarks { get; set; }
    }
}