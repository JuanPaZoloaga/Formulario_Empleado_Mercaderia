using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using parcial.Security;
using parcial.Consts;

namespace parcial
{
    public partial class NewEmployee : Form
    {
        int nroLegajo = 0;
        private readonly Home _home;
        public NewEmployee(Home home)
        {
            _home = home;
            InitializeComponent();
            legajoid(ref nroLegajo);
            txbLegajo.Text = nroLegajo.ToString();
        }
        public void Nuevo() //Funcion para cargar nuevos empleados
        {
            char separador = '-'; //Separador para txt
            string pathCarpeta = @"C:\Parcial\"; //Ubicacion donde se van a generar los archivos
            string nombreArchivo = @"Datos.txt"; //Nombre del archivo txt con datos de los empleados
            string loginArchivo = @"Users.txt"; //Nombre del archivo txt con los datos del login
            string rutaArchivoDatos = Path.Combine(pathCarpeta, nombreArchivo);
            string rutaArchivoLogin = Path.Combine(pathCarpeta, loginArchivo);
            string[] datos = new string[7]; // Arreglo para escribir o leer datos
            /*Cargamos los valores del objeto Empleado*/
            Empleado Empleado_Nuevo = new Empleado();
            Empleado_Nuevo.Apellido = txbApellido.Text;
            Empleado_Nuevo.Nombre = txb_Nombre.Text;
            Empleado_Nuevo.DNI = Convert.ToInt32(txbDNI.Text);
            Empleado_Nuevo.Domicilio = ($"{txbCalle.Text}-{txbNumCalle.Text}");
            Empleado_Nuevo.Dpto = txbDpto.Text;
            Empleado_Nuevo.Piso = txbPiso.Text;
            Empleado_Nuevo.Legajo = Convert.ToInt32(txbLegajo.Text);

            try //Intentamos acceder al archivo con los datos
            {
                if (!(Directory.Exists(pathCarpeta))) //Verificamos que exista la ubicacion
                {
                    Directory.CreateDirectory(pathCarpeta);
                }
                if (Directory.Exists(pathCarpeta))
                {

                    if (!File.Exists(rutaArchivoDatos)) //Verificamos que exista el archivo de datos de los empleados
                    {

                        using (var streamdata = File.Create(rutaArchivoDatos)) ;
                    }
                    if (!File.Exists(rutaArchivoLogin)) //Verificamos que exista el archivo de datos del login
                    {
                        using (var streamlogin = File.Create(rutaArchivoLogin)) ;
                    }
                }
                /* Escribe los datos en el archivo */
                string Letra1;
                Letra1 = txb_Nombre.Text.Trim().ToLower();
                Letra1.ToCharArray();
                ;
                using (StreamWriter Escribir_Login = new StreamWriter(rutaArchivoLogin, true))
                {
                    /* Crea el usuario con la primera letra del nombre y el apellido en minuscula, ademas encriptamos la contraseña para que sea ilegible en el .txt */
                    Escribir_Login.WriteLine($"{Letra1[0]}{txbApellido.Text.Trim().ToLower()}{separador}{HashDirectory.ToSHA256(Empleado_Nuevo.Contraseña)}\n");
                }
                using (StreamWriter Escribir_Datos = new StreamWriter(rutaArchivoDatos, true))
                {
                    //Escribir_Datos.WriteLine($"{Empleado_Nuevo.Legajo}{separador}" +
                    //    $"{Empleado_Nuevo.Apellido.Trim()}{separador}" +
                    //    $"{Empleado_Nuevo.Nombre.Trim()}{separador}" +
                    //    $"{Empleado_Nuevo.DNI}{separador}" +
                    //    $"{Empleado_Nuevo.FechaNacimiento.Date}{separador}" +
                    //    $"{Empleado_Nuevo.Domicilio.Trim()}{separador}" +
                    //    $"{Empleado_Nuevo.Dpto.Trim()}{separador}" +
                    //    $"{Empleado_Nuevo.Piso.Trim()}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.Legajo}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.Apellido.Trim()}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.Nombre.Trim()}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.DNI}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.FechaNacimiento.Date}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.Domicilio.Trim()}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.Dpto.Trim()}{separador}");
                    Escribir_Datos.Write($"{Empleado_Nuevo.Piso.Trim()}{separador}\n");                    
                }

            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        public bool validator() // Funcion que devuelve booleano para comprobar los datos del formulario
        {
            bool validator = true;
            if (txb_Nombre == null || txbApellido == null || datepicker == null) // Validar campos obligatorios
            {
                validator = false;
                MessageBox.Show("El apellido, nombre y Fecha de nacimiento son obligatorios");
            }
            if (Convert.ToInt32(txbDNI.Text) > 99999999 || Convert.ToInt32(txbDNI.Text) < 1000000) // Validador para el numero de documento
            {
                validator = false;
                MessageBox.Show("El DNI no puede tener menos de 6 digitos o mas de 8");

            }
            return validator;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (validator() == true) //Llamamos a la funcion validator para verificar los campos obligatorios
            {
                Nuevo(); // Llama la funcion Nuevo (para cargar el empleado)
                MessageBox.Show("Se cargo correctamente el nuevo empleado");
                if (_home != null)
                {
                    _home.btnSearch_Click(null, null);
                }
                this.Close();
            }
            else { MessageBox.Show("No se pudo cargar el empleado"); }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void legajoid(ref int legajo) //Funcion contador para el legajo
        {
            char separador = '-'; //Separador para txt
            string pathCarpeta = @"C:\Parcial\"; //Ubicacion donde se van a generar los archivos
            string nombreArchivo = @"Datos.txt"; //Nombre del archivo txt con datos de los empleados
            string rutaArchivoDatos = Path.Combine(pathCarpeta, nombreArchivo);
            string[] datos = new string[9]; // Arreglo para escribir o leer datos
            try //Intentamos acceder al archivo con los datos
            {
                if (!(Directory.Exists(pathCarpeta))) //Verificamos que exista la ubicacion
                {
                    Directory.CreateDirectory(pathCarpeta);
                }
                if (Directory.Exists(pathCarpeta))
                {

                    if (!File.Exists(rutaArchivoDatos)) //Verificamos que exista el archivo de datos de los empleados
                    {

                        using (var streamdata = File.Create(rutaArchivoDatos)) ;
                    }
                }

                using (StreamReader streamReader = new StreamReader(rutaArchivoDatos))
                {
                    
                    string filas = streamReader.ReadLine();
                    while (filas != null)
                    {
                        datos = filas.Split(separador);
                        filas = streamReader.ReadLine();
                        legajo = Convert.ToInt32(datos[0]) + 1;
                    } 
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

    }
}