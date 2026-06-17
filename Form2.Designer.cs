namespace Proyecto_Final_POO
{
    partial class Form2
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
            label2 = new Label();
            input_usuario_login = new TextBox();
            label3 = new Label();
            input_password_login = new TextBox();
            btn_ingresar = new Button();
            btn_regresar_a_inicio = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(188, 146);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // input_usuario_login
            // 
            input_usuario_login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            input_usuario_login.Location = new Point(276, 143);
            input_usuario_login.Name = "input_usuario_login";
            input_usuario_login.Size = new Size(364, 33);
            input_usuario_login.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(156, 193);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // input_password_login
            // 
            input_password_login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            input_password_login.Location = new Point(276, 190);
            input_password_login.Name = "input_password_login";
            input_password_login.Size = new Size(364, 33);
            input_password_login.TabIndex = 4;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.Location = new Point(329, 259);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(172, 45);
            btn_ingresar.TabIndex = 5;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_regresar_a_inicio
            // 
            btn_regresar_a_inicio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar_a_inicio.Location = new Point(12, 12);
            btn_regresar_a_inicio.Name = "btn_regresar_a_inicio";
            btn_regresar_a_inicio.Size = new Size(258, 34);
            btn_regresar_a_inicio.TabIndex = 6;
            btn_regresar_a_inicio.Text = "Regresar a Menu Principal";
            btn_regresar_a_inicio.UseVisualStyleBackColor = true;
            btn_regresar_a_inicio.Click += btn_regresar_a_inicio_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_regresar_a_inicio);
            Controls.Add(btn_ingresar);
            Controls.Add(input_password_login);
            Controls.Add(label3);
            Controls.Add(input_usuario_login);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox input_usuario_login;
        private Label label3;
        private TextBox input_password_login;
        private Button btn_ingresar;
        private Button btn_regresar_a_inicio;
    }
}