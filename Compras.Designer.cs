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
            lblTotal1 = new Label();
            label21 = new Label();
            cbxCantidad = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            btnPagar = new Button();
            cBox5 = new ComboBox();
            lblPrecio = new Label();
            lblCantidad1 = new Label();
            lblProducto1 = new Label();
            cBox3 = new ComboBox();
            lblrecibe20 = new Label();
            linkLabel2 = new LinkLabel();
            cBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(85, 24);
            label1.Name = "label1";
            label1.Size = new Size(349, 30);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a nuestra tienda";
            // 
            // cbxProducto
            // 
            cbxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProducto.FormattingEnabled = true;
            cbxProducto.Location = new Point(166, 85);
            cbxProducto.Margin = new Padding(4, 3, 4, 3);
            cbxProducto.Name = "cbxProducto";
            cbxProducto.Size = new Size(120, 23);
            cbxProducto.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLight;
            btnAgregar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(180, 179);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 40);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgProductos
            // 
            dgProductos.BackgroundColor = Color.FromArgb(135, 170, 170);
            dgProductos.BorderStyle = BorderStyle.None;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio, Cantidad, Total });
            dgProductos.Location = new Point(40, 253);
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
            // lblTotal1
            // 
            lblTotal1.AutoSize = true;
            lblTotal1.Font = new Font("Microsoft Sans Serif", 12F);
            lblTotal1.ForeColor = Color.Black;
            lblTotal1.Location = new Point(275, 137);
            lblTotal1.Margin = new Padding(4, 0, 4, 0);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(18, 20);
            lblTotal1.TabIndex = 85;
            lblTotal1.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(214, 137);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(66, 20);
            label21.TabIndex = 84;
            label21.Text = "Precio $";
            // 
            // cbxCantidad
            // 
            cbxCantidad.BackColor = Color.White;
            cbxCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCantidad.FormattingEnabled = true;
            cbxCantidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbxCantidad.Location = new Point(389, 83);
            cbxCantidad.Margin = new Padding(4, 3, 4, 3);
            cbxCantidad.Name = "cbxCantidad";
            cbxCantidad.Size = new Size(45, 23);
            cbxCantidad.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(308, 86);
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
            label3.Location = new Point(85, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 81;
            label3.Text = "Producto";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.ControlLight;
            btnPagar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.Black;
            btnPagar.Location = new Point(180, 450);
            btnPagar.Margin = new Padding(4, 3, 4, 3);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(180, 40);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // cBox5
            // 
            cBox5.FormattingEnabled = true;
            cBox5.Location = new Point(252, 509);
            cBox5.Margin = new Padding(4, 3, 4, 3);
            cBox5.Name = "cBox5";
            cBox5.Size = new Size(59, 23);
            cBox5.TabIndex = 97;
            cBox5.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(58, 516);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(10, 15);
            lblPrecio.TabIndex = 96;
            lblPrecio.Text = ".";
            lblPrecio.Visible = false;
            // 
            // lblCantidad1
            // 
            lblCantidad1.AutoSize = true;
            lblCantidad1.Location = new Point(58, 501);
            lblCantidad1.Margin = new Padding(4, 0, 4, 0);
            lblCantidad1.Name = "lblCantidad1";
            lblCantidad1.Size = new Size(10, 15);
            lblCantidad1.TabIndex = 95;
            lblCantidad1.Text = ".";
            lblCantidad1.Visible = false;
            // 
            // lblProducto1
            // 
            lblProducto1.AutoSize = true;
            lblProducto1.Location = new Point(58, 486);
            lblProducto1.Margin = new Padding(4, 0, 4, 0);
            lblProducto1.Name = "lblProducto1";
            lblProducto1.Size = new Size(10, 15);
            lblProducto1.TabIndex = 94;
            lblProducto1.Text = ".";
            lblProducto1.Visible = false;
            // 
            // cBox3
            // 
            cBox3.BackColor = Color.White;
            cBox3.FormattingEnabled = true;
            cBox3.Items.AddRange(new object[] { "199", "199", "699", "299", "399" });
            cBox3.Location = new Point(319, 509);
            cBox3.Margin = new Padding(4, 3, 4, 3);
            cBox3.Name = "cBox3";
            cBox3.Size = new Size(59, 23);
            cBox3.TabIndex = 93;
            cBox3.Visible = false;
            // 
            // lblrecibe20
            // 
            lblrecibe20.AutoSize = true;
            lblrecibe20.Location = new Point(11, 489);
            lblrecibe20.Margin = new Padding(4, 0, 4, 0);
            lblrecibe20.Name = "lblrecibe20";
            lblrecibe20.Size = new Size(37, 15);
            lblrecibe20.TabIndex = 92;
            lblrecibe20.Text = "ADMI";
            lblrecibe20.Visible = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Crimson;
            linkLabel2.Location = new Point(11, 516);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(34, 15);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Atras";
            linkLabel2.VisitedLinkColor = Color.Crimson;
            // 
            // cBox1
            // 
            cBox1.BackColor = Color.White;
            cBox1.FormattingEnabled = true;
            cBox1.Items.AddRange(new object[] { "Playera Mandalorian", "Playera JL Aquaman Logo", "Hogwarts Jacket", "JL Flash Pullover", "The Shield Hoodie" });
            cBox1.Location = new Point(97, 509);
            cBox1.Margin = new Padding(4, 3, 4, 3);
            cBox1.Name = "cBox1";
            cBox1.Size = new Size(148, 23);
            cBox1.TabIndex = 90;
            cBox1.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel1.Location = new Point(435, 513);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cerrar Sesión";
            linkLabel1.VisitedLinkColor = Color.Crimson;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 227, 212);
            ClientSize = new Size(524, 535);
            Controls.Add(cBox5);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad1);
            Controls.Add(lblProducto1);
            Controls.Add(cBox3);
            Controls.Add(lblrecibe20);
            Controls.Add(linkLabel2);
            Controls.Add(cBox1);
            Controls.Add(linkLabel1);
            Controls.Add(cbxProducto);
            Controls.Add(btnAgregar);
            Controls.Add(dgProductos);
            Controls.Add(lblTotal1);
            Controls.Add(label21);
            Controls.Add(cbxCantidad);
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
        private Label lblTotal1;
        private Label label21;
        private ComboBox cbxCantidad;
        private Label label5;
        private Label label3;
        private Button btnPagar;
        private ComboBox cBox5;
        private Label lblPrecio;
        private Label lblCantidad1;
        private Label lblProducto1;
        private ComboBox cBox3;
        public Label lblrecibe20;
        private LinkLabel linkLabel2;
        private ComboBox cBox1;
        private LinkLabel linkLabel1;
    }
}