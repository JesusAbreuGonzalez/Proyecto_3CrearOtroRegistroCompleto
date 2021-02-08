using Proyecto3CrearOtroRegistroCompleto.BLL;
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

namespace Proyecto3CrearOtroRegistroCompleto.UI.Registros
{
    public partial class RegistroRoles : Form
    {
        public RegistroRoles()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            CreacionDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
        }


        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar 
        //y que la clave y su confirmacion sean iguales
        private bool Validar()
        {
            bool paso = true;
            if (RolIdNumericUpDown.Value == 0)
            {
                RolErrorProvider.SetError(RolIdNumericUpDown, "Campo obligatorio");
                paso = false;
            }

            if (DescripcionTextBox.Text == "")
            {
                RolErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }

        private Roles LlenaClase()
        {
            Roles roles = new Roles();
            roles.RolId = (int)RolIdNumericUpDown.Value;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.FechaCreacion = CreacionDateTimePicker.Value;

            return roles;
        }

        private bool LLenaCampos(int id)
        {
            Roles roles = RolesBLL.Buscar(id);

            if (roles != null)
            {
                RolIdNumericUpDown.Value = roles.RolId;
                DescripcionTextBox.Text = roles.Descripcion;
                CreacionDateTimePicker.Value = roles.FechaCreacion;
                return true;
            }
            else
                return false;
        }

        private bool ExisteEnBaseDeDatos()
        {
            Roles roles = RolesBLL.Buscar((int)RolIdNumericUpDown.Value);
            return (roles != null);
        }


        //Este es el evento del boton Nuevo, sirve para limpiar los campos y errores

        private void NuevoRolButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Este es el evento del boton Buscar, sirve para buscar los datos correspondientes al id ingresado
        private void BuscarRolButton_Click(object sender, EventArgs e)
        {
            int id;
            Roles roles = new Roles();
            id = (int)RolIdNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
            {
                LLenaCampos(id);
                MessageBox.Show("Usuario encontrado");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
       

        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los roles que se registren
        private void GuardarRolButton_Click(object sender, EventArgs e)
        {
            Roles roles;
            bool paso = false;

            if (!Validar())
                return;
            roles = LlenaClase();

            //Determinar si es guardar o modificar
            if (RolIdNumericUpDown.Value != 0)
            {
                paso = RolesBLL.Guardar(roles);
                MessageBox.Show("El rol ha sido guardado con exito");

            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = RolesBLL.Modificar(roles);
            }
        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarRolButton_Click(object sender, EventArgs e)
        {
            RolErrorProvider.Clear();
            int id;
            int.TryParse(RolIdNumericUpDown.Text, out id);
            Limpiar();
            if (RolesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                RolErrorProvider.SetError(RolIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }
    }
}
