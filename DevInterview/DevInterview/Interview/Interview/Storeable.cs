using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    public class Storeable : IStoreable
    {
        public Storeable()
        {

        }
        public IComparable Id { get; set; }
        
    }
}
