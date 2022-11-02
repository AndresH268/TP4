namespace Trabajo_Practico_Nº4._1er_Año
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
            this.lbl_INFORMACIONDELUSUARIO = new System.Windows.Forms.Label();
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.lbl_EDAD = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.btnINGRESAR = new System.Windows.Forms.Button();
            this.btnGUARDARENARCHIVO = new System.Windows.Forms.Button();
            this.btnCARGARARCHIVO = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_INFORMACIONDELUSUARIO
            // 
            this.lbl_INFORMACIONDELUSUARIO.AutoSize = true;
            this.lbl_INFORMACIONDELUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_INFORMACIONDELUSUARIO.Location = new System.Drawing.Point(49, 60);
            this.lbl_INFORMACIONDELUSUARIO.Name = "lbl_INFORMACIONDELUSUARIO";
            this.lbl_INFORMACIONDELUSUARIO.Size = new System.Drawing.Size(295, 24);
            this.lbl_INFORMACIONDELUSUARIO.TabIndex = 0;
            this.lbl_INFORMACIONDELUSUARIO.Text = "INFORMACION DEL USUARIO";
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NOMBRE.Location = new System.Drawing.Point(49, 106);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(99, 24);
            this.lbl_NOMBRE.TabIndex = 1;
            this.lbl_NOMBRE.Text = "NOMBRE";
            // 
            // lbl_EDAD
            // 
            this.lbl_EDAD.AutoSize = true;
            this.lbl_EDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EDAD.Location = new System.Drawing.Point(49, 150);
            this.lbl_EDAD.Name = "lbl_EDAD";
            this.lbl_EDAD.Size = new System.Drawing.Size(66, 24);
            this.lbl_EDAD.TabIndex = 2;
            this.lbl_EDAD.Text = "EDAD";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(187, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(187, 150);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(79, 29);
            this.txtEdad.TabIndex = 4;
            // 
            // Datos
            // 
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(53, 233);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(426, 169);
            this.Datos.TabIndex = 5;
            // 
            // btnINGRESAR
            // 
            this.btnINGRESAR.Location = new System.Drawing.Point(587, 60);
            this.btnINGRESAR.Name = "btnINGRESAR";
            this.btnINGRESAR.Size = new System.Drawing.Size(126, 39);
            this.btnINGRESAR.TabIndex = 6;
            this.btnINGRESAR.Text = "INGRESAR";
            this.btnINGRESAR.UseVisualStyleBackColor = true;
            this.btnINGRESAR.Click += new System.EventHandler(this.btnINGRESAR_Click);
            // 
            // btnGUARDARENARCHIVO
            // 
            this.btnGUARDARENARCHIVO.Location = new System.Drawing.Point(587, 133);
            this.btnGUARDARENARCHIVO.Name = "btnGUARDARENARCHIVO";
            this.btnGUARDARENARCHIVO.Size = new System.Drawing.Size(126, 40);
            this.btnGUARDARENARCHIVO.TabIndex = 7;
            this.btnGUARDARENARCHIVO.Text = "GUARDAR EN ARCHIVO";
            this.btnGUARDARENARCHIVO.UseVisualStyleBackColor = true;
            this.btnGUARDARENARCHIVO.Click += new System.EventHandler(this.btnGUARDARENARCHIVO_Click);
            // 
            // btnCARGARARCHIVO
            // 
            this.btnCARGARARCHIVO.Location = new System.Drawing.Point(587, 219);
            this.btnCARGARARCHIVO.Name = "btnCARGARARCHIVO";
            this.btnCARGARARCHIVO.Size = new System.Drawing.Size(126, 37);
            this.btnCARGARARCHIVO.TabIndex = 8;
            this.btnCARGARARCHIVO.Text = "CARGAR ARCHIVO";
            this.btnCARGARARCHIVO.UseVisualStyleBackColor = true;
            this.btnCARGARARCHIVO.Click += new System.EventHandler(this.btnCARGARARCHIVO_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnCARGARARCHIVO);
            this.Controls.Add(this.btnGUARDARENARCHIVO);
            this.Controls.Add(this.btnINGRESAR);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbl_EDAD);
            this.Controls.Add(this.lbl_NOMBRE);
            this.Controls.Add(this.lbl_INFORMACIONDELUSUARIO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_INFORMACIONDELUSUARIO;
        private System.Windows.Forms.Label lbl_NOMBRE;
        private System.Windows.Forms.Label lbl_EDAD;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Button btnINGRESAR;
        private System.Windows.Forms.Button btnGUARDARENARCHIVO;
        private System.Windows.Forms.Button btnCARGARARCHIVO;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

