namespace Proyecto_Final_POO
{
    partial class Form4
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
            label1 = new Label();
            input_lista_libros = new ComboBox();
            btn_buscar_ubicacion = new Button();
            lbl_info_id = new Label();
            lbl_info_pasillo = new Label();
            lbl_info_seccion = new Label();
            lbl_info_estante = new Label();
            btn_ir_a_renta = new Button();
            btn_cerrar_sesion_f4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(139, 82);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione un Libro:";
            // 
            // input_lista_libros
            // 
            input_lista_libros.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            input_lista_libros.FormattingEnabled = true;
            input_lista_libros.Location = new Point(327, 79);
            input_lista_libros.Name = "input_lista_libros";
            input_lista_libros.Size = new Size(347, 33);
            input_lista_libros.TabIndex = 1;
            input_lista_libros.SelectedIndexChanged += input_lista_libros_SelectedIndexChanged;
            // 
            // btn_buscar_ubicacion
            // 
            btn_buscar_ubicacion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_buscar_ubicacion.Location = new Point(423, 128);
            btn_buscar_ubicacion.Name = "btn_buscar_ubicacion";
            btn_buscar_ubicacion.Size = new Size(156, 33);
            btn_buscar_ubicacion.TabIndex = 3;
            btn_buscar_ubicacion.Text = "Buscar Ubicacion";
            btn_buscar_ubicacion.UseVisualStyleBackColor = true;
            btn_buscar_ubicacion.Click += btn_buscar_ubicacion_Click;
            // 
            // lbl_info_id
            // 
            lbl_info_id.AutoSize = true;
            lbl_info_id.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_info_id.Location = new Point(146, 183);
            lbl_info_id.Name = "lbl_info_id";
            lbl_info_id.Size = new Size(156, 25);
            lbl_info_id.TabIndex = 4;
            lbl_info_id.Text = "Título con ID: ---";
            // 
            // lbl_info_pasillo
            // 
            lbl_info_pasillo.AutoSize = true;
            lbl_info_pasillo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_info_pasillo.Location = new Point(146, 216);
            lbl_info_pasillo.Name = "lbl_info_pasillo";
            lbl_info_pasillo.Size = new Size(100, 25);
            lbl_info_pasillo.TabIndex = 5;
            lbl_info_pasillo.Text = "Pasillo: ---";
            // 
            // lbl_info_seccion
            // 
            lbl_info_seccion.AutoSize = true;
            lbl_info_seccion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_info_seccion.Location = new Point(146, 248);
            lbl_info_seccion.Name = "lbl_info_seccion";
            lbl_info_seccion.Size = new Size(111, 25);
            lbl_info_seccion.TabIndex = 6;
            lbl_info_seccion.Text = "Sección: ---";
            // 
            // lbl_info_estante
            // 
            lbl_info_estante.AutoSize = true;
            lbl_info_estante.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_info_estante.Location = new Point(146, 277);
            lbl_info_estante.Name = "lbl_info_estante";
            lbl_info_estante.Size = new Size(109, 25);
            lbl_info_estante.TabIndex = 7;
            lbl_info_estante.Text = "Estante: ---";
            // 
            // btn_ir_a_renta
            // 
            btn_ir_a_renta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ir_a_renta.Location = new Point(300, 340);
            btn_ir_a_renta.Name = "btn_ir_a_renta";
            btn_ir_a_renta.Size = new Size(217, 48);
            btn_ir_a_renta.TabIndex = 8;
            btn_ir_a_renta.Text = "Continuar";
            btn_ir_a_renta.UseVisualStyleBackColor = true;
            btn_ir_a_renta.Click += btn_ir_a_renta_Click;
            // 
            // btn_cerrar_sesion_f4
            // 
            btn_cerrar_sesion_f4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar_sesion_f4.Location = new Point(12, 12);
            btn_cerrar_sesion_f4.Name = "btn_cerrar_sesion_f4";
            btn_cerrar_sesion_f4.Size = new Size(154, 34);
            btn_cerrar_sesion_f4.TabIndex = 11;
            btn_cerrar_sesion_f4.Text = "Cerrar Sesion";
            btn_cerrar_sesion_f4.UseVisualStyleBackColor = true;
            btn_cerrar_sesion_f4.Click += btn_cerrar_sesion_f4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cerrar_sesion_f4);
            Controls.Add(btn_ir_a_renta);
            Controls.Add(lbl_info_estante);
            Controls.Add(lbl_info_seccion);
            Controls.Add(lbl_info_pasillo);
            Controls.Add(lbl_info_id);
            Controls.Add(btn_buscar_ubicacion);
            Controls.Add(input_lista_libros);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox input_lista_libros;
        private Button btn_buscar_ubicacion;
        private Label lbl_info_id;
        private Label lbl_info_pasillo;
        private Label lbl_info_seccion;
        private Label lbl_info_estante;
        private Button btn_ir_a_renta;
        private Button btn_cerrar_sesion_f4;
    }
}