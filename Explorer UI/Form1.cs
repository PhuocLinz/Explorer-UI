namespace Explorer_UI
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            list.Clear();
            listView.Items.Clear();
            using(FolderBrowserDialog expl = new FolderBrowserDialog())
            {
                if (expl.ShowDialog() == DialogResult.OK)
                {
                    tbOpen.Text = expl.SelectedPath;
                    foreach(string item in Directory.GetFiles(expl.SelectedPath))
                    {
                        imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        list.Add(fi.FullName); 
                        listView.Items.Add(fi.Name, imageList1.Images.Count -1);
                    }
                }
            }
        }
    }
}
