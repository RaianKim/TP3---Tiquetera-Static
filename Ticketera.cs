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
    public static Cliente  BuscarCliente(int IDEntrada)
    {
        int dni = 0;
        string ape = ""; 
        string nomb = "";
        DateTime fecha = new DateTime();
        int tipoEnt = 0;
        int TotalAbon = 0;
        bool estaONo = false;        
            if(DicClientes.Keys.Contains(IDEntrada))
            {
                estaONo = true;
                dni = DicClientes[IDEntrada].DNI;
                ape = DicClientes[IDEntrada].Apellido;
                nomb = DicClientes[IDEntrada].Nombre;
                fecha = DicClientes[IDEntrada].FechaInscripcion;
                tipoEnt = DicClientes[IDEntrada].TipoEntrada;
                TotalAbon = DicClientes[IDEntrada].TotalAbonado;        
            }
        Cliente cliente = new Cliente(dni,ape,nomb,fecha,tipoEnt,TotalAbon);
        Console.WriteLine(cliente);
        return cliente;
        
    }

    public static bool CambiarEntradaDeUnCliente(int id,int tipo, int total)
    {
        bool aux = false;
        if(DicClientes[id].TotalAbonado > total)
        {
            DicClientes[id].TipoEntrada = tipo;
            DicClientes[id].TotalAbonado = total;
            DicClientes[id].FechaInscripcion = DateTime.Today;
            aux = true;
        }
        return aux;
    }
    public static List<string> MostarEstadisticas()
    {
        int AbonoTotal= 0;
        List<string> estadisticas = new List<string>();
        estadisticas.Add($"Se han inscripto {DicClientes.Count} clientes");
        int[] recaudacionTipo = {0,0,0,0,0};
        double[] recaudacionPorcentaje = {0,0,0,0,0};
        foreach (int id in DicClientes.Keys)
        {
            recaudacionTipo[DicClientes[id].TipoEntrada]++;
            AbonoTotal = DicClientes[id].TotalAbonado + AbonoTotal;
        }
        
        for (int item = 1; item  < recaudacionPorcentaje.Length; item++)
        {
            if(DicClientes.Count >= 1)recaudacionPorcentaje[item] = recaudacionTipo[item]*100/DicClientes.Count();        
        }
        
        estadisticas.Add("Porcentaje de cantidad de entradas : | Tipo 1: " + recaudacionPorcentaje[1] + "% | Tipo 2:" + recaudacionPorcentaje[2] + "% | Tipo 3:" + recaudacionPorcentaje[3] + "% | Tipo 4:" + recaudacionPorcentaje[4] + "%") ;
        estadisticas.Add("Recaudación de cada tipo: | Tipo 1: "+ recaudacionTipo[1] + " | Tipo 2: "+recaudacionTipo[2] + " | Tipo 3:" +recaudacionTipo[3] +  " | Tipo 4:" + recaudacionTipo[4]);
        estadisticas.Add($"Recaudación total: ${AbonoTotal}");
        return estadisticas;
    }
    
    
    
   
}
