using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VideoLibrary;

namespace Crazy_Downloader
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private List<byte> usedKeys = new List<byte>();

        private string platform = "Youtube";
        private string playlistElementsFormat;
        private string format;
        private string directory;
        private string link;
        private string playlistName;

        private bool canChange = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseDirectoryBtn_Click(object sender, EventArgs e)
        {
            AvoidProgressBar();

            canChange = true;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryText.Text = folderBrowserDialog.SelectedPath;
                directory = DirectoryText.Text;
            }

            if (DirectoryText.Text == null) usedKeys.Remove(11);
            else ButtonStartCheck(11);
            ButtonStartCheck();
            canChange = false;
        }
        private void ElementTypeChoice_SelectedValueChanged(object sender, EventArgs e)
        {
            AvoidProgressBar();

            string selectedValue;
            try { selectedValue = checked(ElementTypeChoice.SelectedItem.ToString()); }
            catch { return; }

            SetFormatChoice(selectedValue);

            usedKeys.Remove(33);
            usedKeys.Remove(44);
            usedKeys.Remove(66);

            ButtonStartCheck(22);
        }
        private void FormatOfDownloadingChoice_SelectedValueChanged(object sender, EventArgs e)
        {
            AvoidProgressBar();

            try { format = checked(FormatOfDownloadingChoice.SelectedItem.ToString()); }
            catch { return; }

            ButtonStartCheck(33);
        }
        private void PlaylistElementsFormatChoice_SelectedValueChanged(object sender, EventArgs e)
        {
            AvoidProgressBar();

            try { playlistElementsFormat = checked(PlaylistElementsFormatChoice.SelectedItem.ToString()); }
            catch { return; }


            ButtonStartCheck(44);
        }
        private void URLLabel_TextChanged(object sender, EventArgs e)
        {
            AvoidProgressBar();

            link = URLLabel.Text;

            if (URLLabel.Text == "") usedKeys.Remove(55);
            else ButtonStartCheck(55);
            ButtonStartCheck();
        }
        private void PlaylistName_TextChanged(object sender, EventArgs e)
        {
            AvoidProgressBar();

            playlistName = PlaylistName.Text;

            if (PlaylistName.Text == "") usedKeys.Remove(66);
            else ButtonStartCheck(66);
            ButtonStartCheck();
        }
        private void DirectoryText_TextChanged(object sender, EventArgs e)
        {
            AvoidProgressBar();

            if (DirectoryText.Text != directory && !canChange) DirectoryText.Text = directory;
        }

        private void StartDownloadbtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (platform == "Youtube")
                {
                    if (format == "Playlist")
                    {
                        string pathDirectory = $@"{directory}\{playlistName}";
                        Directory.CreateDirectory(pathDirectory);

                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE", true);
                        key.CreateSubKey("GPC");
                        key = key.OpenSubKey("GPC", true);

                        key.SetValue("link", link);
                        key.SetValue("format", playlistElementsFormat);
                        key.SetValue("directory", pathDirectory);
                        key.SetValue("DownloadedVideos", "0");

                        Process.Start("Downloader.exe");
                        ProgressbarForPlaylist();
                    }
                    else
                    {
                        var youTube = YouTube.Default;
                        var video = youTube.GetVideo(link);
                        File.WriteAllBytes($@"{directory}\{video.Title}.{format}", video.GetBytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetFormatChoice(string value)
        {
            DownloadedFileTypeLabel.Enabled = true;
            FormatOfDownloadingChoice.Enabled = true;

            PlaylistName.Visible = false;
            NameOfPlaylistLabel.Visible = false;
            PlaylistElementsFormatChoice.Visible = false;
            WarningLabel.Visible = false;

            switch (value)
            {
                case "Audio":
                    FormatOfDownloadingChoice.Items.Clear();
                    FormatOfDownloadingChoice.Items.Insert(0, "Mp3");
                    FormatOfDownloadingChoice.Items.Insert(1, "WAV");
                    break;

                case "Video":
                    FormatOfDownloadingChoice.Items.Clear();
                    FormatOfDownloadingChoice.Items.Insert(0, "Mp4");
                    FormatOfDownloadingChoice.Items.Insert(1, "avi");
                    break;

                case "Playlist":
                    PlaylistName.Visible = true;
                    NameOfPlaylistLabel.Visible = true;
                    PlaylistElementsFormatChoice.Visible = true;
                    WarningLabel.Visible = true;

                    FormatOfDownloadingChoice.Items.Clear();
                    FormatOfDownloadingChoice.Items.Insert(0, "Playlist");
                    break;

                default:
                    break;
            }
        }
        private void ButtonStartCheck([Optional] byte key)
        {
            if (!usedKeys.Contains(key) && key != 0) usedKeys.Add(key);

            if ((usedKeys.Count == 4 && !PlaylistName.Visible)
                || (usedKeys.Count == 6 && PlaylistName.Visible))
            {
                StartDownloadbtn.Enabled = true;
            }
            else StartDownloadbtn.Enabled = false;
        }
        private void ProgressbarForPlaylist()
        {
            try
            {
                DownloadProgressBar.Visible = true;
                DownloadStateLabel.Visible = true;
                DownloadProgressBar.Value = 0;

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GPC", true);

                string demo = (string)key.GetValue("TotalVIdeos");
                int videosAmount = int.Parse(demo);

                int downloadedVideosAmount;

                int count = 0;
                while (true)
                {
                    demo = (string)key.GetValue("DownloadedVideos");
                    downloadedVideosAmount = int.Parse(demo);

                    DownloadProgressBar.Value = downloadedVideosAmount * 100 / videosAmount;

                    if (downloadedVideosAmount == videosAmount)
                    {
                        DownloadStateLabel.Text = "DOWNLOAD COMPLETED!";
                        break;
                    }
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AvoidProgressBar()
        {
            DownloadProgressBar.Visible = false;
            DownloadStateLabel.Visible = false;
        }
    }
}
