namespace Sistema_ventas
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            label1 = new Label();
            cbxProducto = new ComboBox();
            btnAgregar = new Button();
            dgProductos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblTotalProducto = new Label();
            label21 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnPagar = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            txtCantidad = new TextBox();
            btnVerPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(73, 22);
            label1.Name = "label1";
            label1.Size = new Size(349, 30);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a nuestra tienda";
            // 
            // cbxProducto
            // 
            cbxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProducto.FormattingEnabled = true;
            cbxProducto.Location = new Point(154, 83);
            cbxProducto.Margin = new Padding(4, 3, 4, 3);
            cbxProducto.Name = "cbxProducto";
            cbxProducto.Size = new Size(120, 23);
            cbxProducto.TabIndex = 1;
            cbxProducto.SelectedIndexChanged += cbxProducto_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLight;
            btnAgregar.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(289, 184);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgProductos
            // 
            dgProductos.BackgroundColor = Color.FromArgb(135, 170, 170);
            dgProductos.BorderStyle = BorderStyle.None;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio, Cantidad, Total });
            dgProductos.Location = new Point(28, 251);
            dgProductos.Margin = new Padding(4, 3, 4, 3);
            dgProductos.Name = "dgProductos";
            dgProductos.ReadOnly = true;
            dgProductos.Size = new Size(441, 182);
            dgProductos.TabIndex = 86;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // lblTotalProducto
            // 
            lblTotalProducto.AutoSize = true;
            lblTotalProducto.Font = new Font("Microsoft Sans Serif", 12F);
            lblTotalProducto.ForeColor = Color.Black;
            lblTotalProducto.Location = new Point(263, 135);
            lblTotalProducto.Margin = new Padding(4, 0, 4, 0);
            lblTotalProducto.Name = "lblTotalProducto";
            lblTotalProducto.Size = new Size(18, 20);
            lblTotalProducto.TabIndex = 85;
            lblTotalProducto.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(202, 135);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(66, 20);
            label21.TabIndex = 84;
            label21.Text = "Precio $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(296, 84);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 82;
            label5.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(73, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 81;
            label3.Text = "Producto";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.ControlLight;
            btnPagar.Font = new Font("MS Reference Sans Serif", 12F);
            btnPagar.ForeColor = Color.Black;
            btnPagar.Location = new Point(156, 448);
            btnPagar.Margin = new Padding(4, 3, 4, 3);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(180, 40);
            btnPagar.TabIndex = 5;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Crimson;
            linkLabel2.Location = new Point(13, 479);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(34, 15);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Atras";
            linkLabel2.VisitedLinkColor = Color.Crimson;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel1.Location = new Point(411, 479);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cerrar Sesión";
            linkLabel1.VisitedLinkColor = Color.Crimson;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(377, 84);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(45, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // btnVerPrecio
            // 
            btnVerPrecio.BackColor = SystemColors.ControlLight;
            btnVerPrecio.Font = new Font("MS Reference Sans Serif", 12F);
            btnVerPrecio.ForeColor = Color.Black;
            btnVerPrecio.Location = new Point(28, 184);
            btnVerPrecio.Margin = new Padding(4, 3, 4, 3);
            btnVerPrecio.Name = "btnVerPrecio";
            btnVerPrecio.Size = new Size(180, 33);
            btnVerPrecio.TabIndex = 3;
            btnVerPrecio.Text = "Ver Precio";
            btnVerPrecio.UseVisualStyleBackColor = false;
            btnVerPrecio.Click += btnVerPrecio_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 227, 212);
            ClientSize = new Size(500, 503);
            Controls.Add(btnVerPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(cbxProducto);
            Controls.Add(btnAgregar);
            Controls.Add(dgProductos);
            Controls.Add(lblTotalProducto);
            Controls.Add(label21);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnPagar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxProducto;
        private Button btnAgregar;
        private DataGridView dgProductos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private Label lblTotalProducto;
        private Label label21;
        private Label label5;
        private Label label3;
        private Button btnPagar;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private TextBox txtCantidad;
        private Button btnVerPrecio;
    }
}