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
        public bool add(string bagel)
        {
            _bagels.Add(bagel);
            
            if (_bagels.Contains(bagel))
            {
                return true;
            }

            return false;
        }

        public void remove(string bagel2)
        {
            throw new NotImplementedException();
        }
    }
}
   

