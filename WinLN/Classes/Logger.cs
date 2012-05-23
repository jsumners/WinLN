using System.Diagnostics;

namespace com.jrfom.winln.Classes {
  /// <summary>
  /// A simple event logging class from http://tinyurl.com/c2zfcvs
  /// </summary>
  class Logger {
    private EventLog _EventLog;
    public string _Source { get; set; }
    public string _Log { get; set; }

    public Logger(string SourceName) {
      _EventLog = new EventLog();
      _Source = SourceName;

      if ( !EventLog.SourceExists(_Source) ) {
        EventLog.CreateEventSource(_Source, _Log);
      }
      _EventLog.Source = _Source;
    }

    public void Add(string Message,
            System.Diagnostics.EventLogEntryType eType) {
      _EventLog.WriteEntry(Message, eType);
    }

    public void AddError(string Message) {
      Add(Message, System.Diagnostics.EventLogEntryType.Error);
    }

    public void AddWarning(string Message) {
      Add(Message, System.Diagnostics.EventLogEntryType.Warning);
    }

    public void AddInformation(string Message) {
      Add(Message,
        System.Diagnostics.EventLogEntryType.Information);
    }
  }
}
