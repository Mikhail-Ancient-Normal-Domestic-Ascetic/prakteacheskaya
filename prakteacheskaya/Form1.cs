using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace prakteacheskaya
{
    public partial class Form1 : Form
    {

        private BoysDatabase _human;
        public Form1()
        {
            InitializeComponent();

            _human = new BoysDatabase();
            _human.Initialize();

            BoysDatabase.DataSource = _human.Weathers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = _human.Weathers.Where(u => u.MeasureUnit == MeasureUnits.Slave).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = _human.Weathers.Where(u => u.MeasureUnit == MeasureUnits.GigaNigga).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = _human.Weathers.Where(u => u.MeasureUnit == MeasureUnits.BoyNextDoor).ToList();
                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
