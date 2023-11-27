
using System.Runtime.ConstrainedExecution;

namespace Zoo_Project_Homework.Business;

public interface IEntityBaseService<TEntity,TId>
{
    void GetList();

    void Add(TEntity animal);

    void Delete(TId ID);

    void GetById(TId ID);
}
