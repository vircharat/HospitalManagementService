using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HospitalManagementEntityy;

namespace HospitalManagementDAL
{
    
    public class PatientDAL
    {
        List<Patient>patients;

        public static string sqlcon = "Data Source=VDC01LTC2179;Initial Catalog=HospitalManagementService;Integrated Security=True";
        public string AddPatientsDAL(Patient patient)
        {
            #region connected approach
            string msg = "";
             SqlConnection con = new SqlConnection(sqlcon);
             SqlCommand cmd = new SqlCommand("insert into Patient values("+patient.PatientId+",'"+patient.PatientName+"','"+patient.PatientEmail+"','"+patient.PatientPassword+"')", con);
             con.Open();
             int row =cmd.ExecuteNonQuery();
             con.Close();
             if (row > 0)
                 msg = "patient inserted";


             return msg;
            #endregion
        
        }

        public string UpdatePatientsDAL(Patient patient)
        {
            string msg= "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand(" update Patient set PatientId=" + patient.PatientId + ",PatientName='" + patient.PatientName + "',PatientEmail='" + patient.PatientEmail + "',PatientPassword='" + patient.PatientPassword + "' where PatientId=" + patient.PatientId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "patient updated sucessfully";


            return msg;
        }

        public string RemovePatientDAL(int PatientId)
        {
            string msg = "";
            Patient patient = new Patient();
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from Patient where PatientId=" + PatientId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "patient deleted sucessfully";

            return msg;
        }
        public List<Patient> GetAllPatientsDAL()
        {
            #region connected
             SqlConnection con = new SqlConnection(sqlcon);
             SqlCommand cmd = new SqlCommand("select * from Patient", con);
             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             patients = new List<Patient>();   
             while (dr.Read())
             {
                 patients.Add(new Patient
                 {
                     PatientId = Convert.ToInt32(dr["PatientId"]),
                     PatientName = dr["PatientName"].ToString(),
                     PatientEmail = dr["PatientEmail"].ToString(),
                     PatientPassword =dr["PatientPassword"].ToString()
                 }) ;
             }

             con.Close();
             return patients;
            #endregion
        }

       

     }

       
       
}

