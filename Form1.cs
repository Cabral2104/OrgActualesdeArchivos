
using System.Formats.Asn1;
using System.Globalization;
using System.Xml.Serialization;
using CsvHelper;
using Newtonsoft.Json;


namespace OrgActualesdeArchivos
{
    public partial class Form1 : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            decimal salario = decimal.Parse(txtSalario.Text);

            Empleado nuevoEmpleado = new Empleado(nombre, apellido, salario);
            empleados.Add(nuevoEmpleado);

            LimpiarCampos();
            ActualizarListaEmpleados();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalario.Clear();
        }

        private void ActualizarListaEmpleados()
        {
            listBoxEmpleados.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                listBoxEmpleados.Items.Add(empleado);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 4;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath);

                switch (fileExtension)
                {
                    case ".csv":
                        CargarDesdeCSV(filePath);
                        break;
                    case ".xml":
                        CargarDesdeXML(filePath);
                        break;
                    case ".json":
                        CargarDesdeJSON(filePath);
                        break;
                    default:
                        MessageBox.Show("Formato de archivo no válido.");
                        break;
                }
            }
        }
        private void CargarDesdeCSV(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    empleados.Clear();
                    empleados.AddRange(csv.GetRecords<Empleado>());
                    ActualizarListaEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDesdeXML(string filePath)
        {
            try
            {
                empleados.Clear();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Empleado>));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    empleados = (List<Empleado>)serializer.Deserialize(fileStream);
                }
                ActualizarListaEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDesdeJSON(string filePath)
        {
            try
            {
                empleados.Clear();
                string jsonText = File.ReadAllText(filePath);
                empleados = JsonConvert.DeserializeObject<List<Empleado>>(jsonText);
                ActualizarListaEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 4;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath);

                switch (fileExtension)
                {
                    case ".csv":
                        GuardarComoCSV(filePath);
                        break;
                    case ".xml":
                        GuardarComoXML(filePath);
                        break;
                    case ".json":
                        GuardarComoJSON(filePath);
                        break;
                    default:
                        MessageBox.Show("Formato de archivo no válido.");
                        break;
                }
            }
        }
        private void GuardarComoCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(empleados);
                }
                MessageBox.Show("Empleados guardados correctamente en formato CSV.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar como archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarComoXML(string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Empleado>));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fileStream, empleados);
                }
                MessageBox.Show("Empleados guardados correctamente en formato XML.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar como archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarComoJSON(string filePath)
        {
            try
            {
                string jsonText = JsonConvert.SerializeObject(empleados, Formatting.Indented);
                File.WriteAllText(filePath, jsonText);
                MessageBox.Show("Empleados guardados correctamente en formato JSON.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar como archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
