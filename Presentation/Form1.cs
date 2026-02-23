using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ===== BOTÓN CAMBIAR COLOR =====
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Rojo")
            {
                label1.Text = "Verde";
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.Text = "Rojo";
                label1.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // ===== COMBOBOX - AGREGAR ITEMS CON TEXTBOX =====
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
        }

        // ===== DATETIMEPICKER - AGREGAR FECHAS A COMBOBOX =====
        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            ComboBoxFecha.Items.Add(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}