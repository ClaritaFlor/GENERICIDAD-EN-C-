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
	/// Description of Fruta.
	/// </summary>
	public class Fruta
	{
		protected String Color;
	protected String Temporada;
	
	public Fruta() {
		Color = "";
		Temporada = "";
	}

	public Fruta(String color, String temporada) {
		Color = color;
		Temporada = temporada;
	}

	public String getColor() {
		return Color;
	}

	public void setColor(String color) {
		Color = color;
	}

	public String getTemporada() {
		return Temporada;
	}

	public void setTemporada(String temporada) {
		Temporada = temporada;
	}

	
	public virtual String toString() {
		return "Fruta [Color=" + Color + ", Temporada=" + Temporada + "]";
	}
	
	public virtual String mostrar() {
		return "Fruta [Color=" + Color + ", Temporada=" + Temporada + "]";
	}
	
	public virtual void VerDetalle() {
		Console.WriteLine("++++ Detalles de Fruta ++++ \n Color: "+ Color + "\n Temporada: " + Temporada );
	}
	}
}
