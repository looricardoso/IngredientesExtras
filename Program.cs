using System;
using IngredientesExtras.db;
using System.Linq;

namespace IngredientesExtras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingredientes tipo Extra - Em ordem alfabética");
            using (var ingredientes = new hamburgueriaContext())
            {
                foreach(var ingredExtra in ingredientes.Ingrediente.Where(f => f.TipoIngredienteId == 3).OrderBy(ing => ing.Nome))
                {
                    Console.WriteLine($"Código: {ingredExtra.TipoIngredienteId} - Ingrediente: {ingredExtra.Nome}");
                }
            }
        }
    }
}
