using System;

namespace EComm.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
    }
}
