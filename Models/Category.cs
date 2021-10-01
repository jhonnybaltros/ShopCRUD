using System.ComponentModel.DataAnnotations;

namespace ShopCRUD{
    public class Category
    {
         [Key]

         public int Id { get; set; }

         [Required(ErrorMessage = "This field is required")]
         [MaxLength(60, ErrorMessage ="This field must contain betwen 3 and 60 caracters")]
         [MinLength(3, ErrorMessage = "This field must contain betwen 3 and 60 caracteres")]
    
        public string Title {get; set;}
    }
}