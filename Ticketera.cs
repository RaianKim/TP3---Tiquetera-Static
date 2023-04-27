public static class Ticketera
{

    static private Dictionary<int,Cliente> DicClientes = new Dictionary<int,Cliente>();
    static private int UltimoIDEntrada = 1;
    public static int DevolverUltimoID()
    {
       int aux = 1;
       if(DicClientes.Count() > 0)
       {
        aux = DicClientes.Keys.Last();
       }
       return aux;
    }
    public static int AgregarCliente(Cliente cliente)
    {
        
        if(UltimoIDEntrada != 1 || DicClientes.Count() >= 1)
        {UltimoIDEntrada++;}
        DicClientes.Add(UltimoIDEntrada,cliente);
        return UltimoIDEntrada;
    }
   public static List<string> EstadisticasTicketera = new List<string>();
}
