
using Zoo_Project_Homework.Models;

namespace Zoo_Project_Homework.Data;

public class ZookeeperRepository : IZookeeperRepository
{
    private readonly List<Zookeeper>? _zookeepers;
    public ZookeeperRepository()
    {
        _zookeepers = new List<Zookeeper>()
        {
         new Zookeeper{ID=1,Name="Esra"},
         new Zookeeper{ID=2,Name="Ahmet"},
         new Zookeeper{ID=3,Name="Şevval"},
         new Zookeeper{ID=4,Name="Hasan"}

        };
    }
    public void Add(Zookeeper zookeeper)
    {
        _zookeepers.Add(zookeeper);
    }

    public void Delete(int ID)
    {
        Zookeeper zookeeper = _zookeepers.SingleOrDefault(x => x.ID == ID);
        if (zookeeper is not null)
        {
            _zookeepers.Remove(zookeeper);
        }
    }

    public List<Zookeeper> GetAll()
    {
        return _zookeepers.ToList();
    }

    public Zookeeper GetByID(int ID)
    {
        Zookeeper? zookeeper = _zookeepers.FirstOrDefault(x => x.ID == ID);
        if (zookeeper is not null)
        {
            return zookeeper;
        }
        return null;
    }
}
