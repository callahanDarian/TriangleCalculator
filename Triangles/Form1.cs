using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double txtBox1;
        double txtBox2;
        double area;
        double perim;
        double mSide;
        double c2;
        double isoHeight;
        double isoBase;
        double isoLeg;
        int exit;

        private void rbRight_CheckedChanged(object sender, EventArgs e)
        {
            rbSide1.Text = "Hypotenuse";
            rbSide2.Text = "Leg";
            rbSide3.Text = "Leg";
        }

        private void rbIso_CheckedChanged(object sender, EventArgs e)
        {
            rbSide1.Text = "Base";
            rbSide2.Text = "Height";
            rbSide3.Text = "Leg";
        }

        private void rbEqual_CheckedChanged(object sender, EventArgs e)
        {
            rbSide1.Text = "Leg";
            rbSide2.Text = "Leg";
            rbSide3.Text = "Leg";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBox1 = Convert.ToInt32(txtBoxSide1.Text);
            txtBox2 = Convert.ToInt32(txtBoxSide2.Text);

            if (rbRight.Checked)
            {
                if (rbSide1.Checked)
                {
                    c2 = ((txtBox1 * txtBox1) + (txtBox2 * txtBox2));

                    mSide = Math.Sqrt(c2);
                    lblSide3.Text = "" + mSide;

                    perim = mSide + txtBox1 + txtBox2;
                    lblPerim.Text = "" + perim;

                    area = (txtBox1 * txtBox2) / 2;
                    lblArea.Text = "" + area;
                }
                else if (rbSide2.Checked)
                {
                    c2 = (txtBox1 * txtBox1) - (txtBox2 * txtBox2);

                    mSide = Math.Sqrt(c2);
                    lblSide3.Text = "" + mSide;

                    perim = mSide + txtBox1 + txtBox2;
                    lblPerim.Text = "" + perim;

                    area = (txtBox2 * txtBox2) / 2;
                    lblArea.Text = "" + area;
                }
                else if (rbSide3.Checked)
                {
                    c2 = (txtBox1 * txtBox1) - (txtBox2 * txtBox2);

                    mSide = Math.Sqrt(c2);
                    lblSide3.Text = "" + mSide;

                    perim = mSide + txtBox1 + txtBox2;
                    lblPerim.Text = "" + perim;

                    area = (txtBox2 * txtBox2) / 2;
                    lblArea.Text = "" + area;
                }
                else 
                { }
            }
            if (rbIso.Checked)
            {
                if (rbSide1.Checked)
                {
                    isoBase = 2 * Math.Sqrt((txtBox1 * txtBox1) - (txtBox2 * txtBox2));

                    mSide = isoBase;
                    lblSide3.Text = "" + mSide;

                    perim = mSide + txtBox2 + txtBox2;
                    lblPerim.Text = "" + perim;

                    area = (isoBase * txtBox1) / 2;
                    lblArea.Text = "" + area;
                }
                else if (rbSide2.Checked)
                {
                    isoHeight = Math.Sqrt((txtBox2 * txtBox2) - ((txtBox1 * txtBox1) / 4));

                    mSide = isoHeight;
                    lblSide3.Text = "" + mSide;

                    perim = txtBox1 + txtBox2 + txtBox2;
                    lblPerim.Text = "" + perim;

                    area = (txtBox1 * isoHeight) / 2;
                    lblArea.Text = "" + area;
                }
                else if (rbSide3.Checked)
                {
                    isoLeg = Math.Sqrt(((txtBox1 * txtBox1) / 4) - (txtBox2 * txtBox2));

                    mSide = isoLeg;
                    lblSide3.Text = "" + mSide;

                    perim = isoLeg + isoLeg + txtBox1;
                    lblPerim.Text = "" + perim;

                    area = (txtBox1 * txtBox2) / 2;
                    lblArea.Text = "" + area;
                }
                else 
                { }
            }
            if (rbEqual.Checked)
            {
                if (rbSide1.Checked)
                {
                    mSide = (txtBox1 + txtBox2) / 2;
                    lblSide3.Text = "" + mSide;

                    perim = txtBox1 + txtBox2 + mSide;
                    lblPerim.Text = "" + perim;

                    area = (Math.Sqrt(3) / 4) * (mSide * mSide);
                    lblArea.Text = "" + area;
                }
                else if (rbSide2.Checked)
                {
                    mSide = (txtBox1 + txtBox2) / 2;
                    lblSide3.Text = "" + mSide;

                    perim = txtBox1 + txtBox2 + mSide;
                    lblPerim.Text = "" + perim;

                    area = (Math.Sqrt(3) / 4) * (mSide * mSide);
                    lblArea.Text = "" + area;
                }
                else if (rbSide3.Checked)
                {
                    mSide = (txtBox1 + txtBox2) / 2;
                    lblSide3.Text = "" + mSide;

                    perim = txtBox1 + txtBox2 + mSide;
                    lblPerim.Text = "" + perim;

                    area = (Math.Sqrt(3) / 4) * (mSide * mSide);
                    lblArea.Text = "" + area;
                }
                else 
                { }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            exit = 1;
            txtBoxExit.Text = "E";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (exit == 1)
            {
                exit = 2;
                txtBoxExit.Text = "E X";
            }
            else 
            { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (exit == 2)
            {
                exit = 3;
                txtBoxExit.Text = "E X I";
            }
            else 
            { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (exit == 3)
            {
                exit = 4;
                txtBoxExit.Text = "E X I T";

                btnExit.Visible = true;
            }
            else 
            { }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbSide1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRight.Checked)
            {
                lblSide1.Text = "Length of leg :";
                lblSide2.Text = "Length of leg :";
            }
            else if (rbIso.Checked)
            {
                lblSide1.Text = "Length of height :";
                lblSide2.Text = "Length of leg :";
            }
            else if (rbEqual.Checked)
            {
                lblSide1.Text = "Length of leg :";
                lblSide2.Text = "Length of leg :";
            }
            else 
            { }

        }

        private void rbSide2_CheckedChanged(object sender, EventArgs e)
        {
             if(rbRight.Checked)
            {
                lblSide1.Text = "Length of hypotenuse :";
                lblSide2.Text = "Length of leg :";
            }
            else if (rbIso.Checked)
            {
                lblSide1.Text = "Length of base :";
                lblSide2.Text = "Length of leg :";
            }
            else if (rbEqual.Checked)
            {
                lblSide1.Text = "Length of leg :";
                lblSide2.Text = "Length of leg :";
            }
            else 
             { }
        }

        private void rbSide3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRight.Checked)
            {
                lblSide1.Text = "Length of hypotenuse :";
                lblSide2.Text = "Length of leg :";
            }
            else if (rbIso.Checked)
            {
                lblSide1.Text = "Length of base :";
                lblSide2.Text = "Length of height :";
            }
            else if (rbEqual.Checked)
            {
                lblSide1.Text = "Length of leg :";
                lblSide2.Text = "Length of leg :";
            }
            else 
            { }
        }
    }
}