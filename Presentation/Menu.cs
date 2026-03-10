using Application;
namespace Presentation;

public class Menu{
    public void Show(){
        var service = new ExerciseService();

        while(true){
            Console.Clear();
            Console.WriteLine("Elige el ejercicio:");
            Console.WriteLine("1.- Palindromo");
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