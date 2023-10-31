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
        private PersonaNegocio personaNegocio= new PersonaNegocio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
            
        {
            //
            String name =txtNombre.Text;
            DateTime dateCreacion = fechaCreacion.Value;
            DateTime dataUpdate = dateCreacion;
            Person person = new Person();
            person.Name = name;
            person.Created = dateCreacion;
            person.Updated = dataUpdate;
            personaNegocio.Insert(person);
            if (personaNegocio.Insert(person)!=null) {
                MessageBox.Show("Se agrego correctamente la Persona");
            }
            else
            {
                MessageBox.Show("No se puede agregar la Persona");
            }
 
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
          

        }
    }
}
