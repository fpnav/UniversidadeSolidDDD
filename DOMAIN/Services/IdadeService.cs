using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services
{
    public class IdadeService
    {
        public static bool IsValid(DateTime data)
        {
            return DateTime.Now.Year - data.Year >= 18 ;
        }
    }
}
