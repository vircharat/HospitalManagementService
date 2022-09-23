using HospitalManagementDAL;
using HospitalManagementEntityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBLL
{
    public class DoctorBLL
    {

       
        DoctorDAL doctorDALObj = new DoctorDAL();
        public string AddDoctorBLL(Doctor doctor)
        {


            string msg = doctorDALObj.AddDoctorDAL(doctor);
            return msg;
        }

        public List<Doctor> ShowAllDoctorDALBLL()
        {
            List<Doctor> doctors = doctorDALObj.ShowAllDoctorDAL();

            return doctors;

        }

        public string RemoveDoctorsBLL(int DoctorId)
        {


            string msg = doctorDALObj.DeleteDoctorDAL(DoctorId);
            return msg;

        }

        public string UpdateDoctorBLL(Doctor doctor)
        {


            string msg = doctorDALObj.UpadateDoctorDAl(doctor);
            return msg;

        }

        public bool DoctorLogin(string DoctorEmail, string DoctorPassword)
        {
            bool flag = false;

            
            
            List<Doctor> doctors = doctorDALObj.ShowAllDoctorDAL();

            foreach (var item in doctors)
            {
                if (item.DoctorEmail == DoctorEmail && item.DoctorPassword == DoctorPassword)
                {
                    flag = true;

                    break;
                }


            }
            return flag;

        }
    }  
}
