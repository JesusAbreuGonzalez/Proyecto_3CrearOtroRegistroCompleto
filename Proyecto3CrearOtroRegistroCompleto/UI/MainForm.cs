using Proyecto3CrearOtroRegistroCompleto.UI.Registros;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.PermisostoolStripMenuItem.Click += new EventHandler(this.PermisostoolStripMenuItem_ItemClicked);
            this.UsuariostoolStripMenuItem.Click += new EventHandler(this.UsuariostoolStripMenuItem_ItemClicked);
            this.RolestoolStripMenuItem.Click += new EventHandler(this.RolestoolStripMenuItem_ItemClicked);
        }

        private void PermisostoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rPermisos = new rPermisos();
            rPermisos.MdiParent = this;
            rPermisos.Show();
        }

        private void UsuariostoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rUsuarios = new rUsuarios();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();
        }

        private void RolestoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rRoles = new rRoles();
            rRoles.MdiParent = this;
            rRoles.Show();
        }

        private void RegistroRolesButton_Click(object sender, EventArgs e)
        {
            var registroRoles = new rRoles();
            registroRoles.Show();
        }

        private void RegistroUsuariosButton_Click(object sender, EventArgs e)
        {
            rUsuarios registroUsuarios = new rUsuarios();
            registroUsuarios.Show();
        }

        private void PermisosButton_Click(object sender, EventArgs e)
        {
            rPermisos registroPermisos = new rPermisos();
            registroPermisos.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
