using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17_baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTen.Focus();            
            
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblLT.Text = txtTen.Text;
        }    

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.ForeColor = Color.Red;
            txtTen.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.ForeColor = Color.Green;
            txtTen.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.ForeColor = Color.Blue;
            txtTen.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.ForeColor = Color.Black;
            txtTen.ForeColor = Color.Black;
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void raddo_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void font_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ckID_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.Font = new Font(lblLT.Font.Name, lblLT.Font.Size,
            lblLT.Font.Style ^ FontStyle.Bold);
        }

        private void ckIN_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.Font = new Font(lblLT.Font.Name, lblLT.Font.Size,
            lblLT.Font.Style ^ FontStyle.Italic);
        }

        private void ckGT_CheckedChanged(object sender, EventArgs e)
        {
            lblLT.Font = new Font(lblLT.Font.Name, lblLT.Font.Size,
            lblLT.Font.Style ^ FontStyle.Underline);
        }
    }
}
