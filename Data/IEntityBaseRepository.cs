

using System.Security.Cryptography;

namespace Zoo_Project_Homework.Data;

public interface IEntityBaseRepository<TEntity,TId>
{
    void Add(TEntity animal);
    void Delete(TId ID);
    List<TEntity> GetAll();
    TEntity GetByID(TId ID);
}
