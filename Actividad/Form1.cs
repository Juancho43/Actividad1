using Actividad.Controladoras;
using Actividad.Interfaces;
using Actividad.Modelo;
using System;

namespace Actividad
{
    public partial class Form1 : Form
    {
        private FiguraController Controller;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();
        }
        private void Setup()
        {
            Controller = new FiguraController();
            List<ICalculable> datos = new List<ICalculable>() { new Triangulo(), new Cuadrado(), new Circulo(), new Poligono() };
            comboBoxTipoFigura.DataSource = datos;
        }
        private void SetTextboxs()
        {
            string tipo = comboBoxTipoFigura.SelectedValue.ToString();
            switch (tipo)
            {
                case "Circulo nuevo":
                    textBoxLado1.Enabled = false;
                    textBoxLado2.Enabled = false;
                    textBoxLado3.Enabled = false;
                    textBoxRadio.Enabled = true;
                    textBoxCantidad.Enabled = false;
                    break;
                case "Cuadrado nuevo":
                    textBoxLado1.Enabled = true;
                    textBoxLado2.Enabled = false;
                    textBoxLado3.Enabled = false;
                    textBoxRadio.Enabled = false;
                    textBoxCantidad.Enabled = false;
                    break;
                case "Triangulo nuevo":
                    textBoxLado1.Enabled = true;
                    textBoxLado2.Enabled = true;
                    textBoxLado3.Enabled = true;
                    textBoxRadio.Enabled = false;
                    textBoxCantidad.Enabled = false;
                    break;
                case "Poligono nuevo":
                    textBoxLado1.Enabled = true;
                    textBoxLado2.Enabled = false;
                    textBoxLado3.Enabled = false;
                    textBoxRadio.Enabled = false;
                    textBoxCantidad.Enabled = true;
                    break;
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            string tipo = comboBoxTipoFigura.SelectedValue.ToString();
            switch (tipo)
            {
                case "Circulo nuevo":
                    NuevaFigura(new Circulo(Double.Parse(textBoxRadio.Text)));
                    break;
                case "Cuadrado nuevo":
                    NuevaFigura(new Cuadrado(Double.Parse(textBoxLado1.Text)));
                    break;
                case "Triangulo nuevo":
                    if (Controller.VerificarTriangulo(Double.Parse(textBoxLado1.Text), Double.Parse(textBoxLado2.Text), Double.Parse(textBoxLado3.Text)))
                    {
                        NuevaFigura(new Triangulo(Double.Parse(textBoxLado1.Text), Double.Parse(textBoxLado2.Text), Double.Parse(textBoxLado3.Text)));
                    }
                    else
                    {
                        MessageBox.Show("Los valores ingresados no forman un tríangulo", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "Poligono nuevo":
                    NuevaFigura(new Poligono(Double.Parse(textBoxLado1.Text),Double.Parse(textBoxCantidad.Text)));
                    break;
            }
        }
        private void comboBoxTipoFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTextboxs();
        }
        private void listBoxFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarFigura((ICalculable)listBoxFiguras.SelectedItem);
        }

        private void NuevaFigura(ICalculable figura)
        {
            Controller.SetFigura(figura);
            listBoxFiguras.Items.Add(figura);
        }
        private void MostrarFigura(ICalculable figura)
        {
            labelAltura.Text = "Altura";
            labelAreaData.Text = figura.CalcularArea().ToString("0.00");
            labelPerimetroData.Text = figura.CalcularPerimetro().ToString("0.00");
            switch (figura)
            {
                case Triangulo:
                    Triangulo triangulo = (Triangulo)figura;
                    labelAlturaData.Text = triangulo.CalcularAltura().ToString("0.00");
                    break;
                case Cuadrado:
                    Cuadrado cuadrado = (Cuadrado)figura;
                    labelAlturaData.Text = cuadrado.GetLado().ToString("0.00");
                    break;
                case Circulo:
                    Circulo circulo = (Circulo)figura;
                    double altura = circulo.GetRadio() * 2;
                    labelAlturaData.Text = altura.ToString("0.00");
                    break;
                case Poligono:
                    Poligono poligono = (Poligono)figura;
                    labelAlturaData.Text = poligono.LADO.ToString();
                    labelAltura.Text = "Lado";
                    break;

            }

        }

        
    }
}
