namespace chore_c.Models;

public class Fish
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public int AmountOfFins { get; set; }


    public Fish(string name, int id, string color, int age, int amountOfFins)
    {

        Name = name;
        Id = id;
        Color = color;
        Age = age;
        AmountOfFins = amountOfFins;

    }
}