using System;

namespace NS.Elenalife.Domain.Models
{
    public class MyCityPoster
    {
        public virtual Image Image { get; set; }
        public virtual string FirstLabel { get; set; }
        public virtual string SecondLabel { get; set; }
        public virtual DateTime Date { get; set; }
    }
}