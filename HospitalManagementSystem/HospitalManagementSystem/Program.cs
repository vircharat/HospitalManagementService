using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
     public class Program
    {
        static void Main(string[] args)
        {
            AdminPL adminPLObj = new AdminPL();
            adminPLObj.menu();
            Console.Read();
        }
    }
}
