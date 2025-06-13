
namespace MirrorClip.Control
{
    partial class SelectAreaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.complateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // complateButton
            // 
            this.complateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complateButton.Location = new System.Drawing.Point(0, 0);
            this.complateButton.Name = "complateButton";
            this.complateButton.Size = new System.Drawing.Size(391, 207);
            this.complateButton.TabIndex = 0;
            this.complateButton.Text = "Select";
            this.complateButton.UseVisualStyleBackColor = true;
            this.complateButton.Click += new System.EventHandler(this.complateButton_Click);
            // 
            // SelectAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 207);
            this.Controls.Add(this.complateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectAreaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SelectAreaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button complateButton;
    }
}