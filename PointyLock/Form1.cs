namespace PointyLock
{
    public partial class PointyLock : Form
    {
        List<string> dirList = new List<string>();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        public PointyLock()
        {
            InitializeComponent();
            InitializeDragAndDrop();
        }

        private void InitializeDragAndDrop()
        {
            fileListBx.DataSource = null;
            fileListBx.Items.Clear();
            fileListBx.Items.Add("Drag and drop items here...");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            dirList.Add(dirPathBx.Text);

            fileListBx.DataSource = null;
            fileListBx.DataSource = dirList;
        }

        private void fileListBx_Click(object sender, EventArgs e)
        {
            if (dirList.Count > 0)
            {
                dirList.RemoveAt(fileListBx.SelectedIndex);

                fileListBx.DataSource = null;
                fileListBx.DataSource = dirList;
            }
            if (dirList.Count == 0)
            {
                InitializeDragAndDrop();
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {

        }

        private void fileListBx_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; ++i)
            {
                dirList.Add(s[i]);
            }
            fileListBx.DataSource = null;
            fileListBx.DataSource = dirList;

        }

        private void fileListBx_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void fileListBx_DragLeave(object sender, EventArgs e)
        {
            if (dirList.Count == 0)
            {
                fileListBx.Items.Add("Drag and drop items here...");
            }
        }
    }
}
