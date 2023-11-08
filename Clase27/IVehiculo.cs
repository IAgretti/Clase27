public interface IVehiculo {
    void RegistrarV();
}
public class Vehiculo: IVehiculo {
    public int Modelo {get; set;} = 0;
    public string Color {get; set;} = "";
    public string Marca {get; set;} = "";
    public double Precio {get; set;} = 0.0;

    public void RegistrarV(){
        try {
            Console.Write("Ingrese el modelo del vehículo: ");
            Modelo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el color del vehículo: ");
            Color = Console.ReadLine();
            Console.Write("Ingrese la marca del vehículo: ");
            Marca = Console.ReadLine();
        }catch (Exception){
            Console.WriteLine("Error de ingreso de datos");
        }
    }
    public void Imprimir(){
        Console.WriteLine("**************************");
        Console.WriteLine("El modelo del vehículo es: " + Modelo);
        Console.WriteLine("Su color es: " + Color);
        Console.WriteLine("Y su marca es: " + Marca);
        Console.WriteLine("***************************\n");
    }
}
public class Bicicleta: Vehiculo, IVehiculo {
    public void RegistrarV(){
        try {
            Console.Write("Ingrese el color de la bici: ");
            Color = Console.ReadLine();
            Console.Write("Ingrese el precio de la bici: ");
            Precio = Convert.ToDouble(Console.ReadLine());
        }catch (Exception){
            Console.WriteLine("Error de ingreso de datos");
        }
    }
    public void ImprimirB(){
        Console.WriteLine("**************************");
        Console.WriteLine("La bici es de color: " + Color);
        Console.WriteLine("Y su precio es $: " + Precio.ToString("0.00"));
        Console.WriteLine("***************************\n");
    }
}
public class Pantalla{
    public void Formato(){
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("***********************************\n");
    }
}