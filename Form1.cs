using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Lists;
using System.Xml.Linq;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List C = new ArrayList(7);

        private void Add_Click(object sender, EventArgs e)
        {
            if (!AddTextBox.Text.Equals(""))
            {
                C.add(AddTextBox.Text);
                AddTextBox.Clear();
                UpdateQuantityLabel();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            if (!AddTextBox.Text.Equals(""))
            {
                C.contains(AddTextBox.Text);
                message(AddTextBox.Text);
                AddTextBox.Clear();
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            C.remove(AddTextBox.Text);
            AddTextBox.Clear();
            UpdateQuantityLabel();

        }
        private void UpdateQuantityLabel()
        {
            QuantityLabel.Text = "จำนวน " + C.size() + " คน";
        }
        private void message(object e)
        {

            if (C.contains(e))
            {
                MessageBox.Show("มีข้อมูล : " + e);
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูล : " + e);
            }
        }
        private void GetIndex_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(GetIndextextBox.Text, out index))
            {
                if (index > C.size() || C.isEmpty() || index <= 0)
                {
                    MessageBox.Show("ไม่มีข้อมูลในตำแหน่งที่ : " + index);
                }
                else
                {
                    ShowTextBox.Text = (String)C.get(--index);
                }
            }
            else
            {
                MessageBox.Show("ต้องเป็นตัวเลขเท่านั้น");
            }
        }
        private void Set_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(GetIndextextBox.Text, out index))
            {
                if (C.size() < index || C.isEmpty() || index <= 0)
                {
                    MessageBox.Show("ไม่มีข้อมูลที่จะแก้ไข");
                }
                else if (!ShowTextBox.Text.Equals(""))
                {
                    C.set(--index, ShowTextBox.Text);
                    ShowTextBox.Clear(); GetIndextextBox.Clear();

                    // ------------ถ้าต้องการ ให้โชลำดับด้วย
                    NameAllListBox.Items.Clear();
                    for (int i = 0; i < C.size(); i++)
                    {
                        NameAllListBox.Items.Add("ลำดับที่ : "+ (i + 1) + " มี " + C.get(i));
                    }
                    //--------------
                }
                else
                {
                    MessageBox.Show("ต้องใส่ตำแหน่งและข้อมูลที่จะแก้ไข ");
                }
            }
            else
            {
                MessageBox.Show("ต้องเป็นตัวเลขเท่านั้น");
            }

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            NameAllListBox.Items.Clear();
            for (int i = 0; i < C.size(); i++)
            {
                NameAllListBox.Items.Add("ลำดับที่ : "+ (i+1) +" มี " + C.get(i));
            }

        }
    }
}