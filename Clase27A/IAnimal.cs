using System.Threading.Tasks.Dataflow;

public interface IAnimal{
    void Comer();
    void Correr();
}
public interface IAves {
    void Volar();
    void Picotear();
}
public class Pinguino: IAnimal, IAves {
    public double peso, tamanio;
    public void Comer(){
        Console.WriteLine("El pingüino está comiendo");
    }
    public void Correr(){
        Console.WriteLine("El pingüino está corriendo");
    }
    public void Volar(){
        Console.WriteLine("El pingüino no vuela");
    }
    public void Picotear(){
    Console.WriteLine("El pingüino picotea");
    }
}
public class Canario: IAves {
    public string color = "", nombre = "";
    public void Volar(){
        Console.WriteLine("El canario está volando");
    }
    public void Picotear(){
        Console.WriteLine("El canario picotea");
    }
    public void Cantar(){
        Console.WriteLine("El canario está cantando");
    }
}