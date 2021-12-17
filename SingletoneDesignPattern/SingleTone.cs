using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDesignPattern
{
    public sealed class SingletoneStatic
    {
        private SingletoneStatic()
        {

        }
        public static SingletoneStatic Getinstance { get { return GetInstanceSingle.instance; } }


        private class GetInstanceSingle
        {
            static GetInstanceSingle()
            {

            }

            internal static readonly SingletoneStatic instance = new SingletoneStatic();
        }
    }

    
}
