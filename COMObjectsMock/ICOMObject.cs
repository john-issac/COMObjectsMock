using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectsMock
{
    /// <summary>
    /// All COM calls must be done against this interface to allow decoupling the actual COM object from our code
    /// </summary>
    public interface ICOMObject
    {
        ICOMObject AddMarks(string name, short atlMarks, short comMarks);
        short Calculate();
    }
}
