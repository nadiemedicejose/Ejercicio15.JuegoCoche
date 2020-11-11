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
            this.label1.Font = new System.Drawing.Font("Indigo Regular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(285, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 42);
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
            // Pista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
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
    }
}

