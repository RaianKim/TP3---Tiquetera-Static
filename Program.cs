using System.Threading;
List<string> estadisticas = new List<string>();
int aux = 0, respuesta = 0;
string porcent;
string recaudo;
while(respuesta != 5)
{
Console.Clear();
Console.WriteLine("1. Nueva Inscripción");
Console.WriteLine("2. Obtener Estadísticas del Evento");
Console.WriteLine("3. Buscar Cliente");
Console.WriteLine("4. Cambiar entrada de un Cliente");
Console.WriteLine("5. Salir");
respuesta = Funciones.IngresarEnteroEnRango("Escriba 1,2,3,4 o 5: ",1,5);
Console.Clear();
switch(respuesta)
{
case 1:
NuevaInscrip();
break;
case 2:
MostrarEstadistica();
break;

}

}
void NuevaInscrip()
{
int dni = Funciones.IngresarEntero("Ingrese su DNI");
string ape = Funciones.IngresarTexto("Ingresar su apellido ");
string nomb = Funciones.IngresarTexto("Ingrese su nombre "); 
DateTime fecha = Funciones.IngresarFecha("Ingrese la fecha de inscripcion dd/mm/yyyy");
Console.WriteLine("Opción 1 - Día 1 , valor a abonar $15000");
Console.WriteLine("Opción 2 - Día 2, valor a abonar $30000");
Console.WriteLine("Opción 3 - Día 3, valor a abonar $10000");
Console.WriteLine("Opción 4 - Full Pass, valor a abonar $40000");
int tipoEnt = Funciones.IngresarEnteroEnRango("Ingrese el tipo de entrada",1,4);
int TotalAbon = Funciones.AbonoTotal(tipoEnt);
Cliente cliente = new Cliente(dni,ape,nomb,fecha,tipoEnt,TotalAbon);
int aux = Ticketera.AgregarCliente(cliente);
Console.WriteLine($"se a agregado exitosamente al cliente N°{aux}");
Thread.Sleep(3000);
}
void MostrarEstadistica()
{
    estadisticas = Ticketera.MostarEstadisticas();
    
    for (int i = 0; i < estadisticas.Count; i++)
    {
        Console.WriteLine(estadisticas[i]);
    }
    Thread.Sleep(4000);
}
