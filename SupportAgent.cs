using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure
{
    public class SupportAgent : User
    {
        public Role Role { get; set; } = Role.SupportAgent;
    }
}
