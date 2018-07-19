/*
 * Created by SharpDevelop.
 * User: clarita
 * Date: 7/19/2018
 * Time: 11:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Genericidad
{
	/// <summary>
	/// Description of Caja1.
	/// </summary>
	public class Caja1
	{
		private Object dato;

	public Caja1() {
		this.dato = new Object();
	}
	public Caja1(Object dato) {
		this.dato = dato;
	}
	public Object levantar() {
		Console.Write("Se levanto en elemento "+this.dato+" de la caja");
		return this.dato;
	}

	public void poner(Object d) {
		Console.Write("Se puso en elemento "+d+" en la caja");
		this.dato = d;
	}

	public Object quito() {
		Console.Write("Se quito en elemento "+this.dato+" de la caja");
		Object x=this.dato;
		this.dato=new Object();
		return x;
	}
	
	public string toString() {
		return "Caja1 [dato=" + dato + "]";
	}
	}
}
