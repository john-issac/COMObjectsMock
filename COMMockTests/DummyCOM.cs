using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMockTests
{
    class DummyCOM
    {
        public string Name;
        public short ATLMarks;
        public short COMMarks;
        public short Total;

        public void Calculate()
        {
            Total = (short)(ATLMarks + COMMarks);
        }
    }
}
