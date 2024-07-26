namespace Ejercicio4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbIngresantes = new System.Windows.Forms.RadioButton();
            this.rbGrado = new System.Windows.Forms.RadioButton();
            this.rbPosgrado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPagar = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(668, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(668, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificación";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(21, 48);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(504, 159);
            this.dgvAlumnos.TabIndex = 3;
            this.dgvAlumnos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "1) Alumnos";
            // 
            // rbIngresantes
            // 
            this.rbIngresantes.AutoSize = true;
            this.rbIngresantes.Checked = true;
            this.rbIngresantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresantes.Location = new System.Drawing.Point(549, 66);
            this.rbIngresantes.Name = "rbIngresantes";
            this.rbIngresantes.Size = new System.Drawing.Size(102, 22);
            this.rbIngresantes.TabIndex = 5;
            this.rbIngresantes.TabStop = true;
            this.rbIngresantes.Text = "Ingresantes";
            this.rbIngresantes.UseVisualStyleBackColor = true;
            // 
            // rbGrado
            // 
            this.rbGrado.AutoSize = true;
            this.rbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrado.Location = new System.Drawing.Point(549, 93);
            this.rbGrado.Name = "rbGrado";
            this.rbGrado.Size = new System.Drawing.Size(68, 22);
            this.rbGrado.TabIndex = 6;
            this.rbGrado.Text = "Grado";
            this.rbGrado.UseVisualStyleBackColor = true;
            // 
            // rbPosgrado
            // 
            this.rbPosgrado.AutoSize = true;
            this.rbPosgrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPosgrado.Location = new System.Drawing.Point(549, 120);
            this.rbPosgrado.Name = "rbPosgrado";
            this.rbPosgrado.Size = new System.Drawing.Size(91, 22);
            this.rbPosgrado.TabIndex = 7;
            this.rbPosgrado.Text = "Posgrado";
            this.rbPosgrado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "2) Becas";
            // 
            // dgvBecas
            // 
            this.dgvBecas.AllowUserToAddRows = false;
            this.dgvBecas.AllowUserToDeleteRows = false;
            this.dgvBecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Location = new System.Drawing.Point(21, 277);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.ReadOnly = true;
            this.dgvBecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBecas.Size = new System.Drawing.Size(570, 159);
            this.dgvBecas.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(597, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Alta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "3) Pagar";
            // 
            // dgvPagar
            // 
            this.dgvPagar.AllowUserToAddRows = false;
            this.dgvPagar.AllowUserToDeleteRows = false;
            this.dgvPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagar.Location = new System.Drawing.Point(21, 502);
            this.dgvPagar.Name = "dgvPagar";
            this.dgvPagar.ReadOnly = true;
            this.dgvPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagar.Size = new System.Drawing.Size(570, 159);
            this.dgvPagar.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(597, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "Pagar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPosgrado);
            this.Controls.Add(this.rbGrado);
            this.Controls.Add(this.rbIngresantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbIngresantes;
        private System.Windows.Forms.RadioButton rbGrado;
        private System.Windows.Forms.RadioButton rbPosgrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPagar;
        private System.Windows.Forms.Button button5;
    }
}

