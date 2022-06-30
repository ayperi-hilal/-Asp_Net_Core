using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class aboutManager : IaboutService
    {
        IaboutDal _aboutDal;

        public aboutManager(IaboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(about t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(about t)
        {
            _aboutDal.Delete(t);
        }

        public about TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<about> TGetList(about t)
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(about t)
        {
            _aboutDal.Update(t);
        }
    }
}
