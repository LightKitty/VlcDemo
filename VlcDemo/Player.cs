using LightLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace VlcDemo
{
    public partial class Player : Form
    {
        private bool stdin; // Standard input pipe

        public Player()
        {
            InitializeComponent();
        }

        public Player(bool stdin)
        {
            this.stdin = stdin;

            InitializeComponent();
        }

        /// <summary>
        /// Looks for the vlc directory on the opening of the app
        /// Opens a dialog if the libvlc folder is not found for the user to pick the good one
        /// Folder for 32bits should be "libvlc\win-x86\" and "libvlc\win-x64\" for 64 bits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myVlcControl_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;

            if (currentDirectory == null)
                return;
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory + @"libvlc\win-x86\");
            else
                e.VlcLibDirectory = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory + @"libvlc\win-x64\");

            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Vlc libraries folder.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(stdin) vlcControl1.Play("fd://0"); // Standard input pipe
        }
    }
}
