using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntityy
{
    public class Appointment
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }

        public int DoctorId { get; set; }

        public string DoctorName { get; set; }
        public DateTime AppointmentDate{ get; set; }
    }
}
