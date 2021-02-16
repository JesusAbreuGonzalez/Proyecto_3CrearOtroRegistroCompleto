
namespace Proyecto3CrearOtroRegistroCompleto.UI.Registros
{
    partial class RPermisos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPermisos));
            this.BuscarPermisoButton = new System.Windows.Forms.Button();
            this.EliminarPermisoButton = new System.Windows.Forms.Button();
            this.GuardarPermisoButton = new System.Windows.Forms.Button();
            this.NuevoPermisoButton = new System.Windows.Forms.Button();
            this.PermisoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.PermisoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PermisoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarPermisoButton
            // 
            this.BuscarPermisoButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarPermisoButton.Image")));
            this.BuscarPermisoButton.Location = new System.Drawing.Point(372, 25);
            this.BuscarPermisoButton.Name = "BuscarPermisoButton";
            this.BuscarPermisoButton.Size = new System.Drawing.Size(35, 27);
            this.BuscarPermisoButton.TabIndex = 32;
            this.BuscarPermisoButton.UseVisualStyleBackColor = true;
            this.BuscarPermisoButton.Click += new System.EventHandler(this.BuscarPermisoButton_Click);
            // 
            // EliminarPermisoButton
            // 
            this.EliminarPermisoButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarPermisoButton.Image")));
            this.EliminarPermisoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarPermisoButton.Location = new System.Drawing.Point(319, 134);
            this.EliminarPermisoButton.Name = "EliminarPermisoButton";
            this.EliminarPermisoButton.Size = new System.Drawing.Size(90, 53);
            this.EliminarPermisoButton.TabIndex = 31;
            this.EliminarPermisoButton.Text = "Eliminar";
            this.EliminarPermisoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarPermisoButton.UseVisualStyleBackColor = true;
            this.EliminarPermisoButton.Click += new System.EventHandler(this.EliminarPermisoButton_Click);
            // 
            // GuardarPermisoButton
            // 
            this.GuardarPermisoButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarPermisoButton.Image")));
            this.GuardarPermisoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarPermisoButton.Location = new System.Drawing.Point(167, 134);
            this.GuardarPermisoButton.Name = "GuardarPermisoButton";
            this.GuardarPermisoButton.Size = new System.Drawing.Size(90, 53);
            this.GuardarPermisoButton.TabIndex = 30;
            this.GuardarPermisoButton.Text = "Guardar";
            this.GuardarPermisoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarPermisoButton.UseVisualStyleBackColor = true;
            this.GuardarPermisoButton.Click += new System.EventHandler(this.GuardarPermisoButton_Click);
            // 
            // NuevoPermisoButton
            // 
            this.NuevoPermisoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoPermisoButton.Image")));
            this.NuevoPermisoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoPermisoButton.Location = new System.Drawing.Point(15, 134);
            this.NuevoPermisoButton.Name = "NuevoPermisoButton";
            this.NuevoPermisoButton.Size = new System.Drawing.Size(90, 53);
            this.NuevoPermisoButton.TabIndex = 29;
            this.NuevoPermisoButton.Text = "Nuevo";
            this.NuevoPermisoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoPermisoButton.UseVisualStyleBackColor = true;
            this.NuevoPermisoButton.Click += new System.EventHandler(this.NuevoPermisoButton_Click);
            // 
            // PermisoIdNumericUpDown
            // 
            this.PermisoIdNumericUpDown.Location = new System.Drawing.Point(216, 26);
            this.PermisoIdNumericUpDown.Name = "PermisoIdNumericUpDown";
            this.PermisoIdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.PermisoIdNumericUpDown.TabIndex = 28;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(216, 80);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(150, 27);
            this.DescripcionTextBox.TabIndex = 26;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(12, 83);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 24;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // RolIdLabel
            // 
            this.RolIdLabel.AutoSize = true;
            this.RolIdLabel.Location = new System.Drawing.Point(12, 28);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(86, 20);
            this.RolIdLabel.TabIndex = 23;
            this.RolIdLabel.Text = "Permisos ID";
            // 
            // PermisoErrorProvider
            // 
            this.PermisoErrorProvider.ContainerControl = this;
            // 
            // RegistroPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 205);
            this.Controls.Add(this.BuscarPermisoButton);
            this.Controls.Add(this.EliminarPermisoButton);
            this.Controls.Add(this.GuardarPermisoButton);
            this.Controls.Add(this.NuevoPermisoButton);
            this.Controls.Add(this.PermisoIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolIdLabel);
            this.Name = "RegistroPermisos";
            this.Text = "RegistroPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.PermisoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarPermisoButton;
        private System.Windows.Forms.Button EliminarPermisoButton;
        private System.Windows.Forms.Button GuardarPermisoButton;
        private System.Windows.Forms.Button NuevoPermisoButton;
        private System.Windows.Forms.NumericUpDown PermisoIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.ErrorProvider PermisoErrorProvider;
    }
}