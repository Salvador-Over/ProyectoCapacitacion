
namespace CapaVista
{
    partial class combo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboInteligente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboInteligente
            // 
            this.comboInteligente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboInteligente.FormattingEnabled = true;
            this.comboInteligente.Location = new System.Drawing.Point(0, 0);
            this.comboInteligente.Name = "comboInteligente";
            this.comboInteligente.Size = new System.Drawing.Size(234, 24);
            this.comboInteligente.TabIndex = 0;
            this.comboInteligente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboInteligente);
            this.Name = "combo";
            this.Size = new System.Drawing.Size(234, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboInteligente;
    }
}
