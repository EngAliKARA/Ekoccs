
using EkoCcs.Core.Models;
using FluentNHibernate.Mapping;

namespace EkoCcs.Core.Mappings
{
    public class CustomerMapping : ClassMap<Customer>
    {
        public CustomerMapping()
        {
            Table("Customer");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.AdSoyad).Not.Nullable();
            Map(x => x.Cinsiyet).Not.Nullable();
            Map(x => x.Meslek).Not.Nullable();
            Map(x => x.DogumTarihi).Not.Nullable();
            Map(x => x.Email).Not.Nullable();
            Map(x => x.WebSite);
            Map(x => x.IsMail).Not.Nullable();
            Map(x => x.Adres);
            Map(x => x.IlKodu).Not.Nullable();
            Map(x => x.Aciklama);


        }
    }
}
