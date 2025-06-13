
namespace MirrorClip
{
    partial class MirrorClipForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MirrorClipForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.itemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.modifyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.viewFieldLayout = new System.Windows.Forms.TableLayoutPanel();
            this.viewLabelHeight = new System.Windows.Forms.Label();
            this.viewLabelWidth = new System.Windows.Forms.Label();
            this.viewLabelY = new System.Windows.Forms.Label();
            this.viewLabelX = new System.Windows.Forms.Label();
            this.viewX = new System.Windows.Forms.TextBox();
            this.viewY = new System.Windows.Forms.TextBox();
            this.viewW = new System.Windows.Forms.TextBox();
            this.viewH = new System.Windows.Forms.TextBox();
            this.targetSettingLabel = new System.Windows.Forms.Label();
            this.targetSettingButton = new System.Windows.Forms.Button();
            this.targetFieldLayout = new System.Windows.Forms.TableLayoutPanel();
            this.targetLabelHeight = new System.Windows.Forms.Label();
            this.targetLabelWidth = new System.Windows.Forms.Label();
            this.targetLabelY = new System.Windows.Forms.Label();
            this.targetLabelX = new System.Windows.Forms.Label();
            this.targetX = new System.Windows.Forms.TextBox();
            this.targetY = new System.Windows.Forms.TextBox();
            this.targetW = new System.Windows.Forms.TextBox();
            this.targetH = new System.Windows.Forms.TextBox();
            this.viewSettingLabel = new System.Windows.Forms.Label();
            this.viewSettingButton = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FilterList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.itemTableLayoutPanel.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.viewFieldLayout.SuspendLayout();
            this.targetFieldLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.875F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.125F));
            this.mainTableLayoutPanel.Controls.Add(this.itemTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // itemTableLayoutPanel
            // 
            this.itemTableLayoutPanel.ColumnCount = 1;
            this.itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemTableLayoutPanel.Controls.Add(this.mainLayout, 0, 0);
            this.itemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemTableLayoutPanel.Location = new System.Drawing.Point(191, 0);
            this.itemTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.itemTableLayoutPanel.Name = "itemTableLayoutPanel";
            this.itemTableLayoutPanel.RowCount = 1;
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.itemTableLayoutPanel.Size = new System.Drawing.Size(609, 450);
            this.itemTableLayoutPanel.TabIndex = 5;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.tableLayoutPanel1, 0, 9);
            this.mainLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.mainLayout.Controls.Add(this.viewFieldLayout, 0, 7);
            this.mainLayout.Controls.Add(this.targetSettingLabel, 0, 2);
            this.mainLayout.Controls.Add(this.targetSettingButton, 0, 3);
            this.mainLayout.Controls.Add(this.targetFieldLayout, 0, 4);
            this.mainLayout.Controls.Add(this.viewSettingLabel, 0, 5);
            this.mainLayout.Controls.Add(this.viewSettingButton, 0, 6);
            this.mainLayout.Controls.Add(this.enableCheckBox, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(3, 3);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 10;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.Size = new System.Drawing.Size(603, 444);
            this.mainLayout.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.Controls.Add(this.modifyButton, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.removeButton, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.addButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(603, 21);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // modifyButton
            // 
            this.modifyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyButton.Location = new System.Drawing.Point(463, 0);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(70, 21);
            this.modifyButton.TabIndex = 13;
            this.modifyButton.Text = "modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(533, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(70, 21);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(2, 2);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(393, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 21);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(100, 0);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(293, 21);
            this.nameTextBox.TabIndex = 11;
            // 
            // viewFieldLayout
            // 
            this.viewFieldLayout.ColumnCount = 8;
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.viewFieldLayout.Controls.Add(this.viewLabelHeight, 6, 0);
            this.viewFieldLayout.Controls.Add(this.viewLabelWidth, 4, 0);
            this.viewFieldLayout.Controls.Add(this.viewLabelY, 2, 0);
            this.viewFieldLayout.Controls.Add(this.viewLabelX, 0, 0);
            this.viewFieldLayout.Controls.Add(this.viewX, 1, 0);
            this.viewFieldLayout.Controls.Add(this.viewY, 3, 0);
            this.viewFieldLayout.Controls.Add(this.viewW, 5, 0);
            this.viewFieldLayout.Controls.Add(this.viewH, 7, 0);
            this.viewFieldLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewFieldLayout.Location = new System.Drawing.Point(0, 192);
            this.viewFieldLayout.Margin = new System.Windows.Forms.Padding(0);
            this.viewFieldLayout.Name = "viewFieldLayout";
            this.viewFieldLayout.RowCount = 1;
            this.viewFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.viewFieldLayout.Size = new System.Drawing.Size(603, 21);
            this.viewFieldLayout.TabIndex = 5;
            // 
            // viewLabelHeight
            // 
            this.viewLabelHeight.AutoSize = true;
            this.viewLabelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelHeight.Location = new System.Drawing.Point(452, 2);
            this.viewLabelHeight.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelHeight.Name = "viewLabelHeight";
            this.viewLabelHeight.Size = new System.Drawing.Size(71, 17);
            this.viewLabelHeight.TabIndex = 13;
            this.viewLabelHeight.Text = "Height";
            this.viewLabelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewLabelWidth
            // 
            this.viewLabelWidth.AutoSize = true;
            this.viewLabelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelWidth.Location = new System.Drawing.Point(302, 2);
            this.viewLabelWidth.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelWidth.Name = "viewLabelWidth";
            this.viewLabelWidth.Size = new System.Drawing.Size(71, 17);
            this.viewLabelWidth.TabIndex = 12;
            this.viewLabelWidth.Text = "Width";
            this.viewLabelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewLabelY
            // 
            this.viewLabelY.AutoSize = true;
            this.viewLabelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelY.Location = new System.Drawing.Point(152, 2);
            this.viewLabelY.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelY.Name = "viewLabelY";
            this.viewLabelY.Size = new System.Drawing.Size(71, 17);
            this.viewLabelY.TabIndex = 11;
            this.viewLabelY.Text = "Y";
            this.viewLabelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewLabelX
            // 
            this.viewLabelX.AutoSize = true;
            this.viewLabelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelX.Location = new System.Drawing.Point(2, 2);
            this.viewLabelX.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelX.Name = "viewLabelX";
            this.viewLabelX.Size = new System.Drawing.Size(71, 17);
            this.viewLabelX.TabIndex = 10;
            this.viewLabelX.Text = "X";
            this.viewLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewX
            // 
            this.viewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewX.Location = new System.Drawing.Point(75, 0);
            this.viewX.Margin = new System.Windows.Forms.Padding(0);
            this.viewX.Name = "viewX";
            this.viewX.ReadOnly = true;
            this.viewX.Size = new System.Drawing.Size(75, 21);
            this.viewX.TabIndex = 1;
            // 
            // viewY
            // 
            this.viewY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewY.Location = new System.Drawing.Point(225, 0);
            this.viewY.Margin = new System.Windows.Forms.Padding(0);
            this.viewY.Name = "viewY";
            this.viewY.ReadOnly = true;
            this.viewY.Size = new System.Drawing.Size(75, 21);
            this.viewY.TabIndex = 3;
            // 
            // viewW
            // 
            this.viewW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewW.Location = new System.Drawing.Point(375, 0);
            this.viewW.Margin = new System.Windows.Forms.Padding(0);
            this.viewW.Name = "viewW";
            this.viewW.ReadOnly = true;
            this.viewW.Size = new System.Drawing.Size(75, 21);
            this.viewW.TabIndex = 5;
            // 
            // viewH
            // 
            this.viewH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewH.Location = new System.Drawing.Point(525, 0);
            this.viewH.Margin = new System.Windows.Forms.Padding(0);
            this.viewH.Name = "viewH";
            this.viewH.ReadOnly = true;
            this.viewH.Size = new System.Drawing.Size(78, 21);
            this.viewH.TabIndex = 7;
            // 
            // targetSettingLabel
            // 
            this.targetSettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetSettingLabel.Location = new System.Drawing.Point(3, 54);
            this.targetSettingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.targetSettingLabel.Name = "targetSettingLabel";
            this.targetSettingLabel.Size = new System.Drawing.Size(597, 24);
            this.targetSettingLabel.TabIndex = 0;
            this.targetSettingLabel.Text = "Target";
            this.targetSettingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // targetSettingButton
            // 
            this.targetSettingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetSettingButton.Location = new System.Drawing.Point(3, 84);
            this.targetSettingButton.Name = "targetSettingButton";
            this.targetSettingButton.Size = new System.Drawing.Size(597, 24);
            this.targetSettingButton.TabIndex = 1;
            this.targetSettingButton.Text = "설정";
            this.targetSettingButton.UseVisualStyleBackColor = true;
            this.targetSettingButton.Click += new System.EventHandler(this.targetSettingButton_Click);
            // 
            // targetFieldLayout
            // 
            this.targetFieldLayout.ColumnCount = 8;
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.targetFieldLayout.Controls.Add(this.targetLabelHeight, 6, 0);
            this.targetFieldLayout.Controls.Add(this.targetLabelWidth, 4, 0);
            this.targetFieldLayout.Controls.Add(this.targetLabelY, 2, 0);
            this.targetFieldLayout.Controls.Add(this.targetLabelX, 0, 0);
            this.targetFieldLayout.Controls.Add(this.targetX, 1, 0);
            this.targetFieldLayout.Controls.Add(this.targetY, 3, 0);
            this.targetFieldLayout.Controls.Add(this.targetW, 5, 0);
            this.targetFieldLayout.Controls.Add(this.targetH, 7, 0);
            this.targetFieldLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetFieldLayout.Location = new System.Drawing.Point(0, 111);
            this.targetFieldLayout.Margin = new System.Windows.Forms.Padding(0);
            this.targetFieldLayout.Name = "targetFieldLayout";
            this.targetFieldLayout.RowCount = 1;
            this.targetFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.targetFieldLayout.Size = new System.Drawing.Size(603, 21);
            this.targetFieldLayout.TabIndex = 2;
            // 
            // targetLabelHeight
            // 
            this.targetLabelHeight.AutoSize = true;
            this.targetLabelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelHeight.Location = new System.Drawing.Point(452, 2);
            this.targetLabelHeight.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelHeight.Name = "targetLabelHeight";
            this.targetLabelHeight.Size = new System.Drawing.Size(71, 17);
            this.targetLabelHeight.TabIndex = 13;
            this.targetLabelHeight.Text = "Height";
            this.targetLabelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabelWidth
            // 
            this.targetLabelWidth.AutoSize = true;
            this.targetLabelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelWidth.Location = new System.Drawing.Point(302, 2);
            this.targetLabelWidth.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelWidth.Name = "targetLabelWidth";
            this.targetLabelWidth.Size = new System.Drawing.Size(71, 17);
            this.targetLabelWidth.TabIndex = 12;
            this.targetLabelWidth.Text = "Width";
            this.targetLabelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabelY
            // 
            this.targetLabelY.AutoSize = true;
            this.targetLabelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelY.Location = new System.Drawing.Point(152, 2);
            this.targetLabelY.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelY.Name = "targetLabelY";
            this.targetLabelY.Size = new System.Drawing.Size(71, 17);
            this.targetLabelY.TabIndex = 11;
            this.targetLabelY.Text = "Y";
            this.targetLabelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabelX
            // 
            this.targetLabelX.AutoSize = true;
            this.targetLabelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelX.Location = new System.Drawing.Point(2, 2);
            this.targetLabelX.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelX.Name = "targetLabelX";
            this.targetLabelX.Size = new System.Drawing.Size(71, 17);
            this.targetLabelX.TabIndex = 10;
            this.targetLabelX.Text = "X";
            this.targetLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetX
            // 
            this.targetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetX.Location = new System.Drawing.Point(75, 0);
            this.targetX.Margin = new System.Windows.Forms.Padding(0);
            this.targetX.Name = "targetX";
            this.targetX.ReadOnly = true;
            this.targetX.Size = new System.Drawing.Size(75, 21);
            this.targetX.TabIndex = 1;
            // 
            // targetY
            // 
            this.targetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetY.Location = new System.Drawing.Point(225, 0);
            this.targetY.Margin = new System.Windows.Forms.Padding(0);
            this.targetY.Name = "targetY";
            this.targetY.ReadOnly = true;
            this.targetY.Size = new System.Drawing.Size(75, 21);
            this.targetY.TabIndex = 3;
            // 
            // targetW
            // 
            this.targetW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetW.Location = new System.Drawing.Point(375, 0);
            this.targetW.Margin = new System.Windows.Forms.Padding(0);
            this.targetW.Name = "targetW";
            this.targetW.ReadOnly = true;
            this.targetW.Size = new System.Drawing.Size(75, 21);
            this.targetW.TabIndex = 5;
            // 
            // targetH
            // 
            this.targetH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetH.Location = new System.Drawing.Point(525, 0);
            this.targetH.Margin = new System.Windows.Forms.Padding(0);
            this.targetH.Name = "targetH";
            this.targetH.ReadOnly = true;
            this.targetH.Size = new System.Drawing.Size(78, 21);
            this.targetH.TabIndex = 7;
            // 
            // viewSettingLabel
            // 
            this.viewSettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSettingLabel.Location = new System.Drawing.Point(3, 135);
            this.viewSettingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.viewSettingLabel.Name = "viewSettingLabel";
            this.viewSettingLabel.Size = new System.Drawing.Size(597, 24);
            this.viewSettingLabel.TabIndex = 3;
            this.viewSettingLabel.Text = "View";
            this.viewSettingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // viewSettingButton
            // 
            this.viewSettingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSettingButton.Location = new System.Drawing.Point(3, 165);
            this.viewSettingButton.Name = "viewSettingButton";
            this.viewSettingButton.Size = new System.Drawing.Size(597, 24);
            this.viewSettingButton.TabIndex = 4;
            this.viewSettingButton.Text = "설정";
            this.viewSettingButton.UseVisualStyleBackColor = true;
            this.viewSettingButton.Click += new System.EventHandler(this.viewSettingButton_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enableCheckBox.Location = new System.Drawing.Point(3, 24);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(597, 24);
            this.enableCheckBox.TabIndex = 15;
            this.enableCheckBox.Text = "Enable";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FilterList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 450);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // FilterList
            // 
            this.FilterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterList.FormattingEnabled = true;
            this.FilterList.ItemHeight = 12;
            this.FilterList.Location = new System.Drawing.Point(0, 0);
            this.FilterList.Margin = new System.Windows.Forms.Padding(0);
            this.FilterList.Name = "FilterList";
            this.FilterList.Size = new System.Drawing.Size(191, 450);
            this.FilterList.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 394);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 50);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(0, 0);
            this.StartButton.Margin = new System.Windows.Forms.Padding(0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Location = new System.Drawing.Point(200, 0);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(200, 50);
            this.StopButton.TabIndex = 15;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(400, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(203, 50);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MirrorClipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MirrorClipForm";
            this.Text = "MirrorClip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MirrorClipForm_FormClosed);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.itemTableLayoutPanel.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.viewFieldLayout.ResumeLayout(false);
            this.viewFieldLayout.PerformLayout();
            this.targetFieldLayout.ResumeLayout(false);
            this.targetFieldLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel itemTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox FilterList;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TableLayoutPanel viewFieldLayout;
        private System.Windows.Forms.Label viewLabelHeight;
        private System.Windows.Forms.Label viewLabelWidth;
        private System.Windows.Forms.Label viewLabelY;
        private System.Windows.Forms.Label viewLabelX;
        private System.Windows.Forms.TextBox viewX;
        private System.Windows.Forms.TextBox viewY;
        private System.Windows.Forms.TextBox viewW;
        private System.Windows.Forms.TextBox viewH;
        private System.Windows.Forms.Label targetSettingLabel;
        private System.Windows.Forms.Button targetSettingButton;
        private System.Windows.Forms.TableLayoutPanel targetFieldLayout;
        private System.Windows.Forms.Label targetLabelHeight;
        private System.Windows.Forms.Label targetLabelWidth;
        private System.Windows.Forms.Label targetLabelY;
        private System.Windows.Forms.Label targetLabelX;
        private System.Windows.Forms.TextBox targetX;
        private System.Windows.Forms.TextBox targetY;
        private System.Windows.Forms.TextBox targetW;
        private System.Windows.Forms.TextBox targetH;
        private System.Windows.Forms.Label viewSettingLabel;
        private System.Windows.Forms.Button viewSettingButton;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.Button SaveButton;
    }
}

