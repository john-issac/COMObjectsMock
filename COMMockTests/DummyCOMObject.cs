using COMObjectsMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMockTests
{
    class DummyCOMObject : ICOMObject
    {
        public DummyCOM s;

        public DummyCOMObject()
        {
            s = new DummyCOM();
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
