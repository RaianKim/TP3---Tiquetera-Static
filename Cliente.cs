class Cliente

{
public int DNI{get; private set;}
public string Apellido{get; private set;}
public string Nombre{get; private set;}
public DateTime FechaInscripcion{get;set;}
public int TipoEntrada{get;set;}
public int TotalAbonado{get;set;}

public Cliente()
{


} 

public Cliente(int dni, string ape, string nomb, DateTime fecha, int tipoEnt, int TotalAbon)
{
    DNI = dni;
    Apellido = ape;
    Nombre = nomb;
    FechaInscripcion = fecha;
    TipoEntrada = tipoEnt;
    TotalAbonado = TotalAbon;

}

}

