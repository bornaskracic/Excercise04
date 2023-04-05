namespace Task01
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
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.msImageOptions = new System.Windows.Forms.MenuStrip();
            this.chooseImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonkey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImageOptions = new System.Windows.Forms.ToolStrip();
            this.tsbFox = new System.Windows.Forms.ToolStripButton();
            this.tsbMonkey = new System.Windows.Forms.ToolStripButton();
            this.tsbTiger = new System.Windows.Forms.ToolStripButton();
            this.cmsImageOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmiFox = new System.Windows.Forms.ToolStripMenuItem();
            this.csmiMonkey = new System.Windows.Forms.ToolStripMenuItem();
            this.csmiTiger = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.msImageOptions.SuspendLayout();
            this.tsImageOptions.SuspendLayout();
            this.cmsImageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Image = global::Task01.Properties.Resources.start;
            this.pbMain.Location = new System.Drawing.Point(12, 48);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(847, 452);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // msImageOptions
            // 
            this.msImageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseImageToolStripMenuItem});
            this.msImageOptions.Location = new System.Drawing.Point(0, 0);
            this.msImageOptions.Name = "msImageOptions";
            this.msImageOptions.Size = new System.Drawing.Size(871, 24);
            this.msImageOptions.TabIndex = 1;
            this.msImageOptions.Text = "menuStrip1";
            // 
            // chooseImageToolStripMenuItem
            // 
            this.chooseImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFox,
            this.tsmiMonkey,
            this.tsmiTiger});
            this.chooseImageToolStripMenuItem.Name = "chooseImageToolStripMenuItem";
            this.chooseImageToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.chooseImageToolStripMenuItem.Text = "Choose Image";
            // 
            // tsmiFox
            // 
            this.tsmiFox.Image = global::Task01.Properties.Resources.fox;
            this.tsmiFox.Name = "tsmiFox";
            this.tsmiFox.Size = new System.Drawing.Size(117, 22);
            this.tsmiFox.Text = "Fox";
            // 
            // tsmiMonkey
            // 
            this.tsmiMonkey.Image = global::Task01.Properties.Resources.monkey;
            this.tsmiMonkey.Name = "tsmiMonkey";
            this.tsmiMonkey.Size = new System.Drawing.Size(117, 22);
            this.tsmiMonkey.Text = "Monkey";
            // 
            // tsmiTiger
            // 
            this.tsmiTiger.Image = global::Task01.Properties.Resources.tiger;
            this.tsmiTiger.Name = "tsmiTiger";
            this.tsmiTiger.Size = new System.Drawing.Size(117, 22);
            this.tsmiTiger.Text = "Tiger";
            // 
            // tsImageOptions
            // 
            this.tsImageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFox,
            this.tsbMonkey,
            this.tsbTiger});
            this.tsImageOptions.Location = new System.Drawing.Point(0, 24);
            this.tsImageOptions.Name = "tsImageOptions";
            this.tsImageOptions.Size = new System.Drawing.Size(871, 25);
            this.tsImageOptions.TabIndex = 2;
            this.tsImageOptions.Text = "toolStrip1";
            // 
            // tsbFox
            // 
            this.tsbFox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFox.Image = global::Task01.Properties.Resources.fox;
            this.tsbFox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFox.Name = "tsbFox";
            this.tsbFox.Size = new System.Drawing.Size(23, 22);
            this.tsbFox.Text = "toolStripButton1";
            // 
            // tsbMonkey
            // 
            this.tsbMonkey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMonkey.Image = global::Task01.Properties.Resources.monkey;
            this.tsbMonkey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMonkey.Name = "tsbMonkey";
            this.tsbMonkey.Size = new System.Drawing.Size(23, 22);
            this.tsbMonkey.Text = "toolStripButton2";
            // 
            // tsbTiger
            // 
            this.tsbTiger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTiger.Image = global::Task01.Properties.Resources.tiger;
            this.tsbTiger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTiger.Name = "tsbTiger";
            this.tsbTiger.Size = new System.Drawing.Size(23, 22);
            this.tsbTiger.Text = "toolStripButton3";
            // 
            // cmsImageOptions
            // 
            this.cmsImageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmiFox,
            this.csmiMonkey,
            this.csmiTiger});
            this.cmsImageOptions.Name = "cmsImageOptions";
            this.cmsImageOptions.Size = new System.Drawing.Size(181, 92);
            // 
            // csmiFox
            // 
            this.csmiFox.Image = global::Task01.Properties.Resources.fox;
            this.csmiFox.Name = "csmiFox";
            this.csmiFox.Size = new System.Drawing.Size(180, 22);
            this.csmiFox.Text = "Fox";
            // 
            // csmiMonkey
            // 
            this.csmiMonkey.Image = global::Task01.Properties.Resources.monkey;
            this.csmiMonkey.Name = "csmiMonkey";
            this.csmiMonkey.Size = new System.Drawing.Size(180, 22);
            this.csmiMonkey.Text = "Monkey";
            // 
            // csmiTiger
            // 
            this.csmiTiger.Image = global::Task01.Properties.Resources.tiger;
            this.csmiTiger.Name = "csmiTiger";
            this.csmiTiger.Size = new System.Drawing.Size(180, 22);
            this.csmiTiger.Text = "Tiger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 512);
            this.ContextMenuStrip = this.cmsImageOptions;
            this.Controls.Add(this.tsImageOptions);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.msImageOptions);
            this.MainMenuStrip = this.msImageOptions;
            this.Name = "Form1";
            this.Text = "Image Showcase";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.msImageOptions.ResumeLayout(false);
            this.msImageOptions.PerformLayout();
            this.tsImageOptions.ResumeLayout(false);
            this.tsImageOptions.PerformLayout();
            this.cmsImageOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbMain;
        private MenuStrip msImageOptions;
        private ToolStripMenuItem chooseImageToolStripMenuItem;
        private ToolStripMenuItem tsmiFox;
        private ToolStripMenuItem tsmiMonkey;
        private ToolStripMenuItem tsmiTiger;
        private ToolStrip tsImageOptions;
        private ToolStripButton tsbFox;
        private ToolStripButton tsbMonkey;
        private ToolStripButton tsbTiger;
        private ContextMenuStrip cmsImageOptions;
        private ToolStripMenuItem csmiFox;
        private ToolStripMenuItem csmiMonkey;
        private ToolStripMenuItem csmiTiger;
    }
}