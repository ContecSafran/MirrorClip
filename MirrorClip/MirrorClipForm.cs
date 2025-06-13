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
        CaptureProcess captureProcess = new CaptureProcess();
        OverlayForm overlayForm = new OverlayForm();
        ScreenCapture screenCapture = new ScreenCapture();
        public static string configFile = "config.json";
        public MirrorClipForm()
        {
            InitializeComponent();
            InitializeTrayIcon();
            LoadStatus();
            selectAreaForm.StartPosition = FormStartPosition.Manual;
        }
        public string GetStatusTxtFileName()
        {
            return Directory.GetParent(Application.ExecutablePath) + "\\" + configFile;
        }
        public void SaveStatus()
        {
            item.targetX = Int32.Parse(targetX.Text);
            item.targetY = Int32.Parse(targetY.Text);
            item.targetW = Int32.Parse(targetW.Text);
            item.targetH = Int32.Parse(targetH.Text);
            item.viewX = Int32.Parse(viewX.Text);
            item.viewY = Int32.Parse(viewY.Text);
            item.viewW = Int32.Parse(viewW.Text);
            item.viewH = Int32.Parse(viewH.Text);
            item.enable = this.enableCheckBox.Checked;
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
                viewY.Text = item.viewY.ToString();
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
                item.viewY = Int32.Parse(viewY.Text);
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
            item.viewY = Int32.Parse(viewY.Text);
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
            selectAreaForm.Left = item.targetX;
            selectAreaForm.Top = item.targetY;
            selectAreaForm.Width = item.targetW;
            selectAreaForm.Height = item.targetH;
            if (selectAreaForm.ShowDialog() == DialogResult.Yes)
            {
                int t = selectAreaForm.PointToScreen(Point.Empty).Y;
                int h = selectAreaForm.Height - (t - selectAreaForm.Top - 3);
                targetX.Text = selectAreaForm.Left.ToString();
                targetY.Text = t.ToString();
                targetW.Text = selectAreaForm.Width.ToString();
                targetH.Text = h.ToString();
                item.targetX = selectAreaForm.Left;
                item.targetY = t;
                item.targetW = selectAreaForm.Width;
                item.targetH = h;
            }
        }

        private void viewSettingButton_Click(object sender, EventArgs e)
        {
            selectAreaForm.Left = item.viewX;
            selectAreaForm.Top = item.viewY;
            selectAreaForm.Width = item.viewW;
            selectAreaForm.Height = item.viewH;
            if (selectAreaForm.ShowDialog() == DialogResult.Yes)
            {
                int t = selectAreaForm.PointToScreen(Point.Empty).Y;
                int w = selectAreaForm.Width;
                int h = selectAreaForm.Height;
                float ratio = (float)w / (float)h;
                float referenceRatio = (float)item.targetW / (float)item.targetH;
                h = (int)(w / referenceRatio);
                viewX.Text = selectAreaForm.Left.ToString();
                viewY.Text = selectAreaForm.Top.ToString();
                viewW.Text = w.ToString();
                viewH.Text = h.ToString();
                item.viewX = selectAreaForm.Left;
                item.viewY = t;
                item.viewW = w;
                item.viewH = h;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SaveStatus();
            targetSettingButton.Enabled = false;
            viewSettingButton.Enabled = false;
            screenCapture.Init(item.targetX, item.targetY, item.targetW, item.targetH);
            overlayForm.Show();
            overlayForm.Left = item.viewX;
            overlayForm.Top = item.viewY;
            overlayForm.Width = item.viewW;
            overlayForm.Height = item.viewH;
            captureTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            targetSettingButton.Enabled = true;
            viewSettingButton.Enabled = true;
            captureTimer.Stop();
            overlayForm.Hide();
        }

        private void MirrorClipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            captureProcess.close();
        }

        private void captureTimer_Tick(object sender, EventArgs e)
        {
            screenCapture.Capture();
            overlayForm.reDraw(screenCapture.bmp);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveStatus();
        }
    }
}
