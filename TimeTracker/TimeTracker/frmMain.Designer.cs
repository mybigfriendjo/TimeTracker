namespace TimeTracker {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
			this.textResult = new System.Windows.Forms.TextBox();
			this.textInput = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCollapse = new System.Windows.Forms.Button();
			this.buttonExport = new System.Windows.Forms.Button();
			this.tableLayoutMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutMain
			// 
			this.tableLayoutMain.ColumnCount = 3;
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutMain.Controls.Add(this.textResult, 0, 1);
			this.tableLayoutMain.Controls.Add(this.textInput, 0, 0);
			this.tableLayoutMain.Controls.Add(this.buttonAdd, 1, 0);
			this.tableLayoutMain.Controls.Add(this.buttonCollapse, 2, 0);
			this.tableLayoutMain.Controls.Add(this.buttonExport, 1, 2);
			this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutMain.Name = "tableLayoutMain";
			this.tableLayoutMain.RowCount = 4;
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutMain.Size = new System.Drawing.Size(635, 262);
			this.tableLayoutMain.TabIndex = 0;
			// 
			// textResult
			// 
			this.textResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textResult.Location = new System.Drawing.Point(3, 28);
			this.textResult.Multiline = true;
			this.textResult.Name = "textResult";
			this.textResult.ReadOnly = true;
			this.tableLayoutMain.SetRowSpan(this.textResult, 3);
			this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textResult.Size = new System.Drawing.Size(579, 231);
			this.textResult.TabIndex = 3;
			// 
			// textInput
			// 
			this.textInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textInput.Location = new System.Drawing.Point(3, 3);
			this.textInput.Name = "textInput";
			this.textInput.Size = new System.Drawing.Size(579, 20);
			this.textInput.TabIndex = 0;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAdd.Image = global::TimeTracker.Properties.Resources.add;
			this.buttonAdd.Location = new System.Drawing.Point(586, 1);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(1);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(23, 23);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCollapse
			// 
			this.buttonCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCollapse.Image = global::TimeTracker.Properties.Resources.collapse_up;
			this.buttonCollapse.Location = new System.Drawing.Point(611, 1);
			this.buttonCollapse.Margin = new System.Windows.Forms.Padding(1);
			this.buttonCollapse.Name = "buttonCollapse";
			this.buttonCollapse.Size = new System.Drawing.Size(23, 23);
			this.buttonCollapse.TabIndex = 2;
			this.buttonCollapse.UseVisualStyleBackColor = true;
			this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
			// 
			// buttonExport
			// 
			this.tableLayoutMain.SetColumnSpan(this.buttonExport, 2);
			this.buttonExport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonExport.Location = new System.Drawing.Point(587, 120);
			this.buttonExport.Margin = new System.Windows.Forms.Padding(2);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(46, 46);
			this.buttonExport.TabIndex = 4;
			this.buttonExport.Text = "Export";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.buttonAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 262);
			this.Controls.Add(this.tableLayoutMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "TimeTracker";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.tableLayoutMain.ResumeLayout(false);
			this.tableLayoutMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
		private System.Windows.Forms.TextBox textResult;
		private System.Windows.Forms.TextBox textInput;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCollapse;
		private System.Windows.Forms.Button buttonExport;
	}
}

