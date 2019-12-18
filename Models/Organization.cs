using System;

namespace BizzDirectory.Models
{

    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }

        public string EmailAddress { get; set; }
        public int FoundationYear { get; set; }
        public Uri Website { get; set; }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
