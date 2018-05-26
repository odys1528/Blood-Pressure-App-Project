using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherForm
{
    public class Patient
    {
        string pesel { get; set; }
        string lastName { get; set; }
        string firstName { get; set; }

        List<Measurement> measurements { get; set; }

        public Patient(string pesel, string lastName, string firstName)
        {
            this.pesel = pesel;
            this.lastName = lastName;
            this.firstName = firstName;
            this.measurements = new List<Measurement>();
        }

        public void addMeasure(DateTime measureDate, DateTime measureTime, int systolic, int diastolic, int pulse)
        {
            Measurement measurement = new Measurement(measureDate, measureTime, systolic, diastolic, pulse);
            this.measurements.Add(measurement);
        }
    }

    class Measurement
    {
        public Measurement(DateTime measureDate, DateTime measureTime, int systolic, int diastolic, int pulse)
        {
            this.measureDate = measureDate;
            this.measureTime = measureTime;
            this.systolic = systolic;
            this.diastolic = diastolic;
            this.pulse = pulse;
        }

        DateTime measureDate { get; set; }
        DateTime measureTime { get; set; }
        int systolic { get; set; }
        int diastolic { get; set; }
        int pulse { get; set; }
    }
}
