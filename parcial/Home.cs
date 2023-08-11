using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.btnSearch_Click(null, null);
        }

        private void Panel_Empleados_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            //this.btnSearch_Click(null, null);
            Panel_Empleados.Visible = true;
            panelEmpleadoSuperior.Visible = true;
            panelEmpleadoInferior.Visible = true;
        }

        private void btn_employee_exit_Click(object sender, EventArgs e)
        {
            Panel_Empleados.Visible = false;
            panelEmpleadoSuperior.Visible = false;
            panelEmpleadoInferior.Visible = false;
        }

        private void btn_new_employee_Click(object sender, EventArgs e)
        {
            NewEmployee Empleado = new NewEmployee(this);
            Empleado.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_right_Paint(object sender, PaintEventArgs e)
        {

        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            char separador = '-'; //Separador para txt
            string pathCarpeta = @"C:\Parcial\"; //Ubicacion donde se van a generar los archivos
            string nombreArchivo = @"Datos.txt"; //Nombre del archivo txt con datos de los empleados
            string rutaArchivoDatos = Path.Combine(pathCarpeta, nombreArchivo);
            string[] datos = new string[7]; // Arreglo para escribir o leer datos
            

            try //Intentamos acceder al archivo con los datos
            {

                using (StreamReader leer_datos = new StreamReader(rutaArchivoDatos))
                {
                    

                    string datosArchivo = leer_datos.ReadToEnd();

                    List<string> listaEmpleados = new List<string>(datosArchivo.Split('\n'));
                    listaEmpleados.RemoveAll(i => i.Length == 0);

                    var resultadoBusqueda = listaEmpleados.Where(value => string.IsNullOrEmpty(txbSearch.Text.Trim()) || value.ToUpper().Contains(txbSearch.Text.ToUpper())).ToList();

                    if (resultadoBusqueda.Count > 0)
                    {
                        var dataSource = new List<Empleado>();
                        foreach (var filaEmpleado in resultadoBusqueda)
                        {
                            var empleado = new Empleado();
                            empleado.Legajo = Convert.ToInt32(filaEmpleado.Split('-')[0]);
                            empleado.Apellido = filaEmpleado.Split('-')[1];
                            empleado.Nombre = filaEmpleado.Split('-')[2];
                            empleado.DNI = Convert.ToInt32(filaEmpleado.Split('-')[3]);
                            empleado.FechaNacimiento = DateTime.Parse(filaEmpleado.Split('-')[4]);
                            empleado.Domicilio = $"{filaEmpleado.Split('-')[5]} {filaEmpleado.Split('-')[6]} {filaEmpleado.Split('-')[7]}";
                            dataSource.Add(empleado);
                        }


                        dgvEmpleados.AutoGenerateColumns = false;
                        dgvEmpleados.DataSource = dataSource;
                    }

                    leer_datos.Close(); 
                }

                


            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
