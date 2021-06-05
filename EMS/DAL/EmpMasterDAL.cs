using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class EmpMasterDAL
    {
        CTSEMPEntities dbcontext = new CTSEMPEntities();
        public bool SaveEmployee(EmpMaster emp)
        {
            if (emp != null)
            {
                dbcontext.EmpMasters.Add(emp);
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public object GetCount()
        {
            //var no = dbcontext.EmpMasters.Count();
            decimal no = dbcontext.EmpMasters.Max(e=>e.EmpCode);
            if (no > 0)
            {
                no++;
            }
            else
            {
                no = 1;
            }
            return no;
        }
    }
}
