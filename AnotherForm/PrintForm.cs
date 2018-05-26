using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace AnotherForm
{
    public partial class PrintForm : Form
    {
        private DBLogic db;
        private string pesel;
        private string minDate;
        private string maxDate;
        private int pageSize = 1;
        private Bitmap bmp;
        
        public PrintForm(DBLogic db, string pesel)
        {
            InitializeComponent();
            this.db = db;
            this.pesel = pesel;
        }

        private void Print_Load(object sender, EventArgs e)
        {
            fillGrid();
            dataGridView.Columns["id"].Visible = false;
            dataGridView.Columns["PESEL"].Visible = false;

            minDate = dataGridView.Rows[0].Cells["measure_date"].Value.ToString();
            maxDate = dataGridView.Rows[dataGridView.RowCount - 1].Cells["measure_date"].Value.ToString();
            minDate = minDate.Substring(0, 10);
            maxDate = maxDate.Substring(0, 10);

            startDateTimePicker.Value = DateTime.Parse(minDate);
            startDateTimePicker.MinDate = DateTime.Parse(minDate);
            startDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            endDateTimePicker.Value = DateTime.Parse(maxDate);
            endDateTimePicker.MinDate = DateTime.Parse(minDate);
            endDateTimePicker.MaxDate = DateTime.Parse(maxDate);
        }

        private void fillGrid()
        {
            DataSet ds = new DataSet();
            ds = db.getPatiensMeasures(pesel);
            dataGridView.DataSource = ds.Tables[0];
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            int height = dataGridView.Height;
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height;
            dataGridView.ScrollBars = ScrollBars.None;
            bmp = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            dataGridView.Height = height;
            dataGridView.ScrollBars = ScrollBars.Both;
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pomiary ciśnienia tętniczego", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(100, 50));
            e.Graphics.DrawString("PESEL: " + pesel, new Font("Verdana", 15, FontStyle.Regular), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawString("Przedział czasowy: " + minDate + " - " + maxDate, new Font("Verdana", 15, FontStyle.Regular), Brushes.Black, new Point(100, 150));

            e.Graphics.DrawImage(bmp, 100, 200);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            minDate = startDateTimePicker.Value.ToString();
            minDate = minDate.Substring(0, 10);
            maxDate = endDateTimePicker.Value.ToString();
            maxDate = maxDate.Substring(0, 10);

            DataSet ds = new DataSet();
            ds = db.getPatiensMeasures(pesel);
            DataView dv;
            string pom = String.Format("measure_date >= '{0}' and measure_date <= '{1}'", minDate, maxDate);
            dv = new DataView(ds.Tables[0], pom, "measure_date Asc", DataViewRowState.CurrentRows);
            dataGridView.DataSource = dv;
        }
    }
}
