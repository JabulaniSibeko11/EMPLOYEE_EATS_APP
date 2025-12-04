using System.ComponentModel.DataAnnotations;

namespace BraamBowlApp.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItem_ID { get; set; }

        [Required]
        public string Item_Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; } 

        public string Category { get; set; }

        public string Shop_ID { get; set; }
        public virtual Shop Shop { get; set; }

        public string? Description { get; set; }

        public string Tags { get; set; }
    }
}
