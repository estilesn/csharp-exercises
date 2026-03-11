using Application;
namespace Presentation;

public class Menu{
    public void Show(){
        var service = new ExerciseService();

        while(true){
            Console.Clear();
            Console.WriteLine("Elige el ejercicio:");
            Console.WriteLine("1.- Palindromo");
            Console.WriteLine("2.- Calcular edad");
            Console.WriteLine("3.- Generar contraseña");
            Console.WriteLine("4.- Ahorcado");
            Console.WriteLine("5.- Fibonacci");
            Console.WriteLine("6.- Crea, enlista, actualiza y crea usuarios");
            Console.WriteLine("0.- Salir");
            int option = Convert.ToInt32(Console.ReadLine());
            
            if(option == 0){
                break;
            }

            service.RunExercise(option);
            Console.ReadKey();
        }
    }
}