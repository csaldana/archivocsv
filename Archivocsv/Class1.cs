/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 19/10/2013
 * Time: 04:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivocsv
{
	
	public class Archivo
	{
	string RutaArchivo;	
	public void LeerArchivo(){
		Console.WriteLine("Ingresa ruta del archivo a buscar");
		this.RutaArchivo = Console.ReadLine();
	}
	public Boolean VerificarRuta(){
		Boolean ArchivoExiste;
		if(File.Exists(this.RutaArchivo))
		ArchivoExiste = true;
		else
		ArchivoExiste = false;
		return ArchivoExiste;
	}
	public void VerificarArchivo()
	{
		if(VerificarRuta())
			if(Path.GetExtension(this.RutaArchivo) == ".csv")
				Console.WriteLine("\n Tu archivo si es .CSV");
	else
Console.WriteLine("\nTu archivo no tiene la extensión .CSV  " + Path.GetExtension(this.RutaArchivo));

	
	}
	
	public List<string[]> ObtenerContenido(){
		
	 List<string[]> csvarreglo = new List<string[]>();
	try
	{
		string linea;
		string[] row;
		StreamReader readFile =  new StreamReader(this.RutaArchivo);
		while ((linea = readFile.ReadLine()) != null)
		{
			row = linea.Split(',');
			csvarreglo.Add(row);
		}
		
	}
	catch(Exception e){
		Console.WriteLine("\nEl Archivo no existe..\n",e);	
	}
	return csvarreglo;
	}
	}
}

