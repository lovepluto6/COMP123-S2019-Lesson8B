using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson7B
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the Constructor for Lab08
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lab8Form_Load(object sender, EventArgs e)
        {
            Clearform();
        }
        /// <summary>
        /// This is the Ebent Handler for the Submit Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgeTextBox.Text) ;

            OutputLabel.Text = NameTextBox.Text + " " + NameTextBox.Text;
            //Convert.ToSingle(); another option


            Clearform();
            //another option
            //NameTextBox.Text = ""; or NameTextBox.Text = string(emptly);
        }

        private void Clearform()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //simple input  validation
                try
                {
                    float.Parse(AgeTextBox.Text);
                }
                catch 
                {
                    SubmitButton.Enabled = false;
                }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;

        }
    }
}
