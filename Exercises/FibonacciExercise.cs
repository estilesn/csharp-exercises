using Domain;

namespace Exercises;

class FibonacciExercise : IExercise
{
    public void Execute(){
        Console.WriteLine("Escribe cuantos digitos de Fibonacci deseas:");
        int n = Convert.ToInt32(Console.ReadLine());
        int next = 1;
        int previous = 0;
        
        for (int i = 0; i < n; i++){
        int temp = next + previous;
        next = previous;
        previous = temp;
        Console.Write(" " + next);
        }
    }
}