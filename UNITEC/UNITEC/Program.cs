/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 03/02/2021
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UNITEC
{
	class Program
	{
		public static void Main(string[] args)
	
			//los números son: 576
			//"a" es 5
			//"b" es 7
			//"c" es 6
			
			
	{
		
		Console.WriteLine("Los números son:");	
		int a = 5;
		int b = 7;
		int c = 6;

		//aacb
		
		Console.Write(a);
		Console.Write(a);
		Console.Write(c);
		Console.WriteLine(b);

		Console.WriteLine("______");

		//bca
		
		Console.Write(b);
		Console.Write(c);
		Console.WriteLine(a);

		Console.WriteLine("______");

		//bcbc
		
		Console.Write(b);
		Console.Write(c);
		Console.Write(b);
		Console.WriteLine(c);

		

			Console.WriteLine("¡Fin del Programa!");
			
			
			
			Console.ReadKey();
		}
	}
}