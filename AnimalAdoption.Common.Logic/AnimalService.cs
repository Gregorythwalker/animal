namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "big rock", Age = 50, Description = "Soft natured" },
            new Animal { Id = 2, Name = "small rock", Age = 50, Description = "Under a lot of pressure" },
            new Animal { Id = 3, Name = "diamond", Age = 50, Description = "Shiny and glasslike" },
        };
    }
}
