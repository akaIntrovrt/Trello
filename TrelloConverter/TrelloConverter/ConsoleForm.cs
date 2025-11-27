using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrelloConverter
{
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void RichBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void WriteLine(string msg)
        {
            this.RichBox.AppendText(msg);
        }
        public void Clear()
        {
            this.RichBox.Clear();
        }
    }
}
