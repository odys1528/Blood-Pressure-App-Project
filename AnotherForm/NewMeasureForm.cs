using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherForm
{
    public partial class NewMeasureForm : Form
    {
        private DBLogic db;
        private string pesel;
        private int error;

        public NewMeasureForm(DBLogic db, string pesel)
        {
            InitializeComponent();
            this.db = db;
            this.pesel = pesel;
            confirmAlertLabel.Text = 
                dateAlertLabel.Text = 
                timeAlertLabel.Text = 
                systolicAlertLabel.Text = 
                diastolicAlertLabel.Text = 
                pulseAlertLabel.Text = "";
        }

        private void NewMeasure_Load(object sender, EventArgs e)
        {
            peselTextBox.Text = pesel;
        }

        private void addMeasureButton_Click(object sender, EventArgs e)
        {
            string date = dateAlertLabel.Text;
            string time = timeAlertLabel.Text;
            string systolic = systolicAlertLabel.Text;
            string diastolic = diastolicAlertLabel.Text;
            string pulse = pulseAlertLabel.Text;

            if(date == "" && time == "" && systolic == "" && diastolic == "" && pulse == "" || pulseTextBox.Text != "")
            {
                db.addMeasure(peselTextBox.Text, dateTextBox.Text, timeTextBox.Text, systolicTextBox.Text, diastolicTextBox.Text, pulseTextBox.Text);
                this.Close();
            }
            else
            {
                confirmAlertLabel.Text = "Musisz poprawnie wypełnić wszystkie pola.";
            }
        }

        private void pulseTextBox_Validated(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(pulseTextBox.Text, out a))
            {
                pulseAlertLabel.Text = "Należy podać liczbę.";
                error++;
            }
            else
            {
                pulseAlertLabel.Text = "";
            }
        }

        private void diastolicTextBox_Validated(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(diastolicTextBox.Text, out a))
            {
                diastolicAlertLabel.Text = "Należy podać liczbę.";
            }
            else
            {
                diastolicAlertLabel.Text = "";
            }
        }

        private void systolicTextBox_Validated(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(systolicTextBox.Text, out a))
            {
                systolicAlertLabel.Text = "Należy podać liczbę.";
            }
            else
            {
                systolicAlertLabel.Text = "";
            }
        }

        private void timeTextBox_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\d{2}\:\d{2}");
            Regex r2 = new Regex(@"\d{2}\:\d{2}\:\d{2}");
            if (!r.Match(timeTextBox.Text).Success && !r2.Match(timeTextBox.Text).Success)
            {
                timeAlertLabel.Text = "Podano zły format liczby. Poprawny format: HH:MM lub HH:MM:SS.";
            }
            else
            {
                timeAlertLabel.Text = "";
            }
        }

        private void dateTextBox_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            if (!r.Match(dateTextBox.Text).Success)
            {
                dateAlertLabel.Text = "Podano zły format liczby. Poprawny format: DD.MM.YYYY.";
            }
            else
            {
                dateAlertLabel.Text = "";
            }
        }
    }
}
