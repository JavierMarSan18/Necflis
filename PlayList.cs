using System;
using System.Collections.Generic;

namespace Necflis
{
	public class PlayList
	{
	
		List<Pelicula> playList = new List<Pelicula>();
		public string nombre;
		
		public PlayList(string nombre)
		{
			this.nombre = nombre;
		}
		
		public void agregarNuevaPelicula(Pelicula pelicula)
		{
			if(!(playList.Contains(pelicula)))
			{
				pelicula.indicePlayList = Convert.ToString(playList.Count + 1);
				playList.Add(pelicula);
				
				Console.WriteLine("\n||----------------------------||");
				Console.WriteLine("||La pelicula ha sido agregada||");
				Console.WriteLine("||----------------------------||");
				
			}
			
			Console.ReadKey();
		}
		
		public void verPlayList()
		{
			Console.Clear();
			Console.WriteLine("||---------------------------||");
			Console.WriteLine("||          PLAYLIST         ||");
			Console.WriteLine("||---------------------------||");
			
			if(playList.Count > 0)
			{
				foreach(var pelicula in playList)
				{
					Console.WriteLine($"  {pelicula.indicePlayList}. {pelicula.nombre}");
				}
			}
			else
			{
				Console.WriteLine("\n||---------------------------||");
				Console.WriteLine("||  La Playlist esta vacia   ||");
				Console.WriteLine("||---------------------------||");
			}
		}
	}
}