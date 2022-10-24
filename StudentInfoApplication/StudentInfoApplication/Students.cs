using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    internal class Students
    {

        string studentID, firstname, lastname;

        //I created a Constructor with 3 string Parameters, this will act as the Setter of the Data Type values.
        public Students(string inp1, string inp2, string inp3) {
            studentID = inp1;
            firstname = inp2;
            lastname = inp3;
        }

        //These are the Getter methods
        public string getID() {
            return studentID;
        }
        public string getfn()
        {
            return firstname;
        }
        public string getln()
        {
            return lastname;
        }
    }
}
