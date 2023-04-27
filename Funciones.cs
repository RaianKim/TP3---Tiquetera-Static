using System;
public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero <= 0)
        {   
            Console.Write(msj);
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
    public static void NumAbonoTotal(int Numero,int aux1,int aux2, int aux3, int aux4)
    {
    
       switch(Numero)
       {
        case 1:
            aux1++;
        break;
        case 2:
            aux2++;
        break;
        case 3:
            aux3++;
        break;
        case 4:
            aux4++;
        break;


       }

    }

    private static string sePuedeoNO(int a, int b)
    {
        string c;
        if(a == 0 || b == 0)
        {
            c = "Nada";
        }
        else
        {
            c = (a/b).ToString();
        }
        return c;
    }
    
    public static string porcentaje(int UltimoIDEntrada,int aux1,int aux2, int aux3, int aux4)
    {
        
        string aux = "Opcion 1 = "+ sePuedeoNO(aux1,UltimoIDEntrada) + "%, Opcion 2 = "+ sePuedeoNO(aux2,UltimoIDEntrada) + "%, Opcion 3 = "+ sePuedeoNO(aux3,UltimoIDEntrada) +"%, Opcion 4 = "+ sePuedeoNO(aux4,UltimoIDEntrada)+"%";
        return aux;
    }
    public static string recaudoCadaTipo(int aux1,int aux2, int aux3, int aux4)
    {
        string aux = $"Opcion 1 = {aux1}, Opcion 2 = {aux2}, Opcion 3 = {aux3}, Opcion 4 = {aux4}";
        return aux;
    }

}
