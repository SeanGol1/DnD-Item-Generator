using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;



namespace vendorGen_WinForm
{



    public partial class Form1 : Form
    {



        int gp = 0;
        public Form1()
        {
            InitializeComponent();
            GP();
        }

        public void GP()
        {
            Random rnd = new Random();
            gp = rnd.Next(1000, 100000);

            currentgp.Text = gp.ToString();

        }


        private void btnGen_Click(object sender, EventArgs e)
        {

            _Excel.Application xlApp = new _Excel.Application();
            _Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\seang\Desktop\vendorGen WinForm\Magical_items_Minor.xlsx");
            _Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            _Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            int ic = 0;

            int total = 0;
            if (totalRolled.Text == "")
                total = 1;
            else
                total = Convert.ToInt32(totalRolled.Text);

            string[] colItems = new string[colCount];
            //string[]  = new string[colCount];
            List<string[]> rowItems = new List<string[]>();

            if (xlRange.Cells[total + 1, 6].Value2 == null)            
                tbxAttune.Text = "No";            
            else
                tbxAttune.Text = "Yes";

            //string attune = xlRange.Cells[total + 1, 6].Value2.ToString();
            string itemName = xlRange.Cells[total + 1, 4].Value2.ToString();
            string desc = xlRange.Cells[total + 1, 5].Value2.ToString();

            tbxName.Text = itemName;            

            tbxDesc.Text = desc;





            /*
            for (int i=1; i <= rowCount; i++)
            {                
                for (int j=1; j <=colCount; j++)
                {

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        //colItems[ic] = (xlRange.Cells[i, j].Value2.ToString());
                        if (i == 1)
                        {
                            label2.Text = xlRange.Cells[i, 2].Value2.ToString();
                            label4.Text = xlRange.Cells[i, 3].Value2.ToString();
                            label5.Text = xlRange.Cells[i, 4].Value2.ToString();
                            
                        }                        
                        
                        if (i == total)
                        {
                            tbxName.Text = xlRange.Cells[i, 2].Value2.ToString();
                            tbxAttune.Text = xlRange.Cells[i, 3].Value2.ToString();
                            tbxDesc.Text = xlRange.Cells[i, 4].Value2.ToString();
                        }

                        ic++;
                    }  
                }
                //rowItems.Add(colItems);
                ic = 0;
            }
            */


            //Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //Close Excel File
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);


        }

        private void BtnFullList_Click(object sender, EventArgs e)
        {
            _Excel.Application xlApp = new _Excel.Application();
            _Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\seang\Desktop\vendorGen WinForm\Magical_items_Minor.xlsx");
            _Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            _Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            int ic = 0;

            int total = Convert.ToInt32(totalRolled.Text) + 1;

            string[] colItems = new string[colCount];
            //string[]  = new string[colCount];
            List<string[]> rowItems = new List<string[]>();

            string itemline = "";
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        // Fill box will full line      
                        /*
                        if (i == 1)
                        {
                            label2.Text = xlRange.Cells[i, 2].Value2.ToString();
                            label4.Text = xlRange.Cells[i, 3].Value2.ToString();
                            label5.Text = xlRange.Cells[i, 4].Value2.ToString();

                        }

                        if (i == total)
                        {
                            textBox1.Text = xlRange.Cells[i, 2].Value2.ToString();
                            textBox2.Text = xlRange.Cells[i, 3].Value2.ToString();
                            textBox3.Text = xlRange.Cells[i, 4].Value2.ToString();
                        }*/

                        ic++;
                    }
                }
                //rowItems.Add(colItems);
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
        }
    }
}
