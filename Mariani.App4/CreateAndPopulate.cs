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
            generateNode(temp);
        }
        private void generateNode(Primitives temp)
        {
            int tempNumber;
            Random random = new Random();
            bool flag = Primitives.Equals();

            do
            {
                tempNumber = random.Next(51);
                 temp.setRandomNumbes(tempNumber);
            } while (!flag);

            if()

        }
        public Primitives getGeneratedNumber()
        {
            return  temp;
        }
        
    }
}
