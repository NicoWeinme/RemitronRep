using Excel = Microsoft.Office.Interop.Excel;
using System;
using Remitron;
using System.Runtime.InteropServices;


public class ExcelEditor
{
    
    public void AbrirArchivoExcel(Form1 form1)
    {   

       
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour;
        int minute = currentTime.Minute;
        int second = currentTime.Second;
        string hora = (hour + "+" + minute + "+" + second);
        string newname = (DateTime.Today.ToString("yyyy-mm-dd") + " " + hora + " " + Environment.UserName + ".xlsx");
        string destino = (@"\\cpl-sanopera01\software\Remitron\Remitos Realizados\Preimpresos\" + newname);

        // Crear una instancia de la aplicación de Excel
        Excel.Application excelApp = new Excel.Application();

        // Hacer que Excel sea visible (opcional)
        excelApp.Visible = true;

        string rutaArchivo = @"\\cpl-sanopera01\software\Remitron\src\Archivos Base\PREIMPRESO.xlsx";

        // Abrir el archivo de Excel
        Excel.Workbook workbook = excelApp.Workbooks.Open(rutaArchivo);

        //Configurar parámetros de guardado
        workbook.SaveAs(destino);

        // Obtener la primera hoja del libro (Índice 1)
        Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];


        // Editar las celdas
        //Fecha
        Excel.Range Dia = worksheet.Range["J4"]; Dia.Value = form1.GetTextBoxValue("textBox1");
        Excel.Range Ano = worksheet.Range["L4"]; Ano.Value = form1.GetTextBoxValue("textBox3");
        Excel.Range Mes = worksheet.Range["K4"]; Mes.Value = form1.GetTextBoxValue("textBox2");

        //Datos destino
        Excel.Range NombreD = worksheet.Range["C12"]; NombreD.Value = form1.GetComboBoxValue("comboBox2");
        Excel.Range CuitD = worksheet.Range["H12"]; CuitD.Value = form1.GetTextBoxValue("textBox7");
        Excel.Range DireccionD = worksheet.Range["C13"]; DireccionD.Value = form1.GetComboBoxValue("comboBox3");
        Excel.Range ResponsableD = worksheet.Range["H13"]; ResponsableD.Value = form1.GetTextBoxValue("textBox40");
            
        //Datos Transporte
        Excel.Range ResSoc = worksheet.Range["C50"]; ResSoc.Value = form1.GetTextBoxValue("textBox41");
        Excel.Range CuitT = worksheet.Range["G50"]; CuitT.Value = form1.GetTextBoxValue("textBox10");
        Excel.Range DniT = worksheet.Range["C51"]; DniT.Value = form1.GetTextBoxValue("textBox9");
        Excel.Range NombreT = worksheet.Range["G51"]; NombreT.Value = form1.GetTextBoxValue("textBox6");

        //Datos items - Cantidad
        Excel.Range Cant = worksheet.Range["B16"]; Cant.Value = form1.GetTextBoxValue("textBox39");
        Excel.Range Cant1 = worksheet.Range["B17"]; Cant1.Value = form1.GetTextBoxValue("textBox38");
        Excel.Range Cant2 = worksheet.Range["B18"]; Cant2.Value = form1.GetTextBoxValue("textBox37");
        Excel.Range Cant3 = worksheet.Range["B19"]; Cant3.Value = form1.GetTextBoxValue("textBox36");
        Excel.Range Cant4 = worksheet.Range["B20"]; Cant4.Value = form1.GetTextBoxValue("textBox35");
        Excel.Range Cant5 = worksheet.Range["B21"]; Cant5.Value = form1.GetTextBoxValue("textBox34");
        Excel.Range Cant6 = worksheet.Range["B22"]; Cant6.Value = form1.GetTextBoxValue("textBox33");
        Excel.Range Cant7 = worksheet.Range["B23"]; Cant7.Value = form1.GetTextBoxValue("textBox32");
        Excel.Range Cant8 = worksheet.Range["B24"]; Cant8.Value = form1.GetTextBoxValue("textBox31");
        Excel.Range Cant9 = worksheet.Range["B25"]; Cant9.Value = form1.GetTextBoxValue("textBox30");     
        
        //Datos items - UN
        Excel.Range Un = worksheet.Range["C16"]; Un.Value = form1.GetTextBoxValue("textBox29");
        Excel.Range Un1 = worksheet.Range["C17"]; Un1.Value = form1.GetTextBoxValue("textBox28");
        Excel.Range Un2 = worksheet.Range["C18"]; Un2.Value = form1.GetTextBoxValue("textBox27");
        Excel.Range Un3 = worksheet.Range["C19"]; Un3.Value = form1.GetTextBoxValue("textBox26");
        Excel.Range Un4 = worksheet.Range["C20"]; Un4.Value = form1.GetTextBoxValue("textBox25");
        Excel.Range Un5 = worksheet.Range["C21"]; Un5.Value = form1.GetTextBoxValue("textBox24");
        Excel.Range Un6 = worksheet.Range["C22"]; Un6.Value = form1.GetTextBoxValue("textBox23");
        Excel.Range Un7 = worksheet.Range["C23"]; Un7.Value = form1.GetTextBoxValue("textBox22"); 
        Excel.Range Un8 = worksheet.Range["C24"]; Un8.Value = form1.GetTextBoxValue("textBox17");
        Excel.Range Un9 = worksheet.Range["C25"]; Un9.Value = form1.GetTextBoxValue("textBox16");

            
        //Datos items - Descripcion
        Excel.Range Desc = worksheet.Range["D16"]; Desc.Value = form1.GetTextBoxValue("textBox15");
        Excel.Range Desc1 = worksheet.Range["D17"]; Desc1.Value = form1.GetTextBoxValue("textBox14");
        Excel.Range Desc2 = worksheet.Range["D18"]; Desc2.Value = form1.GetTextBoxValue("textBox13");
        Excel.Range Desc3 = worksheet.Range["D19"]; Desc3.Value = form1.GetTextBoxValue("textBox12");
        Excel.Range Desc4 = worksheet.Range["D20"]; Desc4.Value = form1.GetTextBoxValue("textBox11");
        Excel.Range Desc5 = worksheet.Range["D21"]; Desc5.Value = form1.GetTextBoxValue("textBox8");
        Excel.Range Desc6 = worksheet.Range["D22"]; Desc6.Value = form1.GetTextBoxValue("textBox21");
        Excel.Range Desc7 = worksheet.Range["D23"]; Desc7.Value = form1.GetTextBoxValue("textBox20");
        Excel.Range Desc8 = worksheet.Range["D24"]; Desc8.Value = form1.GetTextBoxValue("textBox19");
        Excel.Range Desc9 = worksheet.Range["D25"]; Desc9.Value = form1.GetTextBoxValue("textBox18");

        //Datos Emisor
        Excel.Range EmisorNombre = worksheet.Range["C56"]; EmisorNombre.Value = form1.GetTextBoxValue("textBox42");
        Excel.Range EmisorLeg = worksheet.Range["C55"]; EmisorLeg.Value = form1.GetTextBoxValue("textBox5");

        // Guardar los cambios (opcional)
        workbook.Save();

        // Imprimir el documento
        workbook.PrintOut();
        workbook.PrintOut();
        workbook.PrintOut();

        // Cerrar y liberar recursos
        workbook.Close();
        excelApp.Quit();
        Marshal.ReleaseComObject(worksheet);
        Marshal.ReleaseComObject(workbook);
        Marshal.ReleaseComObject(excelApp);
        
    }
}
