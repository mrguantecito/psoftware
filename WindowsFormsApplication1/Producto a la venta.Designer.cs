namespace WindowsFormsApplication1
{
    partial class Producto_a_la_venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_a_la_venta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcodigoproducto = new System.Windows.Forms.ComboBox();
            this.txtcodigoproductoalaventa = new System.Windows.Forms.TextBox();
            this.nombreproductoalaventa = new System.Windows.Forms.TextBox();
            this.precioproductoalaventa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnguardarproductoalaventa = new System.Windows.Forms.Button();
            this.btnmodificarproductoalaventa = new System.Windows.Forms.Button();
            this.deshabilitarproductoalaventa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(45, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "codigo producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Productos a la venta";
            // 
            // cbcodigoproducto
            // 
            this.cbcodigoproducto.FormattingEnabled = true;
            this.cbcodigoproducto.Location = new System.Drawing.Point(190, 74);
            this.cbcodigoproducto.Name = "cbcodigoproducto";
            this.cbcodigoproducto.Size = new System.Drawing.Size(66, 21);
            this.cbcodigoproducto.TabIndex = 5;
            this.cbcodigoproducto.SelectedIndexChanged += new System.EventHandler(this.cbcodigoproducto_SelectedIndexChanged);
            // 
            // txtcodigoproductoalaventa
            // 
            this.txtcodigoproductoalaventa.Location = new System.Drawing.Point(274, 75);
            this.txtcodigoproductoalaventa.Name = "txtcodigoproductoalaventa";
            this.txtcodigoproductoalaventa.Size = new System.Drawing.Size(30, 20);
            this.txtcodigoproductoalaventa.TabIndex = 6;
            // 
            // nombreproductoalaventa
            // 
            this.nombreproductoalaventa.Location = new System.Drawing.Point(190, 110);
            this.nombreproductoalaventa.Name = "nombreproductoalaventa";
            this.nombreproductoalaventa.Size = new System.Drawing.Size(100, 20);
            this.nombreproductoalaventa.TabIndex = 7;
            // 
            // precioproductoalaventa
            // 
            this.precioproductoalaventa.Location = new System.Drawing.Point(190, 151);
            this.precioproductoalaventa.Name = "precioproductoalaventa";
            this.precioproductoalaventa.Size = new System.Drawing.Size(100, 20);
            this.precioproductoalaventa.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnguardarproductoalaventa
            // 
            this.btnguardarproductoalaventa.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnguardarproductoalaventa.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarproductoalaventa.Image")));
            this.btnguardarproductoalaventa.Location = new System.Drawing.Point(99, 247);
            this.btnguardarproductoalaventa.Name = "btnguardarproductoalaventa";
            this.btnguardarproductoalaventa.Size = new System.Drawing.Size(75, 72);
            this.btnguardarproductoalaventa.TabIndex = 10;
            this.btnguardarproductoalaventa.UseVisualStyleBackColor = false;
            // 
            // btnmodificarproductoalaventa
            // 
            this.btnmodificarproductoalaventa.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnmodificarproductoalaventa.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificarproductoalaventa.Image")));
            this.btnmodificarproductoalaventa.Location = new System.Drawing.Point(229, 249);
            this.btnmodificarproductoalaventa.Name = "btnmodificarproductoalaventa";
            this.btnmodificarproductoalaventa.Size = new System.Drawing.Size(75, 70);
            this.btnmodificarproductoalaventa.TabIndex = 11;
            this.btnmodificarproductoalaventa.UseVisualStyleBackColor = false;
            // 
            // deshabilitarproductoalaventa
            // 
            this.deshabilitarproductoalaventa.BackColor = System.Drawing.Color.DarkKhaki;
            this.deshabilitarproductoalaventa.Image = ((System.Drawing.Image)(resources.GetObject("deshabilitarproductoalaventa.Image")));
            this.deshabilitarproductoalaventa.Location = new System.Drawing.Point(367, 249);
            this.deshabilitarproductoalaventa.Name = "deshabilitarproductoalaventa";
            this.deshabilitarproductoalaventa.Size = new System.Drawing.Size(75, 70);
            this.deshabilitarproductoalaventa.TabIndex = 12;
            this.deshabilitarproductoalaventa.UseVisualStyleBackColor = false;
            // 
            // Producto_a_la_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(525, 386);
            this.Controls.Add(this.deshabilitarproductoalaventa);
            this.Controls.Add(this.btnmodificarproductoalaventa);
            this.Controls.Add(this.btnguardarproductoalaventa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.precioproductoalaventa);
            this.Controls.Add(this.nombreproductoalaventa);
            this.Controls.Add(this.txtcodigoproductoalaventa);
            this.Controls.Add(this.cbcodigoproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Producto_a_la_venta";
            this.Text = "Producto_a_la_venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcodigoproducto;
        private System.Windows.Forms.TextBox txtcodigoproductoalaventa;
        private System.Windows.Forms.TextBox nombreproductoalaventa;
        private System.Windows.Forms.TextBox precioproductoalaventa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnguardarproductoalaventa;
        private System.Windows.Forms.Button btnmodificarproductoalaventa;
        private System.Windows.Forms.Button deshabilitarproductoalaventa;
    }
}