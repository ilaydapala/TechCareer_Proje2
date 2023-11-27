

namespace Zoo_Project_Homework.Exceptions;

public class AnimalNotFoundException :Exception
{
    public AnimalNotFoundException(int ID) : base($"ID : {ID}, ye ait hayvan bulunamadı.")
    {

    }
}
