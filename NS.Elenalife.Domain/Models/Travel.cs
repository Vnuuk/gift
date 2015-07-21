using System.Collections.Generic;
using FluentNHibernate.Mapping;
using Incoding.Data;

namespace NS.Elenalife.Domain.Models
{
    public class Travel : IncEntityBase
    {
        public new virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Image> Media { get; set; }

        public class TravelMap : ClassMap<Travel>
        {
            public TravelMap()
            {
                Id(r => r.Id).GeneratedBy.Increment();
                Map(r => r.Title);
                Map(r => r.Description);
                HasMany(r => r.Media).KeyColumn("TravelId");
            }
        }
    }
}