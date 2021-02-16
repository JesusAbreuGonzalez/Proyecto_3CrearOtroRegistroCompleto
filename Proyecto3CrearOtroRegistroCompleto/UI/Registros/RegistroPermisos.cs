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
    public partial class RegistroPermisos : Form
    {
        public RegistroPermisos()
        {
            InitializeComponent();
        }

        
        private void Limpiar()
        {
            PermisoIdNumericUpDown.Value = 0;
            CreacionDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
        }


        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar 
        //y que la clave y su confirmacion sean iguales
        private bool Validar()
        {
            bool paso = true;
            if (PermisoIdNumericUpDown.Value == 0)
            {
                PermisoErrorProvider.SetError(PermisoIdNumericUpDown, "Campo obligatorio");
                paso = false;
            }

            if (DescripcionTextBox.Text == "")
            {
                PermisoErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }

        private Permisos LlenaClase()
        {
            Permisos permisos = new Permisos();
            permisos.PermisoId = (int)PermisoIdNumericUpDown.Value;
            permisos.Descripcion = DescripcionTextBox.Text;
            permisos.FechaCreacion = CreacionDateTimePicker.Value;

            return permisos;
        }

        private bool LLenaCampos(int id)
        {
            Permisos permisos = PermisosBLL.Buscar(id);

            if (permisos != null)
            {
                PermisoIdNumericUpDown.Value = permisos.PermisoId;
                DescripcionTextBox.Text = permisos.Descripcion;
                CreacionDateTimePicker.Value = permisos.FechaCreacion;
                return true;
            }
            else
                return false;
        }

        private bool ExisteEnBaseDeDatos()
        {
            Permisos permisos = PermisosBLL.Buscar((int)PermisoIdNumericUpDown.Value);
            return (permisos != null);
        }


        //Este es el evento del boton Nuevo, sirve para limpiar los campos y errores

        private void NuevoPermisoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Este es el evento del boton Buscar, sirve para buscar los datos correspondientes al id ingresado
        private void BuscarPermisoButton_Click(object sender, EventArgs e)
        {
            int id;
            Permisos permisos = new Permisos();
            id = (int)PermisoIdNumericUpDown.Value;

            Limpiar();
            permisos = PermisosBLL.Buscar(id);
            if (permisos != null)
            {
                LLenaCampos(id);
                MessageBox.Show("Usuario encontrado");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }


        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los permisos que se registren
        private void GuardarPermisoButton_Click(object sender, EventArgs e)
        {
            Permisos permisos;
            bool paso = false;

            if (!Validar())
                return;
            permisos = LlenaClase();

            //Determinar si es guardar o modificar
            if (PermisoIdNumericUpDown.Value != 0)
            {
                paso = PermisosBLL.Guardar(permisos);
                MessageBox.Show("El permiso ha sido guardado con exito");

            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PermisosBLL.Modificar(permisos);
            }

        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarPermisoButton_Click(object sender, EventArgs e)
        {
            PermisoErrorProvider.Clear();
            int id;
            int.TryParse(PermisoIdNumericUpDown.Text, out id);
            Limpiar();
            if (PermisosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                PermisoErrorProvider.SetError(PermisoIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        
    }
}
