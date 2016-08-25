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
    public partial class TreeOpenDialog : Form
    {
        private Form1 form;
        public TreeOpenDialog(Form1 a_form)
        {
            InitializeComponent();
            form = a_form;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            form.DeserializeForm(treeName.Text);
            form.compositeNodeList.Clear();
            form.decoratorNodeList.Clear();
            form.leafNodeList.Clear();



            form.newTreeOpened = true;
            this.Close();
        }

        private void treeName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                form.DeserializeForm(treeName.Text);
                form.compositeNodeList.Clear();
                form.decoratorNodeList.Clear();
                form.leafNodeList.Clear();
                form.newTreeOpened = true;
                this.Close();
            }
        }
    }
}
