using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BOL
{
   public class EmpMasterBOL
    {
        EmpMasterDAL empdal = new EmpMasterDAL();
        public bool AddEmployee(EmpMaster emp)
        {
            int count =Convert.ToInt32(empdal.GetCount());
            emp.EmpCode = count;
            return empdal.SaveEmployee(emp);          
        }
    }
}
