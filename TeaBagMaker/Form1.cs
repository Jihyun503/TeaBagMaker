using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] teaList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<teaList.Length; i++)
            {
                this.comboBox1.Items.Add(teaList[i]);
            }
            if (comboBox1.Items.Count > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {

            }
        }
    }
}
