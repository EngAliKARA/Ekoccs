using EkoCcs.Core.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoCcs.Core.Mappings
{
    public class PhoneMapping : ClassMap<Phone>
    {
        public PhoneMapping()
        {
            Table("Phone");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Number).Not.Nullable();
        }
    }
}
