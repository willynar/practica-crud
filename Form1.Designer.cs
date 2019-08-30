namespace practica_crud
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
            this.components = new System.ComponentModel.Container();
            this.prueba_crudDataSet = new practica_crud.prueba_crudDataSet();
            this.pruebacrudDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prueba_crudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebacrudDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prueba_crudDataSet
            // 
            this.prueba_crudDataSet.DataSetName = "prueba_crudDataSet";
            this.prueba_crudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruebacrudDataSetBindingSource
            // 
            this.pruebacrudDataSetBindingSource.DataSource = this.prueba_crudDataSet;
            this.pruebacrudDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prueba_crudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebacrudDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pruebacrudDataSetBindingSource;
        private prueba_crudDataSet prueba_crudDataSet;
    }
}

