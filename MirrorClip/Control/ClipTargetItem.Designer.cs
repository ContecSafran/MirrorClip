
namespace MirrorClip
{
    partial class ClipTargetItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label targetSettingLabel;
        private System.Windows.Forms.Button targetSettingButton;
        private System.Windows.Forms.TableLayoutPanel targetFieldLayout;
        private System.Windows.Forms.Label viewSettingLabel;
        private System.Windows.Forms.Button viewSettingButton;
        private System.Windows.Forms.TextBox targetX, targetY, targetW, targetH;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.viewFieldLayout = new System.Windows.Forms.TableLayoutPanel();
            this.viewLabelHeight = new System.Windows.Forms.Label();
            this.viewLabelWidth = new System.Windows.Forms.Label();
            this.viewLabelY = new System.Windows.Forms.Label();
            this.viewLabelX = new System.Windows.Forms.Label();
            this.viewX = new System.Windows.Forms.TextBox();
            this.viewY = new System.Windows.Forms.TextBox();
            this.viewWidth = new System.Windows.Forms.TextBox();
            this.viewHeight = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.viewFieldLayout.SuspendLayout();
            this.targetFieldLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.mainLayout.Controls.Add(this.viewFieldLayout, 0, 7);
            this.mainLayout.Controls.Add(this.targetSettingLabel, 0, 2);
            this.mainLayout.Controls.Add(this.targetSettingButton, 0, 3);
            this.mainLayout.Controls.Add(this.targetFieldLayout, 0, 4);
            this.mainLayout.Controls.Add(this.viewSettingLabel, 0, 5);
            this.mainLayout.Controls.Add(this.viewSettingButton, 0, 6);
            this.mainLayout.Controls.Add(this.enableCheckBox, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 9;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(596, 236);
            this.mainLayout.TabIndex = 0;
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
            this.viewFieldLayout.Controls.Add(this.viewWidth, 5, 0);
            this.viewFieldLayout.Controls.Add(this.viewHeight, 7, 0);
            this.viewFieldLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewFieldLayout.Location = new System.Drawing.Point(0, 192);
            this.viewFieldLayout.Margin = new System.Windows.Forms.Padding(0);
            this.viewFieldLayout.Name = "viewFieldLayout";
            this.viewFieldLayout.RowCount = 1;
            this.viewFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewFieldLayout.Size = new System.Drawing.Size(596, 21);
            this.viewFieldLayout.TabIndex = 5;
            // 
            // viewLabelHeight
            // 
            this.viewLabelHeight.AutoSize = true;
            this.viewLabelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelHeight.Location = new System.Drawing.Point(446, 2);
            this.viewLabelHeight.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelHeight.Name = "viewLabelHeight";
            this.viewLabelHeight.Size = new System.Drawing.Size(70, 17);
            this.viewLabelHeight.TabIndex = 13;
            this.viewLabelHeight.Text = "Height";
            this.viewLabelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewLabelWidth
            // 
            this.viewLabelWidth.AutoSize = true;
            this.viewLabelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelWidth.Location = new System.Drawing.Point(298, 2);
            this.viewLabelWidth.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelWidth.Name = "viewLabelWidth";
            this.viewLabelWidth.Size = new System.Drawing.Size(70, 17);
            this.viewLabelWidth.TabIndex = 12;
            this.viewLabelWidth.Text = "Width";
            this.viewLabelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewLabelY
            // 
            this.viewLabelY.AutoSize = true;
            this.viewLabelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabelY.Location = new System.Drawing.Point(150, 2);
            this.viewLabelY.Margin = new System.Windows.Forms.Padding(2);
            this.viewLabelY.Name = "viewLabelY";
            this.viewLabelY.Size = new System.Drawing.Size(70, 17);
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
            this.viewLabelX.Size = new System.Drawing.Size(70, 17);
            this.viewLabelX.TabIndex = 10;
            this.viewLabelX.Text = "X";
            this.viewLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewX
            // 
            this.viewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewX.Location = new System.Drawing.Point(74, 0);
            this.viewX.Margin = new System.Windows.Forms.Padding(0);
            this.viewX.Name = "viewX";
            this.viewX.ReadOnly = true;
            this.viewX.Size = new System.Drawing.Size(74, 21);
            this.viewX.TabIndex = 1;
            // 
            // viewY
            // 
            this.viewY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewY.Location = new System.Drawing.Point(222, 0);
            this.viewY.Margin = new System.Windows.Forms.Padding(0);
            this.viewY.Name = "viewY";
            this.viewY.ReadOnly = true;
            this.viewY.Size = new System.Drawing.Size(74, 21);
            this.viewY.TabIndex = 3;
            // 
            // viewWidth
            // 
            this.viewWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewWidth.Location = new System.Drawing.Point(370, 0);
            this.viewWidth.Margin = new System.Windows.Forms.Padding(0);
            this.viewWidth.Name = "viewWidth";
            this.viewWidth.ReadOnly = true;
            this.viewWidth.Size = new System.Drawing.Size(74, 21);
            this.viewWidth.TabIndex = 5;
            // 
            // viewHeight
            // 
            this.viewHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewHeight.Location = new System.Drawing.Point(518, 0);
            this.viewHeight.Margin = new System.Windows.Forms.Padding(0);
            this.viewHeight.Name = "viewHeight";
            this.viewHeight.ReadOnly = true;
            this.viewHeight.Size = new System.Drawing.Size(78, 21);
            this.viewHeight.TabIndex = 7;
            // 
            // targetSettingLabel
            // 
            this.targetSettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetSettingLabel.Location = new System.Drawing.Point(3, 54);
            this.targetSettingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.targetSettingLabel.Name = "targetSettingLabel";
            this.targetSettingLabel.Size = new System.Drawing.Size(590, 24);
            this.targetSettingLabel.TabIndex = 0;
            this.targetSettingLabel.Text = "Target";
            this.targetSettingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // targetSettingButton
            // 
            this.targetSettingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetSettingButton.Location = new System.Drawing.Point(3, 84);
            this.targetSettingButton.Name = "targetSettingButton";
            this.targetSettingButton.Size = new System.Drawing.Size(590, 24);
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
            this.targetFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.targetFieldLayout.Size = new System.Drawing.Size(596, 21);
            this.targetFieldLayout.TabIndex = 2;
            // 
            // targetLabelHeight
            // 
            this.targetLabelHeight.AutoSize = true;
            this.targetLabelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelHeight.Location = new System.Drawing.Point(446, 2);
            this.targetLabelHeight.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelHeight.Name = "targetLabelHeight";
            this.targetLabelHeight.Size = new System.Drawing.Size(70, 17);
            this.targetLabelHeight.TabIndex = 13;
            this.targetLabelHeight.Text = "Height";
            this.targetLabelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabelWidth
            // 
            this.targetLabelWidth.AutoSize = true;
            this.targetLabelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelWidth.Location = new System.Drawing.Point(298, 2);
            this.targetLabelWidth.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelWidth.Name = "targetLabelWidth";
            this.targetLabelWidth.Size = new System.Drawing.Size(70, 17);
            this.targetLabelWidth.TabIndex = 12;
            this.targetLabelWidth.Text = "Width";
            this.targetLabelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabelY
            // 
            this.targetLabelY.AutoSize = true;
            this.targetLabelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabelY.Location = new System.Drawing.Point(150, 2);
            this.targetLabelY.Margin = new System.Windows.Forms.Padding(2);
            this.targetLabelY.Name = "targetLabelY";
            this.targetLabelY.Size = new System.Drawing.Size(70, 17);
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
            this.targetLabelX.Size = new System.Drawing.Size(70, 17);
            this.targetLabelX.TabIndex = 10;
            this.targetLabelX.Text = "X";
            this.targetLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetX
            // 
            this.targetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetX.Location = new System.Drawing.Point(74, 0);
            this.targetX.Margin = new System.Windows.Forms.Padding(0);
            this.targetX.Name = "targetX";
            this.targetX.ReadOnly = true;
            this.targetX.Size = new System.Drawing.Size(74, 21);
            this.targetX.TabIndex = 1;
            // 
            // targetY
            // 
            this.targetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetY.Location = new System.Drawing.Point(222, 0);
            this.targetY.Margin = new System.Windows.Forms.Padding(0);
            this.targetY.Name = "targetY";
            this.targetY.ReadOnly = true;
            this.targetY.Size = new System.Drawing.Size(74, 21);
            this.targetY.TabIndex = 3;
            // 
            // targetW
            // 
            this.targetW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetW.Location = new System.Drawing.Point(370, 0);
            this.targetW.Margin = new System.Windows.Forms.Padding(0);
            this.targetW.Name = "targetW";
            this.targetW.ReadOnly = true;
            this.targetW.Size = new System.Drawing.Size(74, 21);
            this.targetW.TabIndex = 5;
            // 
            // targetH
            // 
            this.targetH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetH.Location = new System.Drawing.Point(518, 0);
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
            this.viewSettingLabel.Size = new System.Drawing.Size(590, 24);
            this.viewSettingLabel.TabIndex = 3;
            this.viewSettingLabel.Text = "View";
            this.viewSettingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // viewSettingButton
            // 
            this.viewSettingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSettingButton.Location = new System.Drawing.Point(3, 165);
            this.viewSettingButton.Name = "viewSettingButton";
            this.viewSettingButton.Size = new System.Drawing.Size(590, 24);
            this.viewSettingButton.TabIndex = 4;
            this.viewSettingButton.Text = "설정";
            this.viewSettingButton.UseVisualStyleBackColor = true;
            this.viewSettingButton.Click += new System.EventHandler(this.viewSettingButton_Click);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(596, 21);
            this.tableLayoutPanel5.TabIndex = 14;
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
            this.addButton.Location = new System.Drawing.Point(386, 0);
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
            this.nameTextBox.Size = new System.Drawing.Size(286, 21);
            this.nameTextBox.TabIndex = 11;
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enableCheckBox.Location = new System.Drawing.Point(3, 24);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(590, 24);
            this.enableCheckBox.TabIndex = 15;
            this.enableCheckBox.Text = "Enable";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(526, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(70, 21);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyButton.Location = new System.Drawing.Point(456, 0);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(70, 21);
            this.modifyButton.TabIndex = 13;
            this.modifyButton.Text = "modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // ClipTargetItem
            // 
            this.Controls.Add(this.mainLayout);
            this.Name = "ClipTargetItem";
            this.Size = new System.Drawing.Size(596, 236);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.viewFieldLayout.ResumeLayout(false);
            this.viewFieldLayout.PerformLayout();
            this.targetFieldLayout.ResumeLayout(false);
            this.targetFieldLayout.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel viewFieldLayout;
        private System.Windows.Forms.Label viewLabelX;
        private System.Windows.Forms.Label viewLabelY;
        private System.Windows.Forms.Label viewLabelWidth;
        private System.Windows.Forms.Label viewLabelHeight;
        private System.Windows.Forms.TextBox viewX;
        private System.Windows.Forms.TextBox viewY;
        private System.Windows.Forms.TextBox viewWidth;
        private System.Windows.Forms.TextBox viewHeight;
        private System.Windows.Forms.Label targetLabelX;
        private System.Windows.Forms.Label targetLabelY;
        private System.Windows.Forms.Label targetLabelWidth;
        private System.Windows.Forms.Label targetLabelHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modifyButton;
    }
}
