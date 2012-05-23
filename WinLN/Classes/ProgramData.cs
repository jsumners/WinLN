using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace com.jrfom.winln.Classes {
  /// <summary>
  /// This class is used to represent WinLN's user data. It provides an
  /// interface for accessing file or directory symlinks.
  /// </summary>
  [JsonObject(MemberSerialization.OptIn)]
  class ProgramData {
    [JsonProperty]
    private Dictionary<string, Symlink> dirSymlinks;
    [JsonProperty]
    private Dictionary<string, Symlink> fileSymlinks;

    /// <summary>
    /// Reads in a data file and returns an object that represents
    /// the data in the data file.
    /// </summary>
    /// <param name="dataFile">Path to the data file.</param>
    public ProgramData(string dataFile) {
      this.dirSymlinks = new Dictionary<string, Symlink>();
      this.fileSymlinks = new Dictionary<string, Symlink>();

      // We must have got here from the ProgramData constructor.
      if ( dataFile.Equals(string.Empty) ) {
        return;
      }

      string fileData = string.Empty;
      try {
        UTF8Encoding enc = new UTF8Encoding();
        StreamReader sr = new StreamReader(dataFile, enc);
        fileData = sr.ReadToEnd();
        sr.Close();
      } catch ( Exception ex ) {
        // If we don't trap at least the System.IO.FileNotFoundException,
        // then the whole program will crash when it tries to instantiate
        // this object. So we're lazy and just trap 'em all.
        Logger log = new Logger("WinLN");
        log.AddError(ex.Message);
      }

      ProgramData pd =
        (ProgramData)JsonConvert.DeserializeObject<ProgramData>(fileData);
      this.dirSymlinks = pd.dirSymlinks;
      this.fileSymlinks = pd.fileSymlinks;
    }

    // Generic constructor
    public ProgramData() : this(string.Empty) { }

    #region Property methods
    public void addDirLink(Symlink symlink) {
      this.dirSymlinks[symlink.winLnName] = symlink;
    }

    public void addFileLink(Symlink symlink) {
      this.fileSymlinks[symlink.winLnName] = symlink;
    }

    public void delDirLink(string linkName) {
      if ( this.dirSymlinks.ContainsKey(linkName) ) {
        this.dirSymlinks.Remove(linkName);
      }
    }

    public void delFileLink(string linkName) {
      if ( this.fileSymlinks.ContainsKey(linkName) ) {
        this.fileSymlinks.Remove(linkName);
      }
    }

    public Symlink getDirLink(string linkName) {
      return this.dirSymlinks[linkName];
    }

    public Symlink getFileLink(string linkName) {
      return this.fileSymlinks[linkName];
    }
    #endregion

    #region Detail methods
    public List<string> dirLinksKeys() {
      Dictionary<string, Symlink>.KeyCollection keys = this.dirSymlinks.Keys;
      List<string> retKeys = keys.ToList<string>();

      return retKeys;
    }

    public List<string> fileLinksKeys() {
      Dictionary<string, Symlink>.KeyCollection keys = this.fileSymlinks.Keys;
      List<string> retKeys = keys.ToList<string>();

      return retKeys;
    }
    #endregion
  }
}