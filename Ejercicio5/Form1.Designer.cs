﻿namespace Ejercicio5
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Alumnolab = new System.Windows.Forms.Label();
            this.rbIngresante = new System.Windows.Forms.RadioButton();
            this.rbGrado = new System.Windows.Forms.RadioButton();
            this.rbPosgrado = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Becalab = new System.Windows.Forms.Label();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 36);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(460, 196);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // Alumnolab
            // 
            this.Alumnolab.AutoSize = true;
            this.Alumnolab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alumnolab.Location = new System.Drawing.Point(12, 9);
            this.Alumnolab.Name = "Alumnolab";
            this.Alumnolab.Size = new System.Drawing.Size(89, 20);
            this.Alumnolab.TabIndex = 1;
            this.Alumnolab.Text = "1) Alumnos";
            // 
            // rbIngresante
            // 
            this.rbIngresante.AutoSize = true;
            this.rbIngresante.Checked = true;
            this.rbIngresante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresante.Location = new System.Drawing.Point(478, 36);
            this.rbIngresante.Name = "rbIngresante";
            this.rbIngresante.Size = new System.Drawing.Size(94, 22);
            this.rbIngresante.TabIndex = 2;
            this.rbIngresante.TabStop = true;
            this.rbIngresante.Text = "Ingresante";
            this.rbIngresante.UseVisualStyleBackColor = true;
            // 
            // rbGrado
            // 
            this.rbGrado.AutoSize = true;
            this.rbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrado.Location = new System.Drawing.Point(478, 64);
            this.rbGrado.Name = "rbGrado";
            this.rbGrado.Size = new System.Drawing.Size(68, 22);
            this.rbGrado.TabIndex = 3;
            this.rbGrado.Text = "Grado";
            this.rbGrado.UseVisualStyleBackColor = true;
            // 
            // rbPosgrado
            // 
            this.rbPosgrado.AutoSize = true;
            this.rbPosgrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPosgrado.Location = new System.Drawing.Point(478, 92);
            this.rbPosgrado.Name = "rbPosgrado";
            this.rbPosgrado.Size = new System.Drawing.Size(91, 22);
            this.rbPosgrado.TabIndex = 4;
            this.rbPosgrado.Text = "Posgrado";
            this.rbPosgrado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(478, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(478, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modificación";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Becalab
            // 
            this.Becalab.AutoSize = true;
            this.Becalab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Becalab.Location = new System.Drawing.Point(610, 5);
            this.Becalab.Name = "Becalab";
            this.Becalab.Size = new System.Drawing.Size(72, 20);
            this.Becalab.TabIndex = 8;
            this.Becalab.Text = "2) Becas";
            // 
            // dgvBecas
            // 
            this.dgvBecas.AllowUserToAddRows = false;
            this.dgvBecas.AllowUserToDeleteRows = false;
            this.dgvBecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Location = new System.Drawing.Point(614, 36);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.ReadOnly = true;
            this.dgvBecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBecas.Size = new System.Drawing.Size(375, 196);
            this.dgvBecas.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1005, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Alta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.Becalab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbPosgrado);
            this.Controls.Add(this.rbGrado);
            this.Controls.Add(this.rbIngresante);
            this.Controls.Add(this.Alumnolab);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label Alumnolab;
        private System.Windows.Forms.RadioButton rbIngresante;
        private System.Windows.Forms.RadioButton rbGrado;
        private System.Windows.Forms.RadioButton rbPosgrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Becalab;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.Button button4;
    }
}

