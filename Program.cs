using Primeiro;
using Classes;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            Pessoa person = new Pessoa();

            person.Nome = "Giovanna";
            person.Idade = 18;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Idade = 23;
            person2.Estado = "MG";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine("#########################");
            Console.WriteLine("ENUMS:");
            Console.WriteLine("Pessoa 0: " + pessoa1);
            Console.WriteLine("Pessoa 1: " + pessoa2);
            Console.WriteLine("Pessoa 2: " + pessoa3);
            Console.WriteLine("");
            Console.WriteLine("#########################");
            Console.WriteLine("ANIMAL:");
            Console.WriteLine("Nome: " + animal.Nome);
            Console.WriteLine("Dono: " + animal.NomeDono);
            Console.WriteLine("Espécie: " + animal.Especie);
            Console.WriteLine("");
            Console.WriteLine("#########################");
            Console.WriteLine("PERSON 1:");
            Console.WriteLine("Nome: " + person.Nome);
            Console.WriteLine("Idade: " + person.Idade);
            Console.WriteLine("Estado: " + person.Estado);
            Console.WriteLine("");
            Console.WriteLine("PERSON 2:");
            Console.WriteLine("Nome: " + person2.Nome);
            Console.WriteLine("Idade: " + person2.Idade);
            Console.WriteLine("Estado: " + person2.Estado);
            Console.WriteLine("");
            Console.WriteLine("#########################");
            Console.WriteLine("NAMESPACES:");
            Console.WriteLine(classe.GetType());
            Console.WriteLine(classe2.GetType());

        }
    }
}
