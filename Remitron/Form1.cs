using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Remitron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            Info info = new Info();
            info.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Imprimir_Click(object sender, EventArgs e)
        {
            List<string> Nombre = new List<string>();
            List<string> Domicilio = new List<string>();
            Nombre.Add(comboBox2.Text);
            Domicilio.Add(comboBox3.Text);
            comboBox2.DataSource = null; comboBox3.DataSource = null;
            comboBox2.DataSource = Nombre; comboBox3.DataSource = Domicilio;
            string Remito = GetComboBoxValue("comboBox1");
            bool validador = true;
            while (validador){
                if (!string.IsNullOrEmpty(Remito))
                {
                    validador = false;
                    if (Remito == "REMITO DIGITAL")
                    {
                        ExcelEditorDigital excelEditor = new ExcelEditorDigital();
                        excelEditor.AbrirArchivoExcel(this);
                    }
                    else if (Remito == "REMITO PRE-IMPRESO")
                    {
                        ExcelEditor excelEditor = new ExcelEditor();
                        excelEditor.AbrirArchivoExcel(this);
                    }
                }
                else
                {
                    validador = false;
                    Form2 form3 = new Form2(); 
                    form3.Show();
                }
            } 
            
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
