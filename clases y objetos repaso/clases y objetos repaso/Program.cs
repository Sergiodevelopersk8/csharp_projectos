using System;

namespace clases_y_objetos_repaso
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person persona = new Person("Sergio",23,"Mexicano");

            /*creando objetos con la palabra reservada var el de arriba es un objeto pero sin herencia*/

            var persona = new SportyPerson("Sergio", 23, "Mexicano");
            Console.WriteLine(persona.show());
            persona.skate();
        }
    }


   abstract class Person 
    {

        public string name;

        public int age;

        public string nationality;

        /*constructor*/

       public Person(string name_, int age_, string nationality_)
        {

            name = name_;
            age = age_;
            nationality = nationality_;

        }

        public string show()
        {
            return name + " " + age + " " + nationality + " ";
        }

    }

    /*aplocando herencia */



    class SportyPerson : Person
    {
        /*con los dos puntos especifico que quiero heredar*/
    

       /* constructor de porsyperson*/
    

        /*para enviar al padre se usa igual dos puntos y despues ponemos la palabra reservada base con solo las variables del constructor*/
        public SportyPerson(string name_, int age_, string nationality_) : base(name_, age_,nationality_)
        {

        }

        public void skate()
        {
            Console.WriteLine(name + " sergio esta practicando skate");
        }

    }
}
