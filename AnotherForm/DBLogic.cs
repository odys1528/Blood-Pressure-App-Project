using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AnotherForm
{
    public class DBLogic
    {
        private string connectionString;

        public void setConectionString(string connStr)
        {
            connectionString = connStr;
        }

        public DataSet getPatientsDB()
        {
            string sql = "select * from Patients order by 1";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet getPatiensMeasures(string pesel)
        {
            string sql = String.Format("select * from BloodPressure where pesel='{0}' order by measure_date, measure_time", pesel);
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void updatePatient(string pesel, string column, string value)
        {
            string sql = String.Format("update Patients set {0}='{1}' where pesel='{2}'", column, value, pesel);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteScalar();
            com.Dispose();
            con.Close();
            con.Dispose();
        }

        public void deletePatient(string pesel)
        {
            string sql = String.Format("delete from Patients where pesel={0};", pesel);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteScalar();
            com.Dispose();
            con.Close();
            con.Dispose();
        }

        public void addPatient(string pesel, string first_name, string last_name)
        {
            string sql = String.Format("insert into Patients values('{0}', '{1}', '{2}');", pesel, last_name, first_name);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteScalar();
            com.Dispose();
            con.Close();
            con.Dispose();
        }

        public void updateMeasure(string id, string column, string value)
        {
            if(column == "measure_date")
            {
                DateTime pom;
                if (!DateTime.TryParse(value, out pom))
                {
                    value = DateTime.Today.ToShortDateString();
                }
                value = value.Substring(0, 10);
                value = convertDate(value);
            }

            string sql;
            if (column == "PESEL" || column == "measure_date" || column == "measure_time")
            {
                sql = String.Format("update BloodPressure set {0}='{1}' where id={2}", column, value, id);
            }
            else
            {
                sql = String.Format("update BloodPressure set {0}={1} where id={2}", column, value, id);
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteScalar();
            com.Dispose();
            con.Close();
            con.Dispose();
        }

        public void deleteMeasure(string id)
        {
            string sql = String.Format("delete from BloodPressure where id={0};", id);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteScalar();
            com.Dispose();
            con.Close();
            con.Dispose();
        }

        public void addMeasure(string pesel, string measure_date, string measure_time, string systolic, string diastolic, string pulse)
        {
            string sql = String.Format("insert into BloodPressure values((select MAX(id)+1 from BloodPressure), '{0}', '{1}', '{2}', {3}, {4}, {5});", 
                pesel, measure_date, measure_time, systolic, diastolic, pulse);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteScalar();
            com.Dispose();
            con.Close();
            con.Dispose();
        }

        private string convertDate(string date)
        {
            string day = date.Substring(0, date.IndexOf("."));
            string month = date.Substring(3, date.IndexOf("."));
            string year = date.Substring(6);
            return year + "/" + month + "/" + day;
        }
    }
}
