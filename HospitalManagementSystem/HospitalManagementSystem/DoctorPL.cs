using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementBLL;
using HospitalManagementEntityy;


namespace HospitalManagementSystem
{
    public class DoctorPL
    { 
         
        public void DoctorLogin()
        {
            DoctorPL doctorPLObj = new DoctorPL();
            string DoctorEmail;
            string DoctorPassword;
            Console.Write("Email :");
            DoctorEmail = Console.ReadLine();
            Console.Write("Password :");
            DoctorPassword = Console.ReadLine();

            DoctorBLL doctorBLLObj = new DoctorBLL();

            bool flag = doctorBLLObj.DoctorLogin(DoctorEmail, DoctorPassword);
            if (flag)
            {
                Console.WriteLine("Logged in Successfully as Doctor");
                doctorPLObj.DoctorSection();


            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }
        }
        public void DoctorSection()
        {
            DoctorPL doctorPLObj = new DoctorPL();
            Console.WriteLine("Welcome to Doctor Section");
            Console.WriteLine("Press 1 to View  Appoinment");
            Console.WriteLine("Press 2 to Accept Appointment");
            Console.WriteLine("Press 3 to Delete Appointment");
            Console.WriteLine("Press 4 to View Diagnosis/Prescription Report");
            Console.WriteLine("Press 5 to logout");
            int codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {
                case 1:
                    doctorPLObj.ViewAppoinment();

                    break;
                case 2:
                    doctorPLObj.AcceptAppointment();
                    break;
                case 3:
                    doctorPLObj.RejectAppointment();
                    break;
                case 4:
                    doctorPLObj.GivePrescription();
                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("invalid code");
                    break;

            }
        }

        public void ViewAppoinment()
        {
            
        }

        public void AcceptAppointment()
        {

        }

        public void RejectAppointment()
        {

        }
        public void GivePrescription()
        {

        }


        public void AddDoctor()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Enter Doctor details");
            Console.Write("Doctor Id :");
            doctor.DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor Name :");
            doctor.DoctorName = Console.ReadLine();
            Console.Write("Doctor Email :");
            doctor.DoctorEmail = Console.ReadLine();
            Console.Write("Doctor Password :");
            doctor.DoctorPassword = Console.ReadLine();
            Console.Write("Doctor Speciality :");
            doctor.DoctorSpeciality = Console.ReadLine();

            DoctorBLL doctorBLLObj = new DoctorBLL();
            string msg = doctorBLLObj.AddDoctorBLL(doctor);

            Console.WriteLine(msg);

        }

        public void UpdateDoctor()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Enter Doctor details");
            Console.Write("Doctor Id :");
            doctor.DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor Name :");
            doctor.DoctorName = Console.ReadLine();
            Console.Write("Doctor Email :");
            doctor.DoctorEmail = Console.ReadLine();
            Console.Write("Doctor Password :");
            doctor.DoctorPassword = Console.ReadLine();
            Console.Write("Doctor Speciality :");
            doctor.DoctorSpeciality = Console.ReadLine();
            DoctorBLL doctorBLLObj = new DoctorBLL();
            string msg = doctorBLLObj.UpdateDoctorBLL(doctor);


            Console.WriteLine(msg);

        }

        public void GetAllDoctor()
        {
            DoctorBLL doctorBLLObj = new DoctorBLL();
            List<Doctor> doctors = doctorBLLObj.ShowAllDoctorDALBLL();
            Console.WriteLine("-------------------------------DoctorsList---------------------------------");
            Console.WriteLine("--Id-----------Name--------Email----------------Password---------Speciality");
            foreach (var item in doctors)
            {

                Console.WriteLine("  " + item.DoctorId + " \t" + item.DoctorName + " \t" + item.DoctorEmail + " \t" + item.DoctorPassword+"\t"+item.DoctorSpeciality);

            }

        }

        public void RemoveDoctor()
        {

            DoctorBLL doctorBLLObj = new DoctorBLL();
            Console.WriteLine("Enter Doctor Details");
            Console.WriteLine("Doctor Id :");
            int DoctorId = Convert.ToInt32(Console.ReadLine());

            string msg = doctorBLLObj.RemoveDoctorsBLL(DoctorId);
            Console.WriteLine(msg);
            Console.Read();

        }

        public bool AdminDoctorSection()
        {
            DoctorPL doctorPLObj = new DoctorPL();
            bool flag1 = true;
            Console.WriteLine("Welcome-to-Admin-Doctor-Section");
            int codeentered;
            // int codebooksection, usersection, requestsection, acceptedsection, logout;
            Console.WriteLine("Press 1 to add a Doctor");
            Console.WriteLine("Press 2 to update a Doctor");
            Console.WriteLine("Press 3 to delete a Doctor");
            Console.WriteLine("Press 4 to show all Doctor");
            Console.WriteLine("Press 5 to exit");
            codeentered = Convert.ToInt32(Console.ReadLine());
           
            switch (codeentered)
            {
                case 1:

                    doctorPLObj.AddDoctor();

                    break;

                case 2:
                    doctorPLObj.UpdateDoctor();

                    break;
                case 3:
                    doctorPLObj.RemoveDoctor();

                    break;
                case 4:
                    doctorPLObj.GetAllDoctor();

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
