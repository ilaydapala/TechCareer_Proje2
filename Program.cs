using Zoo_Project_Homework.Business;
using Zoo_Project_Homework.Data;
using Zoo_Project_Homework.Models;



IAnimalService animalService = new AnimalService(new AnimalRespository());
Console.WriteLine("Hayvan Ekleme");
animalService.GetById(2);
