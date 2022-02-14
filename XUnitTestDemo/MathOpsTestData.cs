using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestDemo
{

    public class MathOpsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1.1, 2.2, 3.3 };
            yield return new object[] { -4, -6, -10 };
            yield return new object[] { -2, 2, 0 };
          
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
