namespace fileMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void libFolderBrowseBtn_Clk(object sender, EventArgs e)
        {
            FolderBrowserDialog libDir = new FolderBrowserDialog();
            if (libDir.ShowDialog() == DialogResult.OK)
            {
                libFolderDir.Text = libDir.SelectedPath;
            }
        }

        private void outputFolderBrowseBtn_Clk(object sender, EventArgs e)
        {
            FolderBrowserDialog outputDir = new FolderBrowserDialog();

            if (outputDir.ShowDialog() == DialogResult.OK)
            {
                outputFolderDir.Text = outputDir.SelectedPath;
            }
        }

        private void moveFileBtn_Clk(object sender, EventArgs e)
        {
            string[] libFileNames = [];
            string[] libFilePath = [];
            string[] libFileExtension = [];

            string[] outputFilePath = [];

            if (Directory.Exists(outputFolderDir.Text))
            {
                outputFilePath = Directory.GetFiles(outputFolderDir.Text);
                foreach (string fileToDelete in outputFilePath)
                {
                    File.Delete(fileToDelete);
                }
            }

            if (Directory.Exists(libFolderDir.Text))
            {
                libFilePath = Directory.GetFiles(libFolderDir.Text);
                libFileNames = libFilePath.Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
                libFileExtension = libFilePath.Select(fileName => Path.GetExtension(fileName)).ToArray();
            }

            if (targetFileNames.TextLength > 0 && libFileNames.Length > 0 && Directory.Exists(outputFolderDir.Text))
            {
                foreach (string line in targetFileNames.Lines)
                {
                    for (int index = 0; index < libFileNames.Length - 1; index++)
                    {
                        if (string.Compare(libFileNames[index], line.Trim()) == 0)
                        {
                            string targetpath = string.Concat(outputFolderDir.Text, "\\", libFileNames[index], libFileExtension[index]);
                            File.Copy(libFilePath[index], targetpath);
                        }
                    }
                }
            }
        }
    }
}
