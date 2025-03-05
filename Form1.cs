using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionReservacionesHotel;

namespace GestionReservacionesHotel
{
    public partial class Form1 : Form
    {
        private List<Reservacion> reservas = new List<Reservacion>();

        private Hotel hotel = new Hotel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void btnMostrarDisponibles_Click(object sender, EventArgs e)
        {
            lstHabitaciones.Items.Clear();
            var disponibles = hotel.ObtenerHabitacionesDisponibles();
            foreach (var habitacion in disponibles)
            {
                lstHabitaciones.Items.Add($"Habitación {habitacion.Numero} - {habitacion.Tipo} - ${habitacion.PrecioPorNoche}");
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string documento = txtDocumento.Text;
            string telefono = txtTelefono.Text;
            int numeroHabitacion, noches;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("Debe ingresar un nombre y un documento válido.");
                return;
            }

            if (!int.TryParse(txtNumHabitacion.Text, out numeroHabitacion) ||
                !int.TryParse(txtNoches.Text, out noches))
            {
                MessageBox.Show("Ingrese valores numéricos válidos para la habitación y las noches.");
                return;
            }

            // Registrar automáticamente al cliente antes de la reserva
            hotel.RegistrarCliente(nombre, documento, telefono);

            // Intentar hacer la reserva
            bool reservaExitosa = hotel.CrearReservacion(documento, numeroHabitacion, noches);

            if (reservaExitosa)
            {
                Reservacion reserva = hotel.Reservaciones[numeroHabitacion];

                lstReservaciones.Items.Add(
                    $"Cliente: {reserva.Cliente.Nombre} | Habitación {reserva.Habitacion.Numero} | Noches: {reserva.Noches} | Total: ${reserva.MontoTotal}"
                );

                MessageBox.Show("Reserva realizada con éxito.");

                // Limpiar los campos
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la reserva. Verifique los datos.");
            }
        }



        private void btnCancelarReservacion_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int numeroHabitacion;

            if (string.IsNullOrWhiteSpace(nombre) || !int.TryParse(txtNumHabitacion.Text, out numeroHabitacion))
            {
                MessageBox.Show("Ingrese un nombre válido y un número de habitación válido.");
                return;
            }

            // Buscar la reserva en la lista
            var reserva = hotel.Reservaciones.Values.FirstOrDefault(r => r.Cliente.Nombre == nombre && r.Habitacion.Numero == numeroHabitacion);

            if (reserva != null)
            {
                bool cancelada = hotel.CancelarReservacion(numeroHabitacion);

                if (cancelada)
                {
                    // Eliminar la reserva de la lista de visualización
                    for (int i = 0; i < lstReservaciones.Items.Count; i++)
                    {
                        if (lstReservaciones.Items[i].ToString().Contains($"Cliente: {nombre}") &&
                            lstReservaciones.Items[i].ToString().Contains($"Habitación {numeroHabitacion}"))
                        {
                            lstReservaciones.Items.RemoveAt(i);
                            break;
                        }
                    }

                    MessageBox.Show("Reserva cancelada correctamente.");
                    LimpiarCampos(); // Limpia los campos después de cancelar la reserva
                }
                else
                {
                    MessageBox.Show("No se pudo cancelar la reserva.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró una reserva con esos datos.");
            }
        }


        private void ActualizarListaReservaciones()
        {
            lstReservaciones.Items.Clear();
            foreach (var reservacion in hotel.Reservaciones.Values)
            {
                lstReservaciones.Items.Add($"Cliente: {reservacion.Cliente.Nombre} - Habitación {reservacion.Habitacion.Numero} - {reservacion.Noches} noches");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtNumHabitacion.Clear();
            txtNoches.Clear();
        }
    }

    public class Reserva
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Habitacion { get; set; }
        public int Noches { get; set; }

        public Reserva(string nombre, string documento, string telefono, string habitacion, int noches)
        {
            Nombre = nombre;
            Documento = documento;
            Telefono = telefono;
            Habitacion = habitacion;
            Noches = noches;
        }

        public override string ToString()
        {
            return $"{Nombre} - Habitación {Habitacion} - {Noches} noches";
        }

        // Comentario de prueba para Git/GitHub
    }
}




