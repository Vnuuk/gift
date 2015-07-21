using Incoding.Data;

namespace NS.Elenalife.Domain.Models
{
    public class Image : IncEntityBase
    {
        public new virtual int Id { get; set; }
        public virtual string Path { get; set; }
        public virtual bool IsMain { get; set; }
    }
}