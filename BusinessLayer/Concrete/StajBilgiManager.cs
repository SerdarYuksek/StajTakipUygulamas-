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
    public class StajBilgiManager : IStajBilgiService
    {
        EfStajBilgiRepository EfStajBilgiRepository;
        public StajBilgiManager()
        {
            EfStajBilgiRepository = new EfStajBilgiRepository();
        }
        public StajBilgi GetById(int id)
        {
            return EfStajBilgiRepository.GetByID(id);
        }

        public List<StajBilgi> GetList()
        {
            return EfStajBilgiRepository.GetListAll();
        }

        public void StajBilgiAdd(StajBilgi stajBilgi)
        {
            EfStajBilgiRepository.Insert(stajBilgi);
        }

        public void StajBilgiDelete(StajBilgi stajBilgi)
        {
            EfStajBilgiRepository.Delete(stajBilgi);
        }

        public void StajBilgiUpdate(StajBilgi stajBilgi)
        {
            EfStajBilgiRepository.Update(stajBilgi);
        }
    }
}
