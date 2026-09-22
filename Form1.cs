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
                    dgv1.Rows.Add(registro.id, registro.name, registro.email);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
