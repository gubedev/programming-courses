using System;

namespace InheritanceAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var jugadorMediocampista = new Player() { };

            var medico = new Profesional() { };

            Console.ReadLine();
        }
    }

    class Player : Person
    {
        public override string GetAlgo()
        {
            throw new NotImplementedException();
        }
    }

    class Agent : Person
    {
        public override string GetAlgo()
        {
            throw new NotImplementedException();
        }
    }

    class Profesional : Person
    {
        public override string GetAlgo()
        {
            throw new NotImplementedException();
        }
    }

    abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string GetFullName ()
        {
            return FirstName + " " + LastName;
        }

        public abstract string GetAlgo();
    }

}


