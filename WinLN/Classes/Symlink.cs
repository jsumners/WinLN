using System;
using Newtonsoft.Json;

namespace com.jrfom.winln.Classes {
  /// <summary>
  /// This class represents a symlink as understood by WinLN.
  /// </summary>
  [JsonObject(MemberSerialization.OptOut)]
  class Symlink {
    public string winLnName { get; set; }
    public string sourcePath { get; set; }
    public string destinationPath { get; set; }
    public Int64 dateTicks { get; set; }

    public Symlink() {
      this.dateTicks = DateTime.Now.Ticks;
    }
  }
}