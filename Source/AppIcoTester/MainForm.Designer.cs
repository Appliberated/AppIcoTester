
namespace AppIcoTester
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.openIconFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseIconButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewNotificationArea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "AppIcoTester";
            this.notifyIcon.Visible = true;
            // 
            // openIconFileDialog
            // 
            this.openIconFileDialog.Filter = "\"Windows Icon (*.ico)|*.ico|All files (*.*)|*.*\"";
            // 
            // chooseIconButton
            // 
            this.chooseIconButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseIconButton.AutoSize = true;
            this.chooseIconButton.Location = new System.Drawing.Point(341, 180);
            this.chooseIconButton.Name = "chooseIconButton";
            this.chooseIconButton.Padding = new System.Windows.Forms.Padding(10);
            this.chooseIconButton.Size = new System.Drawing.Size(119, 45);
            this.chooseIconButton.TabIndex = 0;
            this.chooseIconButton.Text = "Choose an icon";
            this.chooseIconButton.UseVisualStyleBackColor = true;
            this.chooseIconButton.Click += new System.EventHandler(this.ChooseIconButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(341, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "or drag it here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(93, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewTaskbar,
            this.menuViewNotificationArea});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuViewTaskbar
            // 
            this.menuViewTaskbar.Checked = true;
            this.menuViewTaskbar.CheckOnClick = true;
            this.menuViewTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuViewTaskbar.Name = "menuViewTaskbar";
            this.menuViewTaskbar.Size = new System.Drawing.Size(205, 22);
            this.menuViewTaskbar.Text = "Show in taskbar";
            this.menuViewTaskbar.Click += new System.EventHandler(this.MenuViewTaskbar_Click);
            // 
            // menuViewNotificationArea
            // 
            this.menuViewNotificationArea.Checked = true;
            this.menuViewNotificationArea.CheckOnClick = true;
            this.menuViewNotificationArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuViewNotificationArea.Name = "menuViewNotificationArea";
            this.menuViewNotificationArea.Size = new System.Drawing.Size(205, 22);
            this.menuViewNotificationArea.Text = "Show in notification area";
            this.menuViewNotificationArea.Click += new System.EventHandler(this.MenuViewNotificationArea_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseIconButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "AppIcoTester";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.OpenFileDialog openIconFileDialog;
        private System.Windows.Forms.Button chooseIconButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuViewTaskbar;
        private System.Windows.Forms.ToolStripMenuItem menuViewNotificationArea;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
    }
}

