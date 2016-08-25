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
    public partial class Tree_Save_Name : Form
    {
        private Form1 form;
        public Tree_Save_Name(Form1 a_form)
        {
            InitializeComponent();
            form = a_form;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool fHasSpace = saveNameTextBox.Text.Contains(" ");
            if (saveNameTextBox.Text.Length < 1){
                MessageBox.Show("Please Enter a valid Name!\n Can't be blank.");
            }
            else if(fHasSpace == true){
                MessageBox.Show("Name can't contain spaces!");
            }
            else
            {
                form.SerializeForm(saveNameTextBox.Text);
                this.Close();
                MessageBox.Show("Tree Saved");
            }
        }
    }
}
