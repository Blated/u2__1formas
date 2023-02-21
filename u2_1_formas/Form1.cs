using System.ComponentModel.DataAnnotations;

namespace u2_1_formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cbox1.Checked)
            {
                String genero = " Genero: Masculino"; 
                lblresultado.Text = txtNombre.Text + genero;
            }

            if (Rbox1.Checked)
            {
                String genero = " Genero: Femenino";
                lblresultado.Text = txtNombre.Text + genero;
            }

            Graphics papel = pictureBox1.CreateGraphics();
            Pen Lapiz = new Pen(Color.Black);
            papel.DrawRectangle(Lapiz, 10, 10, 100, 50);
            /* 
             * Linea line
             * Ellipse 
             * Ellipse relleno FillEllipse
             */

        }
    }
}