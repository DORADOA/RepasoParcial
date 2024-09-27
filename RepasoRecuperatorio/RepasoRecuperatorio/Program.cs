using RepasoRecuperatorio;

class Program
{
    static void Main()
    {
        Flor flor1 = new Flor("rosas", 300);
        Flor flor2 = new Flor("margaritas", 200);
        ArregloFloral arreglo = new ArregloFloral();
        arreglo.flores.Add(flor1);
        arreglo.flores.Add(flor2);
        Pedido unPedido = new Pedido();
        unPedido.AgregarArreglo(arreglo);
        Cliente cliente = new Cliente("aquiles", unPedido);


        cliente.MostrarResumenPedido();

    }
    
}