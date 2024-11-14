using System;
using System.IO.Ports;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Asegúrate de tener el paquete MySQL.Data

namespace Actividad09
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();

            serialPort = new SerialPort("COM4", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.Open();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() =>
            {
                if (float.TryParse(data, out float temperaturaC))
                {
                    txtTemperaturaC.Text = temperaturaC.ToString("F2");

                    float temperaturaF = (temperaturaC * 9 / 5) + 32;
                    txtTemperaturaF.Text = temperaturaF.ToString("F2");
                }
            }));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (!string.IsNullOrEmpty(txtTemperaturaC.Text) && !string.IsNullOrEmpty(txtTemperaturaF.Text) && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                try
                {
                    // Conexión a la base de datos
                    string connectionString = "Server=localhost;Database=Actividad9;User ID=root;Password=gsmn71acD*;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Comando SQL para insertar los datos en la tabla Registro
                        string query = "INSERT INTO Registro (temperaturaC, temperaturaF, usuario) VALUES (@temperaturaC, @temperaturaF, @usuario)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Asigna los valores a los parámetros
                            command.Parameters.AddWithValue("@temperaturaC", Convert.ToSingle(txtTemperaturaC.Text));
                            command.Parameters.AddWithValue("@temperaturaF", Convert.ToSingle(txtTemperaturaF.Text));
                            command.Parameters.AddWithValue("@usuario", txtUsuario.Text); // Asegúrate de que esto sea lo que el usuario ingresa

                            // Ejecuta el comando
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos guardados exitosamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje en caso de error
                    MessageBox.Show($"Error al guardar los datos en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay datos de temperatura o el nombre de usuario está vacío para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
