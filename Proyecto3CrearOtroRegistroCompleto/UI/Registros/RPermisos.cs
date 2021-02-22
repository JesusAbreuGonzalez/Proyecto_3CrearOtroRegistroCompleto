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
    public partial class rPermisos : Form
    {
        public rPermisos()
        {
            InitializeComponent();
        }

        
        private void Limpiar()
        {
            PermisoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
        }


        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar 
        //y que la clave y su confirmacion sean iguales
        private bool Validar()
        {
            bool paso = true;

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

            return permisos;
        }

        private void LLenaCampos(Permisos permisos)
        {
            PermisoIdNumericUpDown.Value = permisos.PermisoId;
            DescripcionTextBox.Text = permisos.Descripcion;
        }

        private bool ExisteEnBaseDeDatos()
        {
            var permisos = new Permisos();
            permisos = PermisosBLL.Buscar((int)PermisoIdNumericUpDown.Value);
            
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
            var permisos = new Permisos();
            int id = (int)PermisoIdNumericUpDown.Value;

            Limpiar();
            permisos = PermisosBLL.Buscar(id);
            if (permisos != null)
            {
                LLenaCampos(permisos);
            }
            else
            {
                MessageBox.Show("Permiso no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (PermisoIdNumericUpDown.Value == 0)
            {
                paso = PermisosBLL.Guardar(permisos, DescripcionTextBox.Text);
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PermisosBLL.Modificar(permisos);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("El rol ha sido guardada!", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarPermisoButton_Click(object sender, EventArgs e)
        {
            int id = (int)PermisoIdNumericUpDown.Value;
            PermisoErrorProvider.Clear();

            if (PermisosBLL.Eliminar(id))
            {
                MessageBox.Show("La ciudad ha sido eliminada", "Logrado");
                Limpiar();
            }
            else
                PermisoErrorProvider.SetError(PermisoIdNumericUpDown, "Este Id no existe en la base de datos");
        }
    }
}
