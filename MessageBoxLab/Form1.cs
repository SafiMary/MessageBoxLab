using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MessageBoxLab
{
    public partial class Form1 : Form
    {
        int t = 0;
        string title = string.Empty;
       
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Сегодня понедельник", "Сегодня пятница", "Сегодня выходной" });
            timer1.Interval = 3000;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void btnOneB_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBoxgreen.Checked)
            { 
            this.BackColor = Color.Green;
            checkBoxgreen.Enabled = true;
            timer1.Stop();
            }
            if (checkBoxred.Checked)
            {
                this.BackColor = Color.Red;
                checkBoxred.Enabled = true;
                timer1.Stop();
            }
            if (checkBoxwhite.Checked)
            {
                this.BackColor = Color.White;
                checkBoxwhite.Enabled = true;
                timer1.Stop();
            }

            }

        private void btnTwoB_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnTwoB_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnTwoB_MouseClick(object sender, MouseEventArgs e)
        {
          
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }
        
        private void labelColour_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
                checkBoxgreen.Enabled = false;
                timer1.Start();
            
        }

        private void checkBoxred_CheckedChanged(object sender, EventArgs e)
        {
                checkBoxred.Enabled = false;
                timer1.Start();
        }

        private void checkBoxwhite_CheckedChanged(object sender, EventArgs e)
        {
                checkBoxwhite.Enabled = false;
                timer1.Start();
        }
       

        private void groupBoxCheckColour_Enter(object sender, EventArgs e)
        {
           

        }

        private void checkBoxIcon1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIcon1.Checked)
                Icon = Icon.FromHandle(((Bitmap)imageListIcon.Images[0]).GetHicon());
         
        }
        private void checkBoxIcon2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxIcon2.Checked)
                Icon = Icon.FromHandle(((Bitmap)imageListIcon.Images[1]).GetHicon());
        }


        private void checkBoxIcon3_CheckedChanged_1(object sender, EventArgs e)
        {
            Icon = Icon.FromHandle(((Bitmap)imageListIcon.Images[2]).GetHicon());
        }

        private void btnOneB_Click(object sender, EventArgs e)
        {
            var text = "Одна кнопка";
            MessageBox.Show(text);
        }

        private void btnTwoB_Click(object sender, EventArgs e)
        {
            var text = "Две кнопки";
            MessageBox.Show(text);
        }

        private void btnThreeB_Click(object sender, EventArgs e)
        {
            var text = "Три кнопки";
            MessageBox.Show(text);
        }

       
    }
}
