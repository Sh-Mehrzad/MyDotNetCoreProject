using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class RoomViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Room Number")]
        public int RoomNo { get; set; }

        [Display(Name = "Room Name")]
        public string Title { get; set; }

        [Display(Name = "Floor Number")]
        public int Floor { get; set; }
    }
}
