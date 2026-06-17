namespace Proyecto_Final_POO
{
    partial class Form3
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
            input_nuevo_usuario = new TextBox();
            label2 = new Label();
            input_nueva_password = new TextBox();
            label3 = new Label();
            input_rol_usuario = new ComboBox();
            btn_registrar_cuenta = new Button();
            label4 = new Label();
            input_nombre_completo = new TextBox();
            btn_regresar_a_inicio_reg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(89, 211);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario:";
            // 
            // input_nuevo_usuario
            // 
            input_nuevo_usuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            input_nuevo_usuario.Location = new Point(279, 208);
            input_nuevo_usuario.Name = "input_nuevo_usuario";
            input_nuevo_usuario.Size = new Size(373, 33);
            input_nuevo_usuario.TabIndex = 1;
            input_nuevo_usuario.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(159, 264);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // input_nueva_password
            // 
            input_nueva_password.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            input_nueva_password.Location = new Point(279, 261);
            input_nueva_password.Name = "input_nueva_password";
            input_nueva_password.Size = new Size(373, 33);
            input_nueva_password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(110, 154);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 4;
            label3.Text = "Seleccione su Rol:";
            // 
            // input_rol_usuario
            // 
            input_rol_usuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            input_rol_usuario.FormattingEnabled = true;
            input_rol_usuario.Location = new Point(279, 151);
            input_rol_usuario.Name = "input_rol_usuario";
            input_rol_usuario.Size = new Size(373, 33);
            input_rol_usuario.TabIndex = 5;
            // 
            // btn_registrar_cuenta
            // 
            btn_registrar_cuenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar_cuenta.Location = new Point(296, 332);
            btn_registrar_cuenta.Name = "btn_registrar_cuenta";
            btn_registrar_cuenta.Size = new Size(251, 44);
            btn_registrar_cuenta.TabIndex = 7;
            btn_registrar_cuenta.Text = "Registrar Usuario";
            btn_registrar_cuenta.UseVisualStyleBackColor = true;
            btn_registrar_cuenta.Click += btn_registrar_cuenta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 102);
            label4.Name = "label4";
            label4.Size = new Size(179, 25);
            label4.TabIndex = 8;
            label4.Text = "Nombre  completo:";
            // 
            // input_nombre_completo
            // 
            input_nombre_completo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            input_nombre_completo.Location = new Point(279, 99);
            input_nombre_completo.Name = "input_nombre_completo";
            input_nombre_completo.Size = new Size(373, 33);
            input_nombre_completo.TabIndex = 9;
            // 
            // btn_regresar_a_inicio_reg
            // 
            btn_regresar_a_inicio_reg.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar_a_inicio_reg.Location = new Point(15, 12);
            btn_regresar_a_inicio_reg.Name = "btn_regresar_a_inicio_reg";
            btn_regresar_a_inicio_reg.Size = new Size(258, 34);
            btn_regresar_a_inicio_reg.TabIndex = 10;
            btn_regresar_a_inicio_reg.Text = "Regresar a Menu Principal";
            btn_regresar_a_inicio_reg.UseVisualStyleBackColor = true;
            btn_regresar_a_inicio_reg.Click += btn_regresar_a_inicio_reg_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_regresar_a_inicio_reg);
            Controls.Add(input_nombre_completo);
            Controls.Add(label4);
            Controls.Add(btn_registrar_cuenta);
            Controls.Add(input_rol_usuario);
            Controls.Add(label3);
            Controls.Add(input_nueva_password);
            Controls.Add(label2);
            Controls.Add(input_nuevo_usuario);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_nuevo_usuario;
        private Label label2;
        private TextBox input_nueva_password;
        private Label label3;
        private ComboBox input_rol_usuario;
        private Button btn_registrar_cuenta;
        private Label label4;
        private TextBox input_nombre_completo;
        private Button btn_regresar_a_inicio_reg;
    }
}