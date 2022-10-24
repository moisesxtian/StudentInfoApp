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
            string input1, input2, input3;
            input1 = id.Text;
            input2 = ln.Text;
            input3 = fn.Text;
        
            student myclass = new student(input1,input2,input3);
            string set1, set2, set3;
            set1 = myclass.getID();
            set2 = myclass.getfn();
            set3 = myclass.getln();
            lb1.Items.Add(set1);
            lb3.Items.Add(set2);
            lb2.Items.Add(set3);


        }
    }
}
