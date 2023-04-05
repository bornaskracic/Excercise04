namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Menu Strip items
            tsmiFox.Click += imageOptionsMenuItem_Click;
            tsmiMonkey.Click += imageOptionsMenuItem_Click;
            tsmiTiger.Click += imageOptionsMenuItem_Click;
            // Context Menu Strip items
            csmiFox.Click += imageOptionsMenuItem_Click;
            csmiMonkey.Click += imageOptionsMenuItem_Click;
            csmiTiger.Click += imageOptionsMenuItem_Click;
            // Tool Strip items
            tsbFox.Click += imageOptionsMenuItem_Click;
            tsbMonkey.Click += imageOptionsMenuItem_Click;
            tsbTiger.Click += imageOptionsMenuItem_Click;
        }

        public void imageOptionsMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem item)
                pbMain.Image = item.Image;
        }
    }
}