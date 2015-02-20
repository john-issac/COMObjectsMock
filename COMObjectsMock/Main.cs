using Interop.SimpleMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectsMock
{
    public class Main
    {
        private ICOMObject _COMObject;
        public ICOMObject COMObjectsMock {
            get { return _COMObject; }
        }

        /// <summary>
        /// Default constructor using the actual COM object which the provider gets by default.
        /// This is to be used on production environment
        /// </summary>
        public Main()
        {
            _COMObject = COMProvider.GetProvider();
        }

        /// <summary>
        /// Constructor to be used by unit testing to pass a dummy object that acts like COM
        /// </summary>
        /// <param name="COMObject"></param>
        public Main(ICOMObject dummyObject)
        {
            _COMObject = dummyObject;
        }

        public short DoSomething()
        {
            _COMObject.AddMarks("John Smith", 10, 20);
            return _COMObject.Calculate();
        }
    }
}
