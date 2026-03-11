using Domain;

namespace Exercises;

class CrudExercise : IExercise
{
    class User{
        public int Id {get;set;}
        public string Name {get;set;}
        public int Age {get;set;}
        public string Password {get;set;}
    }
    

    private List<User> Users = new List<User>();
    private int IdCont = 1;
    public void Execute(){
        while(true){
            Console.WriteLine("1.- Crear usuario");
            Console.WriteLine("2.- Editar usuario");
            Console.WriteLine("3.- Eliminar usuario");
            Console.WriteLine("4.- Listar usuario");
            Console.WriteLine("0.- Salir");
            int option = (Convert.ToInt32(Console.ReadLine()));

            if (option == 0){
                break;
            }
            Console.Clear();
            switch(option){
                case 1:
                    AddUser();
                    break;
                case 2:
                    EditUser();
                    break;
                case 3:
                    DeleteUser();
                    break;
                case 4:
                    ListUsers();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void AddUser(){
        Console.WriteLine("Nombre:");
        string name = Console.ReadLine();
        Console.WriteLine("Edad:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Contraseña:");
        string password = Console.ReadLine();

        Users.Add(new User{
            Id = IdCont++,
            Name = name,
            Age = age,
            Password = password,
        });

        Console.WriteLine("Usuario creado");
        ListUsers();
    }

    private void EditUser(){
        Console.WriteLine("Ingresar ID del usuario a editar:");
        int id = Convert.ToInt32(Console.ReadLine());
        
        User user = null;
        foreach(var u in Users){
            if (u.Id == id){
                user = u;
                break;
            }
        }

        if (user != null){
        Console.WriteLine("Nuevo nombre:");
        user.Name = Console.ReadLine();
        Console.WriteLine("Nueva edad:");
        user.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nueva contraseña:");
        user.Password = Console.ReadLine();
        
        Console.WriteLine("Usuario editado");
        }
        else{
            Console.WriteLine("Usuario no existe");
        }
        ListUsers();
    }

    private void DeleteUser(){
        Console.WriteLine("Ingresar ID del usuario a eliminar:");
        int id = Convert.ToInt32(Console.ReadLine());
        
        User user = null;
        foreach(var u in Users){
            if (u.Id == id){
                user = u;
                break;
            }
        }

        if (user != null){
            Users.Remove(user);
            Console.WriteLine("Usuario eliminado");
        }
        else{
            Console.WriteLine("Usuario no existe");
        }

        ListUsers();
    }

    private void ListUsers(){
            Console.WriteLine("Lista de todos los usuarios:");

            foreach(var u in Users){
                Console.WriteLine("id: {0} -- Nombre: {1} -- Edad: {2} -- Contraseña: {3}", u.Id, u.Name, u.Age, u.Password );
            }
        }
}