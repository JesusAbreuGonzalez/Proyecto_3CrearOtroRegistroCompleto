using Proyecto3CrearOtroRegistroCompleto.BLL;
using Proyecto3CrearOtroRegistroCompleto.DAL;
using Proyecto3CrearOtroRegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3CrearOtroRegistroCompleto
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();

        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            aliasTextBox.Clear();
            nombresTextBox.Clear();
            claveTextBox.Clear();
            confirmarTextBox.Clear();
            emailTextBox.Clear();
            IngresoDateTimePicker.Value = DateTime.Now;
            activoCheckBox.Checked = false;
        }

        

        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar 
        //y que la clave y su confirmacion sean iguales
        private bool Validar()
        {
            bool paso = true;

            if (nombresTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(nombresTextBox, "Campo obligatorio");
                paso = false;
            }

            if (claveTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(claveTextBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(confirmarTextBox, "Campo obligatorio");
                paso = false;
            }

            if (emailTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(emailTextBox, "Campo obligatorio");
                paso = false;
            }

            if (RolComboBox.Text == "")
            {
                UsuarioErrorProvider.SetError(RolComboBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                UsuarioErrorProvider.SetError(confirmarTextBox, "Claves no coinciden");
                paso = false;
            }

            return paso;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            usuarios.Nombres = nombresTextBox.Text;
            usuarios.Alias = aliasTextBox.Text;
            usuarios.Clave = claveTextBox.Text;
            usuarios.RolId = RolComboBox.SelectedIndex;
            usuarios.Email = emailTextBox.Text;
            usuarios.FechaIngreso = IngresoDateTimePicker.Value;
            usuarios.Activo = activoCheckBox.Checked;

            return usuarios;
        }

        private void LlenaCampos(Usuarios usuarios)
        {
            UsuarioIdNumericUpDown.Value = usuarios.UsuarioId;
            aliasTextBox.Text = usuarios.Alias;
            nombresTextBox.Text = usuarios.Nombres;
            RolComboBox.SelectedIndex = usuarios.RolId;
            emailTextBox.Text = usuarios.Email;
            IngresoDateTimePicker.Value = usuarios.FechaIngreso;
            activoCheckBox.Checked = usuarios.Activo;
        }

        private bool ExisteEnBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuarios != null);
        }


        private void ClaveLabel_Click(object sender, EventArgs e)
        {

        }

        //Este es el evento del boton Nuevo, sirve para limpiar los campos y errores
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        //Este es el evento del boton Buscar, sirve para buscar los datos correspondientes al id ingresado
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = (int)UsuarioIdNumericUpDown.Value;

            Limpiar();
            var usuarios = UsuariosBLL.Buscar(id);
            if(usuarios != null)
            {
                LlenaCampos(usuarios);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
                

        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los usuarios que se registren
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;         

            if (!Validar())
                return;

            usuarios = LlenaClase();
            var paso = UsuariosBLL.Guardar(usuarios);

            if(paso)
            {
                Limpiar();
                MessageBox.Show("El usuario ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El usuario no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            UsuarioErrorProvider.Clear();
            int id = (int)UsuarioIdNumericUpDown.Value;
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                UsuarioErrorProvider.SetError(UsuarioIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            RolComboBox.DataSource = RolesBLL.GetRoles();
            RolComboBox.DisplayMember = "Descripcion";
            RolComboBox.ValueMember = "RolId";
        }

        private void IngresoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
