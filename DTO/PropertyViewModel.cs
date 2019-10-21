using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class PropertyViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Property Title")]
        public string Title { get; set; }

        [Display(Name = "Serial Number")]
        public string PropertyCode { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        
    }
}
