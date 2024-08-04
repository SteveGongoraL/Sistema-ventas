namespace Sistema_ventas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            btnRegistrarProducto = new Button();
            btnRealizarCompra = new Button();
            linkLblCerrarSesion = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(263, 30);
            label1.TabIndex = 1;
            label1.Text = "¿Que quieres hacer?";
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.BackColor = SystemColors.ControlLight;
            btnRegistrarProducto.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarProducto.ForeColor = Color.Black;
            btnRegistrarProducto.Location = new Point(50, 125);
            btnRegistrarProducto.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(227, 40);
            btnRegistrarProducto.TabIndex = 1;
            btnRegistrarProducto.Text = "Registrar Producto";
            btnRegistrarProducto.UseVisualStyleBackColor = false;
            btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            // 
            // btnRealizarCompra
            // 
            btnRealizarCompra.BackColor = SystemColors.ControlLight;
            btnRealizarCompra.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRealizarCompra.ForeColor = Color.Black;
            btnRealizarCompra.Location = new Point(50, 194);
            btnRealizarCompra.Margin = new Padding(4, 3, 4, 3);
            btnRealizarCompra.Name = "btnRealizarCompra";
            btnRealizarCompra.Size = new Size(227, 40);
            btnRealizarCompra.TabIndex = 2;
            btnRealizarCompra.Text = "Realizar Compra";
            btnRealizarCompra.UseVisualStyleBackColor = false;
            btnRealizarCompra.Click += btnRealizarCompra_Click;
            // 
            // linkLblCerrarSesion
            // 
            linkLblCerrarSesion.AutoSize = true;
            linkLblCerrarSesion.LinkColor = Color.Crimson;
            linkLblCerrarSesion.Location = new Point(243, 320);
            linkLblCerrarSesion.Name = "linkLblCerrarSesion";
            linkLblCerrarSesion.Size = new Size(76, 15);
            linkLblCerrarSesion.TabIndex = 3;
            linkLblCerrarSesion.TabStop = true;
            linkLblCerrarSesion.Text = "Cerrar Sesión";
            linkLblCerrarSesion.VisitedLinkColor = Color.Crimson;
            linkLblCerrarSesion.LinkClicked += linkLblCerrarSesion_LinkClicked;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 227, 212);
            ClientSize = new Size(331, 344);
            Controls.Add(linkLblCerrarSesion);
            Controls.Add(btnRealizarCompra);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrarProducto;
        private Button btnRealizarCompra;
        private LinkLabel linkLblCerrarSesion;
    }
}