using Chating.Abstract;
using Chating.AbstractBus;
using Chating.Concrete;

namespace Chating.ConcreteBus
{
    public class DeneManager : IDeneService
    {
        private readonly IDeneDal deneDal;

        public DeneManager(IDeneDal deneDal)
        {
            this.deneDal = deneDal;
        }

        public void TDelete(dene entity)
        {
            deneDal.Delete(entity);
        }

        public dene TGetById(int id)
        {
          return deneDal.GetById(id);
        }

        public List<dene> TGetListAll()
        {
           return deneDal.GetAll();
        }

        public void TInsert(dene entity)
        {
           deneDal.Insert(entity);
        }

        public void TUpdate(dene entity)
        {
          deneDal.Update(entity);
        }
    }
}
