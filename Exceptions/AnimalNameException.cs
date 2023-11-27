
using System.Xml.Linq;
using Zoo_Project_Homework.Consts;

namespace Zoo_Project_Homework.Exceptions;
public class AnimalNameException : Exception
{
    public AnimalNameException(string? name) : base(Messages.NameExceptionMessage(name))
    {
    }
}
