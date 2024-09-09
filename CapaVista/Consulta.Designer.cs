
namespace CapaVista
{
    partial class Consulta
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
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigoEmp = new System.Windows.Forms.TextBox();
            this.nombreEmp = new System.Windows.Forms.TextBox();
            this.puestoEmp = new System.Windows.Forms.TextBox();
            this.deptoEmp = new System.Windows.Forms.TextBox();
            this.cboEstadoEmp = new System.Windows.Forms.ComboBox();
            this.insertarEmp = new System.Windows.Forms.Button();
            this.editarEmp = new System.Windows.Forms.Button();
            this.eliminarEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(224, 10);
            this.Dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(436, 361);
            this.Dgv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(108, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(14, 60);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado";
            // 
            // codigoEmp
            // 
            this.codigoEmp.Location = new System.Drawing.Point(94, 14);
            this.codigoEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoEmp.Name = "codigoEmp";
            this.codigoEmp.Size = new System.Drawing.Size(76, 20);
            this.codigoEmp.TabIndex = 7;
            // 
            // nombreEmp
            // 
            this.nombreEmp.Location = new System.Drawing.Point(94, 56);
            this.nombreEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreEmp.Name = "nombreEmp";
            this.nombreEmp.Size = new System.Drawing.Size(76, 20);
            this.nombreEmp.TabIndex = 8;
            // 
            // puestoEmp
            // 
            this.puestoEmp.Location = new System.Drawing.Point(94, 96);
            this.puestoEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.puestoEmp.Name = "puestoEmp";
            this.puestoEmp.Size = new System.Drawing.Size(76, 20);
            this.puestoEmp.TabIndex = 9;
            // 
            // deptoEmp
            // 
            this.deptoEmp.Location = new System.Drawing.Point(94, 141);
            this.deptoEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deptoEmp.Name = "deptoEmp";
            this.deptoEmp.Size = new System.Drawing.Size(76, 20);
            this.deptoEmp.TabIndex = 10;
            // 
            // cboEstadoEmp
            // 
            this.cboEstadoEmp.FormattingEnabled = true;
            this.cboEstadoEmp.Location = new System.Drawing.Point(94, 188);
            this.cboEstadoEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstadoEmp.Name = "cboEstadoEmp";
            this.cboEstadoEmp.Size = new System.Drawing.Size(92, 21);
            this.cboEstadoEmp.TabIndex = 12;
            // 
            // insertarEmp
            // 
            this.insertarEmp.Location = new System.Drawing.Point(16, 287);
            this.insertarEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertarEmp.Name = "insertarEmp";
            this.insertarEmp.Size = new System.Drawing.Size(75, 36);
            this.insertarEmp.TabIndex = 13;
            this.insertarEmp.Text = "Insertar";
            this.insertarEmp.UseVisualStyleBackColor = true;
            // 
            // editarEmp
            // 
            this.editarEmp.Location = new System.Drawing.Point(16, 335);
            this.editarEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editarEmp.Name = "editarEmp";
            this.editarEmp.Size = new System.Drawing.Size(71, 36);
            this.editarEmp.TabIndex = 14;
            this.editarEmp.Text = "Editar";
            this.editarEmp.UseVisualStyleBackColor = true;
            // 
            // eliminarEmp
            // 
            this.eliminarEmp.Location = new System.Drawing.Point(108, 336);
            this.eliminarEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminarEmp.Name = "eliminarEmp";
            this.eliminarEmp.Size = new System.Drawing.Size(84, 35);
            this.eliminarEmp.TabIndex = 15;
            this.eliminarEmp.Text = "Eliminar";
            this.eliminarEmp.UseVisualStyleBackColor = true;
            this.eliminarEmp.Click += new System.EventHandler(this.eliminarEmp_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 386);
            this.Controls.Add(this.eliminarEmp);
            this.Controls.Add(this.editarEmp);
            this.Controls.Add(this.insertarEmp);
            this.Controls.Add(this.cboEstadoEmp);
            this.Controls.Add(this.deptoEmp);
            this.Controls.Add(this.puestoEmp);
            this.Controls.Add(this.nombreEmp);
            this.Controls.Add(this.codigoEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Consulta";
            this.Text = "CREUD Empleados";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigoEmp;
        private System.Windows.Forms.TextBox nombreEmp;
        private System.Windows.Forms.TextBox puestoEmp;
        private System.Windows.Forms.TextBox deptoEmp;
        private System.Windows.Forms.ComboBox cboEstadoEmp;
        private System.Windows.Forms.Button insertarEmp;
        private System.Windows.Forms.Button editarEmp;
        private System.Windows.Forms.Button eliminarEmp;
    }
}