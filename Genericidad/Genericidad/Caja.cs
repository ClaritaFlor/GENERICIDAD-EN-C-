/*
 * Created by SharpDevelop.
 * User: clarita
 * Date: 7/18/2018
 * Time: 11:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Genericidad
{
	/// <summary>
	/// Description of Caja.
	/// </summary>
	public class Caja
	{
		private int dato;

	public Caja() {
		this.dato=0;
	}

	public Caja(int x) {
		this.dato=x;
	}
	
	public int levantar() {
		Console.WriteLine("Se levanto en elemento "+this.dato+" de la caja");
		return this.dato;
	}

	public void poner(int d) {
		Console.WriteLine("Se puso en elemento "+d+" en la caja");
		this.dato = d;
	}

	public int quito() {
		Console.WriteLine("Se quito en elemento "+this.dato+" de la caja");
		int x=this.dato;
		this.dato=0;
		return x;
	}
	
	public int getDato() {
		return dato;
	}

	public void setDato(int dato) {
		this.dato = dato;
	}

	
	public string toString() {
		return "Caja [dato=" + dato + "]";
	}
	}
}
