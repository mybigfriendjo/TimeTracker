using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.dto;

namespace TimeTracker {
	public partial class frmMain : Form {

		private PrivateFontCollection fonts = new PrivateFontCollection();
		private bool collapsed = false;
		private const int SNAP_DIST = 30;
		private const string DATE_FORMAT = "HH:mm:ss";
		private string currentActivity = null;
		private List<LogEntry> entries = new List<LogEntry>();
		private static CancellationTokenSource tokenSource = new CancellationTokenSource();
		private static CancellationToken cancelToken = tokenSource.Token;
		private static Task listener;

		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		public frmMain() {
			InitializeComponent();

			byte[] fontData = TimeTracker.Properties.Resources.UbuntuMono_R;
			IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
			Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			fonts.AddMemoryFont(fontPtr, fontData.Length);
			Marshal.FreeCoTaskMem(fontPtr);

			textInput.Font = new Font(fonts.Families[0], 10.0F);
			textResult.Font = new Font(fonts.Families[0], 10.0F);

			TopMost = true;

			listener = Task.Factory.StartNew(() => {
				while (true) {
					Thread.Sleep(100);
					if (cancelToken.IsCancellationRequested) {
						break;
					}
				}
			}, cancelToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
		}

		private void buttonCollapse_Click(object sender, EventArgs e) {
			if (collapsed) {
				Height = 300;
				MaximizeBox = true;
				FormBorderStyle = FormBorderStyle.Sizable;
				textResult.Visible = true;
				buttonExport.Visible = true;
				buttonCollapse.Image = TimeTracker.Properties.Resources.collapse_up;
				collapsed = false;
			} else {
				Height = 65;
				MaximizeBox = false;
				FormBorderStyle = FormBorderStyle.FixedSingle;
				textResult.Visible = false;
				buttonExport.Visible = false;
				buttonCollapse.Image = TimeTracker.Properties.Resources.collapse_down;
				collapsed = true;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			if (textInput.Text.Trim().ToLower().Equals("stop")) {
				if (currentActivity != null) {
					log(now(), false, currentActivity);
					currentActivity = null;
				}
			} else {
				DateTime jetzt = now();
				if (currentActivity != null) {
					log(jetzt, false, currentActivity);
					currentActivity = null;
				}
				jetzt = jetzt.AddSeconds(1);
				currentActivity = textInput.Text.Trim();
				log(jetzt, true, currentActivity);
			}
			textInput.Clear();
			textInput.Focus();
		}

		private void log(DateTime timestamp, bool begin, string entry) {
			entries.Add(new LogEntry(timestamp, begin, entry));
			textResult.Text += "[" + timestamp.ToString(DATE_FORMAT) + "]";
			if (begin) {
				textResult.Text += " - START - ";
			} else {
				textResult.Text += " - ENDE  - ";
			}
			textResult.Text += entry + Environment.NewLine;
		}

		private void buttonExport_Click(object sender, EventArgs e) {
			StringBuilder exportCSV = new StringBuilder();
			foreach (LogEntry entry in entries) {
				exportCSV.Append(entry.Timestamp.ToString(DATE_FORMAT)).Append(",");
				if (entry.Begin) {
					exportCSV.Append("START,");
				} else {
					exportCSV.Append("ENDE,");
				}
				if (entry.Entry.Contains(",")) {
					exportCSV.Append("\"").Append(entry.Entry.Replace("\"", "'")).AppendLine("\"");
				} else {
					exportCSV.AppendLine(entry.Entry.Replace("\"", "'"));
				}
			}

			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.Title = "Exportieren...";
			saveDialog.Filter += "*.csv File|*.csv";
			saveDialog.InitialDirectory = "H:\\Documents\\Dokumente\\Zeiten";
			saveDialog.FileName = "TimeExport_" + now().ToString("MM_dd") + ".csv";

			if (saveDialog.ShowDialog() == DialogResult.OK) {
				File.WriteAllText(saveDialog.FileName, exportCSV.ToString());
			}
		}

		// TODO: implement this method stub!
		private string GetActiveWindowTitle() {
			const int nChars = 256;
			StringBuilder Buff = new StringBuilder(nChars);
			IntPtr handle = GetForegroundWindow();

			if (GetWindowText(handle, Buff, nChars) > 0) {
				return Buff.ToString();
			}
			return null;
		}

		private bool DoSnap(int pos, int edge) {
			int delta = pos - edge;
			return delta > 0 && delta <= SNAP_DIST;
		}

		protected override void OnResizeEnd(EventArgs e) {
			base.OnResizeEnd(e);
			Screen scn = Screen.FromPoint(this.Location);
			if (DoSnap(this.Left, scn.WorkingArea.Left)) {
				this.Left = scn.WorkingArea.Left;
			}
			if (DoSnap(this.Top, scn.WorkingArea.Top)) {
				this.Top = scn.WorkingArea.Top;
			}
			if (DoSnap(scn.WorkingArea.Right, this.Right)) {
				this.Left = scn.WorkingArea.Right - this.Width;
			}
			if (DoSnap(scn.WorkingArea.Bottom, this.Bottom)) {
				this.Top = scn.WorkingArea.Bottom - this.Height;
			}
		}

		private static DateTime now() {
			return DateTime.Now;
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {

		}
	}
}
