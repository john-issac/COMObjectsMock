using Interop.SimpleMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectsMock
{
    public class RealCOMObject : ICOMObject
    {
        SimpleObj s;

        public RealCOMObject()
        {
            s = new SimpleObj();
        }

        public ICOMObject AddMarks(string name, short atlMarks, short comMarks)
        {
            s.Name = name;
            s.ATLMarks = atlMarks;
            s.COMMarks = comMarks;
            return this;
        }
        public short Calculate()
        {
            s.Calculate();
            return s.Total;
        }
    }
}
