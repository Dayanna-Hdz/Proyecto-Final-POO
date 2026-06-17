namespace Proyecto_Final_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_ir_a_login = new Button();
            btn_ir_a_registro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 140);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Renta de Libros";
            label1.Click += label1_Click;
            // 
            // btn_ir_a_login
            // 
            btn_ir_a_login.BackColor = SystemColors.Control;
            btn_ir_a_login.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btn_ir_a_login.Location = new Point(113, 226);
            btn_ir_a_login.Name = "btn_ir_a_login";
            btn_ir_a_login.Size = new Size(276, 44);
            btn_ir_a_login.TabIndex = 1;
            btn_ir_a_login.Text = "Iniciar Sesión";
            btn_ir_a_login.UseVisualStyleBackColor = false;
            btn_ir_a_login.Click += button1_Click;
            // 
            // btn_ir_a_registro
            // 
            btn_ir_a_registro.BackColor = SystemColors.Control;
            btn_ir_a_registro.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btn_ir_a_registro.Location = new Point(415, 226);
            btn_ir_a_registro.Name = "btn_ir_a_registro";
            btn_ir_a_registro.Size = new Size(276, 44);
            btn_ir_a_registro.TabIndex = 2;
            btn_ir_a_registro.Text = "Registrarse";
            btn_ir_a_registro.UseVisualStyleBackColor = false;
            btn_ir_a_registro.Click += btn_ir_a_registro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ir_a_registro);
            Controls.Add(btn_ir_a_login);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_ir_a_login;
        private Button btn_ir_a_registro;
    }
}
