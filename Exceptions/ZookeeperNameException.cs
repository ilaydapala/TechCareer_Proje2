
using Zoo_Project_Homework.Consts;

namespace Zoo_Project_Homework.Exceptions;
public class ZookeeperNameException :Exception
{
    public ZookeeperNameException(string name) : base(Messages.NameExceptionMessage(name))
    {
    
    }

}
