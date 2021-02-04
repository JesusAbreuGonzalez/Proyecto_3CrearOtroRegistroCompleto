using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3CrearOtroRegistroCompleto.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrarRolButton_Click(object sender, EventArgs e)
        {
            Registros.RegistroRoles ventana = new Registros.RegistroRoles();
            ventana.Show();
        }

        private void RegistroUsuarioButton_Click(object sender, EventArgs e)
        {
            RegistroUsuarios ventana = new RegistroUsuarios();
            ventana.Show();
        }
    }
}
