using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Controls.OfType<GroupBox>().ToList();
            StringBuilder str = new StringBuilder();
            foreach (var item in a)
            {
                var checkedItem = item.Controls.OfType<RadioButton>().SingleOrDefault(x => x.Checked);

                if (checkedItem.Text == "4" || checkedItem.Text == "Biləcəri")
                {
                    checkedItem.Text = "Düzdür";
                    str.AppendLine(checkedItem.Text);
                    checkedItem.BackColor = Color.Green;
                }
                else
                {
                    checkedItem.Text = "Səhvdir";
                    str.AppendLine(checkedItem.Text);
                    checkedItem.BackColor = Color.Red;
                }
            }

            MessageBox.Show(str.ToString());
        }
    }
}
