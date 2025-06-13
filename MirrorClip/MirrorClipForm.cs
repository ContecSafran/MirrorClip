using MirrorClip.Control;
using MirrorClip.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorClip
{
    public partial class MirrorClipForm : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        private SelectAreaForm selectAreaForm = new SelectAreaForm();
        Item item;
        public static string configFile = "config.json";
        public MirrorClipForm()
        {
            InitializeComponent();
            InitializeTrayIcon();
            LoadStatus();
        }
        public string GetStatusTxtFileName()
        {
            return Directory.GetParent(Application.ExecutablePath) + "\\" + configFile;
        }
        public void SaveStatus()
        {
            File.WriteAllText(GetStatusTxtFileName(), JsonConvert.SerializeObject(item));
        }
        public void LoadStatus()
        {
            string s = GetStatusTxtFileName();
            if (File.Exists(s))
            {
                item = JsonConvert.DeserializeObject<Item>(File.ReadAllText(s));
                nameTextBox.Text = item.name;
                targetX.Text = item.targetX.ToString();
                targetY.Text = item.targetY.ToString();
                targetW.Text = item.targetW.ToString();
                targetH.Text = item.targetH.ToString();
                viewX.Text = item.viewX.ToString();
                viewY.Text = item.viewX.ToString();
                viewW.Text = item.viewW.ToString();
                viewH.Text = item.viewH.ToString();
                this.enableCheckBox.Checked = item.enable;
            }
            else
            {
                item = new Item();
                item.name = nameTextBox.Text = "new item";
                targetX.Text = "100";
                targetY.Text = "100";
                targetW.Text = "100";
                targetH.Text = "100";
                viewX.Text = "200";
                viewY.Text = "200";
                viewW.Text = "100";
                viewH.Text = "100";
                this.enableCheckBox.Checked = true;
                item.targetX = Int32.Parse(targetX.Text);
                item.targetY = Int32.Parse(targetY.Text);
                item.targetW = Int32.Parse(targetW.Text);
                item.targetH = Int32.Parse(targetH.Text);
                item.viewX = Int32.Parse(viewX.Text);
                item.viewX = Int32.Parse(viewY.Text);
                item.viewW = Int32.Parse(viewW.Text);
                item.viewH = Int32.Parse(viewH.Text);
                item.enable = this.enableCheckBox.Checked;
            }

        }
        private void InitializeTrayIcon()
        {
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Exit", null, OnExitClicked);

            trayIcon = new NotifyIcon
            {
                Text = "MirrorClip",
                Icon = new Icon("MirrorClip_MultiSize.ico"), // 아이콘 파일은 실행 파일 경로에 있어야 함
                ContextMenuStrip = trayMenu,
                Visible = true
            };

            trayIcon.DoubleClick += (s, e) => {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            };
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            base.OnFormClosing(e);
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Application.Exit();
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
            item.viewW = Int32.Parse(viewW.Text);
            item.viewH = Int32.Parse(viewH.Text);
            item.enable = this.enableCheckBox.Checked;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            item = new Item();
            updateItem();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            updateItem();
        }

        private void targetSettingButton_Click(object sender, EventArgs e)
        {
            if(selectAreaForm.ShowDialog() == DialogResult.Yes)
            {
                targetX.Text = selectAreaForm.Left.ToString();
                targetY.Text = selectAreaForm.Top.ToString();
                targetW.Text = selectAreaForm.Width.ToString();
                targetH.Text = selectAreaForm.Height.ToString();
            }
        }

        private void viewSettingButton_Click(object sender, EventArgs e)
        {
            if (selectAreaForm.ShowDialog() == DialogResult.Yes)
            {
                viewX.Text = selectAreaForm.Left.ToString();
                viewY.Text = selectAreaForm.Top.ToString();
                viewW.Text = selectAreaForm.Width.ToString();
                viewH.Text = selectAreaForm.Height.ToString();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            targetSettingButton.Enabled = false;
            viewSettingButton.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            targetSettingButton.Enabled = true;
            viewSettingButton.Enabled = true;
        }
    }
}
