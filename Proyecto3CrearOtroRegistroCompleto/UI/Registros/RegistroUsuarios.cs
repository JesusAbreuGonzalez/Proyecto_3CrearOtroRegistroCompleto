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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
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
        void Validar(ref bool interruptor)
        {
            if (UsuarioIdNumericUpDown.Value == 0)
            {
                UsuarioErrorProvider.SetError(UsuarioIdNumericUpDown, "Campo obligatorio");
                interruptor = true;
            }

            if (nombresTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(nombresTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (claveTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(claveTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (confirmarTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(confirmarTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (emailTextBox.Text == "")
            {
                UsuarioErrorProvider.SetError(emailTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (RolComboBox.Text == "")
            {
                UsuarioErrorProvider.SetError(RolComboBox, "Campo obligatorio");
                interruptor = true;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                UsuarioErrorProvider.SetError(confirmarTextBox, "Claves no coinciden");
                interruptor = true;
            }
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuarios.Nombres = nombresTextBox.Text;
            usuarios.Alias = aliasTextBox.Text;
            usuarios.Clave = claveTextBox.Text;
            usuarios.Rol = RolComboBox.Text;
            usuarios.FechaIngreso = IngresoDateTimePicker.Value;
            usuarios.Activo = activoCheckBox.Checked;

            return usuarios;
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
            int id;
            Usuarios usuarios = new Usuarios();
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);
            
            Limpiar();
            usuarios = UsuariosBLL.Buscar(id);
            if(usuarios != null)
            {
                MessageBox.Show("Usuario encontrado");
                LlenaCampo(usuarios);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }

        }
                

        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los usuarios que se registren
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            UsuarioErrorProvider.Clear();
            int id;
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                UsuarioErrorProvider.SetError(UsuarioIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            RolComboBox.DataSource = RolesBLL.GetRoles();
            RolComboBox.DisplayMember = "descripcion";
            RolComboBox.ValueMember = "rolId";
        }
    }
}
