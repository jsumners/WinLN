using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace com.jrfom.winln.Classes {
  class Linker {
    // http://msdn.microsoft.com/en-us/library/windows/desktop/aa363866(v=vs.85).aspx
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool CreateSymbolicLink(
      string lpSymlinkFileName, string lpTargetFileName, int dwFlags
    );

    public Linker() { }

    public string lastError;

    /// <summary>
    /// Create a symbolic link from source rile to destination file. If an
    /// error occurs, the lastError property of the Linker object will be
    /// set to a descriptive message.
    /// </summary>
    /// <param name="srcFile">Full path to the source file.</param>
    /// <param name="dstFile">Full path to the destination file.</param>
    /// <returns>True on success, false on failure.</returns>
    public bool linkFile(string srcFile, string dstFile) {
      bool ret = CreateSymbolicLink(dstFile, srcFile, 0);

      if ( !ret ) {
        Exception ex = new Win32Exception();
        this.lastError = ex.Message;
      }

      return ret;
    }

    /// <summary>
    /// Create a symbolic link from a source directory to a destination directory.
    /// If an error occurs, the lastError property of the Linker object will be
    /// set to a descriptive message.
    /// </summary>
    /// <param name="srcDir">Full path to the source directory.</param>
    /// <param name="dstDir">Full path to the destination directory.</param>
    /// <returns>True on success, false on failure.</returns>
    public bool linkDir(string srcDir, string dstDir) {
      bool ret = CreateSymbolicLink(dstDir, srcDir, 1);

      if ( !ret ) {
        Exception ex = new Win32Exception();
        this.lastError = ex.Message;
      }

      return ret;
    }
  }
}