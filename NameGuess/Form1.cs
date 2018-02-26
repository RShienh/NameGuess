using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("How many letters are in your first name?", "Start");
            if (input != null)
            {
                int value = Int32.Parse(input);
                switch (value)
                {
                    case 1:
                        enter1.Visible = true;
                        l1.Visible = true;
                        break;
                    case 2:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        break;
                    case 3:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        break;
                    case 4:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        break;
                    case 5:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        enter5.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        break;
                    case 6:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        enter5.Visible = true;
                        enter6.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        l6.Visible = true;
                        break;
                    case 7:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        enter5.Visible = true;
                        enter6.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        l6.Visible = true;
                        break;
                    case 8:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        enter5.Visible = true;
                        enter6.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        l6.Visible = true;
                        break;
                    case 9:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        enter5.Visible = true;
                        enter6.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        l6.Visible = true;
                        break;
                    case 10:
                        enter1.Visible = true;
                        enter2.Visible = true;
                        enter3.Visible = true;
                        enter4.Visible = true;
                        enter5.Visible = true;
                        enter6.Visible = true;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        l6.Visible = true;
                        break;
                }
                for (int i = 1; i < value + 1; i++)
                {
                    switch (rLetters(i))
                    {
                        case 1:
                            enter1.Items.Add(list1.Items[0]);
                            enter2.Items.Add(list1.Items[1]);
                            enter3.Items.Add(list1.Items[2]);
                            enter4.Items.Add(list1.Items[3]);
                            enter5.Items.Add(list1.Items[4]);
                            break;
                        case 2:
                            enter1.Items.Add(list2.Items[0]);
                            enter2.Items.Add(list2.Items[1]);
                            enter3.Items.Add(list2.Items[2]);
                            enter4.Items.Add(list2.Items[3]);
                            enter5.Items.Add(list2.Items[4]);
                            break;
                        case 3:
                            enter1.Items.Add(list3.Items[0]);
                            enter2.Items.Add(list3.Items[1]);
                            enter3.Items.Add(list3.Items[2]);
                            enter4.Items.Add(list3.Items[3]);
                            enter5.Items.Add(list3.Items[4]);
                            break;
                        case 4:
                            enter1.Items.Add(list4.Items[0]);
                            enter2.Items.Add(list4.Items[1]);
                            enter3.Items.Add(list4.Items[2]);
                            enter4.Items.Add(list4.Items[3]);
                            enter5.Items.Add(list4.Items[4]);
                            break;
                        case 5:
                            enter1.Items.Add(list5.Items[0]);
                            enter2.Items.Add(list5.Items[1]);
                            enter3.Items.Add(list5.Items[2]);
                            enter4.Items.Add(list5.Items[3]);
                            enter5.Items.Add(list5.Items[4]);
                            break;
                    }
                }
            }
        }
        private static int rLetters(int i)
        {
            string letters = Microsoft.VisualBasic.Interaction.InputBox("In which line has letter number " + i + " ?", "Letter " + i);
            int letter = 0;
            if (letters != null)
            {
                letter = Int32.Parse(letters);
            }
            return letter;
        }
    }
}
