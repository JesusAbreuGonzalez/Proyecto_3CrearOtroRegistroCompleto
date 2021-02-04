
namespace Proyecto3CrearOtroRegistroCompleto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.RegistroRolesButton = new System.Windows.Forms.Button();
            this.RegistroUsuariosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presione la opción deseada";
            // 
            // RegistroRolesButton
            // 
            this.RegistroRolesButton.Location = new System.Drawing.Point(25, 99);
            this.RegistroRolesButton.Name = "RegistroRolesButton";
            this.RegistroRolesButton.Size = new System.Drawing.Size(123, 75);
            this.RegistroRolesButton.TabIndex = 1;
            this.RegistroRolesButton.Text = "Registro de roles";
            this.RegistroRolesButton.UseVisualStyleBackColor = true;
            this.RegistroRolesButton.Click += new System.EventHandler(this.RegistroRolesButton_Click);
            // 
            // RegistroUsuariosButton
            // 
            this.RegistroUsuariosButton.Location = new System.Drawing.Point(301, 99);
            this.RegistroUsuariosButton.Name = "RegistroUsuariosButton";
            this.RegistroUsuariosButton.Size = new System.Drawing.Size(123, 75);
            this.RegistroUsuariosButton.TabIndex = 2;
            this.RegistroUsuariosButton.Text = "Registro de usuarios";
            this.RegistroUsuariosButton.UseVisualStyleBackColor = true;
            this.RegistroUsuariosButton.Click += new System.EventHandler(this.RegistroUsuariosButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 195);
            this.Controls.Add(this.RegistroUsuariosButton);
            this.Controls.Add(this.RegistroRolesButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistroRolesButton;
        private System.Windows.Forms.Button RegistroUsuariosButton;
    }
}