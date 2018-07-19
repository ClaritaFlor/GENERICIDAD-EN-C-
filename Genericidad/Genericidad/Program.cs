/*
 * Created by SharpDevelop.
 * User: clarita
 * Date: 7/18/2018
 * Time: 11:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Genericidad
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("**********PRINCIPAL CAJA");
			Caja c = new Caja();
			c.poner(46);
			int y = c.levantar();
			Console.WriteLine(c.toString());
			c.quito();
			Console.WriteLine(c.toString());
		
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			Console.WriteLine("**********PRINCIPAL CAJA 1");	
			
			Caja1 c1 = new Caja1();
			c1.poner(new Manzana("dulce"));
			Manzana mm = (Manzana) c1.quito();
			Console.WriteLine(mm.toString());
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			Console.WriteLine("**********PRINCIPAL CAJA 2");
					
			Console.WriteLine("*******probando con la Clase Manzana");
			Caja2<Manzana> caja4 = new Caja2<Manzana>();
			caja4.poner(new Manzana("Amarga"));
			Console.WriteLine(caja4.toString());
			caja4.quito(); 
			Console.WriteLine(caja4.toString());
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			Console.WriteLine("**********POLIMORFISMO EN CLASE FRUTAS");
			Fruta[] f = new Fruta[6];
			f[0] = new Manzana("Agria");
			f[1] = new Manzana("dulce");
			f[2] = new Platano("Banano");
			f[3] = new Platano("Guineo");
			f[4] = new Manzana("Sin sabor");
			f[5] = new Platano("cambur");

			Console.WriteLine("**********IMPRIMIENDO VECTOR DE FRUTAS");
		
			foreach (Fruta x in f) {
				Console.WriteLine(x.toString());
			}
			Console.WriteLine();
		
			Fruta[] f2 = new Fruta[7];
			f2[0] = new Manzana("Agria", "roja", "verano");
			f2[1] = new Manzana("dulce", "verde", "primavera");
			f2[2] = new Platano("Banano", "amarillo", "invierno");
			f2[3] = new Platano("Guineo", "verde", "otoño");
			f2[4] = new Manzana("Sin sabor", "roja", "primavera");
			f2[5] = new Platano("cambur", "amarillo", "invierno");
			f2[6] = new Fruta("naranja", "invierno");

			Console.WriteLine("**********IMPRIMIENDO VECTOR DE FRUTAS CON PARAMETROS HEREDADOS");
			foreach (Fruta x in f2) {
				Console.WriteLine(x.mostrar());
			}
		
			Fruta[] f3 = new Fruta[7];
			f3[0] = new Manzana("Agria", "roja", "verano");
			f3[1] = new Manzana("dulce", "verde", "primavera");
			f3[2] = new Platano("Banano", "amarillo", "invierno");
			f3[3] = new Platano("Guineo", "verde", "otoño");
			f3[4] = new Manzana("Sin sabor", "roja", "primavera");
			f3[5] = new Platano("cambur", "amarillo", "invierno");
			f3[6] = new Fruta("naranja", "invierno");

			Console.WriteLine("**********IMPRIMIENDO VECTOR DE FRUTAS CON PARAMETROS HEREDADOS");
			foreach (Fruta x in f3) {
				x.VerDetalle();
			}
		
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		
			Console.WriteLine("**********IMPRIMIENDO ARRARY LIST DE FRUTAS CON PARAMETROS HEREDADOS");
			List<Fruta> lista = new List<Fruta>();
			Console.WriteLine("***********Añadiendo una fruta: manzana");
			lista.Add(new Fruta("Rojo", "invierno"));
			lista.Add(new Manzana("agrio"));
			lista.Add(new Manzana("dulce"));
			lista.Add(new Manzana("sin sabor", "rojo", "primavera"));
			lista.Add(new Platano("banana"));
			lista.Add(new Platano("guineo"));
			
			foreach (Fruta x in lista) {
				Console.WriteLine(x);
			}
		
			foreach (Fruta x in lista) {
				Console.WriteLine(x.toString());
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}