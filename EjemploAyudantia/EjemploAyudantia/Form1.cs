using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploAyudantia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo.SelectedText != null)
            {
                Feedback.Text = "Has seleccionado: " + combo.SelectedItem.ToString();
                Feedback.Visible = true;
            }
            else
            {
                Feedback.Text = "No has seleccionado nada";
                Feedback.Visible = true;
            }
        }
    }
}
