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
using DevExpress.XtraBars;

namespace AnotherForm
{
    public partial class BarChartForm : Form
    {
        private string pesel;
        private string minDate;
        private string maxDate;
        private DBLogic db;
        private DataSet ds;
        private Series systolic;
        private Series diastolic;
        private Series pulse;
        private string dayTime;

        public BarChartForm(string pesel, string minDate, string maxDate, DBLogic db)
        {
            InitializeComponent();
            this.pesel = pesel;
            this.minDate = minDate.Substring(0,10);
            this.maxDate = maxDate.Substring(0,10);
            this.db = db;
            ds = new DataSet();
            systolic = new Series("systolic", ViewType.Bar);
            diastolic = new Series("diastolic", ViewType.Bar);
            pulse = new Series("pulse", ViewType.Bar);
            dayTime = "b";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pressureChartControl.Width, pressureChartControl.Height);
            pressureChartControl.DrawToBitmap(bitmap, new Rectangle(0, 0, pressureChartControl.Width, pressureChartControl.Height));
            e.Graphics.DrawImage(bitmap, 100, 200);

            bitmap = new Bitmap(pulseChartControl.Width, pulseChartControl.Height);
            pulseChartControl.DrawToBitmap(bitmap, new Rectangle(0, 0, pulseChartControl.Width, pulseChartControl.Height));
            e.Graphics.DrawImage(bitmap, 65 + pressureChartControl.Width, 200);

            e.Graphics.DrawString("Pomiary ciśnienia tętniczego", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(100, 50));
            e.Graphics.DrawString("PESEL: "+pesel, new Font("Verdana", 15, FontStyle.Regular), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawString("Przedział czasowy: "+minDate + " - " + maxDate, new Font("Verdana", 15, FontStyle.Regular), Brushes.Black, new Point(100, 150));
        }

        private void BarChartForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "Dane pacjenta " + pesel;

            hourListBox.Items.Add("wszystkie pomiary");
            hourListBox.Items.Add("poranne pomiary");
            hourListBox.Items.Add("wieczorne pomiary");

            ds = db.getPatiensMeasures(pesel);

            pulse.View.Color = System.Drawing.Color.Green;

            XYDiagram diagram = (XYDiagram)pressureChartControl.Diagram;
            diagram.AxisX.VisualRange.SetMinMaxValues(10, 200);
            diagram.AxisX.WholeRange.SetMinMaxValues(10, 200);
            diagram.AxisY.VisualRange.SetMinMaxValues(10, 100);
            diagram.AxisY.WholeRange.SetMinMaxValues(10, 100);
            BarSeriesView myView = (BarSeriesView)systolic.View;
            myView.BarWidth = 8;
            myView = (BarSeriesView)diastolic.View;
            myView.BarWidth = 8;

            diagram = (XYDiagram)pulseChartControl.Diagram;
            diagram.AxisX.VisualRange.SetMinMaxValues(10, 200);
            diagram.AxisX.WholeRange.SetMinMaxValues(10, 200);
            diagram.AxisY.VisualRange.SetMinMaxValues(10, 100);
            diagram.AxisY.WholeRange.SetMinMaxValues(10, 100);
            myView = (BarSeriesView)pulse.View;
            myView.BarWidth = 8;
        }

        private void hourListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = hourListBox.SelectedIndex;

            if (mode == 0) dayTime = "b";
            else if (mode == 1) dayTime = "m";
            else if (mode == 2) dayTime = "e";

            fillSeriesWithData();
        }

        private void BarChartForm_Shown(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Parse(minDate);
            fromDateTimePicker.MinDate = DateTime.Parse(minDate);
            fromDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            toDateTimePicker.Value = DateTime.Parse(maxDate);
            toDateTimePicker.MinDate = DateTime.Parse(minDate);
            toDateTimePicker.MaxDate = DateTime.Parse(maxDate);
            hourListBox.SetSelected(0, true);
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
            systolic.Points.Clear();
            diastolic.Points.Clear();
            pressureChartControl.Series.Clear();
            pulseChartControl.Series.Clear();

            int count = 0;
            Dictionary<int, double> pulseDict = new Dictionary<int, double>();
            Dictionary<int, double> systolicDict = new Dictionary<int, double>();
            Dictionary<int, double> diastolicDict = new Dictionary<int, double>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                DateTime dbTime = DateTime.Parse(row["measure_time"].ToString());
                DateTime noon = DateTime.Parse("12:00");
                DateTime dbDate = DateTime.Parse(row["measure_date"].ToString());

                if (DateTime.Compare(dbDate, fromDateTimePicker.Value) >= 0 && DateTime.Compare(dbDate, toDateTimePicker.Value) <= 0)
                {
                    if ((dayTime == "m" && dbTime <= noon) || (dayTime == "e" && dbTime > noon) || dayTime == "b")
                    {
                        count++;
                        int s = int.Parse(row["systolic"].ToString());
                        int d = int.Parse(row["diastolic"].ToString());
                        int p = int.Parse(row["pulse"].ToString());
                        int keyS = s / 10 * 10 + 5;
                        int keyD = d / 10 * 10 + 5;
                        int keyP = p / 10 * 10 + 5;

                        if (pulseDict.ContainsKey(keyP)) pulseDict[keyP]+=1.0;
                        else pulseDict.Add(keyP, 1.0);

                        if (systolicDict.ContainsKey(keyS)) systolicDict[keyS]+=1.0;
                        else systolicDict.Add(keyS, 1.0);

                        if (diastolicDict.ContainsKey(keyD)) diastolicDict[keyD]+=1.0;
                        else diastolicDict.Add(keyD, 1.0);
                    }
                }
            }

            foreach (KeyValuePair<int, double> pair in systolicDict.ToArray())
            {
                systolic.Points.Add(new SeriesPoint(pair.Key, systolicDict[pair.Key] * 100 / count));
            }
            foreach (KeyValuePair<int, double> pair in diastolicDict.ToArray())
            {
                diastolic.Points.Add(new SeriesPoint(pair.Key, diastolicDict[pair.Key] * 100 / count));
            }
            foreach (KeyValuePair<int, double> pair in pulseDict.ToArray())
            {
                pulse.Points.Add(new SeriesPoint(pair.Key, pulseDict[pair.Key] * 100 / count));
            }

            pressureChartControl.Series.Add(systolic);
            pressureChartControl.Series.Add(diastolic);
            pulseChartControl.Series.Add(pulse);

            XYDiagram diagram = (XYDiagram)pressureChartControl.Diagram;
            BarSeriesView myView = (BarSeriesView)diastolic.View;
            myView.Pane = diagram.Panes[0];
        }
    }
}
