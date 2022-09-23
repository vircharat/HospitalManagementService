using HospitalManagementDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntityy;
using HospitalManagementDAL;

namespace HospitalManagementBLL
{
    public class PatientBLL
    {
        PatientDAL patientDALObj = new PatientDAL();
        public string AddPatientBLL(Patient patient)
        {
            

            string msg = patientDALObj.AddPatientsDAL(patient);
            return msg;
        }
      
        public List<Patient> GetAllPatientBLL()
        {
            List<Patient> patients = patientDALObj.GetAllPatientsDAL();

            return patients;

        }

        public string RemovePatientBLL(int PatientId)
        {
            

            string msg = patientDALObj.RemovePatientDAL(PatientId);
            return msg;

        }

        public string UpdatePatientBLL(Patient patient)
        {
            

            string msg = patientDALObj.UpdatePatientsDAL(patient);
            return msg;

        }

        public bool PatientLogin(string PatientEmail,string PatientPassword)
        {
            bool flag = false;
           
            PatientDAL patientDALObj=new PatientDAL();
            // adminDALObj.GetAllAdminsDAL();
            List<Patient> users = patientDALObj.GetAllPatientsDAL();

            foreach (var item in users)
            {
                if (item.PatientEmail == PatientEmail && item.PatientPassword ==PatientPassword)
                {
                    flag = true;

                    break;
                }


            }
            return flag;

        }

    }
}
