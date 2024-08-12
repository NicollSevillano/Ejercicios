namespace Ejercicio7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCliente = new DataGridView();
            btnAltaCliente = new Button();
            btnBajaCliente = new Button();
            btnModificarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(12, 12);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(364, 150);
            dgvCliente.TabIndex = 0;
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.Font = new Font("Segoe UI", 11.25F);
            btnAltaCliente.Location = new Point(382, 12);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(88, 32);
            btnAltaCliente.TabIndex = 1;
            btnAltaCliente.Text = "Alta";
            btnAltaCliente.UseVisualStyleBackColor = true;
            btnAltaCliente.Click += btnAltaCliente_Click;
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.Font = new Font("Segoe UI", 11.25F);
            btnBajaCliente.Location = new Point(382, 57);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(88, 32);
            btnBajaCliente.TabIndex = 2;
            btnBajaCliente.Text = "Baja";
            btnBajaCliente.UseVisualStyleBackColor = true;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Font = new Font("Segoe UI", 11.25F);
            btnModificarCliente.Location = new Point(382, 102);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(88, 32);
            btnModificarCliente.TabIndex = 3;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnBajaCliente);
            Controls.Add(btnAltaCliente);
            Controls.Add(dgvCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCliente;
        private Button btnAltaCliente;
        private Button btnBajaCliente;
        private Button btnModificarCliente;
    }
}
