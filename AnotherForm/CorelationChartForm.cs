using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherForm
{
    public partial class CorelationChartForm : Form
    {
        private string pesel;
        private string minDate;
        private string maxDate;
        private DBLogic db;
        private Series morningSeries;
        private Series eveningSeries;
        private DataSet ds;

        public CorelationChartForm(string pesel, string minDate, string maxDate, DBLogic db)
        {
            InitializeComponent();
            this.pesel = pesel;
            this.minDate = minDate.Substring(0,10);
            this.maxDate = maxDate.Substring(0,10);
            this.db = db;
            morningSeries = new Series(pesel + "M", ViewType.Point);
            eveningSeries = new Series(pesel + "E", ViewType.Point);
            ds = new DataSet();
        }

        private void CorelationChartForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "Dane pacjenta " + pesel;

            hourListBox.Items.Add("wszystkie pomiary");
            hourListBox.Items.Add("poranne pomiary");
            hourListBox.Items.Add("wieczorne pomiary");

            morningSeries.ArgumentScaleType = ScaleType.Numerical;
            eveningSeries.ArgumentScaleType = ScaleType.Numerical;
            morningSeries.View.Color = System.Drawing.Color.Green;
            eveningSeries.View.Color = System.Drawing.Color.Blue;

            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            diagram.AxisX.VisualRange.SetMinMaxValues(20, 180);
            diagram.AxisX.WholeRange.SetMinMaxValues(20, 180);
            diagram.AxisY.VisualRange.SetMinMaxValues(20, 180);
            diagram.AxisY.WholeRange.SetMinMaxValues(20, 180);

            ds = db.getPatiensMeasures(pesel);
        }

        private void fillSeriesWithData()
        {
            morningSeries.Points.Clear();
            eveningSeries.Points.Clear();
            chartControl1.Series.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                DateTime measure = DateTime.Parse(row["measure_time"].ToString());
                DateTime noon = DateTime.Parse("12:00");
                DateTime dbDate = DateTime.Parse(row["measure_date"].ToString());

                if(DateTime.Compare(dbDate, fromDateTimePicker.Value) >=0 && DateTime.Compare(dbDate, toDateTimePicker.Value) <= 0)
                {
                    int x = int.Parse(row["systolic"].ToString());
                    int y = int.Parse(row["diastolic"].ToString());

                    if (measure <= noon)
                    {
                        morningSeries.Points.Add(new SeriesPoint(x, y));
                    }
                    else
                    {
                        eveningSeries.Points.Add(new SeriesPoint(x, y));
                    }
                }
            }

            chartControl1.Series.Add(morningSeries);
            chartControl1.Series.Add(eveningSeries);
        }

        private void hourListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = hourListBox.SelectedIndex;

            if (mode == 0)
            {
                chartControl1.Series[pesel + "M"].Visible = true;
                chartControl1.Series[pesel + "E"].Visible = true;
            }
            else if (mode == 1)
            {
                chartControl1.Series[pesel + "M"].Visible = true;
                chartControl1.Series[pesel + "E"].Visible = false;
            }
            else if (mode == 2)
            {
                chartControl1.Series[pesel + "M"].Visible = false;
                chartControl1.Series[pesel + "E"].Visible = true;
            }
        }

        private void CorelationChartForm_Shown(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Parse(minDate);
            fromDateTimePicker.MinDate = DateTime.Parse(minDate);
            fromDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            toDateTimePicker.Value = DateTime.Parse(maxDate);
            toDateTimePicker.MinDate = DateTime.Parse(minDate);
            toDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            fillSeriesWithData();
            hourListBox.SetSelected(0, true);
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //fillSeriesWithData();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //fillSeriesWithData();
        }

        private void fromDateTimePicker_Validated(object sender, EventArgs e)
        {
            fillSeriesWithData();
            minDate = fromDateTimePicker.Value.ToString().Substring(0, 10);
        }

        private void toDateTimePicker_Validated(object sender, EventArgs e)
        {
            fillSeriesWithData();
            maxDate = toDateTimePicker.Value.ToString().Substring(0, 10);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(chartControl1.Width, chartControl1.Height);
            chartControl1.DrawToBitmap(bitmap, new Rectangle(0, 0, chartControl1.Width, chartControl1.Height));

            e.Graphics.DrawImage(bitmap, 100, 200);
            e.Graphics.DrawString("Pomiary ciśnienia tętniczego", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(100, 50));
            e.Graphics.DrawString("PESEL: "+pesel, new Font("Verdana", 15, FontStyle.Regular), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawString("Przedział czasowy: "+minDate + " - " + maxDate, new Font("Verdana", 15, FontStyle.Regular), Brushes.Black, new Point(100, 150));
        }
    }
}
