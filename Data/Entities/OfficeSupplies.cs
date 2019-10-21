namespace Data.Entities
{
    public class OfficeSupplies : GeneralClass
    {
        public string Title { get; set; }
        public SuppliesCategory Category { get; set; }
        public OfficeSupplies Mother { get; set; }
        public string SerialNo { get; set; }
        public Unit Unit { get; set; }
        public string BoughtDate { get; set; }
        public string UsageDate { get; set; }
    }
}
