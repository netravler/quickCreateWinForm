using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quickCreateWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Form formNew = new Form())
            {
                formNew.Text = "Created Form";
                formNew.Size = new System.Drawing.Size(400, 200);

                addtxtBox("TextBox", 10, 25, 150, 20, formNew);

                formNew.ShowDialog();
             }
        }

        private void richtextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form formNew = new Form())
            {
                formNew.Text = "Created Form";
                formNew.Size = new System.Drawing.Size(400, 200);

                addrichTextBox("RichTextBox", 10, 25, 150, 100, formNew);

                formNew.ShowDialog();
            }
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form formNew = new Form())
            {
                formNew.Text = "Created Form";
                formNew.Size = new System.Drawing.Size(400, 200);

                addListBox("ListBox", 10, 20, 150, 20, formNew);

                formNew.ShowDialog();
            }
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form formNew = new Form())
            {
                formNew.Text = "Created Form";
                formNew.Size = new System.Drawing.Size(400, 200);

                addCheckBox("CheckBox", 10, 25, 150, 20, formNew);

                formNew.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addtxtBox(string txtBoxName, int locationL, int locationT, int sizeL, int sizeLen, Form parentForm)
        {
            TextBox txtExt1 = new TextBox();
            {
                txtExt1.Name = txtBoxName.ToString();
                txtExt1.Text = txtBoxName.ToString();
                txtExt1.Location = new System.Drawing.Point(locationL, locationT);
                txtExt1.Size = new System.Drawing.Size(sizeL, sizeLen);

                //Hover
                txtExt1.MouseHover += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Hover " + txtExt1.Name);
                };

                //Click
                txtExt1.Click += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Click " + txtExt1.Name);
                };

                parentForm.Controls.Add(txtExt1);
            }
        }

        private void addrichTextBox(string txtBoxName, int locationL, int locationT, int sizeL, int sizeLen, Form parentForm)
        {
            RichTextBox RTBox1 = new RichTextBox();
            {
                RTBox1.Name = txtBoxName.ToString();
                RTBox1.Text = txtBoxName.ToString();
                RTBox1.Location = new System.Drawing.Point(locationL, locationT);
                RTBox1.Size = new System.Drawing.Size(sizeL, sizeLen);

                //Hover
                RTBox1.MouseHover += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Hover " + RTBox1.Name);
                };

                //Click
                RTBox1.Click += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Click " + RTBox1.Name);
                };

                parentForm.Controls.Add(RTBox1);
            }
        }

        private void addListBox(string listboxname, int locationL, int locationT, int sizeL, int sizeLen, Form parentForm)
        {
            ListBox LSTBox1 = new ListBox();
            {
                LSTBox1.Name = listboxname.ToString();
                LSTBox1.Text = listboxname.ToString();
                LSTBox1.Location = new System.Drawing.Point(locationL, locationT);
                LSTBox1.Size = new System.Drawing.Size(sizeL, sizeLen);

                //Hover
                LSTBox1.MouseHover += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Hover " + LSTBox1.Name);
                };

                //Click
                LSTBox1.Click += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Click " + LSTBox1.Name);
                };

                parentForm.Controls.Add(LSTBox1);
            }
        }

        private void addCheckBox(string checkboxname, int locationL, int locationT, int sizeL, int sizeLen, Form parentForm)
        {
            CheckBox CKBox1 = new CheckBox();
            {
                CKBox1.Name = checkboxname.ToString();
                CKBox1.Text = checkboxname.ToString();
                CKBox1.Location = new System.Drawing.Point(locationL, locationT);
                CKBox1.Size = new System.Drawing.Size(sizeL, sizeLen);

                //Hover
                CKBox1.MouseHover += delegate(object sender, EventArgs e)
                {
                    MessageBox.Show("this is a Hover " + CKBox1.Name);
                };

                parentForm.Controls.Add(CKBox1);
            }
        }

     

    }
}
