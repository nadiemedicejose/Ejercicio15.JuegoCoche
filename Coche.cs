using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ejercicio15.JuegoCoche
{
    class Coche
    {
        // Declaración de variables globales
        // Coordenadas de posición en el eje X
        public int X { get; set; }
        Color RGB; // Para pintar el coche del color que necesite
        // Método constructor de la clase Coche, parámetros coordenada en X y el color del coche
        public Coche(int X, Color RGB)
        {
            this.X = X;
            this.RGB = RGB;
        }
        // Método que permite dibujar las partes del auto en determinados puntos de la pantalla
        public void Dibujar(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Definir la calidad y efecto de burbujas
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            #region Estructura de los puntos donde se va a dibujar el auto
            // Definir los puntos donde se pondrán todos los elementos del auto: lado izq, derecho, ventana superior, inferior, techo, parabrisas
            Point[] auto =
            {
                // Lado izquierdo
                new Point(X, 425), // Valor de la posición en pantalla en el eje X, Y = 425
                new Point(X-3, 441),
                new Point(X-3, 454),
                new Point(X, 470),

                // Lado inferior
                new Point(X+8, 473),
                new Point(X+16, 473),
                new Point(X+24, 470),

                // Lado derecho
                new Point(X+27, 454),
                new Point(X+27, 441),
                new Point(X+21, 425),

                // Lado superior
                new Point(X+16, 422),
                new Point(X+6, 422),
                new Point(X, 425),
            };
            
            // Ventana superior (establecer la curva del techo)
            Point[] ventSuperior =
            {
                new Point(X+4, 433),
                new Point(X+21, 433),
                new Point(X+19, 440),
                new Point(X+6, 440),
            };

            // Ventana inferior la cual contendrá los parabrisas del auto
            Point[] ventInferior =
            {
                new Point(X+4, 433),
                new Point(X+21, 433),
                new Point(X+19, 456),
                new Point(X+6, 456),
            };
            // Determinar las coordenadas en la cual se dibujará el techo del carro
            Rectangle techo = new Rectangle(X+6, 440, 13, 16);
            #endregion

            #region Diseño del auto
            Pen contorno = new Pen(RGB, 5);
            Brush tech = new SolidBrush(RGB);
            Brush parabrisas = new SolidBrush(Color.Black);
            Brush relleno = new SolidBrush(RGB);

            // Colocar el relleno para el auto
            g.FillClosedCurve(Brushes.White, auto);
            // Dibujar el contorno
            g.DrawBeziers(contorno, auto);
            // Rellenar el techo
            g.FillRectangle(tech, techo);
            // Dibujar el parabrisas
            g.FillPolygon(parabrisas, ventSuperior);
            // Dibujar el parabrisas trasero
            g.FillPolygon(parabrisas, ventInferior);
            #endregion
        }
    }
}
