using System;
using System.Windows.Forms;

namespace UI_Exam.Pantallas.Generales
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void pbx_Ejercicios_Click(object sender, EventArgs e)
        {
            Ejercicios.frm_Bingo objPantallaBingo = new Ejercicios.frm_Bingo();
            this.Hide();
            objPantallaBingo.ShowDialog();
        }

        private void pbx_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Salir Realmente de la Aplicación...???", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
