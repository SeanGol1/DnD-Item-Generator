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

            int total = 0;
            if (totalRolled.Text == "")
                total = 1;
            else
                total = Convert.ToInt32(totalRolled.Text);
            

            string attune = "";
            if (xlRange.Cells[total + 1, 6].Value2 != null)
            {
                attune = xlRange.Cells[total + 1, 6].Value2.ToString();

                if (attune == "y")
                    attune = "Yes";
                else if (attune == "N")
                    attune = "No";

                tbxAttune.Text = attune;

            }                       
            else
                tbxAttune.Text = "No"; 

            string itemName = xlRange.Cells[total + 1, 4].Value2.ToString();
            string desc = xlRange.Cells[total + 1, 5].Value2.ToString();

            tbxName.Text = itemName;            

            tbxDesc.Text = desc;


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

            listView1.View = View.Details;
            /*
            listView1.Columns.Add("Number");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("Attunement");
            */

            string tempNo= "";
            string tempName = "";
            string tempDesc = "";
            string tempAttune = "";

            for (int i = 2; i <= rowCount; i++)
            {
                //for (int j = 1; j <= colCount; j++)
                //{

                    if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                    {
                        tempNo = xlRange.Cells[i, 1].Value2.ToString();
                        tempName = xlRange.Cells[i, 4].Value2.ToString();
                        tempDesc = xlRange.Cells[i, 5].Value2.ToString();
                        tempAttune = xlRange.Cells[i, 6].Value2.ToString();

                        listView1.Items.Add(new ListViewItem(new string[] {tempNo, tempName, tempDesc, tempAttune }));
                    }
                    
                //}
                
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
