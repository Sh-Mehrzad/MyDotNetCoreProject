using System.Collections.Generic;

namespace Data.Entities
{
    public class SuppliesCategory : GeneralClass
    {
        public string Title { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
