using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto3CrearOtroRegistroCompleto
{
    public partial class VentanaBuscar : Form
    {
        public VentanaBuscar()
        {
            InitializeComponent();
            ResultIngresoDateTimePicker.Format = DateTimePickerFormat.Custom;
            ResultIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy - dddd";
        }

        private void ResultIngresoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
