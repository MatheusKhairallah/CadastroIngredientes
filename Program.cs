using System;
using CadastroIngredientes.db;
using System.Linq;

namespace CadastroIngredientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastre um novo ingrediente em nossa hamburgueria.");
            Console.WriteLine("---Pressione qualquer tecla para continuar---");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite o nome do ingrediente: ");
            string nome= Console.ReadLine();

            Console.WriteLine("Digite o tipo do ingrediente");
            Console.Write("Tipo 1= Pão; Tipo 2= Carne; Tipo 3= Extra (Digite somente o número): ");
            int tipo=Convert.ToInt16(Console.ReadLine());

            using (var db= new hamburgueriaContext())
            {
                var novoIngrediente= new Ingrediente
                {
                    Id= Guid.NewGuid().ToString(),
                    Nome= nome,
                    TipoIngredienteId= tipo,
                };
                db.Ingrediente.Add(novoIngrediente);
                db.SaveChanges();
            }
        }
    }
}
