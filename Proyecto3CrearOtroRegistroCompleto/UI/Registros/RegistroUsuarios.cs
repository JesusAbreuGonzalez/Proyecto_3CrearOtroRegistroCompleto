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
                errorProvider1.SetError(UsuarioIdNumericUpDown, "Campo obligatorio");
                interruptor = true;
            }

            if (nombresTextBox.Text == "")
            {
                errorProvider1.SetError(nombresTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (claveTextBox.Text == "")
            {
                errorProvider1.SetError(claveTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (confirmarTextBox.Text == "")
            {
                errorProvider1.SetError(confirmarTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (emailTextBox.Text == "")
            {
                errorProvider1.SetError(emailTextBox, "Campo obligatorio");
                interruptor = true;
            }

            if (RolComboBox.Text == "")
            {
                errorProvider1.SetError(RolComboBox, "Campo obligatorio");
                interruptor = true;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                errorProvider1.SetError(confirmarTextBox, "Claves no coinciden");
                interruptor = true;
            }
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
         
        }
                

        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los usuarios que se registren
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarButton_Click(object sender, EventArgs e)
        {
           
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            RolComboBox.DataSource = RolesBLL.GetRoles();
            RolComboBox.DisplayMember = "descripcion";
            RolComboBox.ValueMember = "rolId";
        }
    }
}
