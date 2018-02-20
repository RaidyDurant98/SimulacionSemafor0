namespace SimulaSemaforo
{
    partial class Simulacion
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
            this.Startbutton = new System.Windows.Forms.Button();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.ShutDownbutton = new System.Windows.Forms.Button();
            this.Semaforotimer = new System.Windows.Forms.Timer(this.components);
            this.Buttontimer = new System.Windows.Forms.Timer(this.components);
            this.CarropictureBox = new System.Windows.Forms.PictureBox();
            this.SemaforopictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarropictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemaforopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(47, 111);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Location = new System.Drawing.Point(128, 111);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(75, 23);
            this.Stopbutton.TabIndex = 2;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // ShutDownbutton
            // 
            this.ShutDownbutton.Location = new System.Drawing.Point(209, 111);
            this.ShutDownbutton.Name = "ShutDownbutton";
            this.ShutDownbutton.Size = new System.Drawing.Size(75, 23);
            this.ShutDownbutton.TabIndex = 3;
            this.ShutDownbutton.Text = "Shut Down";
            this.ShutDownbutton.UseVisualStyleBackColor = true;
            this.ShutDownbutton.Click += new System.EventHandler(this.ShutDownbutton_Click);
            // 
            // Semaforotimer
            // 
            this.Semaforotimer.Tick += new System.EventHandler(this.Semaforotimer_Tick);
            // 
            // Buttontimer
            // 
            this.Buttontimer.Tick += new System.EventHandler(this.Buttontimer_Tick);
            // 
            // CarropictureBox
            // 
            this.CarropictureBox.Image = global::SimulaSemaforo.Properties.Resources.Carro1;
            this.CarropictureBox.Location = new System.Drawing.Point(12, 226);
            this.CarropictureBox.Name = "CarropictureBox";
            this.CarropictureBox.Size = new System.Drawing.Size(100, 63);
            this.CarropictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarropictureBox.TabIndex = 4;
            this.CarropictureBox.TabStop = false;
            // 
            // SemaforopictureBox
            // 
            this.SemaforopictureBox.Image = global::SimulaSemaforo.Properties.Resources.SemaforoPrendido;
            this.SemaforopictureBox.Location = new System.Drawing.Point(73, 27);
            this.SemaforopictureBox.Name = "SemaforopictureBox";
            this.SemaforopictureBox.Size = new System.Drawing.Size(189, 62);
            this.SemaforopictureBox.TabIndex = 0;
            this.SemaforopictureBox.TabStop = false;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 395);
            this.Controls.Add(this.CarropictureBox);
            this.Controls.Add(this.ShutDownbutton);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.SemaforopictureBox);
            this.Name = "Simulacion";
            this.Text = "Simulacion semaforo";
            this.Load += new System.EventHandler(this.Simulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarropictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemaforopictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SemaforopictureBox;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.Button ShutDownbutton;
        private System.Windows.Forms.Timer Semaforotimer;
        private System.Windows.Forms.Timer Buttontimer;
        private System.Windows.Forms.PictureBox CarropictureBox;
    }
}

