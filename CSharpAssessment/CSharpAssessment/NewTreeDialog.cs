using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssessment
{
    public partial class NewTreeDialog : Form
    {
        private readonly Form1 form1;

        public NewTreeDialog(Form1 a_form1)
        {
            this.form1 = a_form1;
            InitializeComponent();
        }

        private void newTreeDialogOkButton_Click(object sender, EventArgs e)
        {
            form1.compositeNodeList.Clear();
            form1.decoratorNodeList.Clear();
            form1.leafNodeList.Clear();

            form1.compositeOne = null;
            form1.compositeTwo = null;

            form1.decoratorOne = null;
            form1.decoratorTwo = null;

            form1.leafOne = null;
            form1.leafTwo = null;
            form1.leafThree = null;
            form1.leafFour = null;
            form1.leafFive = null;
            form1.leafSix = null;


            form1.newTreeCreated = true;
            if(compositeDropBox1.Text != ""){
                form1.compositeOne = compositeDropBox1.Text;
            }

            if (compositeDropBox2.Text != ""){
                form1.compositeTwo = compositeDropBox2.Text;
            }

            if(decoratorDropBox1.Text != ""){
                form1.decoratorOne = decoratorDropBox1.Text;
            }

            if (decoratorDropBox2.Text != ""){
                form1.decoratorTwo = decoratorDropBox2.Text;
            }

            
            if(leafDropBox1.Text != ""){
                form1.leafOne = leafDropBox1.Text;
            }
            
            if(leafDropBox2.Text != ""){
                form1.leafTwo = leafDropBox2.Text;
            }
            
            if(leafDropBox3.Text != ""){
                form1.leafThree = leafDropBox3.Text;
            }
            
            if(leafDropBox4.Text != ""){
                form1.leafFour = leafDropBox4.Text;
            }

            if(leafDropBox5.Text != ""){
                form1.leafFive = leafDropBox5.Text;
            }

            if(leafDropBox6.Text != ""){
                form1.leafSix = leafDropBox6.Text;
            }

            this.Close();
        }
    }
}
