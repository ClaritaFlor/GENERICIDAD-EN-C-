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
	/// Description of Manzana.
	/// </summary>
	public class Manzana:Fruta
	{
		private String sabor;

		public Manzana():base() {
		this.sabor = "";
	}

	public Manzana(String sabor) {
		this.sabor = sabor;
	}
	
	public Manzana(String sabor,String color, String temporada):base(color,temporada) {
		this.sabor = sabor;
	}

	public String getSabor() {
		return sabor;
	}

	
	public override String toString() {
			return base.toString()+" Manzana [sabor=" + sabor + "]";
	}
	
	public override String mostrar() {		
		return base.mostrar()+" Manzana [sabor=" + sabor + "]";
	}
	
	public override void VerDetalle() {		
		base.VerDetalle();
		Console.WriteLine("Fruta: Manzana \n Sabor: " + sabor);
	}
	}
}
