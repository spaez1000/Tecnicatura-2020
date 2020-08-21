using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Form1 : Form
    {
        delegate void PunteroMetodoMensaje(string Mensaje);

        PunteroMetodoMensaje mensaje;
        Action<string> accion;
        Func<int, int, string> suma;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //int num = 5;
            //int num2 = 6;

            //if (num == num2)
            //    MessageBox.Show("Iguales");
            //else
            //    MessageBox.Show("Distintos");

            //Persona persona1 = new Persona();
            //persona1.Nombre = "Juan";
            //Persona persona2 = new Persona();

            //Persona persona3 = persona1;


            //persona2.Nombre = "Juan";
            //if(persona1==persona3)
            //    MessageBox.Show("Iguales");
            //else
            //    MessageBox.Show("Distintos");

            //IComparable comparable = persona1;

            //Alumno alumno1 = new Alumno();
            //alumno1.Nombre = "Alberto Menendez";

            //Alumno alumno2 = new Alumno
            //{
            //    Nombre = "Roberto Menendez",
            //    Estado = EstadoAlumno.Cursando
            //};

            //if (alumno2.Estado == EstadoAlumno.Cursando)
            //    MessageBox.Show("Cursando");

            //EstadoAlumno estado = (EstadoAlumno)2;
            //MessageBox.Show("Estado: "+ estado.ToString());

            //Point punto = new Point(10, 30);

            //int numero = 13;
            //numero = null;

            //DateTime fecha = new DateTime(2020, 8, 20);
            //fecha = null;

            //Nullable<int> numero2 = 14;
            //numero2 = null;

            //int? numero3 = 15;
            //numero3 = null;

            //if (numero3 == 15)
            //    MessageBox.Show("Igual a 15");

            //DateTime? fecha2 = new DateTime(2020, 8, 20);
            //fecha2 = null;
            //if(fecha2==fecha)
            //    MessageBox.Show("las fechas son iguales");

            //if (fecha2.HasValue)
            //    fecha = fecha2.Value;

            //DateTime fecha3 = new DateTime(2020, 8, 20);
            //MessageBox.Show(fecha3.ToString("yyyyMMdd"));
            //MessageBox.Show(fecha3.ToShortDateString());
            decimal nro = 10.5M;
            double nro2 = 10.5;
            Console.WriteLine(nro.ToString("c"));
            Console.WriteLine(nro.ToString("N2"));
            Console.WriteLine(nro2.ToString("N3"));

            Console.WriteLine("El precio total es " + nro.ToString("c") +
                              " que corresponde a la fecha " +
                              DateTime.Today.ToString("dd/MM/yyyy"));

            Console.WriteLine("El precio total es {0:c} que corresponde a la fecha {1:dd/MM/yyy}", nro, DateTime.Today);

            string mensaje = string.Format("El precio total es {0:c} que corresponde a la fecha {1:dd/MM/yyy}", nro, DateTime.Today);
            Console.WriteLine(mensaje);

            string mensaje2 = $"El precio total es {nro:c} que corresponde a la fecha {DateTime.Today:dd/MM/yyy}";
            Console.WriteLine(mensaje2);

        }

        private void btnDelegado_Click(object sender, EventArgs e)
        {
            MostrarMensajePantalla("Hola a todos!");
            mensaje = MostrarMensajePantalla;

            mensaje("Mensaje desde el delegado");
        }



        private void btnAsignar_Click(object sender, EventArgs e)
        {
            mensaje += MostrarMensajePantalla;
        }

        private void btnBorrarDelegado_Click(object sender, EventArgs e)
        {
            mensaje -= MostrarMensajePantalla;
        }
        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            if (accion != null)
                accion("Mensaje desde el delegado");
        }
        private void MostrarMensajePantalla(string mensaje)
        {
            MessageBox.Show(mensaje);    
        }
        private void MostrarMensajeLabel(string mensaje)
        {
            label1.Text = mensaje;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensaje += MostrarMensajeLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensaje -= MostrarMensajeLabel;
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accion += m =>
                            {
                                label1.Text = "Mensaje anonimo";
                                this.Text = DateTime.Now.ToLongTimeString();
                            };

            suma += (p1, p2) =>
                                {
                                    int resultado = p1 + p2;
                                    return resultado.ToString();
                                };

            label1.Text = suma(2, 8);
               

        }

       
    }

    class Persona : IComparable
    {
        public string Nombre { get; set; }

        public int CompareTo(object obj)
        {
            Persona objPersona = (Persona)obj;

            if (objPersona.Nombre[0] < this.Nombre[0])
                return -1;
            else if (objPersona.Nombre[0] == this.Nombre[0])
                return 0;
            else
                return 1;
        }
    }

    class Alumno : Persona
    {
        public EstadoAlumno Estado { get; set; }

        // 1 = Cursando, 2 = Recibido, 3 = Atrasado, 4 = Abandono
    }

    enum EstadoAlumno
    {
        Cursando = 1, 
        Recibido, 
        Atrasado, 
        Abandono
    }
}
