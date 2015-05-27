using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker {
	public partial class frmMain : Form {

		private PrivateFontCollection fonts = new PrivateFontCollection();
		private bool collapsed = false;

		public frmMain() {
			InitializeComponent();

			byte[] fontData = TimeTracker.Properties.Resources.UbuntuMono_R;
			IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
			Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			fonts.AddMemoryFont(fontPtr, fontData.Length);
			Marshal.FreeCoTaskMem(fontPtr);

			textInput.Font = new Font(fonts.Families[0], 10.0F);
			textResult.Font = new Font(fonts.Families[0], 10.0F);
		}

		private void buttonCollapse_Click(object sender, EventArgs e) {
			if (collapsed) {
				// TODO: implement this method stub
				buttonCollapse.Image = TimeTracker.Properties.Resources.collapse_up;
				collapsed = false;
			} else {
				// TODO: implement this method stub
				buttonCollapse.Image = TimeTracker.Properties.Resources.collapse_down;
				collapsed = true;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			// TODO: wenn stopp eingegeben wird stoppe aktuelle tätigkeit
			// sonst füge text von oberem textfeld mit timestamp hinzu
		}

		private void buttonExport_Click(object sender, EventArgs e) {
			// TODO: export zu csv
		}

		private static string now() {
			return DateTime.Now.ToString("HH:mm");
		}

		private static string longNow() {
			return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		}
	}
}
