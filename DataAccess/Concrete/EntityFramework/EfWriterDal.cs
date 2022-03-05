using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWriterDal : EfEntityRepositoryBase<Writer, Context>, IWriterDal
    {

    }
}
