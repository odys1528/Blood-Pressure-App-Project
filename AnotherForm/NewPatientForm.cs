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
    public partial class NewPatientForm : Form
    {
        private DBLogic db;

        public NewPatientForm(DBLogic db)
        {
            InitializeComponent();
            this.db = db;
            confirmAlertLabel.Text = "";
            peselAlertLabel.Text = "";
            firstNameAlertLabel.Text = "";
            lastNameAlertLabel.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string pesel = peselTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            
            if(peselAlertLabel.Text != "" || firstNameAlertLabel.Text != "" || lastNameAlertLabel.Text != "" || peselAlertLabel.Text != "")
            {
                confirmAlertLabel.Text = "Musisz poprawnie wypełnić wszystkie pola.";
            }
            else
            {
                db.addPatient(pesel, firstName, lastName);
                this.Close();
            }
        }

        private void peselTextBox_Validated(object sender, EventArgs e)
        {
            if (!long.TryParse(peselTextBox.Text, out long x) || peselTextBox.Text.Length != 11)
            {
                peselAlertLabel.Text = "Podany PESEL jest niepoprawny.";
            }
            else peselAlertLabel.Text = "";
        }

        private void firstNameTextBox_Validated(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "") firstNameAlertLabel.Text = "Musisz podać imię pacjenta.";
            else firstNameAlertLabel.Text = "";
        }

        private void lastNameTextBox_Validated(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "") lastNameAlertLabel.Text = "Musisz podać nazwisko pacjenta.";
            else lastNameAlertLabel.Text = "";
        }
    }
}
