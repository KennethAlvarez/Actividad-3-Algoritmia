/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 06/10/2019
 * Time: 09:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
namespace AlgoritmiaAct3
{
	/// <summary>
	/// Description of Senuelo.
	/// </summary>
	public class Senuelo
	{
		Vertice vActual;
		
		public Senuelo(Vertice a)
		{
			vActual = a;
		}
		public void setVerticeActual(Vertice a)
		{
			vActual = a;
		}
		public Vertice getVerticeActual()
		{
			return vActual;
		}
	}
}
