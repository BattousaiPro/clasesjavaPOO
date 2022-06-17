namespace GestionDeStock
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
            this.tbx = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAddress = new System.Windows.Forms.Button();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Electronica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muebles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaBlanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExportation = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx
            // 
            this.tbx.BackColor = System.Drawing.Color.Black;
            this.tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx.ForeColor = System.Drawing.Color.Red;
            this.tbx.Location = new System.Drawing.Point(505, 92);
            this.tbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(63, 24);
            this.tbx.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Black;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(486, 44);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(101, 18);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "ing.Cantidad";
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.Black;
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.ForeColor = System.Drawing.Color.Red;
            this.btnAddress.Location = new System.Drawing.Point(40, 220);
            this.btnAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(119, 45);
            this.btnAddress.TabIndex = 3;
            this.btnAddress.Text = "Address";
            this.btnAddress.UseVisualStyleBackColor = false;
            // 
            // cbxCategories
            // 
            this.cbxCategories.BackColor = System.Drawing.Color.Black;
            this.cbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategories.ForeColor = System.Drawing.Color.Red;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(273, 90);
            this.cbxCategories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(150, 26);
            this.cbxCategories.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Electronica,
            this.Muebles,
            this.LineaBlanca,
            this.Stock});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(40, 292);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 227);
            this.dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Electronica
            // 
            this.Electronica.HeaderText = "Electronica";
            this.Electronica.MinimumWidth = 6;
            this.Electronica.Name = "Electronica";
            this.Electronica.Width = 125;
            // 
            // Muebles
            // 
            this.Muebles.HeaderText = "Muebles";
            this.Muebles.MinimumWidth = 6;
            this.Muebles.Name = "Muebles";
            this.Muebles.Width = 125;
            // 
            // LineaBlanca
            // 
            this.LineaBlanca.HeaderText = "LineaBlanca";
            this.LineaBlanca.MinimumWidth = 6;
            this.LineaBlanca.Name = "LineaBlanca";
            this.LineaBlanca.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(229, 220);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 45);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnExportation
            // 
            this.btnExportation.BackColor = System.Drawing.Color.Black;
            this.btnExportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportation.ForeColor = System.Drawing.Color.Red;
            this.btnExportation.Location = new System.Drawing.Point(602, 220);
            this.btnExportation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportation.Name = "btnExportation";
            this.btnExportation.Size = new System.Drawing.Size(119, 45);
            this.btnExportation.TabIndex = 8;
            this.btnExportation.Text = "Exportation";
            this.btnExportation.UseVisualStyleBackColor = false;
            this.btnExportation.Click += new System.EventHandler(this.btnExportation_Click);
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.BackColor = System.Drawing.Color.Black;
            this.Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.ForeColor = System.Drawing.Color.Red;
            this.Categoria.Location = new System.Drawing.Point(282, 44);
            this.Categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(81, 18);
            this.Categoria.TabIndex = 9;
            this.Categoria.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ing.Producto";
            // 
            // tbxProduct
            // 
            this.tbxProduct.BackColor = System.Drawing.Color.Black;
            this.tbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProduct.ForeColor = System.Drawing.Color.Red;
            this.tbxProduct.Location = new System.Drawing.Point(40, 90);
            this.tbxProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(190, 24);
            this.tbxProduct.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(417, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(748, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxProduct);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.btnExportation);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExportation;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Electronica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muebles;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaBlanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}

