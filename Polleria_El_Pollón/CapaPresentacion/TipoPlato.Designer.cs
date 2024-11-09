namespace CapaPresentacion
{
    partial class TipoPlato
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreTipoPedido = new System.Windows.Forms.TextBox();
            this.txtIDTipoPedido = new System.Windows.Forms.TextBox();
            this.dgvTipoPedido = new System.Windows.Forms.DataGridView();
            this.idTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarTipoPedido = new System.Windows.Forms.Button();
            this.btnEliminarTipoPedido = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.btnModificarTipoPedido = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Location = new System.Drawing.Point(29, 390);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 50);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombreTipoPedido
            // 
            this.txtNombreTipoPedido.Location = new System.Drawing.Point(29, 140);
            this.txtNombreTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreTipoPedido.Name = "txtNombreTipoPedido";
            this.txtNombreTipoPedido.Size = new System.Drawing.Size(239, 22);
            this.txtNombreTipoPedido.TabIndex = 12;
            // 
            // txtIDTipoPedido
            // 
            this.txtIDTipoPedido.Location = new System.Drawing.Point(29, 57);
            this.txtIDTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDTipoPedido.Name = "txtIDTipoPedido";
            this.txtIDTipoPedido.Size = new System.Drawing.Size(239, 22);
            this.txtIDTipoPedido.TabIndex = 10;
            // 
            // dgvTipoPedido
            // 
            this.dgvTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoPedido,
            this.nombreTipoPedido});
            this.dgvTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTipoPedido.Location = new System.Drawing.Point(393, 23);
            this.dgvTipoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTipoPedido.Name = "dgvTipoPedido";
            this.dgvTipoPedido.ReadOnly = true;
            this.dgvTipoPedido.RowHeadersWidth = 51;
            this.dgvTipoPedido.RowTemplate.Height = 24;
            this.dgvTipoPedido.Size = new System.Drawing.Size(682, 342);
            this.dgvTipoPedido.TabIndex = 6;
            // 
            // idTipoPedido
            // 
            this.idTipoPedido.DataPropertyName = "IdTipoPedido";
            this.idTipoPedido.HeaderText = "ID";
            this.idTipoPedido.MinimumWidth = 6;
            this.idTipoPedido.Name = "idTipoPedido";
            this.idTipoPedido.ReadOnly = true;
            this.idTipoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreTipoPedido
            // 
            this.nombreTipoPedido.DataPropertyName = "NombreTipoPedido";
            this.nombreTipoPedido.HeaderText = "Nombre del Tipo de Plato";
            this.nombreTipoPedido.MinimumWidth = 6;
            this.nombreTipoPedido.Name = "nombreTipoPedido";
            this.nombreTipoPedido.ReadOnly = true;
            // 
            // btnAgregarTipoPedido
            // 
            this.btnAgregarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnAgregarTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTipoPedido.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarTipoPedido.Location = new System.Drawing.Point(31, 245);
            this.btnAgregarTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTipoPedido.Name = "btnAgregarTipoPedido";
            this.btnAgregarTipoPedido.Size = new System.Drawing.Size(128, 46);
            this.btnAgregarTipoPedido.TabIndex = 5;
            this.btnAgregarTipoPedido.Text = "Crear";
            this.btnAgregarTipoPedido.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTipoPedido
            // 
            this.btnEliminarTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnEliminarTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTipoPedido.FlatAppearance.BorderSize = 0;
            this.btnEliminarTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarTipoPedido.Location = new System.Drawing.Point(836, 390);
            this.btnEliminarTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTipoPedido.Name = "btnEliminarTipoPedido";
            this.btnEliminarTipoPedido.Size = new System.Drawing.Size(128, 46);
            this.btnEliminarTipoPedido.TabIndex = 8;
            this.btnEliminarTipoPedido.Text = "Eliminar";
            this.btnEliminarTipoPedido.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(27, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 21);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre Tipo de Plato";
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoPedido.Location = new System.Drawing.Point(27, 28);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(146, 21);
            this.lblTipoPedido.TabIndex = 9;
            this.lblTipoPedido.Text = "ID Tipo de plato";
            // 
            // btnModificarTipoPedido
            // 
            this.btnModificarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnModificarTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarTipoPedido.FlatAppearance.BorderSize = 0;
            this.btnModificarTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificarTipoPedido.Location = new System.Drawing.Point(238, 245);
            this.btnModificarTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarTipoPedido.Name = "btnModificarTipoPedido";
            this.btnModificarTipoPedido.Size = new System.Drawing.Size(128, 46);
            this.btnModificarTipoPedido.TabIndex = 7;
            this.btnModificarTipoPedido.Text = "Modificar";
            this.btnModificarTipoPedido.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.txtNombreTipoPedido);
            this.panel2.Controls.Add(this.txtIDTipoPedido);
            this.panel2.Controls.Add(this.dgvTipoPedido);
            this.panel2.Controls.Add(this.btnEliminarTipoPedido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblTipoPedido);
            this.panel2.Controls.Add(this.btnModificarTipoPedido);
            this.panel2.Controls.Add(this.btnAgregarTipoPedido);
            this.panel2.Location = new System.Drawing.Point(26, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 464);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(508, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 537);
            this.panel1.TabIndex = 1;
            // 
            // TipoPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 537);
            this.Controls.Add(this.panel1);
            this.Name = "TipoPlato";
            this.Text = "TipoPlato";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreTipoPedido;
        private System.Windows.Forms.TextBox txtIDTipoPedido;
        private System.Windows.Forms.DataGridView dgvTipoPedido;
        private System.Windows.Forms.Button btnAgregarTipoPedido;
        private System.Windows.Forms.Button btnEliminarTipoPedido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.Button btnModificarTipoPedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoPedido;
    }
}