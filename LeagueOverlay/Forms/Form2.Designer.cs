namespace LeagueOverlay
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zmienWielkoscMapyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.voiceRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BSRocks = new System.Windows.Forms.Label();
            this.BSRaptors = new System.Windows.Forms.Label();
            this.BSWolf = new System.Windows.Forms.Label();
            this.BSFrog = new System.Windows.Forms.Label();
            this.TSRocks = new System.Windows.Forms.Label();
            this.TSRaptors = new System.Windows.Forms.Label();
            this.TSWolfs = new System.Windows.Forms.Label();
            this.TSFrog = new System.Windows.Forms.Label();
            this.turnOffVoiceRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LOL Overlay";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmienWielkoscMapyToolStripMenuItem,
            this.toolStripSeparator2,
            this.showControlsToolStripMenuItem,
            this.hideControlsToolStripMenuItem,
            this.toolStripSeparator3,
            this.voiceRecognitionToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 154);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // zmienWielkoscMapyToolStripMenuItem
            // 
            this.zmienWielkoscMapyToolStripMenuItem.Name = "zmienWielkoscMapyToolStripMenuItem";
            this.zmienWielkoscMapyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zmienWielkoscMapyToolStripMenuItem.Text = "Change timers position";
            this.zmienWielkoscMapyToolStripMenuItem.Click += new System.EventHandler(this.zmienWielkoscMapyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            this.showControlsToolStripMenuItem.Click += new System.EventHandler(this.showControlsToolStripMenuItem_Click);
            // 
            // hideControlsToolStripMenuItem
            // 
            this.hideControlsToolStripMenuItem.Name = "hideControlsToolStripMenuItem";
            this.hideControlsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.hideControlsToolStripMenuItem.Text = "Hide controls";
            this.hideControlsToolStripMenuItem.Click += new System.EventHandler(this.hideControlsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // voiceRecognitionToolStripMenuItem
            // 
            this.voiceRecognitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftSideToolStripMenuItem,
            this.rightSideToolStripMenuItem,
            this.turnOffVoiceRecognitionToolStripMenuItem});
            this.voiceRecognitionToolStripMenuItem.Name = "voiceRecognitionToolStripMenuItem";
            this.voiceRecognitionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.voiceRecognitionToolStripMenuItem.Text = "Voice recognition";
            // 
            // leftSideToolStripMenuItem
            // 
            this.leftSideToolStripMenuItem.Name = "leftSideToolStripMenuItem";
            this.leftSideToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.leftSideToolStripMenuItem.Text = "Left side";
            this.leftSideToolStripMenuItem.Click += new System.EventHandler(this.leftSideToolStripMenuItem_Click);
            // 
            // rightSideToolStripMenuItem
            // 
            this.rightSideToolStripMenuItem.Name = "rightSideToolStripMenuItem";
            this.rightSideToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.rightSideToolStripMenuItem.Text = "Right side";
            this.rightSideToolStripMenuItem.Click += new System.EventHandler(this.rightSideToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // BSRocks
            // 
            this.BSRocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSRocks.AutoSize = true;
            this.BSRocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSRocks.ForeColor = System.Drawing.Color.White;
            this.BSRocks.Location = new System.Drawing.Point(286, 355);
            this.BSRocks.Name = "BSRocks";
            this.BSRocks.Size = new System.Drawing.Size(32, 13);
            this.BSRocks.TabIndex = 1;
            this.BSRocks.Text = "0:00";
            // 
            // BSRaptors
            // 
            this.BSRaptors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSRaptors.AutoSize = true;
            this.BSRaptors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSRaptors.ForeColor = System.Drawing.Color.White;
            this.BSRaptors.Location = new System.Drawing.Point(249, 313);
            this.BSRaptors.Name = "BSRaptors";
            this.BSRaptors.Size = new System.Drawing.Size(32, 13);
            this.BSRaptors.TabIndex = 2;
            this.BSRaptors.Text = "0:00";
            // 
            // BSWolf
            // 
            this.BSWolf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSWolf.AutoSize = true;
            this.BSWolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSWolf.ForeColor = System.Drawing.Color.White;
            this.BSWolf.Location = new System.Drawing.Point(199, 286);
            this.BSWolf.Name = "BSWolf";
            this.BSWolf.Size = new System.Drawing.Size(32, 13);
            this.BSWolf.TabIndex = 3;
            this.BSWolf.Text = "0:00";
            // 
            // BSFrog
            // 
            this.BSFrog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSFrog.AutoSize = true;
            this.BSFrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSFrog.ForeColor = System.Drawing.Color.White;
            this.BSFrog.Location = new System.Drawing.Point(173, 238);
            this.BSFrog.Name = "BSFrog";
            this.BSFrog.Size = new System.Drawing.Size(32, 13);
            this.BSFrog.TabIndex = 4;
            this.BSFrog.Text = "0:00";
            // 
            // TSRocks
            // 
            this.TSRocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TSRocks.AutoSize = true;
            this.TSRocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TSRocks.ForeColor = System.Drawing.Color.White;
            this.TSRocks.Location = new System.Drawing.Point(233, 175);
            this.TSRocks.Name = "TSRocks";
            this.TSRocks.Size = new System.Drawing.Size(32, 13);
            this.TSRocks.TabIndex = 5;
            this.TSRocks.Text = "0:00";
            // 
            // TSRaptors
            // 
            this.TSRaptors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TSRaptors.AutoSize = true;
            this.TSRaptors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TSRaptors.ForeColor = System.Drawing.Color.White;
            this.TSRaptors.Location = new System.Drawing.Point(266, 226);
            this.TSRaptors.Name = "TSRaptors";
            this.TSRaptors.Size = new System.Drawing.Size(32, 13);
            this.TSRaptors.TabIndex = 6;
            this.TSRaptors.Text = "0:00";
            // 
            // TSWolfs
            // 
            this.TSWolfs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TSWolfs.AutoSize = true;
            this.TSWolfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TSWolfs.ForeColor = System.Drawing.Color.White;
            this.TSWolfs.Location = new System.Drawing.Point(330, 251);
            this.TSWolfs.Name = "TSWolfs";
            this.TSWolfs.Size = new System.Drawing.Size(32, 13);
            this.TSWolfs.TabIndex = 7;
            this.TSWolfs.Text = "0:00";
            // 
            // TSFrog
            // 
            this.TSFrog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TSFrog.AutoSize = true;
            this.TSFrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TSFrog.ForeColor = System.Drawing.Color.White;
            this.TSFrog.Location = new System.Drawing.Point(357, 286);
            this.TSFrog.Name = "TSFrog";
            this.TSFrog.Size = new System.Drawing.Size(32, 13);
            this.TSFrog.TabIndex = 8;
            this.TSFrog.Text = "0:00";
            this.TSFrog.Click += new System.EventHandler(this.label8_Click);
            // 
            // turnOffVoiceRecognitionToolStripMenuItem
            // 
            this.turnOffVoiceRecognitionToolStripMenuItem.Name = "turnOffVoiceRecognitionToolStripMenuItem";
            this.turnOffVoiceRecognitionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.turnOffVoiceRecognitionToolStripMenuItem.Text = "Turn off voice recognition";
            this.turnOffVoiceRecognitionToolStripMenuItem.Click += new System.EventHandler(this.turnOffVoiceRecognitionToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.TSFrog);
            this.Controls.Add(this.TSWolfs);
            this.Controls.Add(this.TSRaptors);
            this.Controls.Add(this.TSRocks);
            this.Controls.Add(this.BSFrog);
            this.Controls.Add(this.BSWolf);
            this.Controls.Add(this.BSRaptors);
            this.Controls.Add(this.BSRocks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zmienWielkoscMapyToolStripMenuItem;
        public System.Windows.Forms.Label BSRocks;
        public System.Windows.Forms.Label BSRaptors;
        public System.Windows.Forms.Label BSWolf;
        public  System.Windows.Forms.Label BSFrog;
        public System.Windows.Forms.Label TSRocks;
        public System.Windows.Forms.Label TSRaptors;
        public System.Windows.Forms.Label TSWolfs;
        public System.Windows.Forms.Label TSFrog;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voiceRecognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem leftSideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightSideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem turnOffVoiceRecognitionToolStripMenuItem;
    }
}