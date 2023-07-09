using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Delegate1
{
    public class TestService
    {
        public async Task<int> CheckMe(Func<int,int,Task<int>> SumDelegate, int a,int b)
        {
          return await SumDelegate(a, b);
        }
    }
}
