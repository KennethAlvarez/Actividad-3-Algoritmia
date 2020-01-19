/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 06/10/2019
 * Time: 09:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmiaAct3
{
	/// <summary>
	/// Description of Agente.
	/// </summary>
	public class Agente
	{
		Vertice vActual;
		int velocidad;
		int rastro;
		Arista camino;
		int avanzar;
		public Agente(Vertice pa, int ras)
		{
			this.vActual = pa;
			this.rastro = ras;
			this.velocidad = 5;
			avanzar = 10;
		}
		public void dibujarFlecha(Point dst, Bitmap bm)
		{
			Graphics gr = Graphics.FromImage(bm);
		
			double co = dst.Y - camino.getListaPixeles()[velocidad].Y;
			double ca =  dst.X - camino.getListaPixeles()[velocidad].X;
			double tan = co/ca;
			double dg = Math.Atan2(co, ca) * (180/Math.PI);
			
			//double hipotenusa =  Math.Pow(co, 2) + Math.Pow(ca, 2);
			//hipotenusa =  Math.Sqrt(hipotenusa);
			double hipotenusa = 45; 	
			double b = hipotenusa * Math.Sin((dg*(Math.PI/180))) + camino.getListaPixeles()[velocidad].Y;
			double a = hipotenusa * Math.Cos((dg*(Math.PI/180))) + camino.getListaPixeles()[velocidad].X;
			Pen p = new Pen(Color.Green, 5);
			Point aa = new Point(Convert.ToInt32(a),	Convert.ToInt32(b));
			Point bb = new Point(camino.getListaPixeles()[velocidad].X, camino.getListaPixeles()[velocidad].Y);
			gr.DrawLine(p, bb, aa);
			
		}
		public void tomarDecision(Point dst)
		{		
			double co = dst.Y - vActual.getCentro().Y;
			double ca = dst.X - vActual.getCentro().X;
			double tan = co/ca;
			double dg = Math.Atan2(co, ca) * (180/Math.PI);
			double menor = 360;
			double menorAux = 360;
			//if(dg < 0)
			//	dg = dg * -1;
			
			camino = null;
			Arista aux = null;
			int contador = 0;
			for(int i = 0; i<vActual.getLista().Count;i++)
			{
				double nuevo_angulo = calcularAngulo(dst, dg, i);
					
				if(!vActual.getLista()[i].getDestino().getRastros().Exists(x => x == (rastro * -1)))
				{
					if(!vActual.getLista()[i].getDestino().getRastros().Exists(x => x == rastro))
					{
					if(nuevo_angulo < menor)
					{
						camino = vActual.getLista()[i];
						menor = nuevo_angulo;
					}
					}else{
						if(vActual.getLista()[i].getDestino().getRastros().Count < menorAux)
						{	
							aux = vActual.getLista()[i];
							menorAux = vActual.getLista()[i].getDestino().getRastros().Count;
						}
							contador++;
					}
					
				}
				
			}
			//velocidad = 5+avanzar;
			if(camino != null)
			{
				vActual.getRastros().Add(rastro);
			}else
			{
				if(aux != null)
				{	
					if(contador < 2)
						vActual.getRastros().Add(rastro*-1);
					
					camino = aux;
					vActual.getRastros().Add(rastro);
					//vActual.getRastros().Add(rastro*-1);
				}
			}
		}
		private double calcularAngulo(Point dst, double dg, int i)
		{
			double co = vActual.getLista()[i].getDestino().getCentro().Y - vActual.getCentro().Y;
			double ca = vActual.getLista()[i].getDestino().getCentro().X - vActual.getCentro().X;
			double tan = co/ca;
			double radian = dg * (Math.PI/180);
			
			double nuevo_angulo = Math.Atan2(co, ca) * (180/Math.PI);
			double suplementario;
			
			
			if(dg < 0 )
				dg = dg + 360;
			
			if(nuevo_angulo < 0)
				nuevo_angulo = nuevo_angulo + 360;				
				
			if(nuevo_angulo>dg)
				nuevo_angulo = nuevo_angulo-dg;
			else
				nuevo_angulo = dg - nuevo_angulo;
			
			suplementario = 360 - nuevo_angulo;
			
			if(suplementario < nuevo_angulo)
				nuevo_angulo = suplementario;
			
			return nuevo_angulo;
		}
		public void setVerticeActual(Vertice a)
		{
			vActual = a;
		}
		public Vertice getVertice()
		{
			return vActual;
		}
		
		public int getAvanzar()
		{
			return avanzar;
		}
		public void setAvanzar(int d)
		{
			 avanzar += d;
		}
		public void setCamino(Arista p)
		{
			camino = p;
		}
		public Arista getCamino()
		{
			return camino;
		}
		public bool validarLlegada()
		{			
			velocidad += avanzar;
			 if(velocidad < camino.getListaPixeles().Count){
				return false;
			}
			velocidad = 5 + avanzar;
			vActual = camino.getDestino();
			return true;
		}
		public int getRastro()
		{
			return rastro;
		}
		public Point getListaCamino()
		{
			return this.camino.getListaPixeles()[velocidad];
		}
	}
}
/*private double calcularAngulo(Point dst, double dg, int i)
		{
			double co = vActual.getLista()[i].getDestino().getCentro().Y - vActual.getCentro().Y;
			double ca = vActual.getLista()[i].getDestino().getCentro().X - vActual.getCentro().X;
			double tan = co/ca;
			double radian = dg * (Math.PI/180);
			
			double nuevo_angulo = Math.Atan2(co, ca) * (180/Math.PI);
			double _a = dg;
			
			
			if(dg < 0 )
				dg = dg + 360;
			
			if(nuevo_angulo < 0)
				nuevo_angulo = nuevo_angulo + 360;
		
			_a = 360 - nuevo_angulo;
			
			if(_a < nuevo_angulo)
				nuevo_angulo = _a;
			else
				
				
			if(nuevo_angulo>dg)
				nuevo_angulo = nuevo_angulo-dg;
			else
				nuevo_angulo = dg - nuevo_angulo;
			
			return nuevo_angulo;
		}*/
					