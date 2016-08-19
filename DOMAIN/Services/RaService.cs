using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services
{
    public class RaService
    {
        public static bool IsValid(string ra)
        {
            var teste = ra.Length == 6;
            return teste;
        }
    }
}
