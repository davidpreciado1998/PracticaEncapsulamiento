using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de contacto
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "José García";
            contactoUno.Direccion = "Veracruz S/N";
            contactoUno.CorreoElectronico = "Josegarcia@correo.com";
            contactoUno.TelefonoCasa = "1234567890";
            contactoUno.TelefonoCelular = "9870";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Direccion: " + contactoUno.Direccion);
            Console.WriteLine("Correo: " + contactoUno.CorreoElectronico);
            Console.WriteLine("Tel. Casa: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Tel. Celular: " + contactoUno.TelefonoCelular);

            Console.ReadLine();
           
        }
    }
}
