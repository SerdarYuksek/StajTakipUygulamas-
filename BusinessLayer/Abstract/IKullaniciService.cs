using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKullaniciService
    {
        void KullaniciAdd(Kullanici kullanici);
        void KullaniciDelete(Kullanici kullanici);
        void KullaniciUpdate(Kullanici kullanici);
        List<Kullanici> GetList();
        Kullanici GetById(int id);
    }
}
