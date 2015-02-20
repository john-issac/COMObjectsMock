using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectsMock
{
    /// <summary>
    /// This is the provider that return the real COM object by default. It can also be set to a dummy object for testing
    /// </summary>
    public static class COMProvider
    {
        private static Func<ICOMObject> _instance;
        static COMProvider()
        {
            _instance = () => new RealCOMObject();
        }

        public static ICOMObject GetProvider()
        {
            return _instance();
        }
        
        public static void SetProvider<T>()
            where T : ICOMObject, new()
        {
            _instance = () => new T();
        }
    }
}
