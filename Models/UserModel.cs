using System;
using System.ComponentModel.DataAnnotations;

namespace BizzDirectory.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BuzType{get; set;}
        public string CompanyName{get; set;}
        public string Address{get; set;}
        public string TelNo{get; set;}
    }
}