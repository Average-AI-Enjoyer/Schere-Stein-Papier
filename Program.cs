// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;

namespace Program;

public class Program() {
    static void Main(string[] args){
        Console.WriteLine("Wilkommen Benutzer zu Schere, Stein, Papier!");
        Console.WriteLine("Möchtest du einen Namen wählen? (j/n) ");
        string? choice1 = Console.ReadLine();
        string? name, choiceName;
        if(choice1 == "j"){
            do
            {
            Console.WriteLine("Dann wähle deinen Namen! ");
            name = Console.ReadLine();
            Console.WriteLine(name + ", ist das so richtig? (j/n) ");
            choiceName = Console.ReadLine();
            
            }
            while(choiceName != "j");
            Console.WriteLine("Wilkommen " + name + "!");
        }
        else if(choice1 == "n"){
            
            name = "Benutzer";
            Console.WriteLine("Dann wird dir der Name \""+name+"\" zugeteilt");
        }    
        else if (choice1 != "j" && choice1 != "n"){
            Console.WriteLine("Ich habe das leider nicht verstanden...");
            name = "Benutzer";
            Console.WriteLine("Dann wird dir der Name \""+name+"\" zugeteilt");
        }
        else {
            
        }
    }
}
