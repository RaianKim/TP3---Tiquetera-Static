public static class Ticketera
{

    static private Dictionary<int,Cliente> DicClientes = new Dictionary<int,Cliente>();
    static private int UltimoIDEntrada = 1;
    public static int DevolverUltimoID()
    {
       return DicClientes.Keys.Last();
    }
    public static int AgregarCliente(Cliente cliente)
    {
        UltimoIDEntrada=DevolverUltimoID();
        UltimoIDEntrada++;
        DicClientes.Add(UltimoIDEntrada,cliente);
        return UltimoIDEntrada;
    }
    static public List<string> EstadisticasTicketera = new List<string>();
    
    private static void cantClientes()
    {
     int aux1 = DicClientes.Count();
     string aux2 = aux1.ToString();
     EstadisticasTicketera.Add(aux2);
    }
    
    

}