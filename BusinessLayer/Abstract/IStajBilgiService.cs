using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStajBilgiService
    {
        void StajBilgiAdd(StajBilgi stajBilgi);
        void StajBilgiDelete(StajBilgi stajBilgi);
        void StajBilgiUpdate(StajBilgi stajBilgi);
        List<StajBilgi> GetList();
        StajBilgi GetById(int id);
    }
}
