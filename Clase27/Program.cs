using System.Globalization;

namespace Clase27;

class Program
{
    static void Main(string[] args)
    {
        Vehiculo v = new Vehiculo();
        Bicicleta b = new Bicicleta();
        Pantalla p = new Pantalla();

        p.Formato();
        v.RegistrarV();
        v.Imprimir();
        b.RegistrarV();
        b.ImprimirB();
        Console.ReadKey();
    }
}
