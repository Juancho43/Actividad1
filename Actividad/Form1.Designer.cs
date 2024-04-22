namespace Actividad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxFiguras = new ListBox();
            labelLado1 = new Label();
            labelLado2 = new Label();
            labelLado3 = new Label();
            textBoxLado1 = new TextBox();
            textBoxLado2 = new TextBox();
            textBoxLado3 = new TextBox();
            labelRadio = new Label();
            textBoxRadio = new TextBox();
            labelAltura = new Label();
            buttonCrear = new Button();
            comboBoxTipoFigura = new ComboBox();
            labelArea = new Label();
            labelPerimetro = new Label();
            labelPerimetroData = new Label();
            labelAreaData = new Label();
            labelAlturaData = new Label();
            SuspendLayout();
            // 
            // listBoxFiguras
            // 
            listBoxFiguras.FormattingEnabled = true;
            listBoxFiguras.Location = new Point(12, 12);
            listBoxFiguras.Name = "listBoxFiguras";
            listBoxFiguras.Size = new Size(151, 424);
            listBoxFiguras.TabIndex = 0;
            listBoxFiguras.SelectedIndexChanged += listBoxFiguras_SelectedIndexChanged;
            // 
            // labelLado1
            // 
            labelLado1.AutoSize = true;
            labelLado1.Location = new Point(203, 36);
            labelLado1.Name = "labelLado1";
            labelLado1.Size = new Size(50, 20);
            labelLado1.TabIndex = 1;
            labelLado1.Text = "Lado1";
            // 
            // labelLado2
            // 
            labelLado2.AutoSize = true;
            labelLado2.Location = new Point(203, 78);
            labelLado2.Name = "labelLado2";
            labelLado2.Size = new Size(50, 20);
            labelLado2.TabIndex = 2;
            labelLado2.Text = "Lado2";
            // 
            // labelLado3
            // 
            labelLado3.AutoSize = true;
            labelLado3.Location = new Point(203, 117);
            labelLado3.Name = "labelLado3";
            labelLado3.Size = new Size(50, 20);
            labelLado3.TabIndex = 3;
            labelLado3.Text = "Lado3";
            // 
            // textBoxLado1
            // 
            textBoxLado1.Location = new Point(270, 26);
            textBoxLado1.Name = "textBoxLado1";
            textBoxLado1.Size = new Size(125, 27);
            textBoxLado1.TabIndex = 4;
            // 
            // textBoxLado2
            // 
            textBoxLado2.Location = new Point(270, 68);
            textBoxLado2.Name = "textBoxLado2";
            textBoxLado2.Size = new Size(125, 27);
            textBoxLado2.TabIndex = 5;
            // 
            // textBoxLado3
            // 
            textBoxLado3.Location = new Point(270, 110);
            textBoxLado3.Name = "textBoxLado3";
            textBoxLado3.Size = new Size(125, 27);
            textBoxLado3.TabIndex = 6;
            // 
            // labelRadio
            // 
            labelRadio.AutoSize = true;
            labelRadio.Location = new Point(203, 162);
            labelRadio.Name = "labelRadio";
            labelRadio.Size = new Size(48, 20);
            labelRadio.TabIndex = 7;
            labelRadio.Text = "Radio";
            // 
            // textBoxRadio
            // 
            textBoxRadio.Location = new Point(270, 159);
            textBoxRadio.Name = "textBoxRadio";
            textBoxRadio.Size = new Size(125, 27);
            textBoxRadio.TabIndex = 8;
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Location = new Point(203, 283);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(49, 20);
            labelAltura.TabIndex = 9;
            labelAltura.Text = "Altura";
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(301, 226);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(94, 29);
            buttonCrear.TabIndex = 13;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // comboBoxTipoFigura
            // 
            comboBoxTipoFigura.FormattingEnabled = true;
            comboBoxTipoFigura.Location = new Point(203, 192);
            comboBoxTipoFigura.Name = "comboBoxTipoFigura";
            comboBoxTipoFigura.Size = new Size(192, 28);
            comboBoxTipoFigura.TabIndex = 14;
            comboBoxTipoFigura.SelectedIndexChanged += comboBoxTipoFigura_SelectedIndexChanged;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(203, 371);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(43, 20);
            labelArea.TabIndex = 15;
            labelArea.Text = "Área:";
            // 
            // labelPerimetro
            // 
            labelPerimetro.AutoSize = true;
            labelPerimetro.Location = new Point(203, 329);
            labelPerimetro.Name = "labelPerimetro";
            labelPerimetro.Size = new Size(76, 20);
            labelPerimetro.TabIndex = 16;
            labelPerimetro.Text = "Perímetro:";
            // 
            // labelPerimetroData
            // 
            labelPerimetroData.AutoSize = true;
            labelPerimetroData.Location = new Point(281, 329);
            labelPerimetroData.Name = "labelPerimetroData";
            labelPerimetroData.Size = new Size(27, 20);
            labelPerimetroData.TabIndex = 17;
            labelPerimetroData.Text = "---";
            // 
            // labelAreaData
            // 
            labelAreaData.AutoSize = true;
            labelAreaData.Location = new Point(281, 371);
            labelAreaData.Name = "labelAreaData";
            labelAreaData.Size = new Size(27, 20);
            labelAreaData.TabIndex = 18;
            labelAreaData.Text = "---";
            // 
            // labelAlturaData
            // 
            labelAlturaData.AutoSize = true;
            labelAlturaData.Location = new Point(281, 283);
            labelAlturaData.Name = "labelAlturaData";
            labelAlturaData.Size = new Size(27, 20);
            labelAlturaData.TabIndex = 19;
            labelAlturaData.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(labelAlturaData);
            Controls.Add(labelAreaData);
            Controls.Add(labelPerimetroData);
            Controls.Add(labelPerimetro);
            Controls.Add(labelArea);
            Controls.Add(comboBoxTipoFigura);
            Controls.Add(buttonCrear);
            Controls.Add(labelAltura);
            Controls.Add(textBoxRadio);
            Controls.Add(labelRadio);
            Controls.Add(textBoxLado3);
            Controls.Add(textBoxLado2);
            Controls.Add(textBoxLado1);
            Controls.Add(labelLado3);
            Controls.Add(labelLado2);
            Controls.Add(labelLado1);
            Controls.Add(listBoxFiguras);
            Name = "Form1";
            Text = "Actividad 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxFiguras;
        private Label labelLado1;
        private Label labelLado2;
        private Label labelLado3;
        private TextBox textBoxLado1;
        private TextBox textBoxLado2;
        private TextBox textBoxLado3;
        private Label labelRadio;
        private TextBox textBoxRadio;
        private Label labelAltura;
        private Button buttonCrear;
        private ComboBox comboBoxTipoFigura;
        private Label labelArea;
        private Label labelPerimetro;
        private Label labelPerimetroData;
        private Label labelAreaData;
        private Label labelAlturaData;
    }
}
