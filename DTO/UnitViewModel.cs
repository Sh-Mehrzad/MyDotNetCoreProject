using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class UnitViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Room Number")]
        public int Room { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
