using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivocsv
{
	class Program
	{
		public static void Main(string[] args)
		{
			Archivo c = new Archivo();
			c.LeerArchivo();
			c.VerificarArchivo();
			List<string[]> miarreglo = c.ObtenerContenido();
			foreach(string[] array in miarreglo){//mostrar contenido
				Console.WriteLine("ID:" + array[0] 
				                  + "\nNombre:" + array[1] 
				                  +"\nDireccion:" + array[2] 
				                  +"\nTelefono:" + array[3]);
			}
				
			Console.ReadKey(true);
		}
	}
}