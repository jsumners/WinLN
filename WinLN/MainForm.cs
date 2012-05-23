using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using com.jrfom.winln.Classes;

namespace com.jrfom.winln {
  public partial class MainForm : Form {
    /// <summary>
    /// sourceDirPath and destDirPath are private members for keeping
    /// track of the directories the user has chosen.
    /// </summary>
    private string sourceDirPath;
    private string destDirPath;

    private string sourceFilePath;
    private string destFilePath;

    private ProgramData links;
    private string dataFile;

    public MainForm() {
      InitializeComponent();

      // Our initializations
      string appDataDir =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      appDataDir = Path.Combine(appDataDir, "WinLN");

      if ( !Directory.Exists(appDataDir) ) {
        Directory.CreateDirectory(appDataDir);
      }

      this.dataFile = Path.Combine(appDataDir, "links_data.json");
      if ( File.Exists(this.dataFile) ) {
        this.links = new ProgramData(this.dataFile);
        List<string> dirKeys = links.dirLinksKeys();
        List<string> fileKeys = links.fileLinksKeys();

        for ( int i = 0, j = dirKeys.Count; i < j; i += 1 ) {
          dirLinksList.Items.Add(dirKeys[i]);
        }

        for ( int i = 0, j = fileKeys.Count; i < j; i += 1 ) {
          fileLinksList.Items.Add(fileKeys[i]);
        }
      } else {
        this.links = new ProgramData();
      }

      #region Directory symlinks init
      dirDetailDate.Text = "";
      dirDetailDest.Text = "";
      dirDetailSource.Text = "";
      #endregion

      #region Flie symlinks init
      fileDetailDate.Text = "";
      fileDetailDest.Text = "";
      fileDetailSource.Text = "";
      #endregion
    }

    /// <summary>
    /// This method is used to write our symlinks data to our save file.
    /// It serializes the dirSymlinks and fileSymlinks objects to JSON
    /// and writes that string to a file.
    /// </summary>
    private void saveData() {
      string json = JsonConvert.SerializeObject(this.links);

      Encoding enc = new UTF8Encoding();
      StreamWriter sw = new StreamWriter(this.dataFile, false, enc);
      sw.Write(json);
      sw.Close();
    }

    /// <summary>
    /// A simple utility method to use when deciding what to do with
    /// missing symlinks. The method presents the user with a Yes/No
    /// prompt and returns true or false.
    /// </summary>
    /// <returns>True if the user wants to delete, false otherwise.</returns>
    private bool deleteFromWinLn() {
      DialogResult answer = MessageBox.Show(
        "The symlink was not found. Would you like to remove the link from WinLN?",
        "Link not found.",
        MessageBoxButtons.YesNo);

      return (answer == DialogResult.Yes) ? true : false;
    }

    #region Directory symlinks tab code
    private void sourceDirSelectBtn_Click(object sender, EventArgs e) {
      DialogResult result = dirSourceDialog.ShowDialog();

      if ( result == DialogResult.OK ) {
        this.sourceDirPath = dirSourceDialog.SelectedPath;
        sourceDirTxt.Text = this.sourceDirPath;

        createDirLinkBtn.Enabled = (destDirTxt.Text.Length > 0) ? true : false;
      }
    }

    private void dstDirSelectBtn_Click(object sender, EventArgs e) {
      DialogResult result = dirDestDialog.ShowDialog();

      if ( result == DialogResult.OK ) {
        this.destDirPath = dirDestDialog.SelectedPath;
        destDirTxt.Text = this.destDirPath;

        createDirLinkBtn.Enabled = (sourceDirTxt.Text.Length > 0) ? true : false;
      }
    }

    private void createDirLinkBtn_Click(object sender, EventArgs e) {
      string finalDestPath;
      Linker linker = new Linker();
      bool linkSuccess;
      string winLnName = dirWinLnNameTxt.Text;

      if ( winLnName.Length < 1 ) {
        MessageBox.Show(
          "Please specify a WinLN Name.",
          "WinLN: Error"
        );
        dirWinLnNameTxt.Focus();
        return;
      }

      // TODO: make sure all paths are valid

      if ( dirDestNameTxt.Text.Length > 0 ) {
        finalDestPath = this.destDirPath + "\\" + dirDestNameTxt.Text;
      } else {
        int sep = this.sourceDirPath.LastIndexOf("\\");
        string dirPart = this.sourceDirPath.Substring(sep);
        finalDestPath = this.destDirPath + dirPart;
      }

      linkSuccess = linker.linkDir(this.sourceDirPath, finalDestPath);

      if ( !linkSuccess ) {
        string err = linker.lastError;
        MessageBox.Show(
          "An error occurred while trying to create the link: " + err,
          "WinLN: Error"
        );
      } else {
        this.addToDirList(winLnName, this.sourceDirPath, finalDestPath);
        createDirLinkBtn.Enabled = false;
        sourceDirTxt.Text = "";
        destDirTxt.Text = "";
        dirDestNameTxt.Text = "";
        dirWinLnNameTxt.Text = "";

        this.sourceDirPath = string.Empty;
        this.destDirPath = string.Empty;
      }
    }

    private void addToDirList(string name, string srcPath, string dstPath) {
      Symlink symlink = new Symlink();
      symlink.winLnName = name;
      symlink.sourcePath = srcPath;
      symlink.destinationPath = dstPath;

      this.links.addDirLink(symlink);
      dirLinksList.Items.Add(name);
      this.saveData();
    }

    private void dirLinksList_SelectedIndexChanged(object sender, EventArgs e) {
      if ( dirLinksList.SelectedItems.Count > 0 ) {
        string itemName = dirLinksList.SelectedItem.ToString();
        Symlink symlink = this.links.getDirLink(itemName);

        dirRemoveBtn.Enabled = true;

        dirDetailDate.Text = (new DateTime(symlink.dateTicks))
          .ToLongDateString();
        dirDetailDest.Text = symlink.destinationPath;
        dirDetailSource.Text = symlink.sourcePath;
      }
    }

    private void dirRemoveBtn_Click(object sender, EventArgs e) {
      bool cleanUp = false;
      string itemName = dirLinksList.SelectedItem.ToString();
      Symlink symlink = this.links.getDirLink(itemName);

      if ( !Directory.Exists(symlink.destinationPath) ) {
        if ( this.deleteFromWinLn() ) {
          cleanUp = true;
        }
      } else {
        try {
          Directory.Delete(symlink.destinationPath);
          cleanUp = true;
        } catch ( Exception ex ) {
          MessageBox.Show(ex.Message, "WinLN: Error");
          return;
        }
      }

      if ( cleanUp ) {
        dirLinksList.Items.Remove(dirLinksList.SelectedItem);
        dirDetailDate.Text = "";
        dirDetailDest.Text = "";
        dirDetailSource.Text = "";
        dirRemoveBtn.Enabled = false;

        this.links.delDirLink(itemName);
        this.saveData();
      }
    }
    #endregion

    #region File symlinks tab code
    private void sourceFileSelectBtn_Click(object sender, EventArgs e) {
      DialogResult result = fileSourceDialog.ShowDialog();

      if ( result == DialogResult.OK ) {
        this.sourceFilePath = fileSourceDialog.FileName;
        fileSourceTxt.Text = this.sourceFilePath;

        fileCreateBtn.Enabled = (fileDestTxt.Text.Length > 0) ? true : false;
      }
    }

    private void destFileSelectBtn_Click(object sender, EventArgs e) {
      DialogResult result = fileDestDialog.ShowDialog();

      if ( result == DialogResult.OK ) {
        this.destFilePath = fileDestDialog.FileName;
        fileDestTxt.Text = this.destFilePath;

        fileCreateBtn.Enabled = (fileSourceTxt.Text.Length > 0) ? true : false;
      }
    }

    private void fileCreateLinkBtn_Click(object sender, EventArgs e) {
      Linker linker = new Linker();
      bool linkSuccess;
      string winLnName = fileWinLnNameTxt.Text;

      if ( winLnName.Length < 1 ) {
        MessageBox.Show(
          "Please specify a WinLN Name.",
          "WinLN: Error"
        );
        fileWinLnNameTxt.Focus();
        return;
      }

      // TODO: make sure all paths are valid

      linkSuccess = linker.linkFile(this.sourceFilePath, this.destFilePath);

      if ( !linkSuccess ) {
        string err = linker.lastError;
        MessageBox.Show(
          "An error occurred while trying to create the link: " + err,
          "WinLN: Error"
        );
      } else {
        this.addToFileList(winLnName, this.sourceFilePath, this.destFilePath);
        fileCreateBtn.Enabled = false;
        fileSourceTxt.Text = "";
        fileDestTxt.Text = "";
        fileWinLnNameTxt.Text = "";

        this.sourceFilePath = string.Empty;
        this.destFilePath = string.Empty;
      }
    }

    private void addToFileList(string name, string srcPath, string dstPath) {
      Symlink symlink = new Symlink();
      symlink.winLnName = name;
      symlink.sourcePath = srcPath;
      symlink.destinationPath = dstPath;

      this.links.addFileLink(symlink);
      fileLinksList.Items.Add(name);
      this.saveData();
    }

    private void fileLinksList_SelectedIndexChanged(object sender, EventArgs e) {
      if ( fileLinksList.SelectedItems.Count > 0 ) {
        string itemName = fileLinksList.SelectedItem.ToString();
        Symlink symlink = this.links.getFileLink(itemName);

        fileRemoveBtn.Enabled = true;

        fileDetailDate.Text = (new DateTime(symlink.dateTicks))
          .ToLongDateString();
        fileDetailDest.Text = symlink.destinationPath;
        fileDetailSource.Text = symlink.sourcePath;
      }
    }

    private void fileRemoveBtn_Click(object sender, EventArgs e) {
      bool cleanUp = false;
      string itemName = fileLinksList.SelectedItem.ToString();
      Symlink symlink = this.links.getFileLink(itemName);

      if ( !File.Exists(symlink.destinationPath) ) {
        if ( this.deleteFromWinLn() ) {
          cleanUp = true;
        }
      } else {
        try {
          File.Delete(symlink.destinationPath);
          cleanUp = true;
        } catch ( Exception ex ) {
          MessageBox.Show(ex.Message, "WinLN: Error");
          return;
        }
      }

      if ( cleanUp ) {
        fileLinksList.Items.Remove(fileLinksList.SelectedItem);
        fileDetailDate.Text = "";
        fileDetailDest.Text = "";
        fileDetailSource.Text = "";
        fileRemoveBtn.Enabled = false;

        this.links.delFileLink(itemName);
        this.saveData();
      }
    }
    #endregion

    private void aboutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Form aboutForm = new AboutForm();

      aboutForm.ShowDialog();
    }
  }
}
