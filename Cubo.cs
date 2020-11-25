using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ejercicio15.JuegoCoche
{
    public class Cubo
    {
        // Variables y objetos globales
        #region Variables globales
        public int X { get; set; }
        public int Y { get; set; }
        public int inflateX;
        public int inflateY;
        Color RGB;
        #endregion
        // Método constructor
        public Cubo(Point ubicacion, Color rGB)
        {
            X = ubicacion.X;
            Y = ubicacion.Y;
            this.RGB = rGB;
        }
        // Método para dibujar el cubo (alimento auto)
        public void Dibujar(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Efecto mejor calidad
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Pluma para el contorno del cubo
            Pen contorno = new Pen(RGB, 4);
            // Brocha para rellenar el cubo
            Brush relleno = new SolidBrush(RGB);
            // Dibujar el cubo
            g.DrawRectangle(contorno, X, Y, 27 + inflateX, 27 + inflateY);
            // Relleno uno del cubo (Blanco)
            g.FillRectangle(Brushes.White, X + 2, Y + 2, 23 + inflateX, 23 + inflateY);
            // Relleno dos del cubo (centro del Blanco)
            g.FillRectangle(relleno, X + 6, Y + 6, 15 + inflateX, 15 + inflateY);
        }
    }
}
