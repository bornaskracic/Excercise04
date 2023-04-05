using Common.Utilities;

namespace Task02
{
    public partial class Form1 : Form
    {
        private Size panelSize = new Size(40, 40);

        private Panel lastSelectedPanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmsFormItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var count = int.Parse(item.Tag.ToString());
            AddPanels(count);   
        }

        private void AddPanels(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Panel panel = new Panel
                {
                    Size = panelSize,
                    BackColor = BasicUtils.GetRandomColor(),
                    Location = BasicUtils.GetRandomLocationInParent(ClientSize, panelSize),
                    ContextMenuStrip = cmsPanel,
                };
                panel.Click += panel_Click;

                Controls.Add(panel);
            }
        }

        private void panel_Click(object? sender, EventArgs e)
        {
            if (lastSelectedPanel is not null)
                lastSelectedPanel.BorderStyle = BorderStyle.None;

            var panel = sender as Panel;
            lastSelectedPanel = panel;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BringToFront();
            
        }

        private void removePanelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lastSelectedPanel);
            lastSelectedPanel = null;
        }
    }
}