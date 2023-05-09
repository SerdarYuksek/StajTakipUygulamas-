using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public string TCNO { get; set; }
        public bool Cinsiyet { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }
        public string? OgrenciNo { get; set; }
        public string? AdminNo { get; set; }
        public string? PersonelNo { get; set; }
        public string? Unvan { get; set; }
        public bool KullaniciStatus { get; set; }
        public List<StajBilgi> StajBilgis { get; set; }
    }
}
