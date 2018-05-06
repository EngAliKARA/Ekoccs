using System;

namespace EkoCcs.Core.Models
{
    public class Customer : BaseEntity
    {
        public virtual string AdSoyad { get; set; }
        public virtual int Cinsiyet { get; set; }
        public virtual string Meslek { get; set; }
        public virtual DateTime DogumTarihi { get; set; }
        public virtual string Email { get; set; }
        public virtual string WebSite { get; set; }
        public virtual bool IsMail { get; set; }
        public virtual string Adres { get; set; }
        public virtual int IlKodu { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual City citys { get; set; }
        //public Customer()
        //{
        //    citys = new City();
        //}
    }
}
