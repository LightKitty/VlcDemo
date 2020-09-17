namespace VlcDemo
{
    partial class Player
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.VlcControl = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.VlcControl)).BeginInit();
            this.SuspendLayout();
            // 
            // VlcControl
            // 
            this.VlcControl.BackColor = System.Drawing.Color.Black;
            this.VlcControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VlcControl.Location = new System.Drawing.Point(0, 0);
            this.VlcControl.Name = "VlcControl";
            this.VlcControl.Size = new System.Drawing.Size(800, 450);
            this.VlcControl.Spu = -1;
            this.VlcControl.TabIndex = 0;
            this.VlcControl.Text = "vlcControl1";
            this.VlcControl.VlcLibDirectory = null;
            this.VlcControl.VlcMediaplayerOptions = null;
            this.VlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VlcControl_VlcLibDirectoryNeeded);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VlcControl);
            this.Name = "Player";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VlcControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl VlcControl;
    }
}

