using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_FEB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();            
            cliente.cliente();

            

        }
    }
}


class Inmueble
{
    public string NombreInmueble;
    public string TipoInmueble;
    public string Direccion;
    
    
    public void inmue()
    {
        Console.WriteLine("Escriba nombre del inmueble: ");
        NombreInmueble= Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Escriba el tipo de inmueble: ");
        TipoInmueble= Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Escriba la direccion donde se encuentra el inmueble. ");
        Direccion= Console.ReadLine();
        Console.Clear();

    }

  

  

    
}


class Cliente:Inmueble
{
    public string NombreCliente;
    public string TipoCliente;
    public int Plazos;
    public string Vendedor= "WAKAMALLA VERDE";

   

    public void cliente()
    {
        Console.WriteLine("Escriba el nombre del cliente: ");
        NombreCliente= Console.ReadLine();
        Console.Clear();        
        Console.WriteLine("Escriba el tipo de cliente (Credito o Contado): ");
        TipoCliente = Console.ReadLine();
        Console.Clear();
        if (TipoCliente == "Credito"||TipoCliente=="credito")
        {
            Console.WriteLine("Escriba la cantidad de cuotas: ");
            Plazos= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
        }
        
        inmue();

        Console.WriteLine("-------------------------------------------\n");
        Console.WriteLine("                    RESUMEN                -  \n");
        Console.WriteLine("                                           -\n");
        Console.WriteLine("Nombre de cliente: "+NombreCliente+"\n");
        Console.WriteLine("Tipo de Cliente: "+TipoCliente+"\n");
        if (TipoCliente == "Credito")
        {
            Console.WriteLine("Adquirio el inmueble durante: " + Plazos + " Plazos\n");
        }
       

        Console.WriteLine("Nombre del inmueble: "+NombreInmueble+ "\n");
        Console.WriteLine("Tipo del inmueble: " + TipoInmueble + "\n");
        Console.WriteLine("La direccion del inmueble es: "+Direccion+ "\n");
        Console.WriteLine("Vendedor asignado: "+ Vendedor+"\n");
        

        Console.WriteLine("-------------------------------------------");
        Console.ReadKey();
    }


}

