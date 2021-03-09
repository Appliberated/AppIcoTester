// <copyright file="MainForm.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace AppIcoTester
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// The main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.ResizeRedraw = true;
            this.notifyIcon.Icon = this.Icon;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(-25, -25 - (this.menuStrip.Height / 2));
            borderRectangle.Y += this.menuStrip.Height / 2;

            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void ChooseIconButton_Click(object sender, EventArgs e)
        {
            if (this.openIconFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadIcon(this.openIconFileDialog.FileName);
            }
        }

        private void LoadIcon(string fileName)
        {
            try
            {
                switch (Path.GetExtension(fileName).ToUpper())
                {
                    case ".ICO":
                        this.Icon = this.notifyIcon.Icon = new Icon(fileName);
                        break;
                    case ".BMP" or ".GIF" or ".JPG" or ".PNG" or ".TIFF":
                        Bitmap bitmap = (Bitmap)Image.FromFile(fileName);
                        Icon newIcon = Icon.FromHandle(bitmap.GetHicon());
                        this.Icon = this.notifyIcon.Icon = newIcon;
                        PInvoke.DestroyIcon(newIcon.Handle);
                        break;
                    default:
                        this.Icon = this.notifyIcon.Icon = Icon.ExtractAssociatedIcon(fileName);
                        break;
                }

                this.fileNameLabel.Text = fileName;
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                    this,
                    string.Format(Properties.Resources.IconFileLoadError, fileName),
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------
        // Drag & Drop Functionality
        // --------------------------------------------------------------------

        /// <summary>
        /// Informs the system that the main form accepts drag and drop operations with file/folder items.
        /// </summary>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        /// <summary>
        /// Gets the file that was dragged and dropped on the main form and sets it as the application icon.
        /// </summary>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileItems.Length > 0)
            {
                this.LoadIcon(fileItems[0]);
            }
        }

        // --------------------------------------------------------------------
        // File Menu Items
        // --------------------------------------------------------------------

        /// <summary>
        /// File Menu -> Exit
        /// Closes the form and the application.
        /// </summary>
        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --------------------------------------------------------------------
        // View Menu Items
        // --------------------------------------------------------------------

        /// <summary>
        /// File Menu -> Show in taskbar
        /// Displays the form (and the tested icon) in the Windows taskbar.
        /// </summary>
        private void MenuViewTaskbar_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = this.menuViewTaskbar.Checked;
        }

        /// <summary>
        /// File Menu -> Show in notification area
        /// Displays the form (and the tested icon) in the notification area of the taskbar.
        /// </summary>
        private void MenuViewNotificationArea_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = this.menuViewNotificationArea.Checked;
        }

        /// <summary>
        /// Required native (WinAPI) methods and structures.
        /// </summary>
        private static class PInvoke
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool DestroyIcon(IntPtr handle);
        }
    }
}
