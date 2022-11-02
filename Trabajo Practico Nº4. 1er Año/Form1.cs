using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_Nº4._1er_Año
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creo mi Arreglo. En este caso sera un ArrayList (INGRESAR DATOS)
        ArrayList DatosUsuario = new ArrayList();

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="")
            {
                errorProvider1.SetError(txtNombre, "Debe Ingresar NOMBRE DE USUARIO");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtEdad.Text=="")
            {
                errorProvider1.SetError(txtEdad, "Debe Ingresar la EDAD DE USUARIO");
                txtEdad.Focus();
                return;
            }
            errorProvider1.SetError(txtEdad, "");

            //Genero una Instancia a la Clase Usuario
            Usuario miUsuario = new Usuario();
            //Enviando la Informacion de los Cuadros de Texto(TxtBox) a las Propiedades en la Clase Usuario.

            miUsuario.nombre = txtNombre.Text;
            miUsuario.edad= Convert.ToInt32(txtEdad.Text);

            //Agregar la Informacion al ArrayList
            DatosUsuario.Add(miUsuario);

            //Agregar la Informacion a la DataGrid(Datos)
            Datos.DataSource=null;
            Datos.DataSource = DatosUsuario;
            Limpiar();





        }
        //Crear un Metodo para LIMPIAR los TxtBox(LIMPIAR ARCHIVOS)
        private void Limpiar()
        {
            txtNombre.Text="";
            txtEdad.Text="";
            txtNombre.Focus();
        }

        private void btnGUARDARENARCHIVO_Click(object sender, EventArgs e)
        {
            guardarArchivo();
        }
        //Crear un Metodo para guardar la Informacion en un Archivo de Texto(GUARDAR ARCHIVO)
        public void guardarArchivo()
        {
            //Genero una Instancia a la Clase Usuario
            Usuario miUsuario=new Usuario();
            TextWriter escribir=new StreamWriter("Datos.txt");
            escribir.Close();
            foreach(Usuario usuario in DatosUsuario)
            {
                StreamWriter agregar = File.AppendText("Datos.txt");
                agregar.WriteLine(usuario.nombre + "_" + usuario.edad);
                agregar.Close();
            }

        }

        private void btnCARGARARCHIVO_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        //Metodo para Leer el Archivo de Texto(CARGAR ARCHIVO)
        public void CargarUsuarios()
        {
            try
            {

                StreamReader Leer = new StreamReader("Datos.txt");
                string aux;
                string linea;
                string nombre;
                int edad;
                int posicion;
                //Usamos un Ciclo para la Lectura de los datos de los Usuarios
                while ((linea = Leer.ReadLine()) != null)
                {
                    //Extraigo el Nombre como tal
                    posicion = linea.IndexOf('_');
                    aux = linea.Substring(0, posicion);
                    nombre=aux;
                    linea = linea.Substring(posicion + 1);
                    //Extraemos la Edad
                    edad= Convert.ToInt32(linea);
                    //generar una Instancia a la Clase Usuaria
                    Usuario miUsuario = new Usuario();
                    miUsuario.nombre = nombre;
                    miUsuario.edad = edad;

                    //Llenamos el Arreglo de tipo ArrayList
                    DatosUsuario.Add(miUsuario);
                    Datos.DataSource=null;
                    Datos.DataSource= DatosUsuario;


                }
                Leer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}
       







