namespace WindowsEFEscuela
{
    partial class FrmAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.buscarPorId = new System.Windows.Forms.Button();
            this.GridCategoria = new System.Windows.Forms.DataGridView();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.btnVerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(242, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(292, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(636, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(636, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(636, 36);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // buscarPorId
            // 
            this.buscarPorId.Location = new System.Drawing.Point(636, 231);
            this.buscarPorId.Name = "buscarPorId";
            this.buscarPorId.Size = new System.Drawing.Size(120, 23);
            this.buscarPorId.TabIndex = 9;
            this.buscarPorId.Text = "Buscar por Id";
            this.buscarPorId.UseVisualStyleBackColor = true;
            this.buscarPorId.Click += new System.EventHandler(this.buscarPorId_Click);
            // 
            // GridCategoria
            // 
            this.GridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCategoria.Location = new System.Drawing.Point(12, 278);
            this.GridCategoria.Name = "GridCategoria";
            this.GridCategoria.RowHeadersWidth = 51;
            this.GridCategoria.RowTemplate.Height = 24;
            this.GridCategoria.Size = new System.Drawing.Size(591, 219);
            this.GridCategoria.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(247, 146);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(286, 22);
            this.txtApellido.TabIndex = 12;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(153, 149);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(57, 16);
            this.Apellido.TabIndex = 13;
            this.Apellido.Text = "Apellido";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(242, 206);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(288, 22);
            this.dateTimePicker.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 15;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(164, 212);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(45, 16);
            this.Fecha.TabIndex = 16;
            this.Fecha.Text = "Fecha";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(636, 314);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(80, 34);
            this.btnVerTodo.TabIndex = 17;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.VerTodo);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 568);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.GridCategoria);
            this.Controls.Add(this.buscarPorId);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlumno";
            this.Text = "FrmAlumno";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button buscarPorId;
        private System.Windows.Forms.DataGridView GridCategoria;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Button btnVerTodo;
    }
}