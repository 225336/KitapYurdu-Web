using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "1 ile 100 arsaında değer giriniz")]
        public int DisplayOrder { get; set; }
    }
}
