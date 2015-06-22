namespace WindowsFormsApplication1
{
    partial class Balances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balances));
            this.btnbalancediario = new System.Windows.Forms.Button();
            this.btnbalancemensual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvbalance = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbalancediario
            // 
            this.btnbalancediario.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnbalancediario.Image = ((System.Drawing.Image)(resources.GetObject("btnbalancediario.Image")));
            this.btnbalancediario.Location = new System.Drawing.Point(51, 82);
            this.btnbalancediario.Name = "btnbalancediario";
            this.btnbalancediario.Size = new System.Drawing.Size(75, 75);
            this.btnbalancediario.TabIndex = 0;
            this.btnbalancediario.UseVisualStyleBackColor = false;
            // 
            // btnbalancemensual
            // 
            this.btnbalancemensual.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnbalancemensual.Image = ((System.Drawing.Image)(resources.GetObject("btnbalancemensual.Image")));
            this.btnbalancemensual.Location = new System.Drawing.Point(302, 82);
            this.btnbalancemensual.Name = "btnbalancemensual";
            this.btnbalancemensual.Size = new System.Drawing.Size(75, 75);
            this.btnbalancemensual.TabIndex = 1;
            this.btnbalancemensual.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance diario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(269, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balance Mensual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvbalance
            // 
            this.dgvbalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbalance.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvbalance.Location = new System.Drawing.Point(24, 201);
            this.dgvbalance.Name = "dgvbalance";
            this.dgvbalance.Size = new System.Drawing.Size(427, 150);
            this.dgvbalance.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione Tipo de Balance";
            // 
            // Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvbalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbalancemensual);
            this.Controls.Add(this.btnbalancediario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Balances";
            this.Text = "Balances";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbalancediario;
        private System.Windows.Forms.Button btnbalancemensual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvbalance;
        private System.Windows.Forms.Label label3;
    }
}