
namespace Proyecto3CrearOtroRegistroCompleto.UI.Registros
{
    partial class rRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.RolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EliminarRolButton = new System.Windows.Forms.Button();
            this.GuardarRolButton = new System.Windows.Forms.Button();
            this.NuevoRolButton = new System.Windows.Forms.Button();
            this.BuscarRolButton = new System.Windows.Forms.Button();
            this.RolErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.CreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetallegroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.RolesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolErrorProvider)).BeginInit();
            this.DetallegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RolIdLabel
            // 
            this.RolIdLabel.AutoSize = true;
            this.RolIdLabel.Location = new System.Drawing.Point(17, 24);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(50, 20);
            this.RolIdLabel.TabIndex = 0;
            this.RolIdLabel.Text = "Rol ID";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(17, 79);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 1;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(221, 76);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(178, 27);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // RolIdNumericUpDown
            // 
            this.RolIdNumericUpDown.Location = new System.Drawing.Point(221, 22);
            this.RolIdNumericUpDown.Name = "RolIdNumericUpDown";
            this.RolIdNumericUpDown.Size = new System.Drawing.Size(76, 27);
            this.RolIdNumericUpDown.TabIndex = 6;
            // 
            // EliminarRolButton
            // 
            this.EliminarRolButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarRolButton.Image")));
            this.EliminarRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarRolButton.Location = new System.Drawing.Point(309, 509);
            this.EliminarRolButton.Name = "EliminarRolButton";
            this.EliminarRolButton.Size = new System.Drawing.Size(90, 53);
            this.EliminarRolButton.TabIndex = 21;
            this.EliminarRolButton.Text = "Eliminar";
            this.EliminarRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarRolButton.UseVisualStyleBackColor = true;
            this.EliminarRolButton.Click += new System.EventHandler(this.EliminarRolButton_Click);
            // 
            // GuardarRolButton
            // 
            this.GuardarRolButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarRolButton.Image")));
            this.GuardarRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarRolButton.Location = new System.Drawing.Point(164, 509);
            this.GuardarRolButton.Name = "GuardarRolButton";
            this.GuardarRolButton.Size = new System.Drawing.Size(90, 53);
            this.GuardarRolButton.TabIndex = 20;
            this.GuardarRolButton.Text = "Guardar";
            this.GuardarRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarRolButton.UseVisualStyleBackColor = true;
            this.GuardarRolButton.Click += new System.EventHandler(this.GuardarRolButton_Click);
            // 
            // NuevoRolButton
            // 
            this.NuevoRolButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoRolButton.Image")));
            this.NuevoRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoRolButton.Location = new System.Drawing.Point(18, 509);
            this.NuevoRolButton.Name = "NuevoRolButton";
            this.NuevoRolButton.Size = new System.Drawing.Size(90, 53);
            this.NuevoRolButton.TabIndex = 19;
            this.NuevoRolButton.Text = "Nuevo";
            this.NuevoRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoRolButton.UseVisualStyleBackColor = true;
            this.NuevoRolButton.Click += new System.EventHandler(this.NuevoRolButton_Click);
            // 
            // BuscarRolButton
            // 
            this.BuscarRolButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarRolButton.Image")));
            this.BuscarRolButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarRolButton.Location = new System.Drawing.Point(307, 21);
            this.BuscarRolButton.Name = "BuscarRolButton";
            this.BuscarRolButton.Size = new System.Drawing.Size(92, 28);
            this.BuscarRolButton.TabIndex = 22;
            this.BuscarRolButton.Text = "Buscar";
            this.BuscarRolButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarRolButton.UseVisualStyleBackColor = true;
            this.BuscarRolButton.Click += new System.EventHandler(this.BuscarRolButton_Click);
            // 
            // RolErrorProvider
            // 
            this.RolErrorProvider.ContainerControl = this;
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Location = new System.Drawing.Point(17, 134);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(130, 20);
            this.FechaCreacionLabel.TabIndex = 2;
            this.FechaCreacionLabel.Text = "Fecha de Creación";
            // 
            // CreacionDateTimePicker
            // 
            this.CreacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.CreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreacionDateTimePicker.Location = new System.Drawing.Point(221, 130);
            this.CreacionDateTimePicker.Name = "CreacionDateTimePicker";
            this.CreacionDateTimePicker.Size = new System.Drawing.Size(178, 27);
            this.CreacionDateTimePicker.TabIndex = 5;
            // 
            // DetallegroupBox
            // 
            this.DetallegroupBox.Controls.Add(this.button1);
            this.DetallegroupBox.Controls.Add(this.Agregarbutton);
            this.DetallegroupBox.Controls.Add(this.RolesDataGridView);
            this.DetallegroupBox.Location = new System.Drawing.Point(17, 190);
            this.DetallegroupBox.Name = "DetallegroupBox";
            this.DetallegroupBox.Size = new System.Drawing.Size(382, 301);
            this.DetallegroupBox.TabIndex = 23;
            this.DetallegroupBox.TabStop = false;
            this.DetallegroupBox.Text = "Detalle de rol";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Remover";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(284, 13);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(92, 28);
            this.Agregarbutton.TabIndex = 24;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // RolesDataGridView
            // 
            this.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDataGridView.Location = new System.Drawing.Point(8, 46);
            this.RolesDataGridView.Name = "RolesDataGridView";
            this.RolesDataGridView.RowHeadersWidth = 51;
            this.RolesDataGridView.RowTemplate.Height = 29;
            this.RolesDataGridView.Size = new System.Drawing.Size(368, 219);
            this.RolesDataGridView.TabIndex = 0;
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 578);
            this.Controls.Add(this.DetallegroupBox);
            this.Controls.Add(this.BuscarRolButton);
            this.Controls.Add(this.EliminarRolButton);
            this.Controls.Add(this.GuardarRolButton);
            this.Controls.Add(this.NuevoRolButton);
            this.Controls.Add(this.RolIdNumericUpDown);
            this.Controls.Add(this.CreacionDateTimePicker);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.FechaCreacionLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rRoles";
            this.Text = "RegistroRoles";
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolErrorProvider)).EndInit();
            this.DetallegroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown RolIdNumericUpDown;
        private System.Windows.Forms.Button EliminarRolButton;
        private System.Windows.Forms.Button GuardarRolButton;
        private System.Windows.Forms.Button NuevoRolButton;
        private System.Windows.Forms.Button BuscarRolButton;
        private System.Windows.Forms.ErrorProvider RolErrorProvider;
        private System.Windows.Forms.DateTimePicker CreacionDateTimePicker;
        private System.Windows.Forms.Label FechaCreacionLabel;
        private System.Windows.Forms.GroupBox DetallegroupBox;
        private System.Windows.Forms.DataGridView RolesDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Agregarbutton;
    }
}