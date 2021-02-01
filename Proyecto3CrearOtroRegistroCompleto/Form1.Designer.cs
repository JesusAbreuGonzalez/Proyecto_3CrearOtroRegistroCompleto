
namespace Proyecto3CrearOtroRegistroCompleto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usuariosIdLabel = new System.Windows.Forms.Label();
            this.Aliaslabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.ConfirmarLabel = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.confirmarTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.IngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosIdLabel
            // 
            this.usuariosIdLabel.AutoSize = true;
            this.usuariosIdLabel.Location = new System.Drawing.Point(38, 51);
            this.usuariosIdLabel.Name = "usuariosIdLabel";
            this.usuariosIdLabel.Size = new System.Drawing.Size(24, 20);
            this.usuariosIdLabel.TabIndex = 0;
            this.usuariosIdLabel.Text = "ID";
            // 
            // Aliaslabel
            // 
            this.Aliaslabel.AutoSize = true;
            this.Aliaslabel.Location = new System.Drawing.Point(38, 96);
            this.Aliaslabel.Name = "Aliaslabel";
            this.Aliaslabel.Size = new System.Drawing.Size(41, 20);
            this.Aliaslabel.TabIndex = 1;
            this.Aliaslabel.Text = "Alias";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(38, 139);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(70, 20);
            this.NombresLabel.TabIndex = 2;
            this.NombresLabel.Text = "Nombres";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(38, 179);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(45, 20);
            this.ClaveLabel.TabIndex = 3;
            this.ClaveLabel.Text = "Clave";
            this.ClaveLabel.Click += new System.EventHandler(this.ClaveLabel_Click);
            // 
            // ConfirmarLabel
            // 
            this.ConfirmarLabel.AutoSize = true;
            this.ConfirmarLabel.Location = new System.Drawing.Point(269, 179);
            this.ConfirmarLabel.Name = "ConfirmarLabel";
            this.ConfirmarLabel.Size = new System.Drawing.Size(115, 20);
            this.ConfirmarLabel.TabIndex = 4;
            this.ConfirmarLabel.Text = "Confirmar Clave";
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Location = new System.Drawing.Point(827, 96);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(31, 20);
            this.RolLabel.TabIndex = 5;
            this.RolLabel.Text = "Rol";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(544, 136);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Location = new System.Drawing.Point(544, 179);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(121, 20);
            this.fechaIngresoLabel.TabIndex = 7;
            this.fechaIngresoLabel.Text = "Fecha de Ingreso";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(605, 133);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(316, 27);
            this.emailTextBox.TabIndex = 8;
            // 
            // usuarioIdTextBox
            // 
            this.usuarioIdTextBox.Location = new System.Drawing.Point(114, 48);
            this.usuarioIdTextBox.Name = "usuarioIdTextBox";
            this.usuarioIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.usuarioIdTextBox.TabIndex = 9;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(114, 93);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(189, 27);
            this.aliasTextBox.TabIndex = 10;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(114, 136);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(281, 27);
            this.nombresTextBox.TabIndex = 11;
            // 
            // confirmarTextBox
            // 
            this.confirmarTextBox.Location = new System.Drawing.Point(390, 176);
            this.confirmarTextBox.Name = "confirmarTextBox";
            this.confirmarTextBox.Size = new System.Drawing.Size(125, 27);
            this.confirmarTextBox.TabIndex = 12;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(114, 176);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(125, 27);
            this.claveTextBox.TabIndex = 13;
            // 
            // IngresoDateTimePicker
            // 
            this.IngresoDateTimePicker.Location = new System.Drawing.Point(671, 176);
            this.IngresoDateTimePicker.Name = "IngresoDateTimePicker";
            this.IngresoDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.IngresoDateTimePicker.TabIndex = 14;
            // 
            // RolComboBox
            // 
            this.RolComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RolComboBox.Location = new System.Drawing.Point(864, 93);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(57, 28);
            this.RolComboBox.TabIndex = 15;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(181, 250);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(122, 63);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(393, 250);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(122, 63);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(605, 250);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(122, 63);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(252, 38);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(51, 47);
            this.BuscarButton.TabIndex = 19;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(848, 50);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(73, 24);
            this.activoCheckBox.TabIndex = 20;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 355);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.IngresoDateTimePicker);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.confirmarTextBox);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.usuarioIdTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.fechaIngresoLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.ConfirmarLabel);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.Aliaslabel);
            this.Controls.Add(this.usuariosIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuariosIdLabel;
        private System.Windows.Forms.Label Aliaslabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.Label ConfirmarLabel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usuarioIdTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox confirmarTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.DateTimePicker IngresoDateTimePicker;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox activoCheckBox;
    }
}

