using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace com.jrfom.winln {
  public partial class AboutForm : Form {
    public AboutForm() {
      InitializeComponent();

      versionNumber.Text = Application.ProductVersion;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      ProcessStartInfo startInfo = new ProcessStartInfo(url.Text);
      Process.Start(startInfo);
    }
  }
}
