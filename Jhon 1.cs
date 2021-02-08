/*
 * Created by SharpDevelop.
 * User: M
 * Date: 03/02/2021
 * Time: 10:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EJERCICIO_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a, b , c;
			a = 5;
			b = 10;
			c = 17;
				
			Console.WriteLine("Combinacion aacb");
			Console.Write(a);
			Console.Write(a);
			Console.Write(c);
			Console.Write(b);
			
			Console.WriteLine();
			
			Console.WriteLine("Combinacion bca");
			Console.Write(b);
			Console.Write(c);
			Console.Write(a);
			
			
			Console.WriteLine();
			
			Console.WriteLine("Combinacion bca");
			Console.Write(b);
			Console.Write(c);
			Console.Write(b);
			Console.Write(c);
			
			Console.ReadKey(true);
		}
	}
}