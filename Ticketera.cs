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
    public static List<string> MostarEstadisticas()
    {
        int AbonoTotal= 0;
        string porcentaje = "";
        string cantidadCadaTipo = "";
        List<string> estadisticas = new List<string>();
        estadisticas.Add($"Se han inscripto {DicClientes.Count()} clientes");
        int[] recaudacionTipo = {0,0,0,0,0};
        foreach (int id in DicClientes.Keys)
        {
            recaudacionTipo[DicClientes[id].TipoEntrada]++;
            AbonoTotal = DicClientes[id].TotalAbonado + AbonoTotal;
        }
        
        for (int i = 1; i < DicClientes.Count()+1; i++)
        {
            if(recaudacionTipo[i] == 0)
            {
                porcentaje = porcentaje + "| Tipo " + (DicClientes[i].TipoEntrada) + "°: 0%";
            }
            else
            {
                porcentaje = porcentaje + "| Tipo "+ (DicClientes[i].TipoEntrada) +"° :"+((recaudacionTipo[i] / DicClientes.Count())*100) + "%";
            }
            cantidadCadaTipo = cantidadCadaTipo + "| Tipo "+ (DicClientes[i].TipoEntrada) +"° :" + recaudacionTipo[i] + "%";
        }
        Console.WriteLine("aweqwe" + porcentaje);
        estadisticas.Add($"Porcentaje de cantidad de  entradas vendidas diferenciadas por tipo respecto al total: {porcentaje}");
        estadisticas.Add($"Recaudación de cada tipo: {cantidadCadaTipo}");
        estadisticas.Add($"Recaudación total: ${AbonoTotal}");
        return estadisticas;
    }
    
    
    
   
}
