using Domain;
using Exercises;

namespace Application;

public class ExerciseService{
    public void RunExercise(int option){
        IExercise exercise = null;

        switch(option){
            case 1:
                exercise = new PlalindromoExercise();
                break;
            default:
                exercise = null;
                break;
        }

        exercise?.Execute();
    }
}