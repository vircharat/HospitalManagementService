using HospitalManagementEntityy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL
{
    public class DoctorDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2179; Initial Catalog=HospitalManagementService; Integrated Security=True;";
        public List<Doctor>doctors = new List<Doctor>();



        public string AddDoctorDAL(Doctor doctor)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into Doctor values(" + doctor.DoctorId + ",'" + doctor.DoctorName + "','" + doctor.DoctorEmail + "','" + doctor.DoctorPassword + "','" + doctor.DoctorSpeciality + "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
            {
                msg = "Doctor Inserted successfully";
            }
            return msg;
        }



        public string UpadateDoctorDAl(Doctor doctor)
        {
            string msg = "";
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("Update Doctor set DoctorId=" + doctor.DoctorId + ", DoctorName='" + doctor.DoctorName + "',DoctorEmail='" + doctor.DoctorEmail + "',DoctorPassword='" + doctor.DoctorPassword +"', DoctorSpeciality='"+doctor.DoctorSpeciality+"'where DoctorId=" + doctor.DoctorId, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                msg = "doctor Updated successfull";
            }



            return msg;
        }



        public string DeleteDoctorDAL(int DoctorId)
        {
            string msg = "";
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("Delete from Doctor where DoctorId=" + DoctorId, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                msg = "doctor Deleted Successfully,...  :)";
            }



            return msg;
        }



        public List<Doctor> ShowAllDoctorDAL()
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Doctor ", conn);
            DataTable dt = new DataTable();
            List<Doctor> doctorList = new List<Doctor>();
            adp.Fill(dt);



            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    doctorList.Add(new Doctor
                    {
                        DoctorId = Convert.ToInt32(dt.Rows[i]["DoctorId"]),
                        DoctorName = dt.Rows[i]["DoctorName"].ToString(),
                        DoctorEmail = dt.Rows[i]["DoctorEmail"].ToString(),
                        DoctorPassword = dt.Rows[i]["DoctorPassword"].ToString(),
                        DoctorSpeciality = dt.Rows[i]["DoctorSpeciality"].ToString()
                    });
                }
            }



            return doctorList;
        }
    }
}
