namespace Clase27A;

class Program
{
    static void Main(string[] args)
    {
        Pinguino p = new Pinguino();
        Canario c = new Canario();

        p.tamanio = 120.5;
        p.peso = 15.10;
        Console.WriteLine("El pingüino tiene un tamaño de " + p.tamanio + "cm. y un peso de " + p.peso + " Kg.");
        p.Comer();
        p.Correr();
        p.Volar();
        p.Picotear();

        c.nombre = "Pipo";
        c.color = "Amarillo";
        Console.WriteLine("El canario se llama " + c.nombre + " y su color es " + c.color);
        c.Volar();
        c.Picotear();
        c.Cantar();

        Console.ReadKey();
    }
}
