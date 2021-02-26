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

namespace Proyecto3CrearOtroRegistroCompleto.UI.Registros
{
    public partial class rRoles : Form
    {
        public List<RolesDetalle> rolDetalle { get; set; }
        public rRoles()
        {
            InitializeComponent();
            this.rolDetalle = new List<RolesDetalle>();

        }

        private void LlenarGrid()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = rolDetalle;
        }

        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            CreacionDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
        }


        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar
        private bool Validar()
        {
            bool paso = true;

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
            roles.RolesDetalle = this.rolDetalle;
            LlenarGrid();

            return roles;
        }

        private void LLenaCampos(Roles roles)
        {
            RolIdNumericUpDown.Value = roles.RolId;
            DescripcionTextBox.Text = roles.Descripcion;
            this.rolDetalle = roles.RolesDetalle;
            LlenarGrid();
        }


        private bool ExisteEnBaseDeDatos()
        {
            var roles = new Roles();
            roles = RolesBLL.Buscar((int)RolIdNumericUpDown.Value);
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
            Roles roles = new Roles();
            int id = (int)RolIdNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
            {
                LLenaCampos(roles);
            }
            else
            {
                MessageBox.Show("Rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (RolIdNumericUpDown.Value == 0)
            {
                paso = RolesBLL.Guardar(roles, DescripcionTextBox.Text);
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = RolesBLL.Modificar(roles);
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
        private void EliminarRolButton_Click(object sender, EventArgs e)
        {
            int id = (int)RolIdNumericUpDown.Value;
            RolErrorProvider.Clear();

            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("El rol ha sido eliminado", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                RolErrorProvider.SetError(RolIdNumericUpDown, "Este Id no existe en la base de datos");
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (RolesDataGridView.DataSource != null)
                this.rolDetalle = (List<RolesDetalle>)RolesDataGridView.DataSource;

            this.rolDetalle.Add(
                new RolesDetalle(
                    rolId: (int)RolIdNumericUpDown.Value,
                    permisoId: Convert.ToInt32(PermisoIdComboBox.Text),
                    esAsignado: EsAsignadoCheckBox.Checked)
                );
            LlenarGrid();
            EsAsignadoCheckBox.Checked = false;
        }

        //Llenamos el ComboBox de permio ID, usando el metodo GetPermisos
        private void rRoles_Load(object sender, EventArgs e)
        {

            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "PermisoId";
            PermisoIdComboBox.ValueMember = "PermisoId";
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(RolesDataGridView.Rows.Count > 0 && RolesDataGridView.CurrentRow != null)
            {
                rolDetalle.RemoveAt(RolesDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }
    }
}
