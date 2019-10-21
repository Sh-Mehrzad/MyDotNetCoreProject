namespace Data.Entities
{
    public class Property : GeneralClass
    {
        public string Title { get; set; }
        public virtual SuppliesCategory Category { get; set; }
        public virtual Unit Unit { get; set; }
        public string PropertyCode { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int UnitID { get; set; }
    }
}
