using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MultiVendorStore.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30, ErrorMessage ="Text should contain less then 30 characters")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Number should be in the range of 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
