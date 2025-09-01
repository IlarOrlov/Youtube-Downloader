namespace Crazy_Downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.ElementTypeLabel = new System.Windows.Forms.Label();
            this.DownloadedFileTypeLabel = new System.Windows.Forms.Label();
            this.DIrectoryLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.NameOfPlaylistLabel = new System.Windows.Forms.Label();
            this.PlaylistName = new System.Windows.Forms.TextBox();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.ChooseDirectoryBtn = new System.Windows.Forms.Button();
            this.URLLabel = new System.Windows.Forms.TextBox();
            this.ElementTypeChoice = new System.Windows.Forms.ComboBox();
            this.FormatOfDownloadingChoice = new System.Windows.Forms.ComboBox();
            this.StartDownloadbtn = new System.Windows.Forms.Button();
            this.PlaylistElementsFormatChoice = new System.Windows.Forms.ComboBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadStateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AllowDrop = true;
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(122, 57);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(502, 90);
            this.Title.TabIndex = 0;
            this.Title.Text = "DOWNLOADER\r\nplaylists - videos - musics";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementTypeLabel
            // 
            this.ElementTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ElementTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ElementTypeLabel.Location = new System.Drawing.Point(9, 160);
            this.ElementTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElementTypeLabel.Name = "ElementTypeLabel";
            this.ElementTypeLabel.Size = new System.Drawing.Size(329, 20);
            this.ElementTypeLabel.TabIndex = 1;
            this.ElementTypeLabel.Text = "Type Of Element You\'d Like To Download";
            // 
            // DownloadedFileTypeLabel
            // 
            this.DownloadedFileTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadedFileTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DownloadedFileTypeLabel.Enabled = false;
            this.DownloadedFileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadedFileTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DownloadedFileTypeLabel.Location = new System.Drawing.Point(9, 188);
            this.DownloadedFileTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DownloadedFileTypeLabel.Name = "DownloadedFileTypeLabel";
            this.DownloadedFileTypeLabel.Size = new System.Drawing.Size(235, 20);
            this.DownloadedFileTypeLabel.TabIndex = 2;
            this.DownloadedFileTypeLabel.Text = "Format Of Downloading";
            // 
            // DIrectoryLabel
            // 
            this.DIrectoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DIrectoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.DIrectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIrectoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DIrectoryLabel.Location = new System.Drawing.Point(9, 219);
            this.DIrectoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DIrectoryLabel.Name = "DIrectoryLabel";
            this.DIrectoryLabel.Size = new System.Drawing.Size(168, 20);
            this.DIrectoryLabel.TabIndex = 3;
            this.DIrectoryLabel.Text = "Where To Install";
            // 
            // LinkLabel
            // 
            this.LinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LinkLabel.Location = new System.Drawing.Point(9, 249);
            this.LinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(239, 20);
            this.LinkLabel.TabIndex = 4;
            this.LinkLabel.Text = "URL Link Of The Element";
            // 
            // NameOfPlaylistLabel
            // 
            this.NameOfPlaylistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameOfPlaylistLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameOfPlaylistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfPlaylistLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameOfPlaylistLabel.Location = new System.Drawing.Point(399, 190);
            this.NameOfPlaylistLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameOfPlaylistLabel.Name = "NameOfPlaylistLabel";
            this.NameOfPlaylistLabel.Size = new System.Drawing.Size(225, 18);
            this.NameOfPlaylistLabel.TabIndex = 8;
            this.NameOfPlaylistLabel.Text = "Name Of The Playlist";
            this.NameOfPlaylistLabel.Visible = false;
            // 
            // PlaylistName
            // 
            this.PlaylistName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PlaylistName.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistName.Location = new System.Drawing.Point(571, 188);
            this.PlaylistName.Margin = new System.Windows.Forms.Padding(2);
            this.PlaylistName.MaxLength = 50;
            this.PlaylistName.Multiline = true;
            this.PlaylistName.Name = "PlaylistName";
            this.PlaylistName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PlaylistName.Size = new System.Drawing.Size(159, 25);
            this.PlaylistName.TabIndex = 9;
            this.PlaylistName.Visible = false;
            this.PlaylistName.TextChanged += new System.EventHandler(this.PlaylistName_TextChanged);
            // 
            // DirectoryText
            // 
            this.DirectoryText.BackColor = System.Drawing.Color.White;
            this.DirectoryText.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryText.Location = new System.Drawing.Point(148, 215);
            this.DirectoryText.Margin = new System.Windows.Forms.Padding(2);
            this.DirectoryText.Multiline = true;
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.Size = new System.Drawing.Size(550, 24);
            this.DirectoryText.TabIndex = 10;
            this.DirectoryText.TextChanged += new System.EventHandler(this.DirectoryText_TextChanged);
            // 
            // ChooseDirectoryBtn
            // 
            this.ChooseDirectoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChooseDirectoryBtn.ForeColor = System.Drawing.Color.Black;
            this.ChooseDirectoryBtn.Location = new System.Drawing.Point(702, 215);
            this.ChooseDirectoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseDirectoryBtn.Name = "ChooseDirectoryBtn";
            this.ChooseDirectoryBtn.Size = new System.Drawing.Size(26, 23);
            this.ChooseDirectoryBtn.TabIndex = 11;
            this.ChooseDirectoryBtn.Text = "...";
            this.ChooseDirectoryBtn.UseVisualStyleBackColor = false;
            this.ChooseDirectoryBtn.Click += new System.EventHandler(this.ChooseDirectoryBtn_Click);
            // 
            // URLLabel
            // 
            this.URLLabel.BackColor = System.Drawing.Color.White;
            this.URLLabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel.Location = new System.Drawing.Point(209, 249);
            this.URLLabel.Margin = new System.Windows.Forms.Padding(2);
            this.URLLabel.Multiline = true;
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(521, 24);
            this.URLLabel.TabIndex = 12;
            this.URLLabel.TextChanged += new System.EventHandler(this.URLLabel_TextChanged);
            // 
            // ElementTypeChoice
            // 
            this.ElementTypeChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementTypeChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ElementTypeChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementTypeChoice.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementTypeChoice.FormattingEnabled = true;
            this.ElementTypeChoice.Items.AddRange(new object[] {
            "Audio",
            "Video",
            "Playlist"});
            this.ElementTypeChoice.Location = new System.Drawing.Point(342, 159);
            this.ElementTypeChoice.Margin = new System.Windows.Forms.Padding(2);
            this.ElementTypeChoice.Name = "ElementTypeChoice";
            this.ElementTypeChoice.Size = new System.Drawing.Size(167, 24);
            this.ElementTypeChoice.TabIndex = 13;
            this.ElementTypeChoice.DropDownClosed += new System.EventHandler(this.ElementTypeChoice_SelectedValueChanged);
            // 
            // FormatOfDownloadingChoice
            // 
            this.FormatOfDownloadingChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormatOfDownloadingChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormatOfDownloadingChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatOfDownloadingChoice.Enabled = false;
            this.FormatOfDownloadingChoice.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatOfDownloadingChoice.FormattingEnabled = true;
            this.FormatOfDownloadingChoice.Location = new System.Drawing.Point(200, 187);
            this.FormatOfDownloadingChoice.Margin = new System.Windows.Forms.Padding(2);
            this.FormatOfDownloadingChoice.Name = "FormatOfDownloadingChoice";
            this.FormatOfDownloadingChoice.Size = new System.Drawing.Size(88, 24);
            this.FormatOfDownloadingChoice.TabIndex = 14;
            this.FormatOfDownloadingChoice.DropDownClosed += new System.EventHandler(this.FormatOfDownloadingChoice_SelectedValueChanged);
            // 
            // StartDownloadbtn
            // 
            this.StartDownloadbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDownloadbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartDownloadbtn.Enabled = false;
            this.StartDownloadbtn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDownloadbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartDownloadbtn.Location = new System.Drawing.Point(321, 277);
            this.StartDownloadbtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartDownloadbtn.Name = "StartDownloadbtn";
            this.StartDownloadbtn.Size = new System.Drawing.Size(94, 32);
            this.StartDownloadbtn.TabIndex = 15;
            this.StartDownloadbtn.Text = "START";
            this.StartDownloadbtn.UseVisualStyleBackColor = false;
            this.StartDownloadbtn.Click += new System.EventHandler(this.StartDownloadbtn_ClickAsync);
            // 
            // PlaylistElementsFormatChoice
            // 
            this.PlaylistElementsFormatChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistElementsFormatChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PlaylistElementsFormatChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaylistElementsFormatChoice.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistElementsFormatChoice.FormattingEnabled = true;
            this.PlaylistElementsFormatChoice.Items.AddRange(new object[] {
            "mp3",
            "mp4"});
            this.PlaylistElementsFormatChoice.Location = new System.Drawing.Point(292, 187);
            this.PlaylistElementsFormatChoice.Margin = new System.Windows.Forms.Padding(2);
            this.PlaylistElementsFormatChoice.Name = "PlaylistElementsFormatChoice";
            this.PlaylistElementsFormatChoice.Size = new System.Drawing.Size(72, 24);
            this.PlaylistElementsFormatChoice.TabIndex = 16;
            this.PlaylistElementsFormatChoice.Visible = false;
            this.PlaylistElementsFormatChoice.DropDownClosed += new System.EventHandler(this.PlaylistElementsFormatChoice_SelectedValueChanged);
            // 
            // WarningLabel
            // 
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(11, 275);
            this.WarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(233, 20);
            this.WarningLabel.TabIndex = 17;
            this.WarningLabel.Text = "make sure the Playlist is public";
            this.WarningLabel.Visible = false;
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(12, 344);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(582, 28);
            this.DownloadProgressBar.TabIndex = 18;
            this.DownloadProgressBar.Visible = false;
            // 
            // DownloadStateLabel
            // 
            this.DownloadStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadStateLabel.AutoSize = true;
            this.DownloadStateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DownloadStateLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadStateLabel.ForeColor = System.Drawing.Color.Aqua;
            this.DownloadStateLabel.Location = new System.Drawing.Point(238, 319);
            this.DownloadStateLabel.Name = "DownloadStateLabel";
            this.DownloadStateLabel.Size = new System.Drawing.Size(137, 22);
            this.DownloadStateLabel.TabIndex = 19;
            this.DownloadStateLabel.Text = "PLEASE WAIT";
            this.DownloadStateLabel.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Crazy_Downloader.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.DownloadStateLabel);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.PlaylistElementsFormatChoice);
            this.Controls.Add(this.StartDownloadbtn);
            this.Controls.Add(this.FormatOfDownloadingChoice);
            this.Controls.Add(this.ElementTypeChoice);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.ChooseDirectoryBtn);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.PlaylistName);
            this.Controls.Add(this.NameOfPlaylistLabel);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.DIrectoryLabel);
            this.Controls.Add(this.DownloadedFileTypeLabel);
            this.Controls.Add(this.ElementTypeLabel);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Crazy Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ElementTypeLabel;
        private System.Windows.Forms.Label DownloadedFileTypeLabel;
        private System.Windows.Forms.Label DIrectoryLabel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Label NameOfPlaylistLabel;
        private System.Windows.Forms.TextBox PlaylistName;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Button ChooseDirectoryBtn;
        private System.Windows.Forms.TextBox URLLabel;
        private System.Windows.Forms.ComboBox ElementTypeChoice;
        private System.Windows.Forms.ComboBox FormatOfDownloadingChoice;
        private System.Windows.Forms.Button StartDownloadbtn;
        private System.Windows.Forms.ComboBox PlaylistElementsFormatChoice;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Label DownloadStateLabel;
    }
}

