using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Graphics3DS;

namespace Ejercicio15.JuegoCoche
{
    public class Cubo
    {
        // Variables y objetos globales
        #region Variables globales
        Graphics3D g3;
        public Point3DF[] cubito = new Point3DF[8];
        public int X { get; set; }
        public int Y { get; set; }
        public int inflateX;
        public int inflateY;
        Color RGB;
        #endregion
        // Método constructor
        public Cubo(bool der_izq, Color RGB)
        {
            // Dibujar los 8 puntos del cubo
            cubito[0] = new Point3DF(-10, -10, -10);
            cubito[1] = new Point3DF(-10, -10, 10);
            cubito[2] = new Point3DF(-10, 10, 10);
            cubito[3] = new Point3DF(-10, 10, -10);
            cubito[4] = new Point3DF(10, -10, -10);
            cubito[5] = new Point3DF(10, -10, 10);
            cubito[6] = new Point3DF(10, 10, 10);
            cubito[7] = new Point3DF(10, 10, -10);

            if (der_izq)
            {
                // Mover la figura X unidades hacia la derecha
                for (int i = 0; i < cubito.Length; i++)
                {
                    cubito[i].X += 52;
                }
            }
            else
            {
                for (int i = 0; i < cubito.Length; i++)
                {
                    cubito[i].X += 177;
                }
            }
            
            this.RGB = RGB;
        }
        // Método para dibujar el cubo (alimento auto)
        public void Dibujar(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g3 = new Graphics3D(g);
            // Efecto mejor calidad
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Pluma para el contorno del cubo
            Pen contorno = new Pen(RGB, 2);
            // Brocha para rellenar el cubo
            //Brush relleno = new SolidBrush(RGB); #SinUso
            // Dibujar el cubo
            //g.DrawRectangle(contorno, X, Y, 27 + inflateX, 27 + inflateY);
            

            g3.DrawLine3D(contorno, cubito[0], cubito[1]);
            g3.DrawLine3D(contorno, cubito[1], cubito[2]);
            g3.DrawLine3D(contorno, cubito[2], cubito[3]);
            g3.DrawLine3D(contorno, cubito[3], cubito[0]);
            g3.DrawLine3D(contorno, cubito[4], cubito[5]);
            g3.DrawLine3D(contorno, cubito[5], cubito[6]);
            g3.DrawLine3D(contorno, cubito[6], cubito[7]);
            g3.DrawLine3D(contorno, cubito[7], cubito[4]);
            g3.DrawLine3D(contorno, cubito[0], cubito[4]);
            g3.DrawLine3D(contorno, cubito[1], cubito[5]);
            g3.DrawLine3D(contorno, cubito[2], cubito[6]);
            g3.DrawLine3D(contorno, cubito[3], cubito[7]);
            // Relleno uno del cubo (Blanco)
            //g.FillRectangle(Brushes.White, X + 2, Y + 2, 23 + inflateX, 23 + inflateY);
            // Relleno dos del cubo (centro del Blanco)
            //g.FillRectangle(relleno, X + 6, Y + 6, 15 + inflateX, 15 + inflateY);

        }
    }
}
