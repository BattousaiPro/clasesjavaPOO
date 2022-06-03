namespace GestionTareas
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
            this.btnSendAction_Click = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendAction_Click
            // 
            this.btnSendAction_Click.Location = new System.Drawing.Point(239, 80);
            this.btnSendAction_Click.Name = "btnSendAction_Click";
            this.btnSendAction_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSendAction_Click.TabIndex = 0;
            this.btnSendAction_Click.Text = "Validar";
            this.btnSendAction_Click.UseVisualStyleBackColor = true;
            this.btnSendAction_Click.Click += new System.EventHandler(this.tbxResult_TextChanged);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(47, 124);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(100, 20);
            this.tbxResult.TabIndex = 2;
            this.tbxResult.TextChanged += new System.EventHandler(this.tbxResult_TextChanged);
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(47, 80);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(100, 20);
            this.txbAge.TabIndex = 3;
            this.txbAge.TextChanged += new System.EventHandler(this.txbAge_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnSendAction_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendAction_Click;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.TextBox txbAge;
    }
}

