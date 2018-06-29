using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Class
    {
        //public string Type { get; set; }
        public string Type { get; set;}
        public int Id { get; set; }
        public List<Class> classes { get; set; }
    }
}