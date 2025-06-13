using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorClip.Control
{
    public partial class SelectAreaForm : Form
    {
        public SelectAreaForm()
        {
            InitializeComponent();
        }

        private void complateButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Select Area?","Select Area", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
