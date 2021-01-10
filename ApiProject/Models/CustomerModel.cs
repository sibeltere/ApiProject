using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiProject.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
    }
}