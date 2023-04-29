using System;
public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.WriteLine(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero <= 0)
        {   
            Console.WriteLine(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }

    public static int IngresarEnteroEnRango(string msj, int minimo, int maximo)
    {
        int entero;
        entero = IngresarEntero(msj);
        while (entero < minimo || entero > maximo)
        {
            entero = IngresarEntero("Error: Numero fuera del rango, " + msj);
        }
        return entero;
    }
     public static DateTime IngresarFecha(string msj)
    {
        DateTime fechaDate;
        string fechaCadena = IngresarTexto(msj);
        while (!DateTime.TryParse(fechaCadena, out fechaDate))
        {
            fechaCadena = IngresarTexto("ERROR! " + msj);
        }
        return fechaDate;
    }
    
    public static int AbonoTotal(int numero)
    {
        int aux = 0;
        switch(numero)
        {
            case 1:
            aux = 15000;
            break;
            case 2:
            aux = 30000;
            break;
            case 3:
            aux = 10000;
            break;
            case 4:
            aux = 40000;
            break;

        }
        return aux;
    }
    
    
    

}
