using System.ComponentModel.DataAnnotations;

namespace ShopCRUD.Models
{
    public class Product 
    {
        [Key]

        public int Id { get; set;}

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage ="This field must contain betwen 3 and 60 caracters")]
        [MinLength(3, ErrorMessage = "This field must contain betwen 3 and 60 caracteres")]

        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "This field must contain less than 1024 caracters")]

        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage ="The price must be higher than zero")]
        
        public decimal price { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid Category")]

        public int CategoryId { get; set; }

        public Category Category { get; set;}
    }
}