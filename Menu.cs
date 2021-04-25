using System;


namespace Necflis
{
	public class Menu
	{
		ListaCliente listaCliente = new ListaCliente();
		ListaPelicula listaPelicula = new ListaPelicula();
		public string op;
		
		public bool mostrarMenuPrincipal()
		{
			bool salir = false;
			
			Console.Clear();
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||   BIENVENIDO A NECFLIS    ||");
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||1. Clientes                ||");
			Console.WriteLine("||2. Películas               ||");
			Console.WriteLine("||3. Salir                   ||");
			Console.WriteLine("||---------------------------||");
			Console.Write(".:");
			op = Console.ReadLine();
			
			switch(op)
			{
				case "1":
					mostrarMenuCliente();
					break;
				case "2":
					mostrarMenuPelicula();
					break;
				case "3":
					salir = true;
					break;
			}
			Console.Clear();
			return salir;
		}
		
		public void mostrarMenuCliente()
		{	
			while(true)
			{	Console.Clear();
				Console.WriteLine("||---------------------------||");
				Console.WriteLine("||    BIENVENIDO A NECFLIS   ||");
				Console.WriteLine("||---------------------------||");
				Console.WriteLine("||1. Ver listado de clientes ||");
				Console.WriteLine("||2. Crear nuevo cliente     ||");
				Console.WriteLine("||3. Seleccionar cliente     ||");
				Console.WriteLine("||4. Atras                   ||");
				Console.WriteLine("||---------------------------||");
				Console.Write(".:");
				op = Console.ReadLine();
				
				switch(op)
				{
					case "1"://Ver lista de Clientes
						listaCliente.verListaCliente();
						Console.ReadKey();
						break;
					case "2"://Agregar nuevo Cliente
						Cliente cliente = new Cliente();
						cliente.nuevoCliente();
						listaCliente.agregarNuevoCliente(cliente);
						break;
					case "3"://Seleccionar Cliente
						if(listaCliente.contarCliente() > 0)
						{
							mostrarMenuPlayList(listaCliente.seleccionarCliente());
						}
						break;
					case "4":
						Console.Clear();
						return;
				}
			}
		}
		
		public void mostrarMenuPelicula()
		{
			while(true)
			{	Console.Clear();
				Console.WriteLine("||---------------------------||");
				Console.WriteLine("||    BIENVENIDO A NECFLIS   ||");
				Console.WriteLine("||-------------------- ------||");
				Console.WriteLine("||1. Ver listado de peliculas||");
				Console.WriteLine("||2. Crear pelicula          ||");
				Console.WriteLine("||3. Atras                   ||");
				Console.WriteLine("||---------------------------||");
				Console.Write(".:");
				op = Console.ReadLine();
				
				switch(op)
				{
					case "1"://Ver lista de peliculas
						listaPelicula.verListaPelicula();
						Console.ReadKey();
						break;
					case "2"://Agregar nueva pelicula
						Pelicula pelicula = new Pelicula();
						pelicula.nuevaPelicula();
						listaPelicula.agregarNuevaPelicula(pelicula);
						break;
					case "3"://Atras
						return;
				}
			}
		}
		
		public void mostrarMenuPlayList(Cliente cliente)
		{
			while(true)
			{	Console.Clear();
				
				Console.WriteLine("||---------------------------||");
				Console.WriteLine("||        BIENVENIDO         ||");
				Console.WriteLine("||---------------------------||");
				Console.WriteLine($" Nombre: {cliente.nombre}");
				Console.WriteLine($" Direccion: {cliente.direccion}");
				Console.WriteLine($" Edad: {cliente.edad}");

				Console.WriteLine("||---------------------------||");
				Console.WriteLine("||1. PlayList                ||");
				Console.WriteLine("||2. Agregar Película        ||");
				Console.WriteLine("||3. Atras                   ||");
				Console.WriteLine("||---------------------------||");
				Console.Write(".:");
				op = Console.ReadLine();
				
				switch(op)
				{
					case "1":
						cliente.playList.verPlayList();
						Console.ReadKey();
						break;
					case "2":
						if(listaPelicula.contarPelicula() > 0)
						{
							try
							{
								cliente.playList.agregarNuevaPelicula(listaPelicula.seleccionarPelicula());
							}
							catch{}
						}
						else
						{
							Console.WriteLine("\n||---------------------------||");
							Console.WriteLine("||    LA LISTA ESTA VACIA    ||");
							Console.WriteLine("||---------------------------||");
						}
						break;
					case "3":
						return;
				}
			}
		}
	}
}