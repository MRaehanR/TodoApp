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
    public partial class item_list : UserControl
    {
        public item_list()
        {
            InitializeComponent();
        }

        public item_list(string Text,string Key, bool Checked)
        {
            key = Key;
            value = Text;

            InitializeComponent();
            lbl.Text = Text;
            check.Checked = Checked;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void item_list_Load(object sender, EventArgs e)
        {

        }

        private void check_OnChange(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Strikeout);
            }else
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);
            }

            if(onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler onChange = null;
        public string key = null;
        public string value = null;
    }
}
