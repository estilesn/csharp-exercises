using Domain;
using Exercises;

namespace Application;

public class ExerciseService{
    public void RunExercise(int option){
        IExercise exercise = null;

        switch(option){
            case 1:
                exercise = new PalindromoExercise();
                break;
            case 2:
                exercise = new CalculadoraEdadExercise();
                break;
            case 3:
                exercise = new ContraseñaExercise();
                break;
            case 4:
                exercise = new AhorcadoExercise();
                break;
            case 5:
                exercise = new FibonacciExercise();
                break;
            case 6:
                exercise = new CrudExercise();
                break;
            default:
                exercise = null;
                break;
        }

        exercise?.Execute();
    }
}