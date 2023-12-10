using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_akos.Models;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace zh3_akos
{

    public partial class ExcelUc : UserControl
    {
        Zh3Context zh3Context = new Zh3Context();

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB;     // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public ExcelUc()
        {
            InitializeComponent();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                TáblaKészítés(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void TáblaKészítés()
        {
            string[] fejlécek = new string[]
            {
                "RendelésId",
                "SzállítóId",
                "TermékId",
                "Mennyiség",
                "RendelésDátuma",
                "SzállításDátuma",

            };
            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlécek[i];
            }

            var adatok = zh3Context.Rendeléseks.ToList();

            object[,] adatTömb = new object[adatok.Count(), fejlécek.Count()];
            for (int i = 0; i < adatok.Count(); i++)
            {
                adatTömb[i, 0] = adatok[i].RendelésId;
                adatTömb[i, 1] = adatok[i].SzállítóId;
                adatTömb[i, 2] = adatok[i].TermékId;
                adatTömb[i, 3] = adatok[i].Mennyiség;
                adatTömb[i, 4] = adatok[i].RendelésDátuma;
                adatTömb[i, 5] = adatok[i].SzállításDátuma;


            }
            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);



            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;

            adatRange.Columns.AutoFit();

            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
            fejllécRange.Font.Bold = true;


            fejllécRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejllécRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejllécRange.EntireColumn.AutoFit();
            fejllécRange.RowHeight = 40;
            fejllécRange.Interior.Color = Color.Fuchsia;
            fejllécRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

        }

        private void diagramButton_Click(object sender, EventArgs e)
        {
            // Start Excel and get Application object.
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Create a new, empty workbook and add a worksheet.
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Add data to cells of the first worksheet in the new workbook.
            worksheet.Cells[1, "A"] = "Data Set";
            worksheet.Cells[1, "B"] = "Value";
            worksheet.Cells[2, "A"] = "Point 1";
            worksheet.Cells[2, "B"] = 10;
            worksheet.Cells[3, "A"] = "Point 2";
            worksheet.Cells[3, "B"] = 20;
            worksheet.Cells[4, "A"] = "Point 3";
            worksheet.Cells[4, "B"] = 30;
            worksheet.Cells[5, "A"] = "Point 4";
            worksheet.Cells[5, "B"] = 40;

            // Create a range for the data.
            Excel.Range chartRange = worksheet.get_Range("A1", "B5");

            // Add a chart to the worksheet.
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            // Set chart range.
            chartPage.SetSourceData(chartRange);

            // Set chart properties.
            chartPage.ChartType = Excel.XlChartType.xlLine;
            chartPage.ChartWizard(Source: chartRange,
                Title: "Example Chart",
                CategoryTitle: "Data Set",
                ValueTitle: "Value");

            // Save the workbook and quit Excel.
            //workbook.SaveAs(@"C:\YourPath\ExcelChartExample.xlsx");
            //excelApp.Quit();
        }
    }
}
