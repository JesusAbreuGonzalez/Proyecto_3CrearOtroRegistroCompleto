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
            if (usuarioIdTextBox.Text == "")
            {
                errorProvider1.SetError(usuarioIdTextBox, "Campo obligatorio");
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
            usuarioIdTextBox.Text = "";
            aliasTextBox.Text = "";
            emailTextBox.Text = "";
            claveTextBox.Text = "";
            confirmarTextBox.Text = "";
            nombresTextBox.Text = "";
            RolComboBox.SelectedItem = "";
            IngresoDateTimePicker.Value = DateTime.Now;
            errorProvider1.Clear();
        }


        //Este es el evento del boton Buscar, sirve para buscar los datos correspondientes al id ingresado
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            Contexto contexto = new Contexto();
            VentanaBuscar ventana = new VentanaBuscar();
            contexto.Dispose();

            //Igualamos cada objeto grafico de la 2da ventana al valor que queremos que tome
            if (usuarioIdTextBox.Text == "")
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdTextBox, "Campo obligatorio");
            }
            else
            {
                if (ExisteUsuario(Convert.ToInt32(usuarioIdTextBox.Text)))
                {
                    usuarios = Buscar(Convert.ToInt32(usuarioIdTextBox.Text));
                    ventana.ResultUsuarioIdTextBox.Text = Convert.ToString(usuarios.UsuarioId);
                    ventana.ResultAliasTextBox.Text = usuarios.Alias;
                    ventana.ResultNombresTextBox.Text = usuarios.Nombres;
                    ventana.ResultActivoCheckBox.Checked = usuarios.Activo;
                    ventana.ResultEmailTextBox.Text = usuarios.Email;
                    ventana.ResultIngresoDateTimePicker.Value = usuarios.FechaIngreso;
                    ventana.ResultRolTextBox.Text = Convert.ToString(usuarios.RolId);
                    ventana.Show();
                }
                else
                {
                    MessageBox.Show("Este usuario no existe en la base de datos");
                }

            }
        }
                

        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los usuarios que se registren
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios = new Usuarios();
            bool interruptor = false;

            Validar(ref interruptor);
            if (!interruptor)
            {
                //Verificamos que no exista un id igual, en caso de que exista, se procede a modificarlo
                if (ExisteUsuario(Convert.ToInt32(usuarioIdTextBox.Text)))
                {
                    Eliminar(Convert.ToInt32(usuarioIdTextBox.Text));
                    usuarios.UsuarioId = Convert.ToInt32(usuarioIdTextBox.Text);
                    usuarios.Alias = aliasTextBox.Text;
                    usuarios.Email = emailTextBox.Text;
                    usuarios.Clave = claveTextBox.Text;
                    usuarios.FechaIngreso = IngresoDateTimePicker.Value;
                    usuarios.Activo = activoCheckBox.Checked;
                    usuarios.Nombres = nombresTextBox.Text;
                    usuarios.RolId = Convert.ToInt32(RolComboBox.Text);
                    contexto.Usuarios.Add(usuarios);
                    contexto.SaveChanges();
                    contexto.Dispose();
                    errorProvider1.Clear();
                    MessageBox.Show("El usuario fue modificado con exito a la base de datos");

                }
                else
                {
                    usuarios.UsuarioId = Convert.ToInt32(usuarioIdTextBox.Text);
                    usuarios.Alias = aliasTextBox.Text;
                    usuarios.Email = emailTextBox.Text;
                    usuarios.Clave = claveTextBox.Text;
                    usuarios.FechaIngreso = IngresoDateTimePicker.Value;
                    usuarios.Activo = activoCheckBox.Checked;
                    usuarios.Nombres = nombresTextBox.Text;
                    usuarios.RolId = Convert.ToInt32(RolComboBox.Text);
                    contexto.Usuarios.Add(usuarios);
                    contexto.SaveChanges();
                    contexto.Dispose();
                    errorProvider1.Clear();
                    MessageBox.Show("El usuario fue agregado con exito a la base de datos");
                }
            }
        }

        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (usuarioIdTextBox.Text == "")
            {
                //Indicamos los errores que mostrará si algún campo queda vacío
                errorProvider1.SetError(usuarioIdTextBox, "Campo obligatorio");
            }
            else
            {
                if (ExisteUsuario(Convert.ToInt32(usuarioIdTextBox.Text)))
                {
                    Eliminar(Convert.ToInt32(usuarioIdTextBox.Text));
                    MessageBox.Show("Este Usuario fue eliminado de la base de datos");
                }
                else
                    MessageBox.Show("Este Usuario no existe en la base de datos");
            }
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
