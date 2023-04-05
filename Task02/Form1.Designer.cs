namespace Task02
{
    partial class Form1
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
            this.cmsForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removePanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsForm.SuspendLayout();
            this.cmsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsForm
            // 
            this.cmsForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPanelsToolStripMenuItem,
            this.removePanelsToolStripMenuItem});
            this.cmsForm.Name = "cmsForm";
            this.cmsForm.Size = new System.Drawing.Size(155, 48);
            // 
            // addPanelsToolStripMenuItem
            // 
            this.addPanelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelToolStripMenuItem,
            this.panelsToolStripMenuItem,
            this.panelsToolStripMenuItem1});
            this.addPanelsToolStripMenuItem.Name = "addPanelsToolStripMenuItem";
            this.addPanelsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addPanelsToolStripMenuItem.Text = "Add Panels";
            // 
            // panelToolStripMenuItem
            // 
            this.panelToolStripMenuItem.Name = "panelToolStripMenuItem";
            this.panelToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.panelToolStripMenuItem.Tag = "1";
            this.panelToolStripMenuItem.Text = "1 panel";
            this.panelToolStripMenuItem.Click += new System.EventHandler(this.cmsFormItem_Click);
            // 
            // panelsToolStripMenuItem
            // 
            this.panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            this.panelsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.panelsToolStripMenuItem.Tag = "5";
            this.panelsToolStripMenuItem.Text = "5 panels";
            this.panelsToolStripMenuItem.Click += new System.EventHandler(this.cmsFormItem_Click);
            // 
            // panelsToolStripMenuItem1
            // 
            this.panelsToolStripMenuItem1.Name = "panelsToolStripMenuItem1";
            this.panelsToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.panelsToolStripMenuItem1.Tag = "10";
            this.panelsToolStripMenuItem1.Text = "10 panels";
            this.panelsToolStripMenuItem1.Click += new System.EventHandler(this.cmsFormItem_Click);
            // 
            // removePanelsToolStripMenuItem
            // 
            this.removePanelsToolStripMenuItem.Name = "removePanelsToolStripMenuItem";
            this.removePanelsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removePanelsToolStripMenuItem.Text = "Remove Panels";
            this.removePanelsToolStripMenuItem.Click += new System.EventHandler(this.removePanelsToolStripMenuItem_Click);
            // 
            // cmsPanel
            // 
            this.cmsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.cmsPanel.Name = "cmsPanel";
            this.cmsPanel.Size = new System.Drawing.Size(181, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmsForm;
            this.Name = "Form1";
            this.Text = "Panel Creator";
            this.cmsForm.ResumeLayout(false);
            this.cmsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip cmsForm;
        private ToolStripMenuItem addPanelsToolStripMenuItem;
        private ToolStripMenuItem panelToolStripMenuItem;
        private ToolStripMenuItem panelsToolStripMenuItem;
        private ToolStripMenuItem panelsToolStripMenuItem1;
        private ToolStripMenuItem removePanelsToolStripMenuItem;
        private ContextMenuStrip cmsPanel;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}