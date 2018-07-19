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
	/// Description of Platano.
	/// </summary>
	public class Platano:Fruta
	{
		private String apodo;

		public Platano():base() {
		this.apodo = "";
	}
	public Platano(String apodo) {
		this.apodo = apodo;
	}
		public Platano(String apodo, String color, String temporada):base(color, temporada) {
		this.apodo = apodo;
	}
	public String getApodo() {
		return apodo;
	}
	public void setApodo(String apodo) {
		this.apodo = apodo;
	}
	public override String toString() {		
		return "Platano [apodo=" + apodo + "]";
	}
	
	public override String mostrar() {		
			
		return base.mostrar()+" Platano [apodo=" + apodo + "]";
	}
	
	public override void VerDetalle() {
		base.VerDetalle();
	Console.WriteLine("Fruta: Platano \n Apodo: " + apodo);
	}
	}
}
