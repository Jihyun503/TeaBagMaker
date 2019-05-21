using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] teaList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = "";
        int CountOrgNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.label2.Text = this.orgStr + "2분";
            }
            if (this.comboBox1.SelectedIndex == 1)
            {
                this.label2.Text = this.orgStr + "3분";
            }
            if (this.comboBox1.SelectedIndex == 2)
            {
                this.label2.Text = this.orgStr + "5분";
            }
            if (this.comboBox1.SelectedIndex == 3)
            {
                this.label2.Text = this.orgStr + "2분";
            }
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
                this.CountOrgNum = 120;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                //this.timer.Enabled = false;
                this.label2.Text = "";
                MessageBox.Show("티백을 건지세요!","",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountOrgNum--;
                this.label2.Text = Convert.ToString(CountOrgNum);
            }

        }
    }
}
