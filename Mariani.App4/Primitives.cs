using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class Primitives
    {
        private int randomNumbers;
        public Primitives()
        {

        }
        public bool setRandomNumbes(int n)
        {
            if (n > -1)
            {
                randomNumbers = n;
                return true;
            }
            return false;
            
        }

        public int getNumbers()
        {
            return randomNumbers;
        }
    }
}
