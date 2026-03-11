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
            
            default:
                exercise = null;
                break;
        }

        exercise?.Execute();
    }
}