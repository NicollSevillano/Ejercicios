namespace Ejercicio6
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.rbExtranjero = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaA = new System.Windows.Forms.Button();
            this.btnBajaA = new System.Windows.Forms.Button();
            this.btnModificarA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.btnAltaT = new System.Windows.Forms.Button();
            this.dgvRE = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AllowUserToAddRows = false;
            this.dgvAlumno.AllowUserToDeleteRows = false;
            this.dgvAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(15, 28);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.ReadOnly = true;
            this.dgvAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumno.Size = new System.Drawing.Size(518, 163);
            this.dgvAlumno.TabIndex = 1;
            this.dgvAlumno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumno_RowEnter);
            // 
            // rbExtranjero
            // 
            this.rbExtranjero.AutoSize = true;
            this.rbExtranjero.Checked = true;
            this.rbExtranjero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExtranjero.Location = new System.Drawing.Point(18, 31);
            this.rbExtranjero.Name = "rbExtranjero";
            this.rbExtranjero.Size = new System.Drawing.Size(85, 20);
            this.rbExtranjero.TabIndex = 2;
            this.rbExtranjero.TabStop = true;
            this.rbExtranjero.Text = "Extranjero";
            this.rbExtranjero.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNacional.Location = new System.Drawing.Point(18, 57);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(79, 20);
            this.rbNacional.TabIndex = 3;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExtranjero);
            this.groupBox1.Controls.Add(this.rbNacional);
            this.groupBox1.Location = new System.Drawing.Point(655, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nacionalidades";
            // 
            // btnAltaA
            // 
            this.btnAltaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaA.Location = new System.Drawing.Point(539, 29);
            this.btnAltaA.Name = "btnAltaA";
            this.btnAltaA.Size = new System.Drawing.Size(110, 35);
            this.btnAltaA.TabIndex = 5;
            this.btnAltaA.Text = "Alta";
            this.btnAltaA.UseVisualStyleBackColor = true;
            this.btnAltaA.Click += new System.EventHandler(this.btnAltaA_Click);
            // 
            // btnBajaA
            // 
            this.btnBajaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaA.Location = new System.Drawing.Point(539, 70);
            this.btnBajaA.Name = "btnBajaA";
            this.btnBajaA.Size = new System.Drawing.Size(110, 35);
            this.btnBajaA.TabIndex = 6;
            this.btnBajaA.Text = "Baja";
            this.btnBajaA.UseVisualStyleBackColor = true;
            this.btnBajaA.Click += new System.EventHandler(this.btnBajaA_Click);
            // 
            // btnModificarA
            // 
            this.btnModificarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarA.Location = new System.Drawing.Point(539, 111);
            this.btnModificarA.Name = "btnModificarA";
            this.btnModificarA.Size = new System.Drawing.Size(110, 35);
            this.btnModificarA.TabIndex = 7;
            this.btnModificarA.Text = "Modificación";
            this.btnModificarA.UseVisualStyleBackColor = true;
            this.btnModificarA.Click += new System.EventHandler(this.btnModificarA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Teléfonos alumnos";
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AllowUserToAddRows = false;
            this.dgvTelefonos.AllowUserToDeleteRows = false;
            this.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Location = new System.Drawing.Point(15, 244);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.ReadOnly = true;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(444, 163);
            this.dgvTelefonos.TabIndex = 9;
            // 
            // btnAltaT
            // 
            this.btnAltaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaT.Location = new System.Drawing.Point(465, 244);
            this.btnAltaT.Name = "btnAltaT";
            this.btnAltaT.Size = new System.Drawing.Size(110, 35);
            this.btnAltaT.TabIndex = 10;
            this.btnAltaT.Text = "Alta";
            this.btnAltaT.UseVisualStyleBackColor = true;
            this.btnAltaT.Click += new System.EventHandler(this.btnAltaT_Click);
            // 
            // dgvRE
            // 
            this.dgvRE.AllowUserToAddRows = false;
            this.dgvRE.AllowUserToDeleteRows = false;
            this.dgvRE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRE.Location = new System.Drawing.Point(655, 244);
            this.dgvRE.Name = "dgvRE";
            this.dgvRE.ReadOnly = true;
            this.dgvRE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRE.Size = new System.Drawing.Size(444, 163);
            this.dgvRE.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Actualización";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDesc);
            this.groupBox2.Controls.Add(this.rbAsc);
            this.groupBox2.Location = new System.Drawing.Point(805, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar";
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Checked = true;
            this.rbAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAsc.Location = new System.Drawing.Point(25, 33);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(97, 20);
            this.rbAsc.TabIndex = 4;
            this.rbAsc.Text = "Ascendente";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesc.Location = new System.Drawing.Point(25, 59);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(106, 20);
            this.rbDesc.TabIndex = 5;
            this.rbDesc.Text = "Descendente";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(805, 135);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(110, 35);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 433);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRE);
            this.Controls.Add(this.btnAltaT);
            this.Controls.Add(this.dgvTelefonos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificarA);
            this.Controls.Add(this.btnBajaA);
            this.Controls.Add(this.btnAltaA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.RadioButton rbExtranjero;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaA;
        private System.Windows.Forms.Button btnBajaA;
        private System.Windows.Forms.Button btnModificarA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.Button btnAltaT;
        private System.Windows.Forms.DataGridView dgvRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.Button btnMostrar;
    }
}

