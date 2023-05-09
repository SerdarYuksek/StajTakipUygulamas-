using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class StajBilgi
    {
        [Key]
        public int StajBilgiID { get; set; }
        public string AdUnvan { get; set; }
        public string Adres { get; set; }
        public string Alanı { get; set; }
        public string YetkiliAd { get; set; }
        public int TelNo { get; set; }
        public string Mail { get; set; }
        public int FaksNo { get; set; }
        public string WebSite { get; set; }
        public DateTime Başlamatrh { get; set; }
        public DateTime Bitistrh { get; set; }
        public string StajTürü { get; set; }
        public bool ResmiTatil { get; set; }
        public bool CmtDahil { get; set; }
        public bool Egitim { get; set; }
        public int KabulGün { get; set; }
        public bool Onay { get; set; }
        public bool Kabul { get; set; }
        public bool KatkıPayıOnay { get; set; }
        public string? RedSebep { get; set; }
        public bool StajBilgiStatus { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici kullanici { get; set; }
    }
}
