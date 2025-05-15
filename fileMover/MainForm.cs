using System;

namespace fileMover
{
    public partial class MainForm : Form
    {
        public MainForm()
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

            int fileCopyNum = 0;

            string targetLibFileName = "";

            if (Directory.Exists(outputFolderDir.Text))
            {
                outputFilePath = Directory.GetFiles(outputFolderDir.Text);

                if (Directory.GetFiles(outputFolderDir.Text).Length > 0)
                {
                    DialogResult clearTargetFolder = MessageBox.Show("The target folder is not empty, do you want to clear it?", "Attention!", MessageBoxButtons.YesNo);

                    if (clearTargetFolder == DialogResult.Yes)
                    {
                        foreach (string fileToDelete in outputFilePath)
                        {
                            File.Delete(fileToDelete);
                        }
                    }
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
                    targetLibFileName = line.Trim();

                    if (targetLibFileName.Length > 0)
                    {
                        if (string.Compare(targetLibFileName.Substring(0, 3), "FB_") != 0 && string.Compare(targetLibFileName.Substring(0, 3), "FC_") != 0 &&
                            string.Compare(targetLibFileName.Substring(0, 3), "UDT") != 0 && string.Compare(targetLibFileName.Substring(0, 3), "DB_") != 0 &&
                            targetLibFileName.Contains("\""))
                        {
                            targetLibFileName = targetLibFileName.Substring(targetLibFileName.IndexOf("\"") + 1, targetLibFileName.Length - targetLibFileName.IndexOf("\"") - 1);
                            targetLibFileName = targetLibFileName.Remove(targetLibFileName.IndexOf("\""));
                        }

                        for (int index = 0; index < libFileNames.Length - 1; index++)
                        {

                            if (string.Compare(libFileNames[index], targetLibFileName) == 0)
                            {
                                string targetpath = string.Concat(outputFolderDir.Text, "\\", libFileNames[index], libFileExtension[index]);
                                File.Copy(libFilePath[index], targetpath, true);

                                fileCopyNum++;
                            }
                        }
                    }
                }
            }

            MessageBox.Show(string.Concat(fileCopyNum.ToString(), " files moved successfully."), "Files moved", MessageBoxButtons.OK);
        }

        private void aboutPopUpBtn_Clk(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AboutPopUp>().Any())
            {
                Application.OpenForms.OfType<AboutPopUp>().First().BringToFront();
            }
            else
            {
                var aboutPopUp = new AboutPopUp();
                aboutPopUp.Show();
                aboutPopUp.BringToFront();
            }
        }

        private void autoSaveTargetFileList(object sender, FormClosingEventArgs e)
        {
            if (targetFileNames != null)
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\" + "targetFileNames", targetFileNames.Text);
            }
        }

        private void autoLoadTargetFileList(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\" + "targetFileNames"))
            {
                targetFileNames.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\" + "targetFileNames");
            }
        }
    }
}
