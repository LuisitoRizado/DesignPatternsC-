using DiveIntoDesignPatterns.Patterns.Builder;
using DiveIntoDesignPatterns.Patterns.Prototype;
using DiveIntoDesignPatterns.Patterns.Singleton;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // The client code creates a builder object, passes it to the
        // director and then initiates the construction process. The end
        // result is retrieved from the builder object.
        Console.WriteLine("-----Builder------");

        var director = new HouseDirector();
        var builder = new HouseWithWalls();
        director.HouseBuilder = builder;

        Console.WriteLine("Standard basic product:");
        director.BuildWalls();
        Console.WriteLine(builder.GetHouse().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullHouse();
        Console.WriteLine(builder.GetHouse().ListParts());

        // Remember, the Builder pattern can be used without a Director
        // class.
        Console.WriteLine("Custom product:");
        builder.BuildWalls();
        builder.BuildGarage();
        Console.Write(builder.GetHouse().ListParts());

        //Prototype
        Console.WriteLine("-----Prototype------");

        var gato = new Animal("Daisy", 4);
        var gatoCopy = gato.Clone();
        Console.WriteLine("Cat copy : " + gatoCopy.Name);

        //Singleton
        Console.WriteLine("-----Singleton------");
        var dbConnection = DatabaseConnection.GetInstance(); //Can't create a new Object
        Console.WriteLine("ConnectionString : " + dbConnection.ConnectionString);
    }
}