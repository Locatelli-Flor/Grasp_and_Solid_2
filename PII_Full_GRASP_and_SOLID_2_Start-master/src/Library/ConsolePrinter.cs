using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    // Para implementar este cambio se utiliza el pricipio SRP ya que estamos independizando a la clase recipe de imprimir la receta.
    }
}