using System;
using System.Collections.Generic;


namespace Necflis
{
	public class Cliente
	{	
		public string indice;
		public string nombre;
		public string direccion;
		public string edad;
		public PlayList playList;
		
		public void nuevoCliente()
		{
			Console.Clear();
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||    CREAR NUEVO CLIENTE    ||");
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Ingrese lo siguiente:      ||");
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Nombre:                    ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.nombre = Console.ReadLine();
			
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Dirección:                 ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.direccion = Console.ReadLine();
			
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||Edad:                      ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			this.edad = Console.ReadLine();
		}
	}
}






