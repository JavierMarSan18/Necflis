using System;
using System.Collections.Generic;

namespace Necflis
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Menu menu = new Menu();
				bool salir = false;
				
				while(!salir)
				{	
					salir = menu.mostrarMenuPrincipal();		
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
    }
}
