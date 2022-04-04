using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal abstract class list
    {
        public int Id { get { return id; } }
        private protected int id;

        private protected static int i = 0;
        public abstract string name();
        public abstract void printf();
        public abstract void coor();
    }
}
