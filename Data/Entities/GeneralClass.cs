using System;

namespace Data.Entities
{
    public class GeneralClass
    {
        public int ID { get; set; }
        public string createdByUser { get; set; }
        public string editedByUser { get; set; }
        public Nullable<int> isActive { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public DateTime createdOn { get; set; }
        public Nullable<DateTime> editedOn { get; set; }
    }
}
