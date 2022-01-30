using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IServiceOperations<TEntity, TCreateViewModel, TEditViewModel>
    {
        ServiceResult<TEntity> Create(TCreateViewModel model);
        ServiceResult<TEntity> Find(int id);
        ServiceResult<List<TEntity>> ListAll();
        ServiceResult<object> Remove(int id);
        ServiceResult<TEntity> Update(int id, TEditViewModel model);
    }
}
