using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class CreateAndPopulate
    {
        Primitives temp = new Primitives();

        public CreateAndPopulate()
        {
            populateNode(temp);
        }
        private void populateNode(Primitives temp)
        {
            Random random = new Random();
            int tempNumber;
            bool flag = false;


            do
            {
                tempNumber = random.Next(51);
                flag = temp.setRandomNumbes(tempNumber);

            } while (!flag);
           

        }
        public Primitives getPrimitives()
        {
            return temp;
        }
    }
}
