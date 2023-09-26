using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSecondBlock
{
    internal class Animal
    {
        private String _name;
        private String _species;
        int _age;

        public Animal(String name, String species, int age)
        {
            this._name = name;
            this._species = species;
            this._age = age;
        }
        public override string ToString()
        {
            return $"Кличка: {_name}, Животное: {_species}, Возраст: {_age}".ToString();
        }
    }

}
