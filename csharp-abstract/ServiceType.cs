using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract
{
    abstract class ServiceType
    {
        abstract public void Operate();

        abstract public string Name { get; set; }

    }
}
