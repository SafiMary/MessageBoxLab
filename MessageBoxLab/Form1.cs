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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MessageBoxLab
{
    public partial class Form1 : Form
    {
        int t = 0;
        string title = string.Empty;
        MessageBoxButtons _buttons;
        MessageBoxIcon icon;
        public Form1()
        {
            InitializeComponent();
            comboBoxButton.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
    
            timer1.Interval = 3000;
            timer1.Tick += new EventHandler(timer1_Tick);
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

       
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void SelectedIcon(string item)
        {
            switch (item)
            {
                case "предупреждение": icon = MessageBoxIcon.Warning; break;
                case "стоп": icon = MessageBoxIcon.Stop; break;
                case "запрос": icon = MessageBoxIcon.Question; break;
                case "информация": icon = MessageBoxIcon.Information; break;
                default: icon = MessageBoxIcon.None; break;
            }
        }
        private void listBoxIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIcon(listBoxIcon.SelectedItem.ToString());
        }
        private void SelectedButtons(string item)
        {
            switch (item)
            {
                case "AbortRetryIgnore": _buttons = MessageBoxButtons.AbortRetryIgnore; break;
                case "OK": _buttons = MessageBoxButtons.OK; break;
                case "OKCancel": _buttons = MessageBoxButtons.OKCancel; break;
                case "RetryCancel": _buttons = MessageBoxButtons.RetryCancel; break;
                case "YesNo": _buttons = MessageBoxButtons.YesNo; break;
                case "YesNoCancel": _buttons = MessageBoxButtons.YesNoCancel; break;
                default: _buttons = MessageBoxButtons.OK; break;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedButtons(comboBoxButton.SelectedItem.ToString());
        }

        private void buttonMB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxInput.Text, "Message Box", _buttons, icon);
        }
    }
}
