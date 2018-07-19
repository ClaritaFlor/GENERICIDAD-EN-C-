/*
 * Created by SharpDevelop.
 * User: clarita
 * Date: 7/19/2018
 * Time: 11:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Genericidad
{
	/// <summary>
	/// Description of Caja2.
	/// </summary>
	public class Caja2<T>
	{
			private T dato;
	public Caja2() {
				this.dato=dato;
	}
	public Caja2(T dato) {
				this.dato=dato;
	}
	public T levantar() {
		Console.WriteLine("Se levanto en elemento "+this.dato+" de la caja");
		return this.dato;
	}

	public void poner(T d) {
		Console.WriteLine("Se puso en elemento en la caja");
		this.dato = d;
	}

	public T quito() {
		Console.WriteLine("Se quito en elemento "+this.dato+" de la caja");
		T x=this.dato;
		return x;
	}

	public string toString() {
		return "Caja2 [dato=" + dato + "]";
	}
	}
}
