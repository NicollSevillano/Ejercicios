namespace Ejercicio3
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.btnAltaCobro = new System.Windows.Forms.Button();
            this.rbNormales = new System.Windows.Forms.RadioButton();
            this.rbEspeciales = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPagados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.btnMostarOrden = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCCancelados = new System.Windows.Forms.DataGridView();
            this.btnMostrarCobroCancelado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCancelados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(24, 48);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(273, 150);
            this.dgvCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1) Clientes";
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(314, 62);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(101, 32);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.Location = new System.Drawing.Point(314, 106);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(101, 32);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(314, 150);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 32);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificación";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "2) Cobros";
            // 
            // dgvCobros
            // 
            this.dgvCobros.AllowUserToAddRows = false;
            this.dgvCobros.AllowUserToDeleteRows = false;
            this.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobros.Location = new System.Drawing.Point(438, 48);
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.ReadOnly = true;
            this.dgvCobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobros.Size = new System.Drawing.Size(500, 150);
            this.dgvCobros.TabIndex = 6;
            // 
            // btnAltaCobro
            // 
            this.btnAltaCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCobro.Location = new System.Drawing.Point(955, 48);
            this.btnAltaCobro.Name = "btnAltaCobro";
            this.btnAltaCobro.Size = new System.Drawing.Size(101, 32);
            this.btnAltaCobro.TabIndex = 7;
            this.btnAltaCobro.Text = "Alta";
            this.btnAltaCobro.UseVisualStyleBackColor = true;
            this.btnAltaCobro.Click += new System.EventHandler(this.btnAltaCobro_Click);
            // 
            // rbNormales
            // 
            this.rbNormales.AutoSize = true;
            this.rbNormales.Checked = true;
            this.rbNormales.Location = new System.Drawing.Point(15, 28);
            this.rbNormales.Name = "rbNormales";
            this.rbNormales.Size = new System.Drawing.Size(91, 22);
            this.rbNormales.TabIndex = 8;
            this.rbNormales.TabStop = true;
            this.rbNormales.Text = "Normales";
            this.rbNormales.UseVisualStyleBackColor = true;
            // 
            // rbEspeciales
            // 
            this.rbEspeciales.AutoSize = true;
            this.rbEspeciales.Location = new System.Drawing.Point(15, 57);
            this.rbEspeciales.Name = "rbEspeciales";
            this.rbEspeciales.Size = new System.Drawing.Size(98, 22);
            this.rbEspeciales.TabIndex = 9;
            this.rbEspeciales.Text = "Especiales";
            this.rbEspeciales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEspeciales);
            this.groupBox1.Controls.Add(this.rbNormales);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(955, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 88);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo cobro";
            // 
            // dgvPagados
            // 
            this.dgvPagados.AllowUserToAddRows = false;
            this.dgvPagados.AllowUserToDeleteRows = false;
            this.dgvPagados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagados.Location = new System.Drawing.Point(24, 256);
            this.dgvPagados.Name = "dgvPagados";
            this.dgvPagados.ReadOnly = true;
            this.dgvPagados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagados.Size = new System.Drawing.Size(646, 150);
            this.dgvPagados.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "3) Pagados";
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(690, 268);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(101, 32);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "4) Pagados orden";
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToAddRows = false;
            this.dgvOrden.AllowUserToDeleteRows = false;
            this.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Location = new System.Drawing.Point(24, 459);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrden.Size = new System.Drawing.Size(500, 150);
            this.dgvOrden.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDescendente);
            this.groupBox2.Controls.Add(this.rbAscendente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(542, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 88);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo cobro";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(15, 57);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(113, 22);
            this.rbDescendente.TabIndex = 9;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Checked = true;
            this.rbAscendente.Location = new System.Drawing.Point(15, 28);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(103, 22);
            this.rbAscendente.TabIndex = 8;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // btnMostarOrden
            // 
            this.btnMostarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostarOrden.Location = new System.Drawing.Point(542, 563);
            this.btnMostarOrden.Name = "btnMostarOrden";
            this.btnMostarOrden.Size = new System.Drawing.Size(101, 32);
            this.btnMostarOrden.TabIndex = 16;
            this.btnMostarOrden.Text = "Ordenar";
            this.btnMostarOrden.UseVisualStyleBackColor = true;
            this.btnMostarOrden.Click += new System.EventHandler(this.btnMostarOrden_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "5) Cobros cancelados";
            // 
            // dgvCCancelados
            // 
            this.dgvCCancelados.AllowUserToAddRows = false;
            this.dgvCCancelados.AllowUserToDeleteRows = false;
            this.dgvCCancelados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCCancelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCCancelados.Location = new System.Drawing.Point(701, 459);
            this.dgvCCancelados.Name = "dgvCCancelados";
            this.dgvCCancelados.ReadOnly = true;
            this.dgvCCancelados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCCancelados.Size = new System.Drawing.Size(273, 150);
            this.dgvCCancelados.TabIndex = 18;
            // 
            // btnMostrarCobroCancelado
            // 
            this.btnMostrarCobroCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCobroCancelado.Location = new System.Drawing.Point(987, 475);
            this.btnMostrarCobroCancelado.Name = "btnMostrarCobroCancelado";
            this.btnMostrarCobroCancelado.Size = new System.Drawing.Size(101, 32);
            this.btnMostrarCobroCancelado.TabIndex = 19;
            this.btnMostrarCobroCancelado.Text = "Mostar";
            this.btnMostrarCobroCancelado.UseVisualStyleBackColor = true;
            this.btnMostrarCobroCancelado.Click += new System.EventHandler(this.btnMostrarCobroCancelado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 636);
            this.Controls.Add(this.btnMostrarCobroCancelado);
            this.Controls.Add(this.dgvCCancelados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMostarOrden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPagados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAltaCobro);
            this.Controls.Add(this.dgvCobros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCancelados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCobros;
        private System.Windows.Forms.Button btnAltaCobro;
        private System.Windows.Forms.RadioButton rbNormales;
        private System.Windows.Forms.RadioButton rbEspeciales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPagados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.Button btnMostarOrden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCCancelados;
        private System.Windows.Forms.Button btnMostrarCobroCancelado;
    }
}

