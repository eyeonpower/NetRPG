using System;
using System.Collections.Generic;
using System.Text;
using NetRPG.Runtime.Typing;
using NetRPG.Runtime.Typing.Files;

namespace NetRPG.Runtime.Functions.System
{
    #pragma warning disable 8981 
    class printf : Function
    {
        public override object Execute(object[] Parameters)
        {
            string output = Parameters[0] as string;
            Console.Write(output);
            return output.Length;
        }
    }
    #pragma warning restore 8981
}
