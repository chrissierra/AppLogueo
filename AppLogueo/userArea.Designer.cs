
namespace AppLogueo
{
    partial class userArea
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
            this.labelUsuarioLogueadoBienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso realizado con éxito";
            // 
            // labelUsuarioLogueadoBienvenida
            // 
            this.labelUsuarioLogueadoBienvenida.AutoSize = true;
            this.labelUsuarioLogueadoBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogueadoBienvenida.Location = new System.Drawing.Point(429, 142);
            this.labelUsuarioLogueadoBienvenida.Name = "labelUsuarioLogueadoBienvenida";
            this.labelUsuarioLogueadoBienvenida.Size = new System.Drawing.Size(93, 32);
            this.labelUsuarioLogueadoBienvenida.TabIndex = 1;
            this.labelUsuarioLogueadoBienvenida.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsuarioLogueadoBienvenida);
            this.Controls.Add(this.label1);
            this.Name = "userArea";
            this.Text = "userArea";
            this.Load += new System.EventHandler(this.userArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuarioLogueadoBienvenida;
        private System.Windows.Forms.Label label2;
    }
}