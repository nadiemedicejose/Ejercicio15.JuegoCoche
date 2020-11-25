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
    public class Circulo
    {
        // Variables y objetos globales
        #region Variables globales
        public int X { get; set; }
        public int Y { get; set; }
        public int inflateX;
        public int inflateY;
        Graphics3D g3;
        Point3DF[] fig;
        Color RGB;
        #endregion
        // Método constructor
        public Circulo(Point ubicacion, Color rGB)
        {
            X = ubicacion.X;
            Y = ubicacion.Y;
            this.RGB = rGB;
        }
        // Método para dibujar círculo (alimento auto)
        public void Dibujar(PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g3 = new Graphics3D(g);
            fig = new Point3DF[4];


            // Efecto mejor calidad
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Pluma para el contorno del círculo
            Pen contorno = new Pen(RGB);
            contorno.Width = 0.1F;
            // Brocha para rellenar el círculo
            Brush relleno = new SolidBrush(RGB);
            // Dibujar el círculo
            //g.DrawEllipse(contorno, X, Y, 27 + inflateX, 27 + inflateY);
            // Relleno uno del círculo (Blanco)
            //g.FillEllipse(Brushes.White, X + 2, Y + 2, 23 + inflateX, 23 + inflateY);
            // Relleno dos del círculo (centro del Blanco)
            //g.FillEllipse(relleno, X + 6, Y + 6, 15 + inflateX, 15 + inflateY);

            // Dibujar los puntos para empezar a trazar las líneas
            fig[0] = new Point3DF(0, 30, 0);
            fig[1] = new Point3DF(10, 30, 0);
            fig[2] = new Point3DF(10, 25, 0);
            fig[3] = new Point3DF(8, 23, 0);
            
            double grados_x = 0;
            double grados_y = 0;
            //g.TranslateTransform(X, Y);
            for (int i = 0; i < 100; i++)
            {
                fig[0] = RotarXY(new Point3DF(0, 10+Y, 0), grados_x, grados_y);
                fig[0].X += X+13;
                fig[1] = RotarXY(new Point3DF(15, 10+Y, 0), grados_x, grados_y);
                fig[1].X += X+13;
                fig[2] = RotarXY(new Point3DF(15, 30+Y, 0), grados_x, grados_y);
                fig[2].X += X+13;
                fig[3] = RotarXY(new Point3DF(0, 30+Y, 0), grados_x, grados_y);
                fig[3].X += X+13;
                g3.DrawBezier3D(contorno, fig[0], fig[1], fig[2], fig[3]);
                
                grados_x += 1.8;

            }

            //g.Flush();


        }


        private Point3DF RotarXY(Point3DF p1, double ang_x, double ang_y)
        {
            // Variables para rotar tanto en X como en Y
            Point3DF aux = new Point3DF();
            Point3DF aux2 = new Point3DF();
            double grados_x = (ang_x * Math.PI) / 180;
            double grados_y = (ang_y * Math.PI) / 180;

            //Rotacion y
            aux.X = Convert.ToSingle(p1.X * Math.Cos(grados_x) - p1.Z * Math.Sin(grados_x));
            aux.Y = p1.Y;
            aux.Z = 0; // Convert.ToSingle(p1.Z * Math.Cos(grados_x) + p1.X * Math.Sin(grados_x));
            //Rotación x
            aux2.X = aux.X;
            aux2.Y = Convert.ToSingle(aux.Y * Math.Cos(grados_y) - aux.Z * Math.Sin(grados_y));
            aux2.Z = 0; // Convert.ToSingle(aux.Z * Math.Cos(grados_y) + aux.Y * Math.Sin(grados_y));

            return aux2;
        }
    }
}
