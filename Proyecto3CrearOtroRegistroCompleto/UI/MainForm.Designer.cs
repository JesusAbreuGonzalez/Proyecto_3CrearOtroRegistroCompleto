
namespace Proyecto3CrearOtroRegistroCompleto.UI
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
            this.RegistroUsuarioButton = new System.Windows.Forms.Button();
            this.RegistrarRolButton = new System.Windows.Forms.Button();
            this.OpcionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistroUsuarioButton
            // 
            this.RegistroUsuarioButton.Location = new System.Drawing.Point(329, 98);
            this.RegistroUsuarioButton.Name = "RegistroUsuarioButton";
            this.RegistroUsuarioButton.Size = new System.Drawing.Size(155, 84);
            this.RegistroUsuarioButton.TabIndex = 0;
            this.RegistroUsuarioButton.Text = "Registrar Usuario";
            this.RegistroUsuarioButton.UseVisualStyleBackColor = true;
            this.RegistroUsuarioButton.Click += new System.EventHandler(this.RegistroUsuarioButton_Click);
            // 
            // RegistrarRolButton
            // 
            this.RegistrarRolButton.Location = new System.Drawing.Point(32, 98);
            this.RegistrarRolButton.Name = "RegistrarRolButton";
            this.RegistrarRolButton.Size = new System.Drawing.Size(155, 84);
            this.RegistrarRolButton.TabIndex = 1;
            this.RegistrarRolButton.Text = "Registrar Rol";
            this.RegistrarRolButton.UseVisualStyleBackColor = true;
            this.RegistrarRolButton.Click += new System.EventHandler(this.RegistrarRolButton_Click);
            // 
            // OpcionLabel
            // 
            this.OpcionLabel.AutoSize = true;
            this.OpcionLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpcionLabel.Location = new System.Drawing.Point(96, 33);
            this.OpcionLabel.Name = "OpcionLabel";
            this.OpcionLabel.Size = new System.Drawing.Size(355, 38);
            this.OpcionLabel.TabIndex = 2;
            this.OpcionLabel.Text = "Presione la opción deseada";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 211);
            this.Controls.Add(this.OpcionLabel);
            this.Controls.Add(this.RegistrarRolButton);
            this.Controls.Add(this.RegistroUsuarioButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistroUsuarioButton;
        private System.Windows.Forms.Button RegistrarRolButton;
        private System.Windows.Forms.Label OpcionLabel;
    }
}