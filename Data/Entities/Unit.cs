namespace Data.Entities
{
    public class Unit : GeneralClass
    {
        public string Title { get; set; }
        public virtual Room Room { get; set; }
        public string Description { get; set; }
        public int RoomID { get; set; }
    }
}
