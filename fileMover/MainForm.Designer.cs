namespace fileMover
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            targetFileNames = new TextBox();
            libFolderDir = new TextBox();
            outputFolderDir = new TextBox();
            libFolderLbl = new Label();
            outputFolderLbl = new Label();
            libFolderBrowseBtn = new Button();
            outputFolderBrowseBtn = new Button();
            moveFiles = new Button();
            aboutPopUp = new Button();
            SuspendLayout();
            // 
            // targetFileNames
            // 
            targetFileNames.Location = new Point(12, 12);
            targetFileNames.Multiline = true;
            targetFileNames.Name = "targetFileNames";
            targetFileNames.ScrollBars = ScrollBars.Vertical;
            targetFileNames.Size = new Size(220, 491);
            targetFileNames.TabIndex = 0;
            // 
            // libFolderDir
            // 
            libFolderDir.Location = new Point(238, 40);
            libFolderDir.Name = "libFolderDir";
            libFolderDir.Size = new Size(395, 23);
            libFolderDir.TabIndex = 1;
            // 
            // outputFolderDir
            // 
            outputFolderDir.Location = new Point(238, 118);
            outputFolderDir.Name = "outputFolderDir";
            outputFolderDir.Size = new Size(395, 23);
            outputFolderDir.TabIndex = 2;
            // 
            // libFolderLbl
            // 
            libFolderLbl.AutoSize = true;
            libFolderLbl.Location = new Point(238, 12);
            libFolderLbl.Name = "libFolderLbl";
            libFolderLbl.Size = new Size(76, 15);
            libFolderLbl.TabIndex = 3;
            libFolderLbl.Text = "LibraryFolder";
            // 
            // outputFolderLbl
            // 
            outputFolderLbl.AutoSize = true;
            outputFolderLbl.Location = new Point(238, 100);
            outputFolderLbl.Name = "outputFolderLbl";
            outputFolderLbl.Size = new Size(78, 15);
            outputFolderLbl.TabIndex = 4;
            outputFolderLbl.Text = "OutputFolder";
            // 
            // libFolderBrowseBtn
            // 
            libFolderBrowseBtn.Location = new Point(558, 69);
            libFolderBrowseBtn.Name = "libFolderBrowseBtn";
            libFolderBrowseBtn.Size = new Size(75, 23);
            libFolderBrowseBtn.TabIndex = 5;
            libFolderBrowseBtn.Text = "Browse";
            libFolderBrowseBtn.UseVisualStyleBackColor = true;
            libFolderBrowseBtn.Click += libFolderBrowseBtn_Clk;
            // 
            // outputFolderBrowseBtn
            // 
            outputFolderBrowseBtn.Location = new Point(558, 147);
            outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            outputFolderBrowseBtn.Size = new Size(75, 23);
            outputFolderBrowseBtn.TabIndex = 6;
            outputFolderBrowseBtn.Text = "Browse";
            outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            outputFolderBrowseBtn.Click += outputFolderBrowseBtn_Clk;
            // 
            // moveFiles
            // 
            moveFiles.Location = new Point(391, 242);
            moveFiles.Name = "moveFiles";
            moveFiles.Size = new Size(75, 48);
            moveFiles.TabIndex = 7;
            moveFiles.Text = "Move Files";
            moveFiles.UseVisualStyleBackColor = true;
            moveFiles.Click += moveFileBtn_Clk;
            // 
            // aboutPopUp
            // 
            aboutPopUp.Location = new Point(558, 480);
            aboutPopUp.Name = "aboutPopUp";
            aboutPopUp.Size = new Size(75, 23);
            aboutPopUp.TabIndex = 8;
            aboutPopUp.Text = "About";
            aboutPopUp.UseVisualStyleBackColor = true;
            aboutPopUp.Click += aboutPopUpBtn_Clk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 515);
            Controls.Add(aboutPopUp);
            Controls.Add(moveFiles);
            Controls.Add(outputFolderBrowseBtn);
            Controls.Add(libFolderBrowseBtn);
            Controls.Add(outputFolderLbl);
            Controls.Add(libFolderLbl);
            Controls.Add(outputFolderDir);
            Controls.Add(libFolderDir);
            Controls.Add(targetFileNames);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "fileMover";
            FormClosing += autoSaveTargetFileList;
            Load += autoLoadTargetFileList;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox targetFileNames;
        private TextBox libFolderDir;
        private TextBox outputFolderDir;
        private Label libFolderLbl;
        private Label outputFolderLbl;
        private Button libFolderBrowseBtn;
        private Button outputFolderBrowseBtn;
        private Button moveFiles;
        private Button aboutPopUp;
    }
}
