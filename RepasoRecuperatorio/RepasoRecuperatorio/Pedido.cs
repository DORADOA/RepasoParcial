namespace RepasoRecuperatorio
{
    public class Pedido
    {
        public List<ArregloFloral> arreglosFlorales;
        public Pedido() => arreglosFlorales = new List<ArregloFloral>();
      

        
        public void AgregarArreglo(ArregloFloral arreglo)
        {
            arreglosFlorales.Add(arreglo);
        }
        public double CantidadPedido()
        {
            double acum1 = 0;
            foreach (var ArregloFloral in arreglosFlorales)
            {
                acum1 += ArregloFloral.ObtenerCostoArreglo();
            }
            return acum1;
        }

        public void CantidadFlores()
        {
            foreach (var ArregloFloral in arreglosFlorales)
            {
                foreach (var flor in arreglosFlorales)
                {
                    Console.WriteLine($"{ArregloFloral.flores}");
                }

            }
        }
    }
}
