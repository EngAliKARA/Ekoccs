using EkoCcs.Core.Models;
using FluentNHibernate.Mapping;

namespace EkoCcs.Core.Mappings
{
    public class CityMapping : ClassMap<City>
    {
        public CityMapping()
        {
            Table("City");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.IlKodu).Not.Nullable();
            Map(x => x.IlAdi).Not.Nullable();
        }
    }
}
