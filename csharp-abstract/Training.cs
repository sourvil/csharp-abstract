using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract
{
    class Training : ServiceType
    {
        private string _name = "";
        public override string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public override void Operate()
        {
            Console.WriteLine("Training operation");
        }
    }
}
