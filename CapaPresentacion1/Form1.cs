using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String name =txtNombre.Text;
            DateTime dateCreacion = fechaCreacion.Value;
            DateTime dataUpdate = dateCreacion;
            // cuando creo una persona la fecha de actualizacion es la misma de creacion cuando lo hago por primera vez
            //aca me tengo comunicar con la capa de negocio para que lo agregue?
            
           
        }
    }
}
