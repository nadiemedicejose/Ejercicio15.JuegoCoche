namespace Ejercicio15.JuegoCoche
{
    partial class Pista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Carretera = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerCar1 = new System.Windows.Forms.Timer(this.components);
            this.timerAnimationCar1 = new System.Windows.Forms.Timer(this.components);
            this.timerGenObjCar1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nombre1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerAnimationCar2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).BeginInit();
            this.SuspendLayout();
            // 
            // Carretera
            // 
            this.Carretera.BackColor = System.Drawing.Color.Black;
            this.Carretera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Carretera.Location = new System.Drawing.Point(0, 0);
            this.Carretera.Name = "Carretera";
            this.Carretera.Size = new System.Drawing.Size(384, 461);
            this.Carretera.TabIndex = 0;
            this.Carretera.TabStop = false;
            this.Carretera.Paint += new System.Windows.Forms.PaintEventHandler(this.Carretera_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(285, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // timerCar1
            // 
            this.timerCar1.Interval = 10;
            this.timerCar1.Tick += new System.EventHandler(this.timerCar1_Tick);
            // 
            // timerAnimationCar1
            // 
            this.timerAnimationCar1.Interval = 1;
            this.timerAnimationCar1.Tick += new System.EventHandler(this.timerAnimationCar1_Tick);
            // 
            // timerGenObjCar1
            // 
            this.timerGenObjCar1.Interval = 315;
            this.timerGenObjCar1.Tick += new System.EventHandler(this.timerGenObjCar1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(285, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // nombre1
            // 
            this.nombre1.AutoSize = true;
            this.nombre1.BackColor = System.Drawing.Color.Black;
            this.nombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre1.ForeColor = System.Drawing.Color.Cornsilk;
            this.nombre1.Location = new System.Drawing.Point(289, 9);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(74, 18);
            this.nombre1.TabIndex = 3;
            this.nombre1.Text = "Jugador 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(289, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jugador 2";
            // 
            // timerAnimationCar2
            // 
            this.timerAnimationCar2.Interval = 1;
            this.timerAnimationCar2.Tick += new System.EventHandler(this.timerAnimationCar2_Tick);
            // 
            // Pista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Carretera);
            this.Name = "Pista";
            this.Text = "Juego de Coches";
            this.Load += new System.EventHandler(this.Pista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pista_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Carretera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCar1;
        private System.Windows.Forms.Timer timerAnimationCar1;
        private System.Windows.Forms.Timer timerGenObjCar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerAnimationCar2;
    }
}

