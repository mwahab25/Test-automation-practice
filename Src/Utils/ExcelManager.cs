using Excel = Microsoft.Office.Interop.Excel;

namespace Test_automation.Src.Utils
{
    public class ExcelManager
    {
        private static Excel.Application ExcelApp;
        private static Excel.Workbook ExcelWBook;
        private static Excel.Worksheet ExcelWSheet;

        public static void SetExcel(string path)
        {
            ExcelApp = new Excel.Application
            {
                Visible = false
            };
            ExcelWBook = ExcelApp.Workbooks.Open(path);
        }

        public static void SaveCloseExcel()
        {
            ExcelWBook.Save();
            ExcelWBook.Close(0);
            ExcelApp.Quit();
        }

        public static string GetCellData(int rowNo, int colNo, string sheetName)
        {
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            string cellData = (ExcelWSheet.Cells[rowNo + 1, colNo + 1] as Excel.Range).Text as string;
            return cellData;
        }

        public static void SetCellData(string data, int rowNo, int colNo, string sheetName)
        {
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            (ExcelWSheet.Cells[rowNo + 1, colNo + 1] as Excel.Range).Value = data;
        }
    }
}
