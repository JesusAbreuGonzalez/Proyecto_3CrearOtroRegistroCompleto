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
          
            // Set the Format type and the CustomFormat string.
            IngresoDateTimePicker.Format = DateTimePickerFormat.Custom;
            IngresoDateTimePicker.CustomFormat = "dd/MM/yyyy - dddd";

        }

        //Creamos la funcion "Existe" para usarla en el guardar y verificar si el id ya existe   

        public static bool ExisteUsuario(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuarios.Any(e => e.UsuarioId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        //El metodo eliminar lo utilizaremos en el evento del boton eliminar, para borrar entidades
        public static bool Eliminar(int id)
        {
            bool interruptor = false;
            Contexto contexto = new Contexto();

            try
            {
                var usuarios = contexto.Usuarios.Find(id);

                if (usuarios != null)
                {
                    contexto.Usuarios.Remove(usuarios);//Se elimina la entidad
                    interruptor = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return interruptor;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios;

            try
            {
                usuarios = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return usuarios;
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

        }
    }
}
