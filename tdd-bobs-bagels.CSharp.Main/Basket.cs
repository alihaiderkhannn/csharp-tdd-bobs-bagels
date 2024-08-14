global using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main {
    public class Basket
    {
        private List<string> _bagels = new List<string>();

        public List<string> Bagels { get { return _bagels; } }
        public void add(string bagel)
        {
            throw new NotImplementedException();
        }
    }
}
   

