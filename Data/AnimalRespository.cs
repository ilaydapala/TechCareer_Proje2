

using Zoo_Project_Homework.Models;

namespace Zoo_Project_Homework.Data;

public class AnimalRespository : IAnimalRepository
{
    private readonly List<Animal> _animals;
    public AnimalRespository()
    {
        _animals = new List<Animal>()
        { 
           new Animal() {ID=1,AnimalName="Şila",Age=3,Gender='M',Type="Kedi",ZookeeperID=2},
           new Animal() {ID=2,AnimalName="Boncuk",Age=2,Gender='M',Type="Kedi",ZookeeperID=4},
           new Animal() {ID=3,AnimalName="Joey",Age=1,Gender='M',Type="Köpek",ZookeeperID=2},
           new Animal() {ID=4,AnimalName="Çakıl",Age=1,Gender='F',Type="Köpek",ZookeeperID=1},
           new Animal() {ID=5,AnimalName="Oskar",Age=2,Gender='M',Type="Köpek",ZookeeperID=1},
           new Animal() {ID=6,AnimalName="Mızmız",Age=1,Gender='F',Type="Kedi",ZookeeperID=3},
           new Animal() {ID=7,AnimalName="Asena",Age=2,Gender='F',Type="Kedi",ZookeeperID=1},
           new Animal() {ID=8,AnimalName="Şans",Age=3,Gender='M',Type="Köpek",ZookeeperID=4},
           new Animal() {ID=9,AnimalName="Gofi",Age=4,Gender='M',Type="Kedi",ZookeeperID=3},
           new Animal() {ID=10,AnimalName="Cino",Age=1,Gender='M',Type="Köpek",ZookeeperID=2},


        };
    }

    public void Add(Animal animal)
    {
        _animals.Add(animal);
       
    }

    public void Delete(int ID)
    {
        Animal? animal = _animals.SingleOrDefault(x => x.ID == ID);
        if (animal is not null)
        {
            _animals.Remove(animal);
        }
    }

    public List<Animal> GetAll()
    {
        return _animals.ToList();
        
    }

    public Animal GetByID(int ID)
    {
        Animal? animal = _animals.FirstOrDefault(x => x.ID == ID);
        if (animal is not null)
        {
            return animal;
        }
        return null;
    }
}
