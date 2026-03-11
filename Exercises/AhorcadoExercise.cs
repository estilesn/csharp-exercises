using Domain;

namespace Exercises;

class AhorcadoExercise : IExercise
{
    public void Execute(){
        string word = "ozelot";
        int error = 0;
        int foundLetters = 0;
        //Stop the loop if the user finds the word or makes more than 5 errors
        while(error <= 5 && foundLetters < word.Length){
            Console.WriteLine("Escribe la letra:");
            string letter = Console.ReadLine();

            bool errors = false;
            
            for(int i = 0; i < word.Length; i++){
                if (letter[0] == word[i]){ 
                    errors = true;
                    foundLetters++;
                    Console.WriteLine("la letra {0} esta en la posicion: {1}", letter[0], i + 1);
                }
            } 

            if(errors == false){
            error++;
            Console.WriteLine("Errores:" + error);
            }
        }

        Console.WriteLine("La palabra era: {0} !!", word);
    }
}