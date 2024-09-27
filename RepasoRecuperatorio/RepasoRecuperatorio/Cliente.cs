namespace RepasoRecuperatorio
{
    public class Cliente
    {
        public string Nombre {  get; private set; }
        public Pedido pedido { get; private set; }

        public Cliente(string nombre, Pedido pedido) 
        {
            Pedido nuevoPedido = new Pedido();
            Cliente cliente = new Cliente("Aquiles", nuevoPedido);
        }

        public void MostrarResumenPedido()
        {
            Console.WriteLine($"Cliente: {Nombre}");
            Console.WriteLine($"su pedido de: {pedido.CantidadFlores}");
            Console.WriteLine($"Con un costo de: {pedido.CantidadPedido}");
        }
    }
}
