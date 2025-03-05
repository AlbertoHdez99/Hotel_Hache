namespace GestionReservacionesHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMostrarDisponibles = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumHabitacion = new System.Windows.Forms.TextBox();
            this.txtNoches = new System.Windows.Forms.TextBox();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.lstReservaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarDisponibles
            // 
            this.btnMostrarDisponibles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDisponibles.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDisponibles.Location = new System.Drawing.Point(158, 267);
            this.btnMostrarDisponibles.Name = "btnMostrarDisponibles";
            this.btnMostrarDisponibles.Size = new System.Drawing.Size(226, 23);
            this.btnMostrarDisponibles.TabIndex = 1;
            this.btnMostrarDisponibles.Text = "Mostrar Habitaciones Disponibles";
            this.btnMostrarDisponibles.UseVisualStyleBackColor = true;
            this.btnMostrarDisponibles.Click += new System.EventHandler(this.btnMostrarDisponibles_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(158, 442);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(226, 23);
            this.btnReservar.TabIndex = 2;
            this.btnReservar.Text = "Reservar Habitación";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarReservacion.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReservacion.Location = new System.Drawing.Point(158, 561);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(226, 23);
            this.btnCancelarReservacion.TabIndex = 3;
            this.btnCancelarReservacion.Text = "Cancelar Reservación";
            this.btnCancelarReservacion.UseVisualStyleBackColor = true;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.btnCancelarReservacion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(240, 183);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(240, 211);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(144, 22);
            this.txtDocumento.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(240, 239);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(144, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumHabitacion.Location = new System.Drawing.Point(234, 386);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(150, 22);
            this.txtNumHabitacion.TabIndex = 7;
            // 
            // txtNoches
            // 
            this.txtNoches.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoches.Location = new System.Drawing.Point(234, 414);
            this.txtNoches.Name = "txtNoches";
            this.txtNoches.Size = new System.Drawing.Size(150, 22);
            this.txtNoches.TabIndex = 8;
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstHabitaciones.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHabitaciones.ForeColor = System.Drawing.SystemColors.Window;
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.ItemHeight = 16;
            this.lstHabitaciones.Location = new System.Drawing.Point(158, 296);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(226, 84);
            this.lstHabitaciones.TabIndex = 9;
            // 
            // lstReservaciones
            // 
            this.lstReservaciones.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstReservaciones.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReservaciones.ForeColor = System.Drawing.SystemColors.Window;
            this.lstReservaciones.FormattingEnabled = true;
            this.lstReservaciones.ItemHeight = 16;
            this.lstReservaciones.Location = new System.Drawing.Point(35, 471);
            this.lstReservaciones.Name = "lstReservaciones";
            this.lstReservaciones.Size = new System.Drawing.Size(473, 84);
            this.lstReservaciones.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. Habit.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Noches:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "GESTIÓN DE RESERVACIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "INDICACIONES DE USO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 642);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 90);
            this.label8.TabIndex = 18;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 771);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "UDB | Frank Hernández | HS171707 | Todos los derechos reservados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReservaciones);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.txtNoches);
            this.Controls.Add(this.txtNumHabitacion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelarReservacion);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnMostrarDisponibles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hotel Hache - Gestion de Reservación";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarDisponibles;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelarReservacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNumHabitacion;
        private System.Windows.Forms.TextBox txtNoches;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.ListBox lstReservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

