using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class MultFactor< U >
    {
        private U Factor;
        private static  MultFactor< U > instance = new MultFactor< U >();

        private MultFactor() { }

        public  void SetFactor( U factor )
        {
            Factor = factor;
        }

        public  U GetFactor()
        {
            return Factor;
        }

        public static MultFactor< U > Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
