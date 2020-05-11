using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaceImplementation
{
    class OddGenerator : IEnumerable<int>
    {
        //since IEnumerable<int> is intereted from IEnumerable, it must implement 2 GetEnumerator methods
        //from both interfaces and those both method have the same signatures, so we need to implement
        //one of them EXPLICITLY using the interface type (second method)
        public IEnumerator<int> GetEnumerator()
        {
            int i = 1;
            yield return i;
            while (true)
            {
                i += 2;
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() //EXPLICITLY implemented, its hidded from the class and
            //can be accessed only by casting class instance into the interface
        {
            return this.GetEnumerator(); //returning the previous method
        }
    }
}
