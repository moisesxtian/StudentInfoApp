using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    internal class student
    {

        string stdID, fn, ln;

        public student(string inp1, string inp2, string inp3) {
            stdID = inp1;
            fn = inp2;
            ln = inp3;
        }

        public string getID() {
            return stdID;
        }
        public string getfn()
        {
            return fn;
        }
        public string getln()
        {
            return ln;
        }
    }
}
