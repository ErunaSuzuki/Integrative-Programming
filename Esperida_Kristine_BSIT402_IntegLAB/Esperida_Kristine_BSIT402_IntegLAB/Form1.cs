using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Esperida_Kristine_BSIT402_IntegLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Day
            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day);
                comboBox1.Text = "-Day-";
            }

            //Month
            String[] months_array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach(String month in months_array)
            {
                comboBox2.Items.Add(month);
                comboBox2.Text = "-Month-";
            }

            //Year
            for (int year = 1900; year <= 2020; year++)
            {
                comboBox3.Items.Add(year);
                comboBox3.Text = "-Year-";
            }

            ArrayList programs = new ArrayList();
            programs.Add("Information Technology");
            programs.Add("Tourism");
            programs.Add("Accounting");
            programs.Add("Business Management");
            programs.Add("Culinary Arts");
            programs.Add("Multimedia Arts");

            foreach (String program in programs)
            {
                comboBox4.Items.Add(program);
                comboBox4.Text = "-Select a Program-";
               
            }

        }

     
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        String gender;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            MessageBox.Show("Student Name: " + textBox2.Text + " " + textBox3.Text + " " + textBox1.Text + " " + "\n"
                + "Gender: " + "" + gender + "\n" + "Date of Birth: " + " " + comboBox2.SelectedItem + " " + 
                comboBox1.SelectedItem + " " + comboBox3.SelectedItem + "\n" + "Program: " + comboBox4.SelectedItem);
            this.Dispose(); 
        }
    }
}
