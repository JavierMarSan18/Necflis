using System;
using System.Collections.Generic;

namespace Necflis
{
	public class ListaCliente
	{
	
		List<Cliente> listaCliente = new List<Cliente>();
		
		public void agregarNuevoCliente(Cliente cliente)
		{
			PlayList playlist = new PlayList(cliente.nombre);
			
			cliente.indice = Convert.ToString(listaCliente.Count + 1);
			cliente.playList = playlist;
			listaCliente.Add(cliente);
			
			verListaCliente();
			
			Console.WriteLine("\n||---------------------------||");
			Console.WriteLine("||El cliente ha sido agregado||");
			Console.WriteLine("||---------------------------||");
			
			Console.ReadKey();
		}
		
		public void verListaCliente()
		{	
			Console.Clear();
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||     Lista de Clientes     ||");
			Console.WriteLine("||---------------------------||");
		
			if(listaCliente.Count > 0)
			{	
				foreach(var cliente in listaCliente)
				{
					Console.WriteLine($"  {cliente.indice}. {cliente.nombre}");
				}
			}
			else
			{
				Console.WriteLine("\n||---------------------------||");
				Console.WriteLine("||    La lista esta vacia    ||");
				Console.WriteLine("||---------------------------||");
			}
			
		}
		
		public int contarCliente()
		{
			return listaCliente.Count;
		}

		public Cliente seleccionarCliente()
		{
			Cliente cliente;
	
			string selCliente;
			int indice;
			
			while(true)
			{
				verListaCliente();
				Console.WriteLine("||---------------------------||");
				Console.WriteLine("||   Selecciona un cliente   ||");
				Console.WriteLine("||---------------------------||");
				selCliente = Console.ReadLine();
							
				if(int.TryParse(selCliente, out indice))
				{			
					if(indice >  0 && indice <= listaCliente.Count)
					{
						cliente = listaCliente[Convert.ToInt32(indice) - 1];
						return cliente;
					}
				}
							
			}
		}
	}
}





