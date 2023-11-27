
using Zoo_Project_Homework.Data;
using Zoo_Project_Homework.Exceptions;
using Zoo_Project_Homework.Models;

namespace Zoo_Project_Homework.Business;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;
    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
        
    }
    public void Add(Animal animal)
    {
        try
        {
            Rule(animal);
            _animalRepository.Add(animal);
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
            _animalRepository.Delete(ID);
            GetList();
        }
        catch (AnimalNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int ID)
    {
        try
        {
            Animal? animal = _animalRepository.GetByID(ID);
            Console.WriteLine(animal);
        }
        catch (AnimalNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Animal> animals = _animalRepository.GetAll();
        animals.ForEach(x => Console.WriteLine(x)); 
    }

    private void Rule(Animal animal)
    {
        if (animal.AnimalName.Length < 2)
        {
            throw new AnimalNameException(animal.AnimalName);
        }
    }
}
