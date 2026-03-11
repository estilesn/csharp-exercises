using Domain;

namespace Exercises;

class CalculadoraEdadExercise : IExercise
{
    public void Execute(){
        //Singular variables represent the exact birth date and plural variables represent the elapsed time
        Console.WriteLine("Calculemos tu edad exacta...");
        Console.WriteLine(" Escribe tu año de nacimiento:");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Escribe tu numero de mes de nacimiento:");
        int birthMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Escribe tu dia de nacimiento:");
        int birthDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Escribe tu hora de nacimiento:");
        int birthHour = Convert.ToInt32(Console.ReadLine());
        

        DateTime now = DateTime.Now;
        int yearsElapsed = now.Year - birthYear;
        int monthsElapsed = now.Month - birthMonth;
        int daysElapsed = now.Day - birthDay;
        int hoursElapsed = now.Hour - birthHour;

        // If the value is negative, recalculate so the result isnt negative
        if (monthsElapsed < 0){
            yearsElapsed--;
            monthsElapsed +=12;
        }
        if(daysElapsed < 0){
            int lastMonthDay = DateTime.DaysInMonth(now.Year, now.Month == 1 ? 12 : now.Month - 1);
            monthsElapsed--; 
            daysElapsed += lastMonthDay;
        }
        if(hoursElapsed < 0){
            hoursElapsed += 24;
            daysElapsed--;
        }   


        Console.WriteLine("Tiempo transcurrido desde que naciste: {0} años {1} meses y {2} dias con {3} horas", yearsElapsed, monthsElapsed, daysElapsed, hoursElapsed);
    }
}