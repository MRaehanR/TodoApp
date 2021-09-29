using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }


        int poss = 10;
        public void addItem(string Text,string Key, bool Checked)
        {
            item_list item = new TodoApp.item_list(Text, Key, Checked);
            panel2.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            addItem(text.Text, "0", false);          
        }
    }
}
