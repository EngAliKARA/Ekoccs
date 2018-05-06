namespace EkoCcs.Core.Models
{
    public class Phone : BaseEntity
    {
        public virtual int CustomerId { get; set; }
        public virtual string Type { get; set; }
        public virtual string Number { get; set; }
    }
}
