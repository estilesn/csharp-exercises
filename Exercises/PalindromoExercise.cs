using Domain;

namespace Exercises;

class PlalindromoExercise : IExercise
{
    public void Execute(){
        Console.WriteLine("Ingresa la palabra:");
        string word = Console.ReadLine();

        bool palindromo = true;
        int j = word.Length - 1;

        //Compare characters from start and the end of the word.
        for(int i = 0; i < word.Length; i++){
            if (word[i] == word[j]){ 
                j--;
            } 
            else{
                palindromo=false;
                break;
            }
        }

        if (palindromo == false){
            Console.WriteLine("{0} no es palindromo", word);
        }
        else{
            Console.WriteLine("{0} es palindromo", word);
        }
    }
}