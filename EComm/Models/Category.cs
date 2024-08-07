using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComm.Models
{
    public class Category
    {
        public int Id { get; set; }

      
        public string Title { get; set; }

        
        public int DisplayOrder { get; set; }

     
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [NotMapped]
        public IFormFile CategoryImage { get; set; }
        public string CategoryImagePath { get; set; }
    }
}
