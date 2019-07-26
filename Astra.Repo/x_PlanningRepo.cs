using Astra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astra.Repo
{
    public class x_PlanningRepo
    {
        public static bool Simpan(x_Planning plan)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.x_Planning.Add(plan);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
