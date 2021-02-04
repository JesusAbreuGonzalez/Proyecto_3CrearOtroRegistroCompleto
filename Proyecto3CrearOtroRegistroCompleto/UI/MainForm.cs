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
        }

        private void RegistroRolesButton_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroRoles registroRoles = new UI.Registros.RegistroRoles();
            registroRoles.Show();
        }

        private void RegistroUsuariosButton_Click(object sender, EventArgs e)
        {
            RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            registroUsuarios.Show();
        }
    }
}
