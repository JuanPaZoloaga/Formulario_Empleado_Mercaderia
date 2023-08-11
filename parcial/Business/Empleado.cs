namespace parcial
{

    public class Empleado
    {
        public Empleado()
        {
            this.Contraseña = "P.a.s.s.";
            this.FechaNacimiento = DateTime.Now.Date;
            this.Legajo = 0;
        }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Domicilio { get; set; }
        public string Dpto { get; set; }
        public string Piso { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
