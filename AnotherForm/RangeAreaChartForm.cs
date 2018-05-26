using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace AnotherForm
{
    public partial class RangeAreaChartForm : Form
    {
        private string pesel;
        private string minDate;
        private string maxDate;
        private DBLogic db;
        private DataSet ds;
        private Series pressure;
        private Series morningPressure;
        private Series eveningPressure;
        private Series pulse;
        private Series morningPulse;
        private Series eveningPulse;
        private string dayTime;

        public RangeAreaChartForm(string pesel, string minDate, string maxDate, DBLogic db)
        {
            InitializeComponent();
            this.pesel = pesel;
            this.minDate = minDate.Substring(0,10);
            this.maxDate = maxDate.Substring(0,10);
            this.db = db;
            ds = new DataSet();
            dayTime = "b";
            pressure = new Series("pressure", ViewType.RangeArea);
            pulse = new Series("pulse", ViewType.Line);
            morningPressure = new Series("morningPressure", ViewType.RangeArea);
            eveningPressure = new Series("eveningPressure", ViewType.RangeArea);
            morningPulse = new Series("morningPulse", ViewType.Line);
            eveningPulse = new Series("eveningPulse", ViewType.Line);
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

        private void RangeAreaChartForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "Dane pacjenta " + pesel;

            hourListBox.Items.Add("wszystkie pomiary");
            hourListBox.Items.Add("poranne pomiary");
            hourListBox.Items.Add("wieczorne pomiary");
            hourListBox.Items.Add("porównaj poranne i wieczorne pomiary");

            ds = db.getPatiensMeasures(pesel);

            pressure.ArgumentScaleType = ScaleType.DateTime;
            pulse.ArgumentScaleType = ScaleType.DateTime;
            pressure.ValueScaleType = ScaleType.Numerical;
            pulse.ValueScaleType = ScaleType.Numerical;

            (chartControl1.Diagram as XYDiagram).AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.None;
            (chartControl1.Diagram as XYDiagram).AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second;
        }

        private void RangeAreaChartForm_Shown(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Parse(minDate);
            fromDateTimePicker.MinDate = DateTime.Parse(minDate);
            fromDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            toDateTimePicker.Value = DateTime.Parse(maxDate);
            toDateTimePicker.MinDate = DateTime.Parse(minDate);
            toDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            hourListBox.SetSelected(0, true);fillSeriesWithData();
        }

        private void hourListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = hourListBox.SelectedIndex;

            if (mode == 0) dayTime = "b";
            else if (mode == 1) dayTime = "m";
            else if (mode == 2) dayTime = "e";
            else if (mode == 3) dayTime = "c";

            fillSeriesWithData();
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

        private void fillSeriesWithData()
        {
            pulse.Points.Clear();
            morningPressure.Points.Clear();
            eveningPressure.Points.Clear();
            pressure.Points.Clear();
            chartControl1.Series.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                DateTime dbTime = DateTime.Parse(row["measure_time"].ToString());
                DateTime noon = DateTime.Parse("12:00");
                DateTime dbDate = DateTime.Parse(row["measure_date"].ToString());
                string fullDate = row["measure_date"].ToString().Substring(0,11) + row["measure_time"].ToString();

                int p = 0, s = 0, d = 0;

                if (DateTime.Compare(dbDate, fromDateTimePicker.Value) >= 0 && DateTime.Compare(dbDate, toDateTimePicker.Value) <= 0)
                {
                    if((dayTime == "m" && dbTime <= noon) || (dayTime == "e" && dbTime > noon) || dayTime == "b")
                    {
                        p = int.Parse(row["pulse"].ToString());
                        pulse.Points.Add(new SeriesPoint(fullDate, p));

                        s = int.Parse(row["systolic"].ToString());
                        d = int.Parse(row["diastolic"].ToString());
                        pressure.Points.Add(new SeriesPoint(fullDate, s, d));
                    }
                    else if(dayTime == "c")
                    {
                        s = int.Parse(row["systolic"].ToString());
                        d = int.Parse(row["diastolic"].ToString());
                        p = int.Parse(row["pulse"].ToString());

                        if (dbTime <= noon)
                        {
                            morningPressure.Points.Add(new SeriesPoint(fullDate, s, d));
                            morningPulse.Points.Add(new SeriesPoint(fullDate, p));
                        }
                        else
                        {
                            eveningPressure.Points.Add(new SeriesPoint(fullDate, s, d));
                            eveningPulse.Points.Add(new SeriesPoint(fullDate, p));
                        }
                    }
                }
            }

            if (dayTime == "c")
            {
                chartControl1.Series.Add(morningPressure);
                chartControl1.Series.Add(eveningPressure);
                chartControl1.Series.Add(morningPulse);
                chartControl1.Series.Add(eveningPulse);
                XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
                LineSeriesView myView = (LineSeriesView)morningPulse.View;
                myView.Pane = diagram.Panes[0];
                myView = (LineSeriesView)eveningPulse.View;
                myView.Pane = diagram.Panes[0];
            }
            else
            {
                chartControl1.Series.Add(pressure);
                chartControl1.Series.Add(pulse);
                XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
                LineSeriesView myView = (LineSeriesView)pulse.View;
                myView.Pane = diagram.Panes[0];
            }
        }
    }
}
