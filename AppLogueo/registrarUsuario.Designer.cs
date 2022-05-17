
namespace AppLogueo
{
    partial class registrarUsuario
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
            this.textoBoxRegistroUsuario = new System.Windows.Forms.TextBox();
            this.textoBoxRegistroPass1 = new System.Windows.Forms.TextBox();
            this.textoBoxRegistroPass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Nombre de usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoBoxRegistroUsuario
            // 
            this.textoBoxRegistroUsuario.Location = new System.Drawing.Point(219, 91);
            this.textoBoxRegistroUsuario.Name = "textoBoxRegistroUsuario";
            this.textoBoxRegistroUsuario.Size = new System.Drawing.Size(383, 26);
            this.textoBoxRegistroUsuario.TabIndex = 1;
            this.textoBoxRegistroUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoBoxRegistroPass1
            // 
            this.textoBoxRegistroPass1.Location = new System.Drawing.Point(219, 202);
            this.textoBoxRegistroPass1.Name = "textoBoxRegistroPass1";
            this.textoBoxRegistroPass1.Size = new System.Drawing.Size(383, 26);
            this.textoBoxRegistroPass1.TabIndex = 2;
            // 
            // textoBoxRegistroPass2
            // 
            this.textoBoxRegistroPass2.Location = new System.Drawing.Point(219, 294);
            this.textoBoxRegistroPass2.Name = "textoBoxRegistroPass2";
            this.textoBoxRegistroPass2.Size = new System.Drawing.Size(383, 26);
            this.textoBoxRegistroPass2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresa Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reingresa Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // registrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoBoxRegistroPass2);
            this.Controls.Add(this.textoBoxRegistroPass1);
            this.Controls.Add(this.textoBoxRegistroUsuario);
            this.Controls.Add(this.label1);
            this.Name = "registrarUsuario";
            this.Text = "registrarUsuario";
            this.Load += new System.EventHandler(this.registrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoBoxRegistroUsuario;
        private System.Windows.Forms.TextBox textoBoxRegistroPass1;
        private System.Windows.Forms.TextBox textoBoxRegistroPass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}