using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppd.NewFolder
{
    public class ClassLibrary
    {
        public int sum( int a, int b, string isare)
        {
            int c = 0;
            c = a + b;
            return c;
        }
        public int ferq(int a,int b, string isare)
        {
            int f = 0;
                f = a - b;
            return f;
        }

        public int vur(int a,int b,string isare)
        {
            int v = 0;
            v = a * b;
            
            return v;
        }
        public int bol(int a, int b,string isare)
        {
            int bl = 0;
            bl = a / b;
            return bl;
        }

        public int cxs(int a,  int b, string isare)
        {
            if(isare=="*")
            {
                return vur(a, b, isare);
            }
            else if (isare == "+")
            {
                return sum(a, b, isare);
            }
            else if (isare=="-")
            {
                return ferq(a, b, isare);
            }
            return bol(a, b, isare);
        }
    }
}
