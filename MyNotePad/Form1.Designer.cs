namespace MyNotePad
{
    partial class Form1
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
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlOAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlSAction = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAction = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlCAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlPAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlZAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlAAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlXAction = new System.Windows.Forms.ToolStripMenuItem();
            this.appearance = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.background = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Location = new System.Drawing.Point(0, 40);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(800, 560);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.appearance});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 40);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlOAction,
            this.ctrlSAction,
            this.exitAction});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(71, 36);
            this.file.Text = "File";
            // 
            // ctrlOAction
            // 
            this.ctrlOAction.Name = "ctrlOAction";
            this.ctrlOAction.Size = new System.Drawing.Size(291, 44);
            this.ctrlOAction.Text = "Ctrl+O(Open)";
            this.ctrlOAction.Click += new System.EventHandler(this.openMenuItemClick);
            // 
            // ctrlSAction
            // 
            this.ctrlSAction.Name = "ctrlSAction";
            this.ctrlSAction.Size = new System.Drawing.Size(291, 44);
            this.ctrlSAction.Text = "Ctrl+S(Save)";
            this.ctrlSAction.Click += new System.EventHandler(this.saveMenuItemClick);
            // 
            // exitAction
            // 
            this.exitAction.Name = "exitAction";
            this.exitAction.Size = new System.Drawing.Size(291, 44);
            this.exitAction.Text = "Alt+F4(Exit)";
            this.exitAction.Click += new System.EventHandler(this.exitMenuItemClick);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlCAction,
            this.ctrlPAction,
            this.ctrlZAction,
            this.ctrlAAction,
            this.ctrlXAction});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(74, 36);
            this.edit.Text = "Edit";
            // 
            // ctrlCAction
            // 
            this.ctrlCAction.Name = "ctrlCAction";
            this.ctrlCAction.Size = new System.Drawing.Size(242, 44);
            this.ctrlCAction.Text = "Copy";
            this.ctrlCAction.Click += new System.EventHandler(this.copyMenuItemClick);
            // 
            // ctrlPAction
            // 
            this.ctrlPAction.Name = "ctrlPAction";
            this.ctrlPAction.Size = new System.Drawing.Size(242, 44);
            this.ctrlPAction.Text = "Paste";
            this.ctrlPAction.Click += new System.EventHandler(this.pasteMenuItemClick);
            // 
            // ctrlZAction
            // 
            this.ctrlZAction.Name = "ctrlZAction";
            this.ctrlZAction.Size = new System.Drawing.Size(242, 44);
            this.ctrlZAction.Text = "Ctrl + Z";
            this.ctrlZAction.Click += new System.EventHandler(this.ctrlZClick);
            // 
            // ctrlAAction
            // 
            this.ctrlAAction.Name = "ctrlAAction";
            this.ctrlAAction.Size = new System.Drawing.Size(242, 44);
            this.ctrlAAction.Text = "Select all";
            this.ctrlAAction.Click += new System.EventHandler(this.ctrlAClick);
            // 
            // ctrlXAction
            // 
            this.ctrlXAction.Name = "ctrlXAction";
            this.ctrlXAction.Size = new System.Drawing.Size(242, 44);
            this.ctrlXAction.Text = "Cut";
            this.ctrlXAction.Click += new System.EventHandler(this.ctrlXClick);
            // 
            // appearance
            // 
            this.appearance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font,
            this.background});
            this.appearance.Name = "appearance";
            this.appearance.Size = new System.Drawing.Size(160, 36);
            this.appearance.Text = "Appearance";
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(274, 44);
            this.font.Text = "Font";
            this.font.Click += new System.EventHandler(this.fontClick);
            // 
            // background
            // 
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(274, 44);
            this.background.Text = "Background";
            this.background.Click += new System.EventHandler(this.backClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "MyNotePad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        // Creating all the entities.
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem ctrlOAction;
        private System.Windows.Forms.ToolStripMenuItem ctrlSAction;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem ctrlCAction;
        private System.Windows.Forms.ToolStripMenuItem ctrlPAction;
        private System.Windows.Forms.ToolStripMenuItem ctrlZAction;
        private System.Windows.Forms.ToolStripMenuItem ctrlAAction;
        private System.Windows.Forms.ToolStripMenuItem ctrlXAction;
        private System.Windows.Forms.ToolStripMenuItem exitAction;
        private System.Windows.Forms.ToolStripMenuItem appearance;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem background;
    }
}