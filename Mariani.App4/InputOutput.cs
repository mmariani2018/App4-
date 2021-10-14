using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class InputOutput
    {
        public InputOutput() { }

        public void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string getSomething(string message)
        {
            Console.Write(message + "  ");
            return Console.ReadLine();
           
        }
    }
}
