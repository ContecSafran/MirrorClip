using MirrorClip.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorClip
{
    public partial class ClipTargetItem : UserControl
    {
        Item item;
        public ClipTargetItem()
        {
            InitializeComponent();
        }

        private void targetSettingButton_Click(object sender, EventArgs e)
        {

        }

        private void viewSettingButton_Click(object sender, EventArgs e)
        {

        }
        void updateItem()
        {
            item.name = nameTextBox.Text;
            item.targetX = Int32.Parse(targetX.Text);
            item.targetY = Int32.Parse(targetY.Text);
            item.targetW = Int32.Parse(targetW.Text);
            item.targetH = Int32.Parse(targetH.Text);
            item.viewX = Int32.Parse(viewX.Text);
            item.viewX = Int32.Parse(viewY.Text);
            item.viewW = Int32.Parse(viewWidth.Text);
            item.viewH = Int32.Parse(viewHeight.Text);
            item.enable = this.enableCheckBox.Checked;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            item = new Item();
            updateItem();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            updateItem();
        }
    }
}
