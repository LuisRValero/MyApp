using CsvHelper;
using System.Globalization;
namespace MyApp

{
    public partial class Form1 : Form
    {
        List<Persona> registros = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butCargar_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                var reader = new StreamReader(ofd1.FileName);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                registros = csv.GetRecords<Persona>().ToList();
                foreach (var registro in registros)
                {
                    dgvRegistros.Rows.Add(registro.id, registro.name, registro.email);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 editar = new Form2(dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString());
            editar.Show();
            if (editar.ShowDialog() == DialogResult.OK)
            {
                string nombre = editar.ActualizaNombre;
                string correo = editar.ActualizaCorreo;
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;
            }
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            registros.Clear();
            foreach (DataGridViewRow fila in dgvRegistros.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Persona p = new Persona();
                    p.id = int.Parse(fila.Cells[0].Value.ToString());
                    p.name = fila.Cells[1].Value.ToString();
                    p.email = fila.Cells[2].Value.ToString();
                    registros.Add(p);
                }
            }

            using (var writer = new StreamWriter(ofd1.FileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(registros);
            }
        }
    }
}
