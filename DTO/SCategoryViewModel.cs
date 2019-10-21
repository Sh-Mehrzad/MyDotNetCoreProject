using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class SCategoryViewModel
    {

        public int ID { get; set; }

        [Display(Name = "Category Title")]
        public string Title { get; set; }
    }
}
