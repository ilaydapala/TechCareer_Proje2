

using Zoo_Project_Homework.Data;
using Zoo_Project_Homework.Exceptions;
using Zoo_Project_Homework.Models;

namespace Zoo_Project_Homework.Business;

public class ZookeeperSevice : IZookeeperService
{
    private readonly IZookeeperRepository? _zookeeperRepository;
    public ZookeeperSevice(IZookeeperRepository zookeeperRepository)
    {
        _zookeeperRepository= zookeeperRepository;
    }
    public void Add(Zookeeper zookeeper)
    {
        try
        {
            Rule(zookeeper);
            _zookeeperRepository.Add(zookeeper);
            GetList();
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
    public void Delete(int ID)
    {
        try
        {
            _zookeeperRepository.Delete(ID);
            GetList();
        }
        catch (ZookeeperNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int ID)
    {
        try
        {
            Zookeeper? zookeeper = _zookeeperRepository.GetByID(ID);
            Console.WriteLine(zookeeper);
        }
        catch (ZookeeperNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Zookeeper> zookeepers = _zookeeperRepository.GetAll();
        zookeepers.ForEach(book => Console.WriteLine(book));
    }

    private void Rule(Zookeeper zookeeper)
    {
        if (zookeeper.Name.Length < 2)
        {
            throw new ZookeeperNameException(zookeeper.Name);
        }
    }
}
