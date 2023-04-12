using System.ComponentModel.DataAnnotations;

namespace FirstBlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(12 , ErrorMessage ="Grocery name should be less than 12 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1,60000,ErrorMessage ="Valid price range is (1-60000)")]
        public float Price { get; set; }

    }
}
