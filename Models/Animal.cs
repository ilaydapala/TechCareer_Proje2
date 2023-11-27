

namespace Zoo_Project_Homework.Models;

public class Animal : EntityBase<int>
{
    public string? AnimalName { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public string? Type { get; set; }
    public int ZookeeperID { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Hayvan Adı: {AnimalName}, Yaşı: {Age}, Cinsiyeti: {Gender}, Türü: {Type} ,Bakıcısı :{ZookeeperID}";
    }

}
