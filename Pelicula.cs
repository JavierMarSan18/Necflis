using System;


namespace Necflis
{
	public class Pelicula
	{
		public string indiceListaPelicula;
		public string indicePlayList;
		public string nombre;
		public string tipo;
		public string genero;
		public string sinopsis;
		
		
		public void nuevaPelicula()
		{
			Console.Clear();
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||    CREAR NUEVA PELICULA   ||");
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Ingrese lo siguiente:      ||");
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Nombre:                    ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.nombre = Console.ReadLine();
			
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Tipo:                      ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.tipo = Console.ReadLine();
			
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Genero:                    ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.genero = Console.ReadLine();
			
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Sinopsis:                  ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.sinopsis = Console.ReadLine();
		}
	}
}






