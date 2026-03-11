using Domain;

namespace Exercises;



class ContraseñaExercise : IExercise
{
    //Generates a random password
    private string PasswordAlgorithm(int n){ 
    Random random = new Random();
    string mayus="QWERTYUIOPASDFGHJKLZXCVBNM";
    string minus = "qwertyuiopasdfghjklzxcvbnm";
    string nums = "0123456789";
    string specials = "!@#$%^&*";
    string all = mayus + minus + nums + specials;
    string password = "";

    password += mayus[random.Next(0, mayus.Length)];
    password += minus[random.Next(0, minus.Length)];
    password += nums[random.Next(0, nums.Length)];
    password += specials[random.Next(0, specials.Length)];

    while(password.Length < n){
        password += all[random.Next(0, all.Length)];
    } return password;
}
    
    public void Execute(){
        while(true){
            Console.WriteLine("Escribe la cantidad de digitos que quieres en tu contraseña:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<8){
                Console.WriteLine("La longitud minima es de 8 caracteres");
            }
            else{
                string password = PasswordAlgorithm(n);
                Console.WriteLine(password);
                break;
            }
        }
    }
}