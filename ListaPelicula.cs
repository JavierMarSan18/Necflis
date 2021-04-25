using System;
using System.Collections.Generic;

namespace Necflis
{
	public class ListaPelicula
	{
	
		List<Pelicula> listaPelicula = new List<Pelicula>();
		
		public void agregarNuevaPelicula(Pelicula pelicula)
		{
			pelicula.indiceListaPelicula = Convert.ToString(listaPelicula.Count + 1);
			listaPelicula.Add(pelicula);
			
			verListaPelicula();
			
			Console.WriteLine("\n||----------------------------||");
			Console.WriteLine("||La pelicula ha sido agregada||");
			Console.WriteLine("||----------------------------||");
			
			Console.ReadKey();
		}
		
		public void verListaPelicula()
		{
			Console.Clear();
			
			Console.WriteLine("||----------------------------||");
			Console.WriteLine("||     Lista de Peliculas     ||");
			Console.WriteLine("||----------------------------||");
			
			foreach(var pelicula in listaPelicula)
			{
				Console.WriteLine($"  {pelicula.indiceListaPelicula}. {pelicula.nombre}");
			}
		}
		
		public int contarPelicula()
		{
			return listaPelicula.Count;
		}
		
		public Pelicula seleccionarPelicula()
		{	
			Pelicula pelicula;

			string selPelicula;
			int indice;
			while(true)
			{
				verListaPelicula();
				Console.WriteLine("||----------------------------||");
				Console.WriteLine("||  Selecciona una Pelicula   ||");
				Console.WriteLine("||----------------------------||");
				Console.WriteLine("||Ingresa 0 para volver       ||");
				Console.WriteLine("||--------------------------- ||");
				selPelicula = Console.ReadLine();
								
				if(int.TryParse(selPelicula, out indice))
				{			
					if(indice >  0 && indice <= listaPelicula.Count)
					{
						pelicula = listaPelicula[Convert.ToInt32(indice) - 1];
						return pelicula;
					}
					else if(indice == 0)
					{
						pelicula = listaPelicula[Convert.ToInt32(indice) + 1];
						return pelicula;
					}
				}					
			}
		}
	}
}