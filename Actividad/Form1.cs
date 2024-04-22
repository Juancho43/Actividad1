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
            List<ICalculable> datos = new List<ICalculable>() { new Triangulo(), new Cuadrado(), new Circulo() };
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
                    break;
                case "Cuadrado nuevo":
                    textBoxLado1.Enabled = true;
                    textBoxLado2.Enabled = false;
                    textBoxLado3.Enabled = false;
                    textBoxRadio.Enabled = false;
                    break;
                case "Triangulo nuevo":
                    textBoxLado1.Enabled = true;
                    textBoxLado2.Enabled = true;
                    textBoxLado3.Enabled = true;
                    textBoxRadio.Enabled = false;
                    break;
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            string tipo = comboBoxTipoFigura.SelectedValue.ToString();
            switch (tipo)
            {
                case "Circulo nuevo":
                    ICalculable circulo = new Circulo(Double.Parse(textBoxRadio.Text));
                    Controller.SetFigura(circulo);
                    listBoxFiguras.Items.Add(circulo);
                    break;
                case "Cuadrado nuevo":
                    ICalculable cuadrado = new Cuadrado(Double.Parse(textBoxLado1.Text));
                    Controller.SetFigura(cuadrado);
                    listBoxFiguras.Items.Add(cuadrado);
                    break;
                case "Triangulo nuevo":
                    if (Controller.VerificarTriangulo(Double.Parse(textBoxLado1.Text), Double.Parse(textBoxLado2.Text), Double.Parse(textBoxLado3.Text)))
                    {
                        ICalculable triangulo = new Triangulo(Double.Parse(textBoxLado1.Text), Double.Parse(textBoxLado2.Text), Double.Parse(textBoxLado3.Text));
                        Controller.SetFigura(triangulo);
                        listBoxFiguras.Items.Add(triangulo);
                    }
                    else
                    {
                        MessageBox.Show("Los valores ingresados no forman un tríangulo", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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
        private void MostrarFigura(ICalculable figura)
        {

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

            }

        }

        
    }
}
