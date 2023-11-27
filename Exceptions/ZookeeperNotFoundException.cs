
namespace Zoo_Project_Homework.Exceptions;

public class ZookeeperNotFoundException :Exception
{
    public ZookeeperNotFoundException(int ID) : base($"ID : {ID}, ye ait bakıcı bulunamadı.")
    {

    }
}
