using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(dateTimePicker2.Value < dateTimePicker1.Value)
                {
                    MessageBox.Show("Current Date must be greater then Birth Date");
                }
                int age = dateTimePicker2.Value.Year - dateTimePicker1.Value.Year;
                if (dateTimePicker2.Value.AddYears(age) > dateTimePicker1.Value)
                {
                    age--;
                    lblAge.Text = "Age: " + age.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
