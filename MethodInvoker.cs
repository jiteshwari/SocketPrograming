using System;

namespace ShocketProgramming
{
    internal class MethodInvoker
    {
        private Action msg;

        public MethodInvoker(Action msg)
        {
            this.msg = msg;
        }
    }
}