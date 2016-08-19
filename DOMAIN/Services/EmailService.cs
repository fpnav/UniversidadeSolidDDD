using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services
{
    public class EmailService
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}
