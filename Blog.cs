using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        internal Author Author { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<Post> Posts { get; set; }
        
    }
}
