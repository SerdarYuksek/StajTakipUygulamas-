using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        EfKullaniciRepository efKullaniciRepository;
        public KullaniciManager()
        {
            efKullaniciRepository = new EfKullaniciRepository();
        }
        public Kullanici GetById(int id)
        {
            return efKullaniciRepository.GetByID(id);
        }

        public List<Kullanici> GetList()
        {
            return efKullaniciRepository.GetListAll();
        }

        public void KullaniciAdd(Kullanici kullanici)
        {
            efKullaniciRepository.Insert(kullanici);
        }

        public void KullaniciDelete(Kullanici kullanici)
        {
            efKullaniciRepository.Delete(kullanici);
        }

        public void KullaniciUpdate(Kullanici kullanici)
        {
            efKullaniciRepository.Update(kullanici);
        }
    }
}
