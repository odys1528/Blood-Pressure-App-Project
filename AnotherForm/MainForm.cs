using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AnotherForm
{
    public partial class MainForm : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["AnotherForm.Properties.Settings.Ustawienie"].ConnectionString;
        DBLogic db;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DBLogic();
            db.setConectionString(connectionString);

            fillPatientsGrid();
        }

        private void fillPatientsGrid()
        {
            DataSet ds = new DataSet();
            ds = db.getPatientsDB();
            patientsGridView.DataSource = ds.Tables[0];
        }

        private void fillMeasuresGrid(string pesel)
        {
            DataSet ds = new DataSet();
            ds = db.getPatiensMeasures(pesel);
            measuresGridView.DataSource = ds.Tables[0];
        }

        private void patientsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string pesel = patientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string column = patientsGridView.Columns[e.ColumnIndex].Name.ToString();
            string value = patientsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            db.updatePatient(pesel, column, value);
        }

        private void measuresGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id = measuresGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string column = measuresGridView.Columns[e.ColumnIndex].Name.ToString();
            string value = measuresGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            db.updateMeasure(id, column, value);
        }

        private void patientsGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = db.getPatiensMeasures(patientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            measuresGridView.DataSource = ds.Tables[0];
        }

        private void measuresGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            measuresGridView.Columns["id"].Visible = false;
            measuresGridView.Columns[1].ReadOnly = true;
            measuresGridView.Columns[1].Visible = false;
        }

        private void patientsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            patientsGridView.Columns[0].ReadOnly = true;
        }

        private void deleteMeasureButton_Click(object sender, EventArgs e)
        {
            int rowId = measuresGridView.CurrentCell.RowIndex;
            string id = measuresGridView.Rows[rowId].Cells[0].Value.ToString();
            string pesel = measuresGridView.Rows[rowId].Cells[1].Value.ToString();
            db.deleteMeasure(id);
            fillMeasuresGrid(pesel);
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            int rowId = patientsGridView.CurrentCell.RowIndex;
            string pesel = patientsGridView.Rows[rowId].Cells[0].Value.ToString();
            db.deletePatient(pesel);
            fillPatientsGrid();
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatient = new NewPatientForm(db);
            newPatient.ShowDialog();
            fillPatientsGrid();
        }

        private void newMeasureButton_Click(object sender, EventArgs e)
        {
            int rowId = patientsGridView.CurrentCell.RowIndex;
            string pesel = patientsGridView.Rows[rowId].Cells[0].Value.ToString();
            if(pesel != null)
            {
                NewMeasureForm newMeasure = new NewMeasureForm(db, pesel);
                newMeasure.ShowDialog();
                fillMeasuresGrid(pesel);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            int rowId = patientsGridView.CurrentCell.RowIndex;
            string pesel = patientsGridView.Rows[rowId].Cells[0].Value.ToString();
            if(pesel != null && measuresGridView.RowCount>0)
            {
                PrintForm print = new PrintForm(db, pesel);
                print.ShowDialog();
            }
        }

        private void plot1Button_Click(object sender, EventArgs e)
        {
            int rowId = patientsGridView.CurrentCell.RowIndex;
            string pesel = patientsGridView.Rows[rowId].Cells[0].Value.ToString();
            if (pesel != null)
            {
                string minDate = measuresGridView.Rows[0].Cells["measure_date"].Value.ToString();
                string maxDate = measuresGridView.Rows[measuresGridView.RowCount - 1].Cells["measure_date"].Value.ToString();
                RangeAreaChartForm form = new RangeAreaChartForm(pesel, minDate, maxDate, db);
                form.ShowDialog();
            }
        }

        private void plot2Button_Click(object sender, EventArgs e)
        {
            int rowId = patientsGridView.CurrentCell.RowIndex;
            string pesel = patientsGridView.Rows[rowId].Cells[0].Value.ToString();
            if (pesel != null)
            {
                string minDate = measuresGridView.Rows[0].Cells["measure_date"].Value.ToString();
                string maxDate = measuresGridView.Rows[measuresGridView.RowCount - 1].Cells["measure_date"].Value.ToString();
                BarChartForm form = new BarChartForm(pesel, minDate, maxDate, db);
                form.ShowDialog();
            }
        }

        private void plot3Button_Click(object sender, EventArgs e)
        {
            int rowId = patientsGridView.CurrentCell.RowIndex;
            string pesel = patientsGridView.Rows[rowId].Cells[0].Value.ToString();
            if (pesel != null)
            {
                string minDate = measuresGridView.Rows[0].Cells["measure_date"].Value.ToString();
                string maxDate = measuresGridView.Rows[measuresGridView.RowCount - 1].Cells["measure_date"].Value.ToString();
                CorelationChartForm form = new CorelationChartForm(pesel, minDate, maxDate, db);
                form.ShowDialog();
            }
                
        }
    }
}
