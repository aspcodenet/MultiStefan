using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class NameService
    {
        public string GetName(int id)
        {
            return $"Hello-{id}";
        }
    }
}
