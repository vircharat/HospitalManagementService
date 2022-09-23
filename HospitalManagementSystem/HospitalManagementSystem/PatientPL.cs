using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntityy;
using HospitalManagementDAL;
using HospitalManagementBLL;

namespace HospitalManagementSystem
{
    public class PatientPL
    {
       
        public void PatientLogin()
        {
            PatientPL patientPLObj = new PatientPL();
            string PatientEmail;
            string PatientPassword;
            Console.Write("Email :");
            PatientEmail = Console.ReadLine();
            Console.Write("Password :");
            PatientPassword = Console.ReadLine();
            
            PatientBLL patientBLLObj = new PatientBLL();

            bool flag = patientBLLObj.PatientLogin(PatientEmail, PatientPassword);
            if (flag)
            {
                Console.WriteLine("Logged in Successfully as patient");
                patientPLObj.PatientSection();
               

            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

        }

        public void BookAppointment()
        {
            Patient patient = new Patient();
            Console.WriteLine("Enter patient details");
            Console.Write("Patient Id :");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name :");
            patient.PatientName = Console.ReadLine();
            Console.Write("Doctor Name :");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Patient Password :");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLLObj = new PatientBLL();
            string msg = patientBLLObj.AddPatientBLL(patient);

            Console.WriteLine(msg);

        }
        public void ViewAppointment()
        {

        }
        public  void DeleteAppointment()
        {

        }
        public void ViewDiagnosisReport()
        {

        }
        public void PatientSection()
        {
            PatientPL patientPLObj = new PatientPL();
            Console.WriteLine("Welcome to Patient Section");
            Console.WriteLine("Press 1 to Book Appoinment");
            Console.WriteLine("Press 2 to View Appointment");
            Console.WriteLine("Press 3 to Delete Appointment");
            Console.WriteLine("Press 4 to View Diagnosis/Prescription Report");
            Console.WriteLine("Press 5 to logout");
            int codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {
                case 1:
                    patientPLObj.BookAppointment();

                    break;
                case 2:
                    patientPLObj.ViewAppointment();
                    break;
                case 3:
                    patientPLObj.DeleteAppointment();
                    break;
                case 4:
                    patientPLObj.ViewDiagnosisReport();
                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("invalid code");
                    break;


            }
        }

        public void AddPatient()
        {
            Patient patient = new Patient();
            Console.WriteLine("Enter patient details");
            Console.Write("Patient Id :");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name :");
            patient.PatientName = Console.ReadLine();
            Console.Write("Patient Email :");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Patient Password :");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLLObj = new PatientBLL();
            string msg = patientBLLObj.AddPatientBLL(patient);

            Console.WriteLine(msg);



        }

        public void UpdatePatient()
        {
            Patient patient = new Patient();
            Console.WriteLine("Enter patient details");
            Console.Write("Patient Id :");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name :");
            patient.PatientName = Console.ReadLine();
            Console.Write("Patient Email :");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Patient Password :");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLLObj = new PatientBLL();
            string msg = patientBLLObj.UpdatePatientBLL(patient);

            Console.WriteLine(msg);

        }

        public void GetAllPatient()
        {
            PatientBLL patientBLLObj = new PatientBLL();
            List<Patient> patients= patientBLLObj.GetAllPatientBLL();
            Console.WriteLine("-------------------------------PatientsList----------------------------");
            Console.WriteLine("--Id-----------Name--------Email-------------------Password---------");
            foreach (var item in patients)
            {

                Console.WriteLine("  " + item.PatientId + " \t" + item.PatientName + " \t" + item.PatientEmail + " \t" + item.PatientPassword);

            }

        }

        public void RemovePatient()
        {
            PatientBLL patientBLLObj = new PatientBLL();
            Console.WriteLine("Enter patient Details");
            Console.WriteLine("Patient Id :");
            int PatientId = Convert.ToInt32(Console.ReadLine());
            
            string msg = patientBLLObj.RemovePatientBLL(PatientId);
            Console.WriteLine(msg);
            Console.Read();


        }
        public bool AdminPatientSection()
        {
            bool flag1 = true;
            Console.WriteLine("Welcome-to-Admin-Patient-Section");
            int codeentered;
            // int codebooksection, usersection, requestsection, acceptedsection, logout;
            Console.WriteLine("Press 1 to add a Patient");
            Console.WriteLine("Press 2 to update a Patient");
            Console.WriteLine("Press 3 to delete a Patient");
            Console.WriteLine("Press 4 to show all Patient");
            Console.WriteLine("Press 5 to exit");
            codeentered = Convert.ToInt32(Console.ReadLine());
            PatientPL patientPLObj = new PatientPL();
            switch (codeentered)
            {
                case 1:

                    patientPLObj.AddPatient();

                    break;

                case 2:
                    patientPLObj.UpdatePatient();

                    break;
                case 3:
                    patientPLObj.RemovePatient();

                    break;
                case 4:
                    patientPLObj.GetAllPatient();

                    break;
                case 5:
                    flag1 = false;
                    break;
                default:
                    Console.WriteLine("invalid code");
                    break;

            }

            return flag1;


        }
    }
}
