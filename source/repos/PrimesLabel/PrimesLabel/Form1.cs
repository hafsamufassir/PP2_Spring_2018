using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesLabel
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //textBox.Text = "";
            label.Text = "";
            num = int.Parse(textBox.Text);
            //num = int.Parse(s); 
            List<int> list = new List<int>();
            string s;
            if(textBox.Text == num.ToString())
            {
                for(int i = 1; i < num; i++)
                { 
                    if (IsPrime(i))
                    {
                        list.Add(i);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    label.Text += list[i].ToString() + " " ;
                }
            }
        }

        static bool IsPrime(int a)
        {
            if(a == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
