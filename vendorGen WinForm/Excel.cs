using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;


namespace vendorGen_WinForm
{
    
    public class Excel
    {
        

   

        public Excel()
        {
                        
        }

        /*
        public List<string[]> ReadLine()
        {
            _Excel.Application xlApp = new _Excel.Application();
            _Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\seang\Desktop\vendorGen WinForm\Items.xlsx");
            _Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            _Excel.Range xlRange = xlWorksheet.UsedRange;

             READ LINE AND ADD TO LIST (GOT MESSY) 
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            string item = "";
            int ic = 0;
            int rc = 0; 
            
            string[] colItems = new string[colCount];
            //string[]  = new string[colCount];
            List<string[]> rowItems = new List<string[]>();
            

            for (int i=1; i <= rowCount; i++)
            {
                
                for (int j=1; j <=colCount; j++)
                {                    

                    if (j == 1)
                    {

                    }

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        colItems[ic] = (xlRange.Cells[i, j].Value2.ToString());
                        ic++;
                    }  
                }
                rowItems.Add(colItems);
                ic = 0;
            }
            





            //Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //Close Excel File
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            //return rowItems;


        }
        */
        

    }
}
