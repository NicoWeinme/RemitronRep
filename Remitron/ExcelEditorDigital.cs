using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace Remitron
{
    public class ExcelEditorDigital
    {
        public void AbrirArchivoExcel(Form1 form1)
        {

            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            int minute = currentTime.Minute;
            int second = currentTime.Second;
            string NRemito = form1.GetTextBoxValue("textBox4");
            string hora = (hour + "." + minute + "." + second);
            string newname = (DateTime.Today.ToString("yyyy-mm-dd") + " " + hora + " " + Environment.UserName + " " + NRemito + ".xlsx");
            string destino = (@"\\cpl-sanopera01\software\Remitron\Remitos Realizados\Digitales\" + newname);

            // Crear una instancia de la aplicación de Excel
            Excel.Application excelApp = new Excel.Application();

            // Hacer que Excel sea visible (opcional)
            excelApp.Visible = true;

            string rutaArchivo = @"\\cpl-sanopera01\software\Remitron\src\Archivos Base\DIGITAL.xlsx";

            // Abrir el archivo de Excel
            Excel.Workbook workbook = excelApp.Workbooks.Open(rutaArchivo);

            //Configurar parámetros de guardado
            workbook.SaveAs(destino);

            // Obtener la primera hoja del libro (Índice 1)
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];


            // Editar las celdas
            //Fecha
            Excel.Range Dia = worksheet.Range["U5"]; Dia.Value = form1.GetTextBoxValue("textBox1");
            Excel.Range Ano = worksheet.Range["V5"]; Ano.Value = form1.GetTextBoxValue("textBox3");
            Excel.Range Mes = worksheet.Range["W5"]; Mes.Value = form1.GetTextBoxValue("textBox2");

            //Datos destino
            Excel.Range NombreD = worksheet.Range["E14"]; NombreD.Value = form1.GetComboBoxValue("comboBox2");
            Excel.Range CuitD = worksheet.Range["O14"]; CuitD.Value = form1.GetTextBoxValue("textBox7");
            Excel.Range DireccionD = worksheet.Range["E15"]; DireccionD.Value = form1.GetComboBoxValue("comboBox3");
            Excel.Range ResponsableD = worksheet.Range["R15"]; ResponsableD.Value = form1.GetTextBoxValue("textBox40");

            //Datos Transporte
            Excel.Range ResSoc = worksheet.Range["E52"]; ResSoc.Value = form1.GetTextBoxValue("textBox41");
            Excel.Range CuitT = worksheet.Range["O52"]; CuitT.Value = form1.GetTextBoxValue("textBox10");
            Excel.Range DniT = worksheet.Range["R53"]; DniT.Value = form1.GetTextBoxValue("textBox9");
            Excel.Range NombreT = worksheet.Range["E53"]; NombreT.Value = form1.GetTextBoxValue("textBox6");

            //Datos items - Cantidad
            Excel.Range Cant = worksheet.Range["C19"]; Cant.Value = form1.GetTextBoxValue("textBox39");
            Excel.Range Cant1 = worksheet.Range["C20"]; Cant1.Value = form1.GetTextBoxValue("textBox38");
            Excel.Range Cant2 = worksheet.Range["C21"]; Cant2.Value = form1.GetTextBoxValue("textBox37");
            Excel.Range Cant3 = worksheet.Range["C22"]; Cant3.Value = form1.GetTextBoxValue("textBox36");
            Excel.Range Cant4 = worksheet.Range["C23"]; Cant4.Value = form1.GetTextBoxValue("textBox35");
            Excel.Range Cant5 = worksheet.Range["C24"]; Cant5.Value = form1.GetTextBoxValue("textBox34");
            Excel.Range Cant6 = worksheet.Range["C25"]; Cant6.Value = form1.GetTextBoxValue("textBox33");
            Excel.Range Cant7 = worksheet.Range["C26"]; Cant7.Value = form1.GetTextBoxValue("textBox32");
            Excel.Range Cant8 = worksheet.Range["C27"]; Cant8.Value = form1.GetTextBoxValue("textBox31");
            Excel.Range Cant9 = worksheet.Range["C28"]; Cant9.Value = form1.GetTextBoxValue("textBox30");

            //Datos items - UN
            Excel.Range Un = worksheet.Range["E19"]; Un.Value = form1.GetTextBoxValue("textBox29");
            Excel.Range Un1 = worksheet.Range["E20"]; Un1.Value = form1.GetTextBoxValue("textBox28");
            Excel.Range Un2 = worksheet.Range["E21"]; Un2.Value = form1.GetTextBoxValue("textBox27");
            Excel.Range Un3 = worksheet.Range["E22"]; Un3.Value = form1.GetTextBoxValue("textBox26");
            Excel.Range Un4 = worksheet.Range["E23"]; Un4.Value = form1.GetTextBoxValue("textBox25");
            Excel.Range Un5 = worksheet.Range["E24"]; Un5.Value = form1.GetTextBoxValue("textBox24");
            Excel.Range Un6 = worksheet.Range["E25"]; Un6.Value = form1.GetTextBoxValue("textBox23");
            Excel.Range Un7 = worksheet.Range["E26"]; Un7.Value = form1.GetTextBoxValue("textBox22");
            Excel.Range Un8 = worksheet.Range["E27"]; Un8.Value = form1.GetTextBoxValue("textBox17");
            Excel.Range Un9 = worksheet.Range["E28"]; Un9.Value = form1.GetTextBoxValue("textBox16");

            //Datos items - Descripcion
            Excel.Range Desc = worksheet.Range["F19"]; Desc.Value = form1.GetTextBoxValue("textBox15");
            Excel.Range Desc1 = worksheet.Range["F20"]; Desc1.Value = form1.GetTextBoxValue("textBox14");
            Excel.Range Desc2 = worksheet.Range["F21"]; Desc2.Value = form1.GetTextBoxValue("textBox13");
            Excel.Range Desc3 = worksheet.Range["F22"]; Desc3.Value = form1.GetTextBoxValue("textBox12");
            Excel.Range Desc4 = worksheet.Range["F23"]; Desc4.Value = form1.GetTextBoxValue("textBox11");
            Excel.Range Desc5 = worksheet.Range["F24"]; Desc5.Value = form1.GetTextBoxValue("textBox8");
            Excel.Range Desc6 = worksheet.Range["F25"]; Desc6.Value = form1.GetTextBoxValue("textBox21");
            Excel.Range Desc7 = worksheet.Range["F26"]; Desc7.Value = form1.GetTextBoxValue("textBox20");
            Excel.Range Desc8 = worksheet.Range["F27"]; Desc8.Value = form1.GetTextBoxValue("textBox19");
            Excel.Range Desc9 = worksheet.Range["F28"]; Desc9.Value = form1.GetTextBoxValue("textBox18");

            //Datos Emisor
            Excel.Range EmisorNombre = worksheet.Range["C58"]; EmisorNombre.Value = form1.GetTextBoxValue("textBox42");
            Excel.Range EmisorLeg = worksheet.Range["C57"];   EmisorLeg.Value = form1.GetTextBoxValue("textBox5");

            // Guardar los cambios (opcional)
            workbook.Save();

            // Imprimir el documento
            workbook.PrintOut();

            // Cerrar y liberar recursos
            workbook.Close();
            excelApp.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);

        }
    }
}
