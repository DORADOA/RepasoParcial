namespace RepasoRecuperatorio
{
    public class ArregloFloral
    {
        public List<Flor> flores;

        public ArregloFloral()
        {
            flores = new List<Flor>();
        }
        public double ObtenerCostoArreglo()
        {
            double acum = 0;
            foreach (var flor in flores)
            {
                acum += flor.Costo;
            }
            if (flores.Count > 5)
            {
                return acum - 0.10;
            }
            return acum;           

        }
    }
}
