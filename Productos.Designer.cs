namespace Sistema_ventas
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            label1 = new Label();
            btnRealizarCompra = new Button();
            linkLblCerrarSesion = new LinkLabel();
            linkLblMenu = new LinkLabel();
            label3 = new Label();
            txtPrecioProducto = new TextBox();
            label2 = new Label();
            txtNombreProducto = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(57, 24);
            label1.Name = "label1";
            label1.Size = new Size(223, 30);
            label1.TabIndex = 2;
            label1.Text = "Agregar Producto";
            // 
            // btnRealizarCompra
            // 
            btnRealizarCompra.BackColor = SystemColors.ControlLight;
            btnRealizarCompra.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRealizarCompra.ForeColor = Color.Black;
            btnRealizarCompra.Location = new Point(82, 294);
            btnRealizarCompra.Margin = new Padding(4, 3, 4, 3);
            btnRealizarCompra.Name = "btnRealizarCompra";
            btnRealizarCompra.Size = new Size(167, 36);
            btnRealizarCompra.TabIndex = 3;
            btnRealizarCompra.Text = "Registrar";
            btnRealizarCompra.UseVisualStyleBackColor = false;
            btnRealizarCompra.Click += btnRealizarCompra_Click;
            // 
            // linkLblCerrarSesion
            // 
            linkLblCerrarSesion.AutoSize = true;
            linkLblCerrarSesion.LinkColor = Color.Crimson;
            linkLblCerrarSesion.Location = new Point(243, 363);
            linkLblCerrarSesion.Name = "linkLblCerrarSesion";
            linkLblCerrarSesion.Size = new Size(76, 15);
            linkLblCerrarSesion.TabIndex = 4;
            linkLblCerrarSesion.TabStop = true;
            linkLblCerrarSesion.Text = "Cerrar Sesión";
            linkLblCerrarSesion.VisitedLinkColor = Color.Crimson;
            linkLblCerrarSesion.LinkClicked += linkLblCerrarSesion_LinkClicked;
            // 
            // linkLblMenu
            // 
            linkLblMenu.AutoSize = true;
            linkLblMenu.LinkColor = Color.Crimson;
            linkLblMenu.Location = new Point(12, 363);
            linkLblMenu.Name = "linkLblMenu";
            linkLblMenu.Size = new Size(38, 15);
            linkLblMenu.TabIndex = 5;
            linkLblMenu.TabStop = true;
            linkLblMenu.Text = "Menu";
            linkLblMenu.VisitedLinkColor = Color.Crimson;
            linkLblMenu.LinkClicked += linkLblMenu_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(40, 228);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 9;
            label3.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(40, 252);
            txtPrecioProducto.MaxLength = 3000;
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(250, 23);
            txtPrecioProducto.TabIndex = 2;
            txtPrecioProducto.KeyPress += txtPrecioProducto_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(40, 172);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(40, 196);
            txtNombreProducto.MaxLength = 3000;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(250, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AddProducto;
            pictureBox1.Location = new Point(111, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 227, 212);
            ClientSize = new Size(331, 387);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtPrecioProducto);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(linkLblMenu);
            Controls.Add(linkLblCerrarSesion);
            Controls.Add(btnRealizarCompra);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRealizarCompra;
        private LinkLabel linkLblCerrarSesion;
        private LinkLabel linkLblMenu;
        private Label label3;
        private TextBox txtPrecioProducto;
        private Label label2;
        private TextBox txtNombreProducto;
        private PictureBox pictureBox1;
    }
}