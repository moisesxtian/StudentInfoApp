using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{

    public partial class frmStudentInfo : Form
    {

    public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This Stores the Value in the TextBox
            string idinp, lninp, fninp;
            idinp = id.Text;
            lninp = ln.Text;
            fninp = fn.Text;

            /* This transfers the Value of the TextBox to the 'Students' Class inside a constructor
            Constructor Overloading is implemented with 3 paramerters*/
            Students students = new Students(idinp,lninp,fninp);

            /*Getting the value of Students ID, Last name and First Name from the 'Students Class
              and adding it into the listboxes */
            lb1.Items.Add(students.getID());
            lb3.Items.Add(students.getfn());
            lb2.Items.Add(students.getln());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
