using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoDesignPatterns.Patterns.Prototype
{
    public class Animal : IAnimalPrototype
    {
        public Animal(Animal animal) {
            Name = animal.Name; 
            Age = animal.Age;   
        }
        public Animal(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age {  get; set; }
        public Animal Clone()
        {
            return new Animal(this);
        }
    }
}
