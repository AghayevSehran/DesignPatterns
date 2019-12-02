using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
           
        }

        public void Print(Document d)
        {
        
        }

        public void Scan(Document d)
        {
           
        }
    }
}
