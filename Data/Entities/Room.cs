using System.Collections.Generic;

namespace Data.Entities
{
    public class Room : GeneralClass
    {
        public int RoomNo { get; set; }
        public string Title { get; set; }
        public int Floor { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
    }
}
